using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']"
	[global::Android.Runtime.Register ("io/reactivex/Observable", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class Observable : global::Java.Lang.Object, global::IO.Reactivex.IObservableSource {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/Observable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Observable); }
		}

		protected Observable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/constructor[@name='Observable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Observable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Observable)) {
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

		static IntPtr id_all_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='all' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;']]"
		[Register ("all", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single All (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_all_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_all_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "all", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_all_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_amb_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='amb' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("amb", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Amb (global::Java.Lang.IIterable sources)
		{
			if (id_amb_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_amb_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "amb", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_amb_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ambArray_arrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='ambArray' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("ambArray", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable AmbArray (params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_ambArray_arrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_ambArray_arrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "ambArray", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ambArray_arrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_ambWith_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='ambWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("ambWith", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable AmbWith (global::IO.Reactivex.IObservableSource other)
		{
			if (id_ambWith_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_ambWith_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "ambWith", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ambWith_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_any_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='any' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;']]"
		[Register ("any", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Any (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_any_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_any_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "any", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_any_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_as_Lio_reactivex_ObservableConverter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='as' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableConverter&lt;T, ? extends R&gt;']]"
		[Register ("as", "(Lio/reactivex/ObservableConverter;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Java.Lang.Object As (global::IO.Reactivex.IObservableConverter converter)
		{
			if (id_as_Lio_reactivex_ObservableConverter_ == IntPtr.Zero)
				id_as_Lio_reactivex_ObservableConverter_ = JNIEnv.GetMethodID (class_ref, "as", "(Lio/reactivex/ObservableConverter;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (converter);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_as_Lio_reactivex_ObservableConverter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_blockingFirst;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingFirst' and count(parameter)=0]"
		[Register ("blockingFirst", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object BlockingFirst ()
		{
			if (id_blockingFirst == IntPtr.Zero)
				id_blockingFirst = JNIEnv.GetMethodID (class_ref, "blockingFirst", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingFirst), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_blockingFirst_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingFirst' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("blockingFirst", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object BlockingFirst (global::Java.Lang.Object defaultItem)
		{
			if (id_blockingFirst_Ljava_lang_Object_ == IntPtr.Zero)
				id_blockingFirst_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "blockingFirst", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_defaultItem = JNIEnv.ToLocalJniHandle (defaultItem);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultItem);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingFirst_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultItem);
			}
		}

		static IntPtr id_blockingForEach_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingForEach' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("blockingForEach", "(Lio/reactivex/functions/Consumer;)V", "")]
		public unsafe void BlockingForEach (global::IO.Reactivex.Functions.IConsumer onNext)
		{
			if (id_blockingForEach_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_blockingForEach_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "blockingForEach", "(Lio/reactivex/functions/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onNext);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockingForEach_Lio_reactivex_functions_Consumer_, __args);
			} finally {
			}
		}

		static IntPtr id_blockingIterable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingIterable' and count(parameter)=0]"
		[Register ("blockingIterable", "()Ljava/lang/Iterable;", "")]
		public unsafe global::Java.Lang.IIterable BlockingIterable ()
		{
			if (id_blockingIterable == IntPtr.Zero)
				id_blockingIterable = JNIEnv.GetMethodID (class_ref, "blockingIterable", "()Ljava/lang/Iterable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingIterable), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_blockingIterable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingIterable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("blockingIterable", "(I)Ljava/lang/Iterable;", "")]
		public unsafe global::Java.Lang.IIterable BlockingIterable (int bufferSize)
		{
			if (id_blockingIterable_I == IntPtr.Zero)
				id_blockingIterable_I = JNIEnv.GetMethodID (class_ref, "blockingIterable", "(I)Ljava/lang/Iterable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bufferSize);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingIterable_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_blockingLast;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingLast' and count(parameter)=0]"
		[Register ("blockingLast", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object BlockingLast ()
		{
			if (id_blockingLast == IntPtr.Zero)
				id_blockingLast = JNIEnv.GetMethodID (class_ref, "blockingLast", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingLast), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_blockingLast_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingLast' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("blockingLast", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object BlockingLast (global::Java.Lang.Object defaultItem)
		{
			if (id_blockingLast_Ljava_lang_Object_ == IntPtr.Zero)
				id_blockingLast_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "blockingLast", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_defaultItem = JNIEnv.ToLocalJniHandle (defaultItem);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultItem);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingLast_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultItem);
			}
		}

		static IntPtr id_blockingLatest;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingLatest' and count(parameter)=0]"
		[Register ("blockingLatest", "()Ljava/lang/Iterable;", "")]
		public unsafe global::Java.Lang.IIterable BlockingLatest ()
		{
			if (id_blockingLatest == IntPtr.Zero)
				id_blockingLatest = JNIEnv.GetMethodID (class_ref, "blockingLatest", "()Ljava/lang/Iterable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingLatest), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_blockingMostRecent_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingMostRecent' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("blockingMostRecent", "(Ljava/lang/Object;)Ljava/lang/Iterable;", "")]
		public unsafe global::Java.Lang.IIterable BlockingMostRecent (global::Java.Lang.Object initialValue)
		{
			if (id_blockingMostRecent_Ljava_lang_Object_ == IntPtr.Zero)
				id_blockingMostRecent_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "blockingMostRecent", "(Ljava/lang/Object;)Ljava/lang/Iterable;");
			IntPtr native_initialValue = JNIEnv.ToLocalJniHandle (initialValue);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_initialValue);
				global::Java.Lang.IIterable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingMostRecent_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_initialValue);
			}
		}

		static IntPtr id_blockingNext;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingNext' and count(parameter)=0]"
		[Register ("blockingNext", "()Ljava/lang/Iterable;", "")]
		public unsafe global::Java.Lang.IIterable BlockingNext ()
		{
			if (id_blockingNext == IntPtr.Zero)
				id_blockingNext = JNIEnv.GetMethodID (class_ref, "blockingNext", "()Ljava/lang/Iterable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingNext), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_blockingSingle;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingSingle' and count(parameter)=0]"
		[Register ("blockingSingle", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object BlockingSingle ()
		{
			if (id_blockingSingle == IntPtr.Zero)
				id_blockingSingle = JNIEnv.GetMethodID (class_ref, "blockingSingle", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingSingle), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_blockingSingle_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingSingle' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("blockingSingle", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object BlockingSingle (global::Java.Lang.Object defaultItem)
		{
			if (id_blockingSingle_Ljava_lang_Object_ == IntPtr.Zero)
				id_blockingSingle_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "blockingSingle", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_defaultItem = JNIEnv.ToLocalJniHandle (defaultItem);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultItem);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_blockingSingle_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultItem);
			}
		}

		static IntPtr id_blockingSubscribe;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingSubscribe' and count(parameter)=0]"
		[Register ("blockingSubscribe", "()V", "")]
		public unsafe void BlockingSubscribe ()
		{
			if (id_blockingSubscribe == IntPtr.Zero)
				id_blockingSubscribe = JNIEnv.GetMethodID (class_ref, "blockingSubscribe", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockingSubscribe);
			} finally {
			}
		}

		static IntPtr id_blockingSubscribe_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("blockingSubscribe", "(Lio/reactivex/functions/Consumer;)V", "")]
		public unsafe void BlockingSubscribe (global::IO.Reactivex.Functions.IConsumer onNext)
		{
			if (id_blockingSubscribe_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_blockingSubscribe_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "blockingSubscribe", "(Lio/reactivex/functions/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onNext);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockingSubscribe_Lio_reactivex_functions_Consumer_, __args);
			} finally {
			}
		}

		static IntPtr id_blockingSubscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingSubscribe' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
		[Register ("blockingSubscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;)V", "")]
		public unsafe void BlockingSubscribe (global::IO.Reactivex.Functions.IConsumer onNext, global::IO.Reactivex.Functions.IConsumer onError)
		{
			if (id_blockingSubscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_blockingSubscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "blockingSubscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (onNext);
				__args [1] = new JValue (onError);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockingSubscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_, __args);
			} finally {
			}
		}

		static IntPtr id_blockingSubscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingSubscribe' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;'] and parameter[3][@type='io.reactivex.functions.Action']]"
		[Register ("blockingSubscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)V", "")]
		public unsafe void BlockingSubscribe (global::IO.Reactivex.Functions.IConsumer onNext, global::IO.Reactivex.Functions.IConsumer onError, global::IO.Reactivex.Functions.IAction onComplete)
		{
			if (id_blockingSubscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_blockingSubscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "blockingSubscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (onNext);
				__args [1] = new JValue (onError);
				__args [2] = new JValue (onComplete);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockingSubscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_, __args);
			} finally {
			}
		}

		static IntPtr id_blockingSubscribe_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='blockingSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("blockingSubscribe", "(Lio/reactivex/Observer;)V", "")]
		public unsafe void BlockingSubscribe (global::IO.Reactivex.IObserver observer)
		{
			if (id_blockingSubscribe_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_blockingSubscribe_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "blockingSubscribe", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockingSubscribe_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

		static IntPtr id_buffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("buffer", "(I)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Buffer (int count)
		{
			if (id_buffer_I == IntPtr.Zero)
				id_buffer_I = JNIEnv.GetMethodID (class_ref, "buffer", "(I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_buffer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("buffer", "(II)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Buffer (int count, int skip)
		{
			if (id_buffer_II == IntPtr.Zero)
				id_buffer_II = JNIEnv.GetMethodID (class_ref, "buffer", "(II)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (count);
				__args [1] = new JValue (skip);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_buffer_IILjava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.concurrent.Callable&lt;U&gt;']]"
		[Register ("buffer", "(IILjava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U extends java.util.Collection<? super T>"})]
		public unsafe global::IO.Reactivex.Observable Buffer (int count, int skip, global::Java.Util.Concurrent.ICallable bufferSupplier)
		{
			if (id_buffer_IILjava_util_concurrent_Callable_ == IntPtr.Zero)
				id_buffer_IILjava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "buffer", "(IILjava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (count);
				__args [1] = new JValue (skip);
				__args [2] = new JValue (bufferSupplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_IILjava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_ILjava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.Callable&lt;U&gt;']]"
		[Register ("buffer", "(ILjava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U extends java.util.Collection<? super T>"})]
		public unsafe global::IO.Reactivex.Observable Buffer (int count, global::Java.Util.Concurrent.ICallable bufferSupplier)
		{
			if (id_buffer_ILjava_util_concurrent_Callable_ == IntPtr.Zero)
				id_buffer_ILjava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "buffer", "(ILjava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (count);
				__args [1] = new JValue (bufferSupplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_ILjava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends TOpening&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super TOpening, ? extends io.reactivex.ObservableSource&lt;? extends TClosing&gt;&gt;']]"
		[Register ("buffer", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TOpening", "TClosing"})]
		public unsafe global::IO.Reactivex.Observable Buffer (global::IO.Reactivex.IObservableSource openingIndicator, global::IO.Reactivex.Functions.IFunction closingIndicator)
		{
			if (id_buffer_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_buffer_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "buffer", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (openingIndicator);
				__args [1] = new JValue (closingIndicator);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends TOpening&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super TOpening, ? extends io.reactivex.ObservableSource&lt;? extends TClosing&gt;&gt;'] and parameter[3][@type='java.util.concurrent.Callable&lt;U&gt;']]"
		[Register ("buffer", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TOpening", "TClosing", "U extends java.util.Collection<? super T>"})]
		public unsafe global::IO.Reactivex.Observable Buffer (global::IO.Reactivex.IObservableSource openingIndicator, global::IO.Reactivex.Functions.IFunction closingIndicator, global::Java.Util.Concurrent.ICallable bufferSupplier)
		{
			if (id_buffer_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_buffer_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "buffer", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (openingIndicator);
				__args [1] = new JValue (closingIndicator);
				__args [2] = new JValue (bufferSupplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;B&gt;']]"
		[Register ("buffer", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B"})]
		public unsafe global::IO.Reactivex.Observable Buffer (global::IO.Reactivex.IObservableSource boundary)
		{
			if (id_buffer_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_buffer_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "buffer", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (boundary);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_Lio_reactivex_ObservableSource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;B&gt;'] and parameter[2][@type='int']]"
		[Register ("buffer", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B"})]
		public unsafe global::IO.Reactivex.Observable Buffer (global::IO.Reactivex.IObservableSource boundary, int initialCapacity)
		{
			if (id_buffer_Lio_reactivex_ObservableSource_I == IntPtr.Zero)
				id_buffer_Lio_reactivex_ObservableSource_I = JNIEnv.GetMethodID (class_ref, "buffer", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (boundary);
				__args [1] = new JValue (initialCapacity);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_Lio_reactivex_ObservableSource_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_Lio_reactivex_ObservableSource_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;B&gt;'] and parameter[2][@type='java.util.concurrent.Callable&lt;U&gt;']]"
		[Register ("buffer", "(Lio/reactivex/ObservableSource;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B", "U extends java.util.Collection<? super T>"})]
		public unsafe global::IO.Reactivex.Observable Buffer (global::IO.Reactivex.IObservableSource boundary, global::Java.Util.Concurrent.ICallable bufferSupplier)
		{
			if (id_buffer_Lio_reactivex_ObservableSource_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_buffer_Lio_reactivex_ObservableSource_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "buffer", "(Lio/reactivex/ObservableSource;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (boundary);
				__args [1] = new JValue (bufferSupplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_Lio_reactivex_ObservableSource_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.ObservableSource&lt;B&gt;&gt;']]"
		[Register ("buffer", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B"})]
		public unsafe global::IO.Reactivex.Observable Buffer (global::Java.Util.Concurrent.ICallable boundarySupplier)
		{
			if (id_buffer_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_buffer_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "buffer", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (boundarySupplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_Ljava_util_concurrent_Callable_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.ObservableSource&lt;B&gt;&gt;'] and parameter[2][@type='java.util.concurrent.Callable&lt;U&gt;']]"
		[Register ("buffer", "(Ljava/util/concurrent/Callable;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B", "U extends java.util.Collection<? super T>"})]
		public unsafe global::IO.Reactivex.Observable Buffer (global::Java.Util.Concurrent.ICallable boundarySupplier, global::Java.Util.Concurrent.ICallable bufferSupplier)
		{
			if (id_buffer_Ljava_util_concurrent_Callable_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_buffer_Ljava_util_concurrent_Callable_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "buffer", "(Ljava/util/concurrent/Callable;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (boundarySupplier);
				__args [1] = new JValue (bufferSupplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_Ljava_util_concurrent_Callable_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("buffer", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Buffer (long timespan, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_buffer_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_buffer_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "buffer", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_JLjava_util_concurrent_TimeUnit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='int']]"
		[Register ("buffer", "(JLjava/util/concurrent/TimeUnit;I)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Buffer (long timespan, global::Java.Util.Concurrent.TimeUnit unit, int count)
		{
			if (id_buffer_JLjava_util_concurrent_TimeUnit_I == IntPtr.Zero)
				id_buffer_JLjava_util_concurrent_TimeUnit_I = JNIEnv.GetMethodID (class_ref, "buffer", "(JLjava/util/concurrent/TimeUnit;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (count);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_JLjava_util_concurrent_TimeUnit_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("buffer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Buffer (long timespan, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "buffer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='int']]"
		[Register ("buffer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;I)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Buffer (long timespan, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, int count)
		{
			if (id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I == IntPtr.Zero)
				id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I = JNIEnv.GetMethodID (class_ref, "buffer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (count);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ILjava_util_concurrent_Callable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='int'] and parameter[5][@type='java.util.concurrent.Callable&lt;U&gt;'] and parameter[6][@type='boolean']]"
		[Register ("buffer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;ILjava/util/concurrent/Callable;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U extends java.util.Collection<? super T>"})]
		public unsafe global::IO.Reactivex.Observable Buffer (long timespan, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, int count, global::Java.Util.Concurrent.ICallable bufferSupplier, bool restartTimerOnMaxSize)
		{
			if (id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ILjava_util_concurrent_Callable_Z == IntPtr.Zero)
				id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ILjava_util_concurrent_Callable_Z = JNIEnv.GetMethodID (class_ref, "buffer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;ILjava/util/concurrent/Callable;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (count);
				__args [4] = new JValue (bufferSupplier);
				__args [5] = new JValue (restartTimerOnMaxSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ILjava_util_concurrent_Callable_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_JJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("buffer", "(JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Buffer (long timespan, long timeskip, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_buffer_JJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_buffer_JJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "buffer", "(JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (timeskip);
				__args [2] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_JJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler']]"
		[Register ("buffer", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Buffer (long timespan, long timeskip, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_buffer_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_buffer_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "buffer", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (timeskip);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='buffer' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler'] and parameter[5][@type='java.util.concurrent.Callable&lt;U&gt;']]"
		[Register ("buffer", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U extends java.util.Collection<? super T>"})]
		public unsafe global::IO.Reactivex.Observable Buffer (long timespan, long timeskip, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, global::Java.Util.Concurrent.ICallable bufferSupplier)
		{
			if (id_buffer_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_buffer_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "buffer", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (timeskip);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				__args [4] = new JValue (bufferSupplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buffer_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_bufferSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='bufferSize' and count(parameter)=0]"
		[Register ("bufferSize", "()I", "")]
		public static unsafe int BufferSize ()
		{
			if (id_bufferSize == IntPtr.Zero)
				id_bufferSize = JNIEnv.GetStaticMethodID (class_ref, "bufferSize", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_bufferSize);
			} finally {
			}
		}

		static IntPtr id_cache;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='cache' and count(parameter)=0]"
		[Register ("cache", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Cache ()
		{
			if (id_cache == IntPtr.Zero)
				id_cache = JNIEnv.GetMethodID (class_ref, "cache", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cache), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cacheWithInitialCapacity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='cacheWithInitialCapacity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("cacheWithInitialCapacity", "(I)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable CacheWithInitialCapacity (int initialCapacity)
		{
			if (id_cacheWithInitialCapacity_I == IntPtr.Zero)
				id_cacheWithInitialCapacity_I = JNIEnv.GetMethodID (class_ref, "cacheWithInitialCapacity", "(I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (initialCapacity);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cacheWithInitialCapacity_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cast_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='cast' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;U&gt;']]"
		[Register ("cast", "(Ljava/lang/Class;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable Cast (global::Java.Lang.Class clazz)
		{
			if (id_cast_Ljava_lang_Class_ == IntPtr.Zero)
				id_cast_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "cast", "(Ljava/lang/Class;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clazz);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cast_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_collect_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='collect' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends U&gt;'] and parameter[2][@type='io.reactivex.functions.BiConsumer&lt;? super U, ? super T&gt;']]"
		[Register ("collect", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiConsumer;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Single Collect (global::Java.Util.Concurrent.ICallable initialValueSupplier, global::IO.Reactivex.Functions.IBiConsumer collector)
		{
			if (id_collect_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_ == IntPtr.Zero)
				id_collect_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_ = JNIEnv.GetMethodID (class_ref, "collect", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiConsumer;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (initialValueSupplier);
				__args [1] = new JValue (collector);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_collect_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_collectInto_Ljava_lang_Object_Lio_reactivex_functions_BiConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='collectInto' and count(parameter)=2 and parameter[1][@type='U'] and parameter[2][@type='io.reactivex.functions.BiConsumer&lt;? super U, ? super T&gt;']]"
		[Register ("collectInto", "(Ljava/lang/Object;Lio/reactivex/functions/BiConsumer;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Single CollectInto (global::Java.Lang.Object initialValue, global::IO.Reactivex.Functions.IBiConsumer collector)
		{
			if (id_collectInto_Ljava_lang_Object_Lio_reactivex_functions_BiConsumer_ == IntPtr.Zero)
				id_collectInto_Ljava_lang_Object_Lio_reactivex_functions_BiConsumer_ = JNIEnv.GetMethodID (class_ref, "collectInto", "(Ljava/lang/Object;Lio/reactivex/functions/BiConsumer;)Lio/reactivex/Single;");
			IntPtr native_initialValue = JNIEnv.ToLocalJniHandle (initialValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_initialValue);
				__args [1] = new JValue (collector);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_collectInto_Ljava_lang_Object_Lio_reactivex_functions_BiConsumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_initialValue);
			}
		}

		static IntPtr id_combineLatest_Lio_reactivex_functions_Function_IarrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;'] and parameter[2][@type='int'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("combineLatest", "(Lio/reactivex/functions/Function;I[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::IO.Reactivex.Functions.IFunction combiner, int bufferSize, params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_combineLatest_Lio_reactivex_functions_Function_IarrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_combineLatest_Lio_reactivex_functions_Function_IarrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "(Lio/reactivex/functions/Function;I[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (combiner);
				__args [1] = new JValue (bufferSize);
				__args [2] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_Lio_reactivex_functions_Function_IarrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_combineLatest_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;[]'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;']]"
		[Register ("combineLatest", "([Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::IO.Reactivex.IObservableSource[] sources, global::IO.Reactivex.Functions.IFunction combiner)
		{
			if (id_combineLatest_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_combineLatest_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "([Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_sources);
				__args [1] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_combineLatest_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;[]'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;'] and parameter[3][@type='int']]"
		[Register ("combineLatest", "([Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::IO.Reactivex.IObservableSource[] sources, global::IO.Reactivex.Functions.IFunction combiner, int bufferSize)
		{
			if (id_combineLatest_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_combineLatest_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "([Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_sources);
				__args [1] = new JValue (combiner);
				__args [2] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.functions.BiFunction&lt;? super T1, ? super T2, ? extends R&gt;']]"
		[Register ("combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.Functions.IBiFunction combiner)
		{
			if (id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.functions.Function3&lt;? super T1, ? super T2, ? super T3, ? extends R&gt;']]"
		[Register ("combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function3;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.Functions.IFunction3 combiner)
		{
			if (id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_ == IntPtr.Zero)
				id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function3;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=5 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.functions.Function4&lt;? super T1, ? super T2, ? super T3, ? super T4, ? extends R&gt;']]"
		[Register ("combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function4;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.Functions.IFunction4 combiner)
		{
			if (id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_ == IntPtr.Zero)
				id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function4;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=6 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.ObservableSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.functions.Function5&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? extends R&gt;']]"
		[Register ("combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function5;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.IObservableSource source5, global::IO.Reactivex.Functions.IFunction5 combiner)
		{
			if (id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_ == IntPtr.Zero)
				id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function5;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function6_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=7 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.ObservableSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.ObservableSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.functions.Function6&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? extends R&gt;']]"
		[Register ("combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function6;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.IObservableSource source5, global::IO.Reactivex.IObservableSource source6, global::IO.Reactivex.Functions.IFunction6 combiner)
		{
			if (id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function6_ == IntPtr.Zero)
				id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function6_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function6;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (source6);
				__args [6] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function6_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function7_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=8 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.ObservableSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.ObservableSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.ObservableSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.functions.Function7&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? extends R&gt;']]"
		[Register ("combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function7;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.IObservableSource source5, global::IO.Reactivex.IObservableSource source6, global::IO.Reactivex.IObservableSource source7, global::IO.Reactivex.Functions.IFunction7 combiner)
		{
			if (id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function7_ == IntPtr.Zero)
				id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function7_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function7;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (source6);
				__args [6] = new JValue (source7);
				__args [7] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function7_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function8_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=9 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.ObservableSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.ObservableSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.ObservableSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.ObservableSource&lt;? extends T8&gt;'] and parameter[9][@type='io.reactivex.functions.Function8&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? extends R&gt;']]"
		[Register ("combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function8;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.IObservableSource source5, global::IO.Reactivex.IObservableSource source6, global::IO.Reactivex.IObservableSource source7, global::IO.Reactivex.IObservableSource source8, global::IO.Reactivex.Functions.IFunction8 combiner)
		{
			if (id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function8_ == IntPtr.Zero)
				id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function8_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function8;)Lio/reactivex/Observable;");
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
				__args [8] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function8_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function9_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=10 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.ObservableSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.ObservableSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.ObservableSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.ObservableSource&lt;? extends T8&gt;'] and parameter[9][@type='io.reactivex.ObservableSource&lt;? extends T9&gt;'] and parameter[10][@type='io.reactivex.functions.Function9&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? super T9, ? extends R&gt;']]"
		[Register ("combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function9;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.IObservableSource source5, global::IO.Reactivex.IObservableSource source6, global::IO.Reactivex.IObservableSource source7, global::IO.Reactivex.IObservableSource source8, global::IO.Reactivex.IObservableSource source9, global::IO.Reactivex.Functions.IFunction9 combiner)
		{
			if (id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function9_ == IntPtr.Zero)
				id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function9_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function9;)Lio/reactivex/Observable;");
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
				__args [9] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function9_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_combineLatest_Ljava_lang_Iterable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;']]"
		[Register ("combineLatest", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::Java.Lang.IIterable sources, global::IO.Reactivex.Functions.IFunction combiner)
		{
			if (id_combineLatest_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_combineLatest_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_Ljava_lang_Iterable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_combineLatest_Ljava_lang_Iterable_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatest' and count(parameter)=3 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;'] and parameter[3][@type='int']]"
		[Register ("combineLatest", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatest (global::Java.Lang.IIterable sources, global::IO.Reactivex.Functions.IFunction combiner, int bufferSize)
		{
			if (id_combineLatest_Ljava_lang_Iterable_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_combineLatest_Ljava_lang_Iterable_Lio_reactivex_functions_Function_I = JNIEnv.GetStaticMethodID (class_ref, "combineLatest", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (combiner);
				__args [2] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatest_Ljava_lang_Iterable_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_combineLatestDelayError_Lio_reactivex_functions_Function_IarrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatestDelayError' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;'] and parameter[2][@type='int'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("combineLatestDelayError", "(Lio/reactivex/functions/Function;I[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatestDelayError (global::IO.Reactivex.Functions.IFunction combiner, int bufferSize, params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_combineLatestDelayError_Lio_reactivex_functions_Function_IarrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_combineLatestDelayError_Lio_reactivex_functions_Function_IarrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatestDelayError", "(Lio/reactivex/functions/Function;I[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (combiner);
				__args [1] = new JValue (bufferSize);
				__args [2] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatestDelayError_Lio_reactivex_functions_Function_IarrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_combineLatestDelayError_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatestDelayError' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;[]'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;']]"
		[Register ("combineLatestDelayError", "([Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatestDelayError (global::IO.Reactivex.IObservableSource[] sources, global::IO.Reactivex.Functions.IFunction combiner)
		{
			if (id_combineLatestDelayError_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_combineLatestDelayError_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatestDelayError", "([Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_sources);
				__args [1] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatestDelayError_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_combineLatestDelayError_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatestDelayError' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;[]'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;'] and parameter[3][@type='int']]"
		[Register ("combineLatestDelayError", "([Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatestDelayError (global::IO.Reactivex.IObservableSource[] sources, global::IO.Reactivex.Functions.IFunction combiner, int bufferSize)
		{
			if (id_combineLatestDelayError_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_combineLatestDelayError_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I = JNIEnv.GetStaticMethodID (class_ref, "combineLatestDelayError", "([Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_sources);
				__args [1] = new JValue (combiner);
				__args [2] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatestDelayError_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_combineLatestDelayError_Ljava_lang_Iterable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatestDelayError' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;']]"
		[Register ("combineLatestDelayError", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatestDelayError (global::Java.Lang.IIterable sources, global::IO.Reactivex.Functions.IFunction combiner)
		{
			if (id_combineLatestDelayError_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_combineLatestDelayError_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "combineLatestDelayError", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatestDelayError_Ljava_lang_Iterable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_combineLatestDelayError_Ljava_lang_Iterable_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='combineLatestDelayError' and count(parameter)=3 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;'] and parameter[3][@type='int']]"
		[Register ("combineLatestDelayError", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable CombineLatestDelayError (global::Java.Lang.IIterable sources, global::IO.Reactivex.Functions.IFunction combiner, int bufferSize)
		{
			if (id_combineLatestDelayError_Ljava_lang_Iterable_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_combineLatestDelayError_Ljava_lang_Iterable_Lio_reactivex_functions_Function_I = JNIEnv.GetStaticMethodID (class_ref, "combineLatestDelayError", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (combiner);
				__args [2] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_combineLatestDelayError_Ljava_lang_Iterable_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_compose_Lio_reactivex_ObservableTransformer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='compose' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableTransformer&lt;? super T, ? extends R&gt;']]"
		[Register ("compose", "(Lio/reactivex/ObservableTransformer;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Compose (global::IO.Reactivex.IObservableTransformer composer)
		{
			if (id_compose_Lio_reactivex_ObservableTransformer_ == IntPtr.Zero)
				id_compose_Lio_reactivex_ObservableTransformer_ = JNIEnv.GetMethodID (class_ref, "compose", "(Lio/reactivex/ObservableTransformer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (composer);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compose_Lio_reactivex_ObservableTransformer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concat_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concat' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
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

		static IntPtr id_concat_Lio_reactivex_ObservableSource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concat' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("concat", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Concat (global::IO.Reactivex.IObservableSource sources, int prefetch)
		{
			if (id_concat_Lio_reactivex_ObservableSource_I == IntPtr.Zero)
				id_concat_Lio_reactivex_ObservableSource_I = JNIEnv.GetStaticMethodID (class_ref, "concat", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (prefetch);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concat_Lio_reactivex_ObservableSource_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concat' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("concat", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Concat (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2)
		{
			if (id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concat", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concat' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("concat", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Concat (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3)
		{
			if (id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concat", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concat' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("concat", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Concat (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4)
		{
			if (id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concat", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concat_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concat_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concat' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("concat", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Concat (global::Java.Lang.IIterable sources)
		{
			if (id_concat_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_concat_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "concat", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concat_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatArray_arrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatArray' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("concatArray", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatArray (params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_concatArray_arrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concatArray_arrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concatArray", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatArray_arrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_concatArrayDelayError_arrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatArrayDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("concatArrayDelayError", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatArrayDelayError (params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_concatArrayDelayError_arrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concatArrayDelayError_arrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concatArrayDelayError", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatArrayDelayError_arrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_concatArrayEager_IIarrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatArrayEager' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("concatArrayEager", "(II[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatArrayEager (int maxConcurrency, int prefetch, params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_concatArrayEager_IIarrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concatArrayEager_IIarrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concatArrayEager", "(II[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (maxConcurrency);
				__args [1] = new JValue (prefetch);
				__args [2] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatArrayEager_IIarrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_concatArrayEager_arrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatArrayEager' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("concatArrayEager", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatArrayEager (params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_concatArrayEager_arrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concatArrayEager_arrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concatArrayEager", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatArrayEager_arrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_concatArrayEagerDelayError_IIarrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatArrayEagerDelayError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("concatArrayEagerDelayError", "(II[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatArrayEagerDelayError (int maxConcurrency, int prefetch, params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_concatArrayEagerDelayError_IIarrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concatArrayEagerDelayError_IIarrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concatArrayEagerDelayError", "(II[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (maxConcurrency);
				__args [1] = new JValue (prefetch);
				__args [2] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatArrayEagerDelayError_IIarrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_concatArrayEagerDelayError_arrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatArrayEagerDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("concatArrayEagerDelayError", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatArrayEagerDelayError (params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_concatArrayEagerDelayError_arrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concatArrayEagerDelayError_arrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concatArrayEagerDelayError", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatArrayEagerDelayError_arrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_concatDelayError_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("concatDelayError", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatDelayError (global::IO.Reactivex.IObservableSource sources)
		{
			if (id_concatDelayError_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concatDelayError_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concatDelayError", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatDelayError_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatDelayError_Lio_reactivex_ObservableSource_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatDelayError' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("concatDelayError", "(Lio/reactivex/ObservableSource;IZ)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatDelayError (global::IO.Reactivex.IObservableSource sources, int prefetch, bool tillTheEnd)
		{
			if (id_concatDelayError_Lio_reactivex_ObservableSource_IZ == IntPtr.Zero)
				id_concatDelayError_Lio_reactivex_ObservableSource_IZ = JNIEnv.GetStaticMethodID (class_ref, "concatDelayError", "(Lio/reactivex/ObservableSource;IZ)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (prefetch);
				__args [2] = new JValue (tillTheEnd);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatDelayError_Lio_reactivex_ObservableSource_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatDelayError_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatDelayError' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("concatDelayError", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatDelayError (global::Java.Lang.IIterable sources)
		{
			if (id_concatDelayError_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_concatDelayError_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "concatDelayError", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatDelayError_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatEager_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatEager' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("concatEager", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatEager (global::IO.Reactivex.IObservableSource sources)
		{
			if (id_concatEager_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concatEager_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "concatEager", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatEager_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatEager_Lio_reactivex_ObservableSource_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatEager' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("concatEager", "(Lio/reactivex/ObservableSource;II)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatEager (global::IO.Reactivex.IObservableSource sources, int maxConcurrency, int prefetch)
		{
			if (id_concatEager_Lio_reactivex_ObservableSource_II == IntPtr.Zero)
				id_concatEager_Lio_reactivex_ObservableSource_II = JNIEnv.GetStaticMethodID (class_ref, "concatEager", "(Lio/reactivex/ObservableSource;II)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (maxConcurrency);
				__args [2] = new JValue (prefetch);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatEager_Lio_reactivex_ObservableSource_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatEager_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatEager' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("concatEager", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatEager (global::Java.Lang.IIterable sources)
		{
			if (id_concatEager_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_concatEager_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "concatEager", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatEager_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatEager_Ljava_lang_Iterable_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatEager' and count(parameter)=3 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("concatEager", "(Ljava/lang/Iterable;II)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable ConcatEager (global::Java.Lang.IIterable sources, int maxConcurrency, int prefetch)
		{
			if (id_concatEager_Ljava_lang_Iterable_II == IntPtr.Zero)
				id_concatEager_Ljava_lang_Iterable_II = JNIEnv.GetStaticMethodID (class_ref, "concatEager", "(Ljava/lang/Iterable;II)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (maxConcurrency);
				__args [2] = new JValue (prefetch);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatEager_Ljava_lang_Iterable_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMap_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMap' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;']]"
		[Register ("concatMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMap (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_concatMap_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_concatMap_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "concatMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMap_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMap_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMap' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("concatMap", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMap (global::IO.Reactivex.Functions.IFunction mapper, int prefetch)
		{
			if (id_concatMap_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_concatMap_Lio_reactivex_functions_Function_I = JNIEnv.GetMethodID (class_ref, "concatMap", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (prefetch);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMap_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapCompletable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapCompletable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.CompletableSource&gt;']]"
		[Register ("concatMapCompletable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable ConcatMapCompletable (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_concatMapCompletable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_concatMapCompletable_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "concatMapCompletable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapCompletable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapCompletable_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapCompletable' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.CompletableSource&gt;'] and parameter[2][@type='int']]"
		[Register ("concatMapCompletable", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable ConcatMapCompletable (global::IO.Reactivex.Functions.IFunction mapper, int capacityHint)
		{
			if (id_concatMapCompletable_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_concatMapCompletable_Lio_reactivex_functions_Function_I = JNIEnv.GetMethodID (class_ref, "concatMapCompletable", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (capacityHint);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapCompletable_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapCompletableDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.CompletableSource&gt;']]"
		[Register ("concatMapCompletableDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable ConcatMapCompletableDelayError (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "concatMapCompletableDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapCompletableDelayError' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.CompletableSource&gt;'] and parameter[2][@type='boolean']]"
		[Register ("concatMapCompletableDelayError", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable ConcatMapCompletableDelayError (global::IO.Reactivex.Functions.IFunction mapper, bool tillTheEnd)
		{
			if (id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_Z == IntPtr.Zero)
				id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_Z = JNIEnv.GetMethodID (class_ref, "concatMapCompletableDelayError", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (tillTheEnd);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapCompletableDelayError' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.CompletableSource&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("concatMapCompletableDelayError", "(Lio/reactivex/functions/Function;ZI)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable ConcatMapCompletableDelayError (global::IO.Reactivex.Functions.IFunction mapper, bool tillTheEnd, int prefetch)
		{
			if (id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_ZI == IntPtr.Zero)
				id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_ZI = JNIEnv.GetMethodID (class_ref, "concatMapCompletableDelayError", "(Lio/reactivex/functions/Function;ZI)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (tillTheEnd);
				__args [2] = new JValue (prefetch);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapCompletableDelayError_Lio_reactivex_functions_Function_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapDelayError_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;']]"
		[Register ("concatMapDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapDelayError (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_concatMapDelayError_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_concatMapDelayError_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "concatMapDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapDelayError_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapDelayError_Lio_reactivex_functions_Function_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapDelayError' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("concatMapDelayError", "(Lio/reactivex/functions/Function;IZ)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapDelayError (global::IO.Reactivex.Functions.IFunction mapper, int prefetch, bool tillTheEnd)
		{
			if (id_concatMapDelayError_Lio_reactivex_functions_Function_IZ == IntPtr.Zero)
				id_concatMapDelayError_Lio_reactivex_functions_Function_IZ = JNIEnv.GetMethodID (class_ref, "concatMapDelayError", "(Lio/reactivex/functions/Function;IZ)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (prefetch);
				__args [2] = new JValue (tillTheEnd);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapDelayError_Lio_reactivex_functions_Function_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapEager_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapEager' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;']]"
		[Register ("concatMapEager", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapEager (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_concatMapEager_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_concatMapEager_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "concatMapEager", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapEager_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapEager_Lio_reactivex_functions_Function_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapEager' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("concatMapEager", "(Lio/reactivex/functions/Function;II)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapEager (global::IO.Reactivex.Functions.IFunction mapper, int maxConcurrency, int prefetch)
		{
			if (id_concatMapEager_Lio_reactivex_functions_Function_II == IntPtr.Zero)
				id_concatMapEager_Lio_reactivex_functions_Function_II = JNIEnv.GetMethodID (class_ref, "concatMapEager", "(Lio/reactivex/functions/Function;II)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (maxConcurrency);
				__args [2] = new JValue (prefetch);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapEager_Lio_reactivex_functions_Function_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapEagerDelayError_Lio_reactivex_functions_Function_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapEagerDelayError' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='boolean']]"
		[Register ("concatMapEagerDelayError", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapEagerDelayError (global::IO.Reactivex.Functions.IFunction mapper, bool tillTheEnd)
		{
			if (id_concatMapEagerDelayError_Lio_reactivex_functions_Function_Z == IntPtr.Zero)
				id_concatMapEagerDelayError_Lio_reactivex_functions_Function_Z = JNIEnv.GetMethodID (class_ref, "concatMapEagerDelayError", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (tillTheEnd);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapEagerDelayError_Lio_reactivex_functions_Function_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapEagerDelayError_Lio_reactivex_functions_Function_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapEagerDelayError' and count(parameter)=4 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("concatMapEagerDelayError", "(Lio/reactivex/functions/Function;IIZ)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapEagerDelayError (global::IO.Reactivex.Functions.IFunction mapper, int maxConcurrency, int prefetch, bool tillTheEnd)
		{
			if (id_concatMapEagerDelayError_Lio_reactivex_functions_Function_IIZ == IntPtr.Zero)
				id_concatMapEagerDelayError_Lio_reactivex_functions_Function_IIZ = JNIEnv.GetMethodID (class_ref, "concatMapEagerDelayError", "(Lio/reactivex/functions/Function;IIZ)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (maxConcurrency);
				__args [2] = new JValue (prefetch);
				__args [3] = new JValue (tillTheEnd);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapEagerDelayError_Lio_reactivex_functions_Function_IIZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapIterable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapIterable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends java.lang.Iterable&lt;? extends U&gt;&gt;']]"
		[Register ("concatMapIterable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapIterable (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_concatMapIterable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_concatMapIterable_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "concatMapIterable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapIterable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapIterable_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapIterable' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends java.lang.Iterable&lt;? extends U&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("concatMapIterable", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapIterable (global::IO.Reactivex.Functions.IFunction mapper, int prefetch)
		{
			if (id_concatMapIterable_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_concatMapIterable_Lio_reactivex_functions_Function_I = JNIEnv.GetMethodID (class_ref, "concatMapIterable", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (prefetch);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapIterable_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapMaybe_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapMaybe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;']]"
		[Register ("concatMapMaybe", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapMaybe (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_concatMapMaybe_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_concatMapMaybe_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "concatMapMaybe", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapMaybe_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapMaybe_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapMaybe' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("concatMapMaybe", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapMaybe (global::IO.Reactivex.Functions.IFunction mapper, int prefetch)
		{
			if (id_concatMapMaybe_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_concatMapMaybe_Lio_reactivex_functions_Function_I = JNIEnv.GetMethodID (class_ref, "concatMapMaybe", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (prefetch);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapMaybe_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapMaybeDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;']]"
		[Register ("concatMapMaybeDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapMaybeDelayError (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "concatMapMaybeDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapMaybeDelayError' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='boolean']]"
		[Register ("concatMapMaybeDelayError", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapMaybeDelayError (global::IO.Reactivex.Functions.IFunction mapper, bool tillTheEnd)
		{
			if (id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_Z == IntPtr.Zero)
				id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_Z = JNIEnv.GetMethodID (class_ref, "concatMapMaybeDelayError", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (tillTheEnd);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapMaybeDelayError' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("concatMapMaybeDelayError", "(Lio/reactivex/functions/Function;ZI)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapMaybeDelayError (global::IO.Reactivex.Functions.IFunction mapper, bool tillTheEnd, int prefetch)
		{
			if (id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_ZI == IntPtr.Zero)
				id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_ZI = JNIEnv.GetMethodID (class_ref, "concatMapMaybeDelayError", "(Lio/reactivex/functions/Function;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (tillTheEnd);
				__args [2] = new JValue (prefetch);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapMaybeDelayError_Lio_reactivex_functions_Function_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapSingle_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapSingle' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;']]"
		[Register ("concatMapSingle", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapSingle (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_concatMapSingle_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_concatMapSingle_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "concatMapSingle", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapSingle_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapSingle_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapSingle' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("concatMapSingle", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapSingle (global::IO.Reactivex.Functions.IFunction mapper, int prefetch)
		{
			if (id_concatMapSingle_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_concatMapSingle_Lio_reactivex_functions_Function_I = JNIEnv.GetMethodID (class_ref, "concatMapSingle", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (prefetch);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapSingle_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapSingleDelayError_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapSingleDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;']]"
		[Register ("concatMapSingleDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapSingleDelayError (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_concatMapSingleDelayError_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_concatMapSingleDelayError_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "concatMapSingleDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapSingleDelayError_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapSingleDelayError_Lio_reactivex_functions_Function_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapSingleDelayError' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='boolean']]"
		[Register ("concatMapSingleDelayError", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapSingleDelayError (global::IO.Reactivex.Functions.IFunction mapper, bool tillTheEnd)
		{
			if (id_concatMapSingleDelayError_Lio_reactivex_functions_Function_Z == IntPtr.Zero)
				id_concatMapSingleDelayError_Lio_reactivex_functions_Function_Z = JNIEnv.GetMethodID (class_ref, "concatMapSingleDelayError", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (tillTheEnd);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapSingleDelayError_Lio_reactivex_functions_Function_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatMapSingleDelayError_Lio_reactivex_functions_Function_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatMapSingleDelayError' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("concatMapSingleDelayError", "(Lio/reactivex/functions/Function;ZI)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ConcatMapSingleDelayError (global::IO.Reactivex.Functions.IFunction mapper, bool tillTheEnd, int prefetch)
		{
			if (id_concatMapSingleDelayError_Lio_reactivex_functions_Function_ZI == IntPtr.Zero)
				id_concatMapSingleDelayError_Lio_reactivex_functions_Function_ZI = JNIEnv.GetMethodID (class_ref, "concatMapSingleDelayError", "(Lio/reactivex/functions/Function;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (tillTheEnd);
				__args [2] = new JValue (prefetch);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatMapSingleDelayError_Lio_reactivex_functions_Function_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatWith_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("concatWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ConcatWith (global::IO.Reactivex.ICompletableSource other)
		{
			if (id_concatWith_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_concatWith_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "concatWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatWith_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatWith_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;']]"
		[Register ("concatWith", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ConcatWith (global::IO.Reactivex.IMaybeSource other)
		{
			if (id_concatWith_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_concatWith_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "concatWith", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatWith_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatWith_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("concatWith", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ConcatWith (global::IO.Reactivex.IObservableSource other)
		{
			if (id_concatWith_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_concatWith_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "concatWith", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatWith_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_concatWith_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='concatWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T&gt;']]"
		[Register ("concatWith", "(Lio/reactivex/SingleSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ConcatWith (global::IO.Reactivex.ISingleSource other)
		{
			if (id_concatWith_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_concatWith_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "concatWith", "(Lio/reactivex/SingleSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_concatWith_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_contains_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("contains", "(Ljava/lang/Object;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Contains (global::Java.Lang.Object element)
		{
			if (id_contains_Ljava_lang_Object_ == IntPtr.Zero)
				id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/Object;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (element);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_count;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='count' and count(parameter)=0]"
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

		static IntPtr id_create_Lio_reactivex_ObservableOnSubscribe_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='create' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableOnSubscribe&lt;T&gt;']]"
		[Register ("create", "(Lio/reactivex/ObservableOnSubscribe;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Create (global::IO.Reactivex.IObservableOnSubscribe source)
		{
			if (id_create_Lio_reactivex_ObservableOnSubscribe_ == IntPtr.Zero)
				id_create_Lio_reactivex_ObservableOnSubscribe_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lio/reactivex/ObservableOnSubscribe;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lio_reactivex_ObservableOnSubscribe_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_debounce_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='debounce' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;U&gt;&gt;']]"
		[Register ("debounce", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable Debounce (global::IO.Reactivex.Functions.IFunction debounceSelector)
		{
			if (id_debounce_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_debounce_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "debounce", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (debounceSelector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_debounce_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_debounce_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='debounce' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("debounce", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Debounce (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_debounce_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_debounce_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "debounce", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_debounce_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_debounce_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='debounce' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("debounce", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Debounce (long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_debounce_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_debounce_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "debounce", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_debounce_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_defaultIfEmpty_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='defaultIfEmpty' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("defaultIfEmpty", "(Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DefaultIfEmpty (global::Java.Lang.Object defaultItem)
		{
			if (id_defaultIfEmpty_Ljava_lang_Object_ == IntPtr.Zero)
				id_defaultIfEmpty_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "defaultIfEmpty", "(Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_defaultItem = JNIEnv.ToLocalJniHandle (defaultItem);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultItem);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_defaultIfEmpty_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultItem);
			}
		}

		static IntPtr id_defer_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='defer' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("defer", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Defer (global::Java.Util.Concurrent.ICallable supplier)
		{
			if (id_defer_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_defer_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "defer", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (supplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defer_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='delay' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;U&gt;&gt;']]"
		[Register ("delay", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable Delay (global::IO.Reactivex.Functions.IFunction itemDelay)
		{
			if (id_delay_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_delay_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "delay", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (itemDelay);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='delay' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;U&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;V&gt;&gt;']]"
		[Register ("delay", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "V"})]
		public unsafe global::IO.Reactivex.Observable Delay (global::IO.Reactivex.IObservableSource subscriptionDelay, global::IO.Reactivex.Functions.IFunction itemDelay)
		{
			if (id_delay_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_delay_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "delay", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (subscriptionDelay);
				__args [1] = new JValue (itemDelay);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='delay' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Delay (long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='delay' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='boolean']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Delay (long delay, global::Java.Util.Concurrent.TimeUnit unit, bool delayError)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_Z == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_Z = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (delayError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='delay' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Delay (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='delay' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='boolean']]"
		[Register ("delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Delay (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, bool delayError)
		{
			if (id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z == IntPtr.Zero)
				id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z = JNIEnv.GetMethodID (class_ref, "delay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (delayError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='delaySubscription' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;U&gt;']]"
		[Register ("delaySubscription", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable DelaySubscription (global::IO.Reactivex.IObservableSource other)
		{
			if (id_delaySubscription_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_delaySubscription_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='delaySubscription' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("delaySubscription", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DelaySubscription (long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_delaySubscription_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_delaySubscription_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='delaySubscription' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("delaySubscription", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DelaySubscription (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "delaySubscription", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delaySubscription_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_dematerialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='dematerialize' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("dematerialize", "()Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T2"})]
		public unsafe global::IO.Reactivex.Observable Dematerialize ()
		{
			if (id_dematerialize == IntPtr.Zero)
				id_dematerialize = JNIEnv.GetMethodID (class_ref, "dematerialize", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dematerialize), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_dematerialize_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='dematerialize' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, io.reactivex.Notification&lt;R&gt;&gt;']]"
		[Register ("dematerialize", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Dematerialize (global::IO.Reactivex.Functions.IFunction selector)
		{
			if (id_dematerialize_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_dematerialize_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "dematerialize", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (selector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dematerialize_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_distinct;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='distinct' and count(parameter)=0]"
		[Register ("distinct", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Distinct ()
		{
			if (id_distinct == IntPtr.Zero)
				id_distinct = JNIEnv.GetMethodID (class_ref, "distinct", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_distinct), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_distinct_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='distinct' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, K&gt;']]"
		[Register ("distinct", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public unsafe global::IO.Reactivex.Observable Distinct (global::IO.Reactivex.Functions.IFunction keySelector)
		{
			if (id_distinct_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_distinct_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "distinct", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (keySelector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_distinct_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_distinct_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='distinct' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, K&gt;'] and parameter[2][@type='java.util.concurrent.Callable&lt;? extends java.util.Collection&lt;? super K&gt;&gt;']]"
		[Register ("distinct", "(Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public unsafe global::IO.Reactivex.Observable Distinct (global::IO.Reactivex.Functions.IFunction keySelector, global::Java.Util.Concurrent.ICallable collectionSupplier)
		{
			if (id_distinct_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_distinct_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "distinct", "(Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (collectionSupplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_distinct_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_distinctUntilChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='distinctUntilChanged' and count(parameter)=0]"
		[Register ("distinctUntilChanged", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DistinctUntilChanged ()
		{
			if (id_distinctUntilChanged == IntPtr.Zero)
				id_distinctUntilChanged = JNIEnv.GetMethodID (class_ref, "distinctUntilChanged", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_distinctUntilChanged), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_distinctUntilChanged_Lio_reactivex_functions_BiPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='distinctUntilChanged' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiPredicate&lt;? super T, ? super T&gt;']]"
		[Register ("distinctUntilChanged", "(Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DistinctUntilChanged (global::IO.Reactivex.Functions.IBiPredicate comparer)
		{
			if (id_distinctUntilChanged_Lio_reactivex_functions_BiPredicate_ == IntPtr.Zero)
				id_distinctUntilChanged_Lio_reactivex_functions_BiPredicate_ = JNIEnv.GetMethodID (class_ref, "distinctUntilChanged", "(Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (comparer);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_distinctUntilChanged_Lio_reactivex_functions_BiPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_distinctUntilChanged_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='distinctUntilChanged' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, K&gt;']]"
		[Register ("distinctUntilChanged", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public unsafe global::IO.Reactivex.Observable DistinctUntilChanged (global::IO.Reactivex.Functions.IFunction keySelector)
		{
			if (id_distinctUntilChanged_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_distinctUntilChanged_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "distinctUntilChanged", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (keySelector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_distinctUntilChanged_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doAfterNext_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doAfterNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("doAfterNext", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoAfterNext (global::IO.Reactivex.Functions.IConsumer onAfterNext)
		{
			if (id_doAfterNext_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doAfterNext_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doAfterNext", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onAfterNext);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doAfterNext_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doAfterTerminate_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doAfterTerminate' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doAfterTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoAfterTerminate (global::IO.Reactivex.Functions.IAction onFinally)
		{
			if (id_doAfterTerminate_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doAfterTerminate_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doAfterTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onFinally);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doAfterTerminate_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doFinally_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doFinally' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doFinally", "(Lio/reactivex/functions/Action;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoFinally (global::IO.Reactivex.Functions.IAction onFinally)
		{
			if (id_doFinally_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doFinally_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doFinally", "(Lio/reactivex/functions/Action;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onFinally);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doFinally_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnComplete_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doOnComplete' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnComplete", "(Lio/reactivex/functions/Action;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoOnComplete (global::IO.Reactivex.Functions.IAction onComplete)
		{
			if (id_doOnComplete_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnComplete_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnComplete", "(Lio/reactivex/functions/Action;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onComplete);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnComplete_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnDispose_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doOnDispose' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnDispose", "(Lio/reactivex/functions/Action;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoOnDispose (global::IO.Reactivex.Functions.IAction onDispose)
		{
			if (id_doOnDispose_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnDispose_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnDispose", "(Lio/reactivex/functions/Action;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onDispose);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnDispose_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnEach_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doOnEach' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.Notification&lt;T&gt;&gt;']]"
		[Register ("doOnEach", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoOnEach (global::IO.Reactivex.Functions.IConsumer onNotification)
		{
			if (id_doOnEach_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnEach_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnEach", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onNotification);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnEach_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnEach_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doOnEach' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("doOnEach", "(Lio/reactivex/Observer;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoOnEach (global::IO.Reactivex.IObserver observer)
		{
			if (id_doOnEach_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_doOnEach_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "doOnEach", "(Lio/reactivex/Observer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnEach_Lio_reactivex_Observer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnError_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doOnError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
		[Register ("doOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoOnError (global::IO.Reactivex.Functions.IConsumer onError)
		{
			if (id_doOnError_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnError_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnError_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnLifecycle_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doOnLifecycle' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;'] and parameter[2][@type='io.reactivex.functions.Action']]"
		[Register ("doOnLifecycle", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoOnLifecycle (global::IO.Reactivex.Functions.IConsumer onSubscribe, global::IO.Reactivex.Functions.IAction onDispose)
		{
			if (id_doOnLifecycle_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnLifecycle_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnLifecycle", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (onSubscribe);
				__args [1] = new JValue (onDispose);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnLifecycle_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnNext_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doOnNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("doOnNext", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoOnNext (global::IO.Reactivex.Functions.IConsumer onNext)
		{
			if (id_doOnNext_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnNext_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnNext", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onNext);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnNext_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnSubscribe_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doOnSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register ("doOnSubscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoOnSubscribe (global::IO.Reactivex.Functions.IConsumer onSubscribe)
		{
			if (id_doOnSubscribe_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_doOnSubscribe_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "doOnSubscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSubscribe);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnSubscribe_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doOnTerminate_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='doOnTerminate' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("doOnTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable DoOnTerminate (global::IO.Reactivex.Functions.IAction onTerminate)
		{
			if (id_doOnTerminate_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_doOnTerminate_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "doOnTerminate", "(Lio/reactivex/functions/Action;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onTerminate);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doOnTerminate_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_elementAt_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='elementAt' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("elementAt", "(J)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe ElementAt (long index)
		{
			if (id_elementAt_J == IntPtr.Zero)
				id_elementAt_J = JNIEnv.GetMethodID (class_ref, "elementAt", "(J)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_elementAt_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_elementAt_JLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='elementAt' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='T']]"
		[Register ("elementAt", "(JLjava/lang/Object;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single ElementAt (long index, global::Java.Lang.Object defaultItem)
		{
			if (id_elementAt_JLjava_lang_Object_ == IntPtr.Zero)
				id_elementAt_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "elementAt", "(JLjava/lang/Object;)Lio/reactivex/Single;");
			IntPtr native_defaultItem = JNIEnv.ToLocalJniHandle (defaultItem);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_defaultItem);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_elementAt_JLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultItem);
			}
		}

		static IntPtr id_elementAtOrError_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='elementAtOrError' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("elementAtOrError", "(J)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single ElementAtOrError (long index)
		{
			if (id_elementAtOrError_J == IntPtr.Zero)
				id_elementAtOrError_J = JNIEnv.GetMethodID (class_ref, "elementAtOrError", "(J)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_elementAtOrError_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_empty;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Empty ()
		{
			if (id_empty == IntPtr.Zero)
				id_empty = JNIEnv.GetStaticMethodID (class_ref, "empty", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_empty), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/Throwable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Error (global::Java.Lang.Throwable exception)
		{
			if (id_error_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_error_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/Throwable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (exception);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_error_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends java.lang.Throwable&gt;']]"
		[Register ("error", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Error (global::Java.Util.Concurrent.ICallable errorSupplier)
		{
			if (id_error_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_error_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errorSupplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_filter_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;']]"
		[Register ("filter", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Filter (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_filter_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_filter_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "filter", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_filter_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_first_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='first' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("first", "(Ljava/lang/Object;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single First (global::Java.Lang.Object defaultItem)
		{
			if (id_first_Ljava_lang_Object_ == IntPtr.Zero)
				id_first_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "first", "(Ljava/lang/Object;)Lio/reactivex/Single;");
			IntPtr native_defaultItem = JNIEnv.ToLocalJniHandle (defaultItem);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultItem);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_first_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultItem);
			}
		}

		static IntPtr id_firstElement;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='firstElement' and count(parameter)=0]"
		[Register ("firstElement", "()Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe FirstElement ()
		{
			if (id_firstElement == IntPtr.Zero)
				id_firstElement = JNIEnv.GetMethodID (class_ref, "firstElement", "()Lio/reactivex/Maybe;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_firstElement), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_firstOrError;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='firstOrError' and count(parameter)=0]"
		[Register ("firstOrError", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single FirstOrError ()
		{
			if (id_firstOrError == IntPtr.Zero)
				id_firstOrError = JNIEnv.GetMethodID (class_ref, "firstOrError", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_firstOrError), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='boolean']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction mapper, bool delayErrors)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_Z == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_Z = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (delayErrors);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;ZI)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction mapper, bool delayErrors, int maxConcurrency)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_ZI == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_ZI = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (delayErrors);
				__args [2] = new JValue (maxConcurrency);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_ZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=4 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;ZII)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction mapper, bool delayErrors, int maxConcurrency, int bufferSize)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_ZII == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_ZII = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;ZII)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (delayErrors);
				__args [2] = new JValue (maxConcurrency);
				__args [3] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_ZII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction mapper, int maxConcurrency)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_I = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (maxConcurrency);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Throwable, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[3][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction onNextMapper, global::IO.Reactivex.Functions.IFunction onErrorMapper, global::Java.Util.Concurrent.ICallable onCompleteSupplier)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (onNextMapper);
				__args [1] = new JValue (onErrorMapper);
				__args [2] = new JValue (onCompleteSupplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=4 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;java.lang.Throwable, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[3][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[4][@type='int']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction onNextMapper, global::IO.Reactivex.Functions.IFunction onErrorMapper, global::Java.Util.Concurrent.ICallable onCompleteSupplier, int maxConcurrency)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_I == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_I = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (onNextMapper);
				__args [1] = new JValue (onErrorMapper);
				__args [2] = new JValue (onCompleteSupplier);
				__args [3] = new JValue (maxConcurrency);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends U&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction mapper, global::IO.Reactivex.Functions.IBiFunction resultSelector)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (resultSelector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends U&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;'] and parameter[3][@type='boolean']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction mapper, global::IO.Reactivex.Functions.IBiFunction combiner, bool delayErrors)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_Z == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_Z = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (combiner);
				__args [2] = new JValue (delayErrors);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=4 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends U&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;ZI)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction mapper, global::IO.Reactivex.Functions.IBiFunction combiner, bool delayErrors, int maxConcurrency)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ZI == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ZI = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (combiner);
				__args [2] = new JValue (delayErrors);
				__args [3] = new JValue (maxConcurrency);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=5 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends U&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;ZII)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction mapper, global::IO.Reactivex.Functions.IBiFunction combiner, bool delayErrors, int maxConcurrency, int bufferSize)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ZII == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ZII = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;ZII)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (combiner);
				__args [2] = new JValue (delayErrors);
				__args [3] = new JValue (maxConcurrency);
				__args [4] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ZII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMap' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends U&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;'] and parameter[3][@type='int']]"
		[Register ("flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Observable FlatMap (global::IO.Reactivex.Functions.IFunction mapper, global::IO.Reactivex.Functions.IBiFunction combiner, int maxConcurrency)
		{
			if (id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_I == IntPtr.Zero)
				id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_I = JNIEnv.GetMethodID (class_ref, "flatMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (combiner);
				__args [2] = new JValue (maxConcurrency);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapCompletable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMapCompletable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.CompletableSource&gt;']]"
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

		static IntPtr id_flatMapCompletable_Lio_reactivex_functions_Function_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMapCompletable' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.CompletableSource&gt;'] and parameter[2][@type='boolean']]"
		[Register ("flatMapCompletable", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable FlatMapCompletable (global::IO.Reactivex.Functions.IFunction mapper, bool delayErrors)
		{
			if (id_flatMapCompletable_Lio_reactivex_functions_Function_Z == IntPtr.Zero)
				id_flatMapCompletable_Lio_reactivex_functions_Function_Z = JNIEnv.GetMethodID (class_ref, "flatMapCompletable", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (delayErrors);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapCompletable_Lio_reactivex_functions_Function_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapIterable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMapIterable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends java.lang.Iterable&lt;? extends U&gt;&gt;']]"
		[Register ("flatMapIterable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable FlatMapIterable (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMapIterable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMapIterable_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flatMapIterable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapIterable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapIterable_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMapIterable' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends java.lang.Iterable&lt;? extends U&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends V&gt;']]"
		[Register ("flatMapIterable", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "V"})]
		public unsafe global::IO.Reactivex.Observable FlatMapIterable (global::IO.Reactivex.Functions.IFunction mapper, global::IO.Reactivex.Functions.IBiFunction resultSelector)
		{
			if (id_flatMapIterable_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_flatMapIterable_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "flatMapIterable", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (resultSelector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapIterable_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapMaybe_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMapMaybe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;']]"
		[Register ("flatMapMaybe", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMapMaybe (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMapMaybe_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMapMaybe_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flatMapMaybe", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapMaybe_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapMaybe_Lio_reactivex_functions_Function_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMapMaybe' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='boolean']]"
		[Register ("flatMapMaybe", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMapMaybe (global::IO.Reactivex.Functions.IFunction mapper, bool delayErrors)
		{
			if (id_flatMapMaybe_Lio_reactivex_functions_Function_Z == IntPtr.Zero)
				id_flatMapMaybe_Lio_reactivex_functions_Function_Z = JNIEnv.GetMethodID (class_ref, "flatMapMaybe", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (delayErrors);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapMaybe_Lio_reactivex_functions_Function_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapSingle_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMapSingle' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;']]"
		[Register ("flatMapSingle", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMapSingle (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_flatMapSingle_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_flatMapSingle_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "flatMapSingle", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapSingle_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatMapSingle_Lio_reactivex_functions_Function_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='flatMapSingle' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='boolean']]"
		[Register ("flatMapSingle", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable FlatMapSingle (global::IO.Reactivex.Functions.IFunction mapper, bool delayErrors)
		{
			if (id_flatMapSingle_Lio_reactivex_functions_Function_Z == IntPtr.Zero)
				id_flatMapSingle_Lio_reactivex_functions_Function_Z = JNIEnv.GetMethodID (class_ref, "flatMapSingle", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (delayErrors);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatMapSingle_Lio_reactivex_functions_Function_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_forEach_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='forEach' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("forEach", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable ForEach (global::IO.Reactivex.Functions.IConsumer onNext)
		{
			if (id_forEach_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_forEach_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "forEach", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onNext);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forEach_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_forEachWhile_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='forEachWhile' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;']]"
		[Register ("forEachWhile", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable ForEachWhile (global::IO.Reactivex.Functions.IPredicate onNext)
		{
			if (id_forEachWhile_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_forEachWhile_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "forEachWhile", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onNext);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forEachWhile_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_forEachWhile_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='forEachWhile' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
		[Register ("forEachWhile", "(Lio/reactivex/functions/Predicate;Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable ForEachWhile (global::IO.Reactivex.Functions.IPredicate onNext, global::IO.Reactivex.Functions.IConsumer onError)
		{
			if (id_forEachWhile_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_forEachWhile_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "forEachWhile", "(Lio/reactivex/functions/Predicate;Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (onNext);
				__args [1] = new JValue (onError);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forEachWhile_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_forEachWhile_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='forEachWhile' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;'] and parameter[3][@type='io.reactivex.functions.Action']]"
		[Register ("forEachWhile", "(Lio/reactivex/functions/Predicate;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable ForEachWhile (global::IO.Reactivex.Functions.IPredicate onNext, global::IO.Reactivex.Functions.IConsumer onError, global::IO.Reactivex.Functions.IAction onComplete)
		{
			if (id_forEachWhile_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_forEachWhile_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "forEachWhile", "(Lio/reactivex/functions/Predicate;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (onNext);
				__args [1] = new JValue (onError);
				__args [2] = new JValue (onComplete);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forEachWhile_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromArray_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='fromArray' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("fromArray", "([Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable FromArray (params global::Java.Lang.Object[] items)
		{
			if (id_fromArray_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_fromArray_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "fromArray", "([Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_items);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromArray_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (items != null) {
					JNIEnv.CopyArray (native_items, items);
					JNIEnv.DeleteLocalRef (native_items);
				}
			}
		}

		static IntPtr id_fromCallable_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='fromCallable' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends T&gt;']]"
		[Register ("fromCallable", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable FromCallable (global::Java.Util.Concurrent.ICallable supplier)
		{
			if (id_fromCallable_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_fromCallable_Ljava_util_concurrent_Callable_ = JNIEnv.GetStaticMethodID (class_ref, "fromCallable", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (supplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCallable_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='fromFuture' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Future&lt;? extends T&gt;']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable FromFuture (global::Java.Util.Concurrent.IFuture future)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (future);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='fromFuture' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Future&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.Scheduler']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable FromFuture (global::Java.Util.Concurrent.IFuture future, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (future);
				__args [1] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='fromFuture' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Future&lt;? extends T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable FromFuture (global::Java.Util.Concurrent.IFuture future, long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (future);
				__args [1] = new JValue (timeout);
				__args [2] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='fromFuture' and count(parameter)=4 and parameter[1][@type='java.util.concurrent.Future&lt;? extends T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable FromFuture (global::Java.Util.Concurrent.IFuture future, long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (future);
				__args [1] = new JValue (timeout);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromIterable_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='fromIterable' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends T&gt;']]"
		[Register ("fromIterable", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable FromIterable (global::Java.Lang.IIterable source)
		{
			if (id_fromIterable_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_fromIterable_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "fromIterable", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromIterable_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_generate_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='generate' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;io.reactivex.Emitter&lt;T&gt;&gt;']]"
		[Register ("generate", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Generate (global::IO.Reactivex.Functions.IConsumer generator)
		{
			if (id_generate_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_generate_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "generate", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (generator);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generate_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='generate' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;S&gt;'] and parameter[2][@type='io.reactivex.functions.BiConsumer&lt;S, io.reactivex.Emitter&lt;T&gt;&gt;']]"
		[Register ("generate", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiConsumer;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "S"})]
		public static unsafe global::IO.Reactivex.Observable Generate (global::Java.Util.Concurrent.ICallable initialState, global::IO.Reactivex.Functions.IBiConsumer generator)
		{
			if (id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_ == IntPtr.Zero)
				id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_ = JNIEnv.GetStaticMethodID (class_ref, "generate", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiConsumer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (initialState);
				__args [1] = new JValue (generator);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='generate' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Callable&lt;S&gt;'] and parameter[2][@type='io.reactivex.functions.BiConsumer&lt;S, io.reactivex.Emitter&lt;T&gt;&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super S&gt;']]"
		[Register ("generate", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiConsumer;Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "S"})]
		public static unsafe global::IO.Reactivex.Observable Generate (global::Java.Util.Concurrent.ICallable initialState, global::IO.Reactivex.Functions.IBiConsumer generator, global::IO.Reactivex.Functions.IConsumer disposeState)
		{
			if (id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "generate", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiConsumer;Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (initialState);
				__args [1] = new JValue (generator);
				__args [2] = new JValue (disposeState);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiConsumer_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='generate' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;S&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;S, io.reactivex.Emitter&lt;T&gt;, S&gt;']]"
		[Register ("generate", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "S"})]
		public static unsafe global::IO.Reactivex.Observable Generate (global::Java.Util.Concurrent.ICallable initialState, global::IO.Reactivex.Functions.IBiFunction generator)
		{
			if (id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetStaticMethodID (class_ref, "generate", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (initialState);
				__args [1] = new JValue (generator);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='generate' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Callable&lt;S&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;S, io.reactivex.Emitter&lt;T&gt;, S&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super S&gt;']]"
		[Register ("generate", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "S"})]
		public static unsafe global::IO.Reactivex.Observable Generate (global::Java.Util.Concurrent.ICallable initialState, global::IO.Reactivex.Functions.IBiFunction generator, global::IO.Reactivex.Functions.IConsumer disposeState)
		{
			if (id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "generate", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (initialState);
				__args [1] = new JValue (generator);
				__args [2] = new JValue (disposeState);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generate_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_groupBy_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='groupBy' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;']]"
		[Register ("groupBy", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public unsafe global::IO.Reactivex.Observable GroupBy (global::IO.Reactivex.Functions.IFunction keySelector)
		{
			if (id_groupBy_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_groupBy_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "groupBy", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (keySelector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_groupBy_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_groupBy_Lio_reactivex_functions_Function_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='groupBy' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='boolean']]"
		[Register ("groupBy", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public unsafe global::IO.Reactivex.Observable GroupBy (global::IO.Reactivex.Functions.IFunction keySelector, bool delayError)
		{
			if (id_groupBy_Lio_reactivex_functions_Function_Z == IntPtr.Zero)
				id_groupBy_Lio_reactivex_functions_Function_Z = JNIEnv.GetMethodID (class_ref, "groupBy", "(Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (delayError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_groupBy_Lio_reactivex_functions_Function_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='groupBy' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;']]"
		[Register ("groupBy", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public unsafe global::IO.Reactivex.Observable GroupBy (global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector)
		{
			if (id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "groupBy", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (valueSelector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='groupBy' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;'] and parameter[3][@type='boolean']]"
		[Register ("groupBy", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public unsafe global::IO.Reactivex.Observable GroupBy (global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector, bool delayError)
		{
			if (id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Z == IntPtr.Zero)
				id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Z = JNIEnv.GetMethodID (class_ref, "groupBy", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (valueSelector);
				__args [2] = new JValue (delayError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='groupBy' and count(parameter)=4 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("groupBy", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;ZI)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public unsafe global::IO.Reactivex.Observable GroupBy (global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector, bool delayError, int bufferSize)
		{
			if (id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ZI == IntPtr.Zero)
				id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ZI = JNIEnv.GetMethodID (class_ref, "groupBy", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (valueSelector);
				__args [2] = new JValue (delayError);
				__args [3] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_groupBy_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_groupJoin_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='groupJoin' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends TRight&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;TLeftEnd&gt;&gt;'] and parameter[3][@type='io.reactivex.functions.Function&lt;? super TRight, ? extends io.reactivex.ObservableSource&lt;TRightEnd&gt;&gt;'] and parameter[4][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super io.reactivex.Observable&lt;TRight&gt;, ? extends R&gt;']]"
		[Register ("groupJoin", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TRight", "TLeftEnd", "TRightEnd", "R"})]
		public unsafe global::IO.Reactivex.Observable GroupJoin (global::IO.Reactivex.IObservableSource other, global::IO.Reactivex.Functions.IFunction leftEnd, global::IO.Reactivex.Functions.IFunction rightEnd, global::IO.Reactivex.Functions.IBiFunction resultSelector)
		{
			if (id_groupJoin_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_groupJoin_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "groupJoin", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (other);
				__args [1] = new JValue (leftEnd);
				__args [2] = new JValue (rightEnd);
				__args [3] = new JValue (resultSelector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_groupJoin_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hide;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hide), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ignoreElements;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='ignoreElements' and count(parameter)=0]"
		[Register ("ignoreElements", "()Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable IgnoreElements ()
		{
			if (id_ignoreElements == IntPtr.Zero)
				id_ignoreElements = JNIEnv.GetMethodID (class_ref, "ignoreElements", "()Lio/reactivex/Completable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ignoreElements), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_interval_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='interval' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("interval", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public static unsafe global::IO.Reactivex.Observable Interval (long period, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_interval_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_interval_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "interval", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (period);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_interval_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_interval_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='interval' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("interval", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public static unsafe global::IO.Reactivex.Observable Interval (long period, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_interval_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_interval_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "interval", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (period);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_interval_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_interval_JJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='interval' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("interval", "(JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public static unsafe global::IO.Reactivex.Observable Interval (long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_interval_JJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_interval_JJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "interval", "(JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (initialDelay);
				__args [1] = new JValue (period);
				__args [2] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_interval_JJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_interval_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='interval' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler']]"
		[Register ("interval", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public static unsafe global::IO.Reactivex.Observable Interval (long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_interval_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_interval_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "interval", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (initialDelay);
				__args [1] = new JValue (period);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_interval_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_intervalRange_JJJJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='intervalRange' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.util.concurrent.TimeUnit']]"
		[Register ("intervalRange", "(JJJJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public static unsafe global::IO.Reactivex.Observable IntervalRange (long start, long count, long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_intervalRange_JJJJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_intervalRange_JJJJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "intervalRange", "(JJJJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (start);
				__args [1] = new JValue (count);
				__args [2] = new JValue (initialDelay);
				__args [3] = new JValue (period);
				__args [4] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_intervalRange_JJJJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_intervalRange_JJJJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='intervalRange' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.util.concurrent.TimeUnit'] and parameter[6][@type='io.reactivex.Scheduler']]"
		[Register ("intervalRange", "(JJJJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public static unsafe global::IO.Reactivex.Observable IntervalRange (long start, long count, long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_intervalRange_JJJJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_intervalRange_JJJJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "intervalRange", "(JJJJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (start);
				__args [1] = new JValue (count);
				__args [2] = new JValue (initialDelay);
				__args [3] = new JValue (period);
				__args [4] = new JValue (unit);
				__args [5] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_intervalRange_JJJJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isEmpty;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='isEmpty' and count(parameter)=0]"
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

		static IntPtr id_join_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='join' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends TRight&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;TLeftEnd&gt;&gt;'] and parameter[3][@type='io.reactivex.functions.Function&lt;? super TRight, ? extends io.reactivex.ObservableSource&lt;TRightEnd&gt;&gt;'] and parameter[4][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super TRight, ? extends R&gt;']]"
		[Register ("join", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TRight", "TLeftEnd", "TRightEnd", "R"})]
		public unsafe global::IO.Reactivex.Observable Join (global::IO.Reactivex.IObservableSource other, global::IO.Reactivex.Functions.IFunction leftEnd, global::IO.Reactivex.Functions.IFunction rightEnd, global::IO.Reactivex.Functions.IBiFunction resultSelector)
		{
			if (id_join_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_join_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "join", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (other);
				__args [1] = new JValue (leftEnd);
				__args [2] = new JValue (rightEnd);
				__args [3] = new JValue (resultSelector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_join_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_just_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='just' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Just (global::Java.Lang.Object item)
		{
			if (id_just_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_item);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item);
			}
		}

		static IntPtr id_just_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='just' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Just (global::Java.Lang.Object item1, global::Java.Lang.Object item2)
		{
			if (id_just_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item1 = JNIEnv.ToLocalJniHandle (item1);
			IntPtr native_item2 = JNIEnv.ToLocalJniHandle (item2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_item1);
				__args [1] = new JValue (native_item2);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item1);
				JNIEnv.DeleteLocalRef (native_item2);
			}
		}

		static IntPtr id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='just' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Just (global::Java.Lang.Object item1, global::Java.Lang.Object item2, global::Java.Lang.Object item3)
		{
			if (id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item1 = JNIEnv.ToLocalJniHandle (item1);
			IntPtr native_item2 = JNIEnv.ToLocalJniHandle (item2);
			IntPtr native_item3 = JNIEnv.ToLocalJniHandle (item3);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_item1);
				__args [1] = new JValue (native_item2);
				__args [2] = new JValue (native_item3);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item1);
				JNIEnv.DeleteLocalRef (native_item2);
				JNIEnv.DeleteLocalRef (native_item3);
			}
		}

		static IntPtr id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='just' and count(parameter)=4 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='T'] and parameter[4][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Just (global::Java.Lang.Object item1, global::Java.Lang.Object item2, global::Java.Lang.Object item3, global::Java.Lang.Object item4)
		{
			if (id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item1 = JNIEnv.ToLocalJniHandle (item1);
			IntPtr native_item2 = JNIEnv.ToLocalJniHandle (item2);
			IntPtr native_item3 = JNIEnv.ToLocalJniHandle (item3);
			IntPtr native_item4 = JNIEnv.ToLocalJniHandle (item4);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_item1);
				__args [1] = new JValue (native_item2);
				__args [2] = new JValue (native_item3);
				__args [3] = new JValue (native_item4);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item1);
				JNIEnv.DeleteLocalRef (native_item2);
				JNIEnv.DeleteLocalRef (native_item3);
				JNIEnv.DeleteLocalRef (native_item4);
			}
		}

		static IntPtr id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='just' and count(parameter)=5 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='T'] and parameter[4][@type='T'] and parameter[5][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Just (global::Java.Lang.Object item1, global::Java.Lang.Object item2, global::Java.Lang.Object item3, global::Java.Lang.Object item4, global::Java.Lang.Object item5)
		{
			if (id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item1 = JNIEnv.ToLocalJniHandle (item1);
			IntPtr native_item2 = JNIEnv.ToLocalJniHandle (item2);
			IntPtr native_item3 = JNIEnv.ToLocalJniHandle (item3);
			IntPtr native_item4 = JNIEnv.ToLocalJniHandle (item4);
			IntPtr native_item5 = JNIEnv.ToLocalJniHandle (item5);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_item1);
				__args [1] = new JValue (native_item2);
				__args [2] = new JValue (native_item3);
				__args [3] = new JValue (native_item4);
				__args [4] = new JValue (native_item5);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item1);
				JNIEnv.DeleteLocalRef (native_item2);
				JNIEnv.DeleteLocalRef (native_item3);
				JNIEnv.DeleteLocalRef (native_item4);
				JNIEnv.DeleteLocalRef (native_item5);
			}
		}

		static IntPtr id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='just' and count(parameter)=6 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='T'] and parameter[4][@type='T'] and parameter[5][@type='T'] and parameter[6][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Just (global::Java.Lang.Object item1, global::Java.Lang.Object item2, global::Java.Lang.Object item3, global::Java.Lang.Object item4, global::Java.Lang.Object item5, global::Java.Lang.Object item6)
		{
			if (id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item1 = JNIEnv.ToLocalJniHandle (item1);
			IntPtr native_item2 = JNIEnv.ToLocalJniHandle (item2);
			IntPtr native_item3 = JNIEnv.ToLocalJniHandle (item3);
			IntPtr native_item4 = JNIEnv.ToLocalJniHandle (item4);
			IntPtr native_item5 = JNIEnv.ToLocalJniHandle (item5);
			IntPtr native_item6 = JNIEnv.ToLocalJniHandle (item6);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_item1);
				__args [1] = new JValue (native_item2);
				__args [2] = new JValue (native_item3);
				__args [3] = new JValue (native_item4);
				__args [4] = new JValue (native_item5);
				__args [5] = new JValue (native_item6);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item1);
				JNIEnv.DeleteLocalRef (native_item2);
				JNIEnv.DeleteLocalRef (native_item3);
				JNIEnv.DeleteLocalRef (native_item4);
				JNIEnv.DeleteLocalRef (native_item5);
				JNIEnv.DeleteLocalRef (native_item6);
			}
		}

		static IntPtr id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='just' and count(parameter)=7 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='T'] and parameter[4][@type='T'] and parameter[5][@type='T'] and parameter[6][@type='T'] and parameter[7][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Just (global::Java.Lang.Object item1, global::Java.Lang.Object item2, global::Java.Lang.Object item3, global::Java.Lang.Object item4, global::Java.Lang.Object item5, global::Java.Lang.Object item6, global::Java.Lang.Object item7)
		{
			if (id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item1 = JNIEnv.ToLocalJniHandle (item1);
			IntPtr native_item2 = JNIEnv.ToLocalJniHandle (item2);
			IntPtr native_item3 = JNIEnv.ToLocalJniHandle (item3);
			IntPtr native_item4 = JNIEnv.ToLocalJniHandle (item4);
			IntPtr native_item5 = JNIEnv.ToLocalJniHandle (item5);
			IntPtr native_item6 = JNIEnv.ToLocalJniHandle (item6);
			IntPtr native_item7 = JNIEnv.ToLocalJniHandle (item7);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_item1);
				__args [1] = new JValue (native_item2);
				__args [2] = new JValue (native_item3);
				__args [3] = new JValue (native_item4);
				__args [4] = new JValue (native_item5);
				__args [5] = new JValue (native_item6);
				__args [6] = new JValue (native_item7);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item1);
				JNIEnv.DeleteLocalRef (native_item2);
				JNIEnv.DeleteLocalRef (native_item3);
				JNIEnv.DeleteLocalRef (native_item4);
				JNIEnv.DeleteLocalRef (native_item5);
				JNIEnv.DeleteLocalRef (native_item6);
				JNIEnv.DeleteLocalRef (native_item7);
			}
		}

		static IntPtr id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='just' and count(parameter)=8 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='T'] and parameter[4][@type='T'] and parameter[5][@type='T'] and parameter[6][@type='T'] and parameter[7][@type='T'] and parameter[8][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Just (global::Java.Lang.Object item1, global::Java.Lang.Object item2, global::Java.Lang.Object item3, global::Java.Lang.Object item4, global::Java.Lang.Object item5, global::Java.Lang.Object item6, global::Java.Lang.Object item7, global::Java.Lang.Object item8)
		{
			if (id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item1 = JNIEnv.ToLocalJniHandle (item1);
			IntPtr native_item2 = JNIEnv.ToLocalJniHandle (item2);
			IntPtr native_item3 = JNIEnv.ToLocalJniHandle (item3);
			IntPtr native_item4 = JNIEnv.ToLocalJniHandle (item4);
			IntPtr native_item5 = JNIEnv.ToLocalJniHandle (item5);
			IntPtr native_item6 = JNIEnv.ToLocalJniHandle (item6);
			IntPtr native_item7 = JNIEnv.ToLocalJniHandle (item7);
			IntPtr native_item8 = JNIEnv.ToLocalJniHandle (item8);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_item1);
				__args [1] = new JValue (native_item2);
				__args [2] = new JValue (native_item3);
				__args [3] = new JValue (native_item4);
				__args [4] = new JValue (native_item5);
				__args [5] = new JValue (native_item6);
				__args [6] = new JValue (native_item7);
				__args [7] = new JValue (native_item8);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item1);
				JNIEnv.DeleteLocalRef (native_item2);
				JNIEnv.DeleteLocalRef (native_item3);
				JNIEnv.DeleteLocalRef (native_item4);
				JNIEnv.DeleteLocalRef (native_item5);
				JNIEnv.DeleteLocalRef (native_item6);
				JNIEnv.DeleteLocalRef (native_item7);
				JNIEnv.DeleteLocalRef (native_item8);
			}
		}

		static IntPtr id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='just' and count(parameter)=9 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='T'] and parameter[4][@type='T'] and parameter[5][@type='T'] and parameter[6][@type='T'] and parameter[7][@type='T'] and parameter[8][@type='T'] and parameter[9][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Just (global::Java.Lang.Object item1, global::Java.Lang.Object item2, global::Java.Lang.Object item3, global::Java.Lang.Object item4, global::Java.Lang.Object item5, global::Java.Lang.Object item6, global::Java.Lang.Object item7, global::Java.Lang.Object item8, global::Java.Lang.Object item9)
		{
			if (id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item1 = JNIEnv.ToLocalJniHandle (item1);
			IntPtr native_item2 = JNIEnv.ToLocalJniHandle (item2);
			IntPtr native_item3 = JNIEnv.ToLocalJniHandle (item3);
			IntPtr native_item4 = JNIEnv.ToLocalJniHandle (item4);
			IntPtr native_item5 = JNIEnv.ToLocalJniHandle (item5);
			IntPtr native_item6 = JNIEnv.ToLocalJniHandle (item6);
			IntPtr native_item7 = JNIEnv.ToLocalJniHandle (item7);
			IntPtr native_item8 = JNIEnv.ToLocalJniHandle (item8);
			IntPtr native_item9 = JNIEnv.ToLocalJniHandle (item9);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_item1);
				__args [1] = new JValue (native_item2);
				__args [2] = new JValue (native_item3);
				__args [3] = new JValue (native_item4);
				__args [4] = new JValue (native_item5);
				__args [5] = new JValue (native_item6);
				__args [6] = new JValue (native_item7);
				__args [7] = new JValue (native_item8);
				__args [8] = new JValue (native_item9);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item1);
				JNIEnv.DeleteLocalRef (native_item2);
				JNIEnv.DeleteLocalRef (native_item3);
				JNIEnv.DeleteLocalRef (native_item4);
				JNIEnv.DeleteLocalRef (native_item5);
				JNIEnv.DeleteLocalRef (native_item6);
				JNIEnv.DeleteLocalRef (native_item7);
				JNIEnv.DeleteLocalRef (native_item8);
				JNIEnv.DeleteLocalRef (native_item9);
			}
		}

		static IntPtr id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='just' and count(parameter)=10 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='T'] and parameter[4][@type='T'] and parameter[5][@type='T'] and parameter[6][@type='T'] and parameter[7][@type='T'] and parameter[8][@type='T'] and parameter[9][@type='T'] and parameter[10][@type='T']]"
		[Register ("just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Just (global::Java.Lang.Object item1, global::Java.Lang.Object item2, global::Java.Lang.Object item3, global::Java.Lang.Object item4, global::Java.Lang.Object item5, global::Java.Lang.Object item6, global::Java.Lang.Object item7, global::Java.Lang.Object item8, global::Java.Lang.Object item9, global::Java.Lang.Object item10)
		{
			if (id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "just", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item1 = JNIEnv.ToLocalJniHandle (item1);
			IntPtr native_item2 = JNIEnv.ToLocalJniHandle (item2);
			IntPtr native_item3 = JNIEnv.ToLocalJniHandle (item3);
			IntPtr native_item4 = JNIEnv.ToLocalJniHandle (item4);
			IntPtr native_item5 = JNIEnv.ToLocalJniHandle (item5);
			IntPtr native_item6 = JNIEnv.ToLocalJniHandle (item6);
			IntPtr native_item7 = JNIEnv.ToLocalJniHandle (item7);
			IntPtr native_item8 = JNIEnv.ToLocalJniHandle (item8);
			IntPtr native_item9 = JNIEnv.ToLocalJniHandle (item9);
			IntPtr native_item10 = JNIEnv.ToLocalJniHandle (item10);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_item1);
				__args [1] = new JValue (native_item2);
				__args [2] = new JValue (native_item3);
				__args [3] = new JValue (native_item4);
				__args [4] = new JValue (native_item5);
				__args [5] = new JValue (native_item6);
				__args [6] = new JValue (native_item7);
				__args [7] = new JValue (native_item8);
				__args [8] = new JValue (native_item9);
				__args [9] = new JValue (native_item10);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_just_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item1);
				JNIEnv.DeleteLocalRef (native_item2);
				JNIEnv.DeleteLocalRef (native_item3);
				JNIEnv.DeleteLocalRef (native_item4);
				JNIEnv.DeleteLocalRef (native_item5);
				JNIEnv.DeleteLocalRef (native_item6);
				JNIEnv.DeleteLocalRef (native_item7);
				JNIEnv.DeleteLocalRef (native_item8);
				JNIEnv.DeleteLocalRef (native_item9);
				JNIEnv.DeleteLocalRef (native_item10);
			}
		}

		static IntPtr id_last_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='last' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("last", "(Ljava/lang/Object;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Last (global::Java.Lang.Object defaultItem)
		{
			if (id_last_Ljava_lang_Object_ == IntPtr.Zero)
				id_last_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "last", "(Ljava/lang/Object;)Lio/reactivex/Single;");
			IntPtr native_defaultItem = JNIEnv.ToLocalJniHandle (defaultItem);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultItem);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_last_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultItem);
			}
		}

		static IntPtr id_lastElement;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='lastElement' and count(parameter)=0]"
		[Register ("lastElement", "()Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe LastElement ()
		{
			if (id_lastElement == IntPtr.Zero)
				id_lastElement = JNIEnv.GetMethodID (class_ref, "lastElement", "()Lio/reactivex/Maybe;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_lastElement), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_lastOrError;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='lastOrError' and count(parameter)=0]"
		[Register ("lastOrError", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single LastOrError ()
		{
			if (id_lastOrError == IntPtr.Zero)
				id_lastOrError = JNIEnv.GetMethodID (class_ref, "lastOrError", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_lastOrError), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_lift_Lio_reactivex_ObservableOperator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='lift' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableOperator&lt;? extends R, ? super T&gt;']]"
		[Register ("lift", "(Lio/reactivex/ObservableOperator;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Lift (global::IO.Reactivex.IObservableOperator lifter)
		{
			if (id_lift_Lio_reactivex_ObservableOperator_ == IntPtr.Zero)
				id_lift_Lio_reactivex_ObservableOperator_ = JNIEnv.GetMethodID (class_ref, "lift", "(Lio/reactivex/ObservableOperator;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (lifter);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_lift_Lio_reactivex_ObservableOperator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_map_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='map' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends R&gt;']]"
		[Register ("map", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Map (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_map_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_map_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "map", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_materialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='materialize' and count(parameter)=0]"
		[Register ("materialize", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Materialize ()
		{
			if (id_materialize == IntPtr.Zero)
				id_materialize = JNIEnv.GetMethodID (class_ref, "materialize", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_materialize), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_merge_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("merge", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Merge (global::IO.Reactivex.IObservableSource sources)
		{
			if (id_merge_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_merge_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_merge_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_merge_Lio_reactivex_ObservableSource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='merge' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("merge", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Merge (global::IO.Reactivex.IObservableSource sources, int maxConcurrency)
		{
			if (id_merge_Lio_reactivex_ObservableSource_I == IntPtr.Zero)
				id_merge_Lio_reactivex_ObservableSource_I = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (maxConcurrency);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_merge_Lio_reactivex_ObservableSource_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='merge' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("merge", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Merge (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2)
		{
			if (id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='merge' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("merge", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Merge (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3)
		{
			if (id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='merge' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("merge", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Merge (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4)
		{
			if (id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_merge_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_merge_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("merge", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Merge (global::Java.Lang.IIterable sources)
		{
			if (id_merge_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_merge_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_merge_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_merge_Ljava_lang_Iterable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='merge' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("merge", "(Ljava/lang/Iterable;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Merge (global::Java.Lang.IIterable sources, int maxConcurrency)
		{
			if (id_merge_Ljava_lang_Iterable_I == IntPtr.Zero)
				id_merge_Ljava_lang_Iterable_I = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Ljava/lang/Iterable;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (maxConcurrency);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_merge_Ljava_lang_Iterable_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_merge_Ljava_lang_Iterable_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='merge' and count(parameter)=3 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("merge", "(Ljava/lang/Iterable;II)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Merge (global::Java.Lang.IIterable sources, int maxConcurrency, int bufferSize)
		{
			if (id_merge_Ljava_lang_Iterable_II == IntPtr.Zero)
				id_merge_Ljava_lang_Iterable_II = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Ljava/lang/Iterable;II)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (maxConcurrency);
				__args [2] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_merge_Ljava_lang_Iterable_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeArray_IIarrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeArray' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("mergeArray", "(II[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeArray (int maxConcurrency, int bufferSize, params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_mergeArray_IIarrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_mergeArray_IIarrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "mergeArray", "(II[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (maxConcurrency);
				__args [1] = new JValue (bufferSize);
				__args [2] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeArray_IIarrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_mergeArray_arrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeArray' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("mergeArray", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeArray (params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_mergeArray_arrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_mergeArray_arrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "mergeArray", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeArray_arrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_mergeArrayDelayError_IIarrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeArrayDelayError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("mergeArrayDelayError", "(II[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeArrayDelayError (int maxConcurrency, int bufferSize, params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_mergeArrayDelayError_IIarrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_mergeArrayDelayError_IIarrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "mergeArrayDelayError", "(II[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (maxConcurrency);
				__args [1] = new JValue (bufferSize);
				__args [2] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeArrayDelayError_IIarrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_mergeArrayDelayError_arrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeArrayDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("mergeArrayDelayError", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeArrayDelayError (params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_mergeArrayDelayError_arrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_mergeArrayDelayError_arrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "mergeArrayDelayError", "([Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeArrayDelayError_arrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_mergeDelayError_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("mergeDelayError", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeDelayError (global::IO.Reactivex.IObservableSource sources)
		{
			if (id_mergeDelayError_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_mergeDelayError_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "mergeDelayError", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeDelayError_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeDelayError_Lio_reactivex_ObservableSource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeDelayError' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("mergeDelayError", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeDelayError (global::IO.Reactivex.IObservableSource sources, int maxConcurrency)
		{
			if (id_mergeDelayError_Lio_reactivex_ObservableSource_I == IntPtr.Zero)
				id_mergeDelayError_Lio_reactivex_ObservableSource_I = JNIEnv.GetStaticMethodID (class_ref, "mergeDelayError", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (maxConcurrency);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeDelayError_Lio_reactivex_ObservableSource_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeDelayError' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("mergeDelayError", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeDelayError (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2)
		{
			if (id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "mergeDelayError", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeDelayError' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("mergeDelayError", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeDelayError (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3)
		{
			if (id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "mergeDelayError", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeDelayError' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("mergeDelayError", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeDelayError (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4)
		{
			if (id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "mergeDelayError", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeDelayError_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeDelayError_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeDelayError' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("mergeDelayError", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeDelayError (global::Java.Lang.IIterable sources)
		{
			if (id_mergeDelayError_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_mergeDelayError_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "mergeDelayError", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeDelayError_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeDelayError_Ljava_lang_Iterable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeDelayError' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("mergeDelayError", "(Ljava/lang/Iterable;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeDelayError (global::Java.Lang.IIterable sources, int maxConcurrency)
		{
			if (id_mergeDelayError_Ljava_lang_Iterable_I == IntPtr.Zero)
				id_mergeDelayError_Ljava_lang_Iterable_I = JNIEnv.GetStaticMethodID (class_ref, "mergeDelayError", "(Ljava/lang/Iterable;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (maxConcurrency);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeDelayError_Ljava_lang_Iterable_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeDelayError_Ljava_lang_Iterable_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeDelayError' and count(parameter)=3 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("mergeDelayError", "(Ljava/lang/Iterable;II)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable MergeDelayError (global::Java.Lang.IIterable sources, int maxConcurrency, int bufferSize)
		{
			if (id_mergeDelayError_Ljava_lang_Iterable_II == IntPtr.Zero)
				id_mergeDelayError_Ljava_lang_Iterable_II = JNIEnv.GetStaticMethodID (class_ref, "mergeDelayError", "(Ljava/lang/Iterable;II)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (maxConcurrency);
				__args [2] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeDelayError_Ljava_lang_Iterable_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeWith_Lio_reactivex_CompletableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableSource']]"
		[Register ("mergeWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable MergeWith (global::IO.Reactivex.ICompletableSource other)
		{
			if (id_mergeWith_Lio_reactivex_CompletableSource_ == IntPtr.Zero)
				id_mergeWith_Lio_reactivex_CompletableSource_ = JNIEnv.GetMethodID (class_ref, "mergeWith", "(Lio/reactivex/CompletableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mergeWith_Lio_reactivex_CompletableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeWith_Lio_reactivex_MaybeSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;']]"
		[Register ("mergeWith", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable MergeWith (global::IO.Reactivex.IMaybeSource other)
		{
			if (id_mergeWith_Lio_reactivex_MaybeSource_ == IntPtr.Zero)
				id_mergeWith_Lio_reactivex_MaybeSource_ = JNIEnv.GetMethodID (class_ref, "mergeWith", "(Lio/reactivex/MaybeSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mergeWith_Lio_reactivex_MaybeSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeWith_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("mergeWith", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable MergeWith (global::IO.Reactivex.IObservableSource other)
		{
			if (id_mergeWith_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_mergeWith_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "mergeWith", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mergeWith_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeWith_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='mergeWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T&gt;']]"
		[Register ("mergeWith", "(Lio/reactivex/SingleSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable MergeWith (global::IO.Reactivex.ISingleSource other)
		{
			if (id_mergeWith_Lio_reactivex_SingleSource_ == IntPtr.Zero)
				id_mergeWith_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "mergeWith", "(Lio/reactivex/SingleSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mergeWith_Lio_reactivex_SingleSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_never;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='never' and count(parameter)=0]"
		[Register ("never", "()Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Never ()
		{
			if (id_never == IntPtr.Zero)
				id_never = JNIEnv.GetStaticMethodID (class_ref, "never", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_never), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_observeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='observeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("observeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ObserveOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_observeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_observeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "observeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_observeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_observeOn_Lio_reactivex_Scheduler_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='observeOn' and count(parameter)=2 and parameter[1][@type='io.reactivex.Scheduler'] and parameter[2][@type='boolean']]"
		[Register ("observeOn", "(Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ObserveOn (global::IO.Reactivex.Scheduler scheduler, bool delayError)
		{
			if (id_observeOn_Lio_reactivex_Scheduler_Z == IntPtr.Zero)
				id_observeOn_Lio_reactivex_Scheduler_Z = JNIEnv.GetMethodID (class_ref, "observeOn", "(Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (scheduler);
				__args [1] = new JValue (delayError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_observeOn_Lio_reactivex_Scheduler_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_observeOn_Lio_reactivex_Scheduler_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='observeOn' and count(parameter)=3 and parameter[1][@type='io.reactivex.Scheduler'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("observeOn", "(Lio/reactivex/Scheduler;ZI)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ObserveOn (global::IO.Reactivex.Scheduler scheduler, bool delayError, int bufferSize)
		{
			if (id_observeOn_Lio_reactivex_Scheduler_ZI == IntPtr.Zero)
				id_observeOn_Lio_reactivex_Scheduler_ZI = JNIEnv.GetMethodID (class_ref, "observeOn", "(Lio/reactivex/Scheduler;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (scheduler);
				__args [1] = new JValue (delayError);
				__args [2] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_observeOn_Lio_reactivex_Scheduler_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ofType_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='ofType' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;U&gt;']]"
		[Register ("ofType", "(Ljava/lang/Class;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable OfType (global::Java.Lang.Class clazz)
		{
			if (id_ofType_Ljava_lang_Class_ == IntPtr.Zero)
				id_ofType_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "ofType", "(Ljava/lang/Class;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clazz);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ofType_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorResumeNext_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='onErrorResumeNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Throwable, ? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("onErrorResumeNext", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable OnErrorResumeNext (global::IO.Reactivex.Functions.IFunction resumeFunction)
		{
			if (id_onErrorResumeNext_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_onErrorResumeNext_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "onErrorResumeNext", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (resumeFunction);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorResumeNext_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorResumeNext_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='onErrorResumeNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("onErrorResumeNext", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable OnErrorResumeNext (global::IO.Reactivex.IObservableSource next)
		{
			if (id_onErrorResumeNext_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_onErrorResumeNext_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "onErrorResumeNext", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (next);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorResumeNext_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorReturn_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='onErrorReturn' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Throwable, ? extends T&gt;']]"
		[Register ("onErrorReturn", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable OnErrorReturn (global::IO.Reactivex.Functions.IFunction valueSupplier)
		{
			if (id_onErrorReturn_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_onErrorReturn_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "onErrorReturn", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (valueSupplier);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorReturn_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onErrorReturnItem_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='onErrorReturnItem' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onErrorReturnItem", "(Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable OnErrorReturnItem (global::Java.Lang.Object item)
		{
			if (id_onErrorReturnItem_Ljava_lang_Object_ == IntPtr.Zero)
				id_onErrorReturnItem_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onErrorReturnItem", "(Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_item);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onErrorReturnItem_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item);
			}
		}

		static IntPtr id_onExceptionResumeNext_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='onExceptionResumeNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("onExceptionResumeNext", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable OnExceptionResumeNext (global::IO.Reactivex.IObservableSource next)
		{
			if (id_onExceptionResumeNext_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_onExceptionResumeNext_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "onExceptionResumeNext", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (next);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onExceptionResumeNext_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onTerminateDetach;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='onTerminateDetach' and count(parameter)=0]"
		[Register ("onTerminateDetach", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable OnTerminateDetach ()
		{
			if (id_onTerminateDetach == IntPtr.Zero)
				id_onTerminateDetach = JNIEnv.GetMethodID (class_ref, "onTerminateDetach", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onTerminateDetach), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_publish;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='publish' and count(parameter)=0]"
		[Register ("publish", "()Lio/reactivex/observables/ConnectableObservable;", "")]
		public unsafe global::IO.Reactivex.Observables.ConnectableObservable Publish ()
		{
			if (id_publish == IntPtr.Zero)
				id_publish = JNIEnv.GetMethodID (class_ref, "publish", "()Lio/reactivex/observables/ConnectableObservable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_publish_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='publish' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;T&gt;, ? extends io.reactivex.ObservableSource&lt;R&gt;&gt;']]"
		[Register ("publish", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Publish (global::IO.Reactivex.Functions.IFunction selector)
		{
			if (id_publish_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_publish_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "publish", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (selector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_range_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='range' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("range", "(II)Lio/reactivex/Observable;", "")]
		public static unsafe global::IO.Reactivex.Observable Range (int start, int count)
		{
			if (id_range_II == IntPtr.Zero)
				id_range_II = JNIEnv.GetStaticMethodID (class_ref, "range", "(II)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (start);
				__args [1] = new JValue (count);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_range_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_rangeLong_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='rangeLong' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("rangeLong", "(JJ)Lio/reactivex/Observable;", "")]
		public static unsafe global::IO.Reactivex.Observable RangeLong (long start, long count)
		{
			if (id_rangeLong_JJ == IntPtr.Zero)
				id_rangeLong_JJ = JNIEnv.GetStaticMethodID (class_ref, "rangeLong", "(JJ)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (start);
				__args [1] = new JValue (count);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_rangeLong_JJ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_reduce_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='reduce' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiFunction&lt;T, T, T&gt;']]"
		[Register ("reduce", "(Lio/reactivex/functions/BiFunction;)Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe Reduce (global::IO.Reactivex.Functions.IBiFunction reducer)
		{
			if (id_reduce_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_reduce_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "reduce", "(Lio/reactivex/functions/BiFunction;)Lio/reactivex/Maybe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (reducer);
				global::IO.Reactivex.Maybe __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reduce_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reduce_Ljava_lang_Object_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='reduce' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;R, ? super T, R&gt;']]"
		[Register ("reduce", "(Ljava/lang/Object;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Single Reduce (global::Java.Lang.Object seed, global::IO.Reactivex.Functions.IBiFunction reducer)
		{
			if (id_reduce_Ljava_lang_Object_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_reduce_Ljava_lang_Object_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "reduce", "(Ljava/lang/Object;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Single;");
			IntPtr native_seed = JNIEnv.ToLocalJniHandle (seed);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_seed);
				__args [1] = new JValue (reducer);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reduce_Ljava_lang_Object_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seed);
			}
		}

		static IntPtr id_reduceWith_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='reduceWith' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;R&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;R, ? super T, R&gt;']]"
		[Register ("reduceWith", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Single ReduceWith (global::Java.Util.Concurrent.ICallable seedSupplier, global::IO.Reactivex.Functions.IBiFunction reducer)
		{
			if (id_reduceWith_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_reduceWith_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "reduceWith", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (seedSupplier);
				__args [1] = new JValue (reducer);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reduceWith_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_repeat;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='repeat' and count(parameter)=0]"
		[Register ("repeat", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Repeat ()
		{
			if (id_repeat == IntPtr.Zero)
				id_repeat = JNIEnv.GetMethodID (class_ref, "repeat", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_repeat), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_repeat_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='repeat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("repeat", "(J)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Repeat (long times)
		{
			if (id_repeat_J == IntPtr.Zero)
				id_repeat_J = JNIEnv.GetMethodID (class_ref, "repeat", "(J)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (times);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_repeat_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_repeatUntil_Lio_reactivex_functions_BooleanSupplier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='repeatUntil' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BooleanSupplier']]"
		[Register ("repeatUntil", "(Lio/reactivex/functions/BooleanSupplier;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable RepeatUntil (global::IO.Reactivex.Functions.IBooleanSupplier stop)
		{
			if (id_repeatUntil_Lio_reactivex_functions_BooleanSupplier_ == IntPtr.Zero)
				id_repeatUntil_Lio_reactivex_functions_BooleanSupplier_ = JNIEnv.GetMethodID (class_ref, "repeatUntil", "(Lio/reactivex/functions/BooleanSupplier;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (stop);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_repeatUntil_Lio_reactivex_functions_BooleanSupplier_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_repeatWhen_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='repeatWhen' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;java.lang.Object&gt;, ? extends io.reactivex.ObservableSource&lt;?&gt;&gt;']]"
		[Register ("repeatWhen", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable RepeatWhen (global::IO.Reactivex.Functions.IFunction handler)
		{
			if (id_repeatWhen_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_repeatWhen_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "repeatWhen", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (handler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_repeatWhen_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=0]"
		[Register ("replay", "()Lio/reactivex/observables/ConnectableObservable;", "")]
		public unsafe global::IO.Reactivex.Observables.ConnectableObservable Replay ()
		{
			if (id_replay == IntPtr.Zero)
				id_replay = JNIEnv.GetMethodID (class_ref, "replay", "()Lio/reactivex/observables/ConnectableObservable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_replay_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("replay", "(I)Lio/reactivex/observables/ConnectableObservable;", "")]
		public unsafe global::IO.Reactivex.Observables.ConnectableObservable Replay (int bufferSize)
		{
			if (id_replay_I == IntPtr.Zero)
				id_replay_I = JNIEnv.GetMethodID (class_ref, "replay", "(I)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bufferSize);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_replay_ILio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='io.reactivex.Scheduler']]"
		[Register ("replay", "(ILio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;", "")]
		public unsafe global::IO.Reactivex.Observables.ConnectableObservable Replay (int bufferSize, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_replay_ILio_reactivex_Scheduler_ == IntPtr.Zero)
				id_replay_ILio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "replay", "(ILio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (bufferSize);
				__args [1] = new JValue (scheduler);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_ILio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_IJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("replay", "(IJLjava/util/concurrent/TimeUnit;)Lio/reactivex/observables/ConnectableObservable;", "")]
		public unsafe global::IO.Reactivex.Observables.ConnectableObservable Replay (int bufferSize, long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_replay_IJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_replay_IJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "replay", "(IJLjava/util/concurrent/TimeUnit;)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (bufferSize);
				__args [1] = new JValue (time);
				__args [2] = new JValue (unit);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_IJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler']]"
		[Register ("replay", "(IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;", "")]
		public unsafe global::IO.Reactivex.Observables.ConnectableObservable Replay (int bufferSize, long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_replay_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_replay_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "replay", "(IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (bufferSize);
				__args [1] = new JValue (time);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;T&gt;, ? extends io.reactivex.ObservableSource&lt;R&gt;&gt;']]"
		[Register ("replay", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Replay (global::IO.Reactivex.Functions.IFunction selector)
		{
			if (id_replay_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_replay_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "replay", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (selector);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;T&gt;, ? extends io.reactivex.ObservableSource&lt;R&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("replay", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Replay (global::IO.Reactivex.Functions.IFunction selector, int bufferSize)
		{
			if (id_replay_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_replay_Lio_reactivex_functions_Function_I = JNIEnv.GetMethodID (class_ref, "replay", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (selector);
				__args [1] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_Lio_reactivex_functions_Function_ILio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;T&gt;, ? extends io.reactivex.ObservableSource&lt;R&gt;&gt;'] and parameter[2][@type='int'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("replay", "(Lio/reactivex/functions/Function;ILio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Replay (global::IO.Reactivex.Functions.IFunction selector, int bufferSize, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_replay_Lio_reactivex_functions_Function_ILio_reactivex_Scheduler_ == IntPtr.Zero)
				id_replay_Lio_reactivex_functions_Function_ILio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "replay", "(Lio/reactivex/functions/Function;ILio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (selector);
				__args [1] = new JValue (bufferSize);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_Lio_reactivex_functions_Function_ILio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_Lio_reactivex_functions_Function_IJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=4 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;T&gt;, ? extends io.reactivex.ObservableSource&lt;R&gt;&gt;'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit']]"
		[Register ("replay", "(Lio/reactivex/functions/Function;IJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Replay (global::IO.Reactivex.Functions.IFunction selector, int bufferSize, long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_replay_Lio_reactivex_functions_Function_IJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_replay_Lio_reactivex_functions_Function_IJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "replay", "(Lio/reactivex/functions/Function;IJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (selector);
				__args [1] = new JValue (bufferSize);
				__args [2] = new JValue (time);
				__args [3] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_Lio_reactivex_functions_Function_IJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_Lio_reactivex_functions_Function_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=5 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;T&gt;, ? extends io.reactivex.ObservableSource&lt;R&gt;&gt;'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit'] and parameter[5][@type='io.reactivex.Scheduler']]"
		[Register ("replay", "(Lio/reactivex/functions/Function;IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Replay (global::IO.Reactivex.Functions.IFunction selector, int bufferSize, long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_replay_Lio_reactivex_functions_Function_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_replay_Lio_reactivex_functions_Function_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "replay", "(Lio/reactivex/functions/Function;IJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (selector);
				__args [1] = new JValue (bufferSize);
				__args [2] = new JValue (time);
				__args [3] = new JValue (unit);
				__args [4] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_Lio_reactivex_functions_Function_IJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_Lio_reactivex_functions_Function_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;T&gt;, ? extends io.reactivex.ObservableSource&lt;R&gt;&gt;'] and parameter[2][@type='io.reactivex.Scheduler']]"
		[Register ("replay", "(Lio/reactivex/functions/Function;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Replay (global::IO.Reactivex.Functions.IFunction selector, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_replay_Lio_reactivex_functions_Function_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_replay_Lio_reactivex_functions_Function_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "replay", "(Lio/reactivex/functions/Function;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (selector);
				__args [1] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_Lio_reactivex_functions_Function_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_Lio_reactivex_functions_Function_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;T&gt;, ? extends io.reactivex.ObservableSource&lt;R&gt;&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("replay", "(Lio/reactivex/functions/Function;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Replay (global::IO.Reactivex.Functions.IFunction selector, long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_replay_Lio_reactivex_functions_Function_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_replay_Lio_reactivex_functions_Function_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "replay", "(Lio/reactivex/functions/Function;JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (selector);
				__args [1] = new JValue (time);
				__args [2] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_Lio_reactivex_functions_Function_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_Lio_reactivex_functions_Function_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=4 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;T&gt;, ? extends io.reactivex.ObservableSource&lt;R&gt;&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler']]"
		[Register ("replay", "(Lio/reactivex/functions/Function;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Replay (global::IO.Reactivex.Functions.IFunction selector, long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_replay_Lio_reactivex_functions_Function_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_replay_Lio_reactivex_functions_Function_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "replay", "(Lio/reactivex/functions/Function;JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (selector);
				__args [1] = new JValue (time);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_Lio_reactivex_functions_Function_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("replay", "(Lio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;", "")]
		public unsafe global::IO.Reactivex.Observables.ConnectableObservable Replay (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_replay_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_replay_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "replay", "(Lio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("replay", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/observables/ConnectableObservable;", "")]
		public unsafe global::IO.Reactivex.Observables.ConnectableObservable Replay (long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_replay_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_replay_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "replay", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='replay' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("replay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;", "")]
		public unsafe global::IO.Reactivex.Observables.ConnectableObservable Replay (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_replay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_replay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "replay", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replay_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retry;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='retry' and count(parameter)=0]"
		[Register ("retry", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Retry ()
		{
			if (id_retry == IntPtr.Zero)
				id_retry = JNIEnv.GetMethodID (class_ref, "retry", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_retry_Lio_reactivex_functions_BiPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiPredicate&lt;? super java.lang.Integer, ? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Retry (global::IO.Reactivex.Functions.IBiPredicate predicate)
		{
			if (id_retry_Lio_reactivex_functions_BiPredicate_ == IntPtr.Zero)
				id_retry_Lio_reactivex_functions_BiPredicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_Lio_reactivex_functions_BiPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retry_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Retry (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_retry_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_retry_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retry_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("retry", "(J)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Retry (long times)
		{
			if (id_retry_J == IntPtr.Zero)
				id_retry_J = JNIEnv.GetMethodID (class_ref, "retry", "(J)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (times);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_retry_JLio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='retry' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='io.reactivex.functions.Predicate&lt;? super java.lang.Throwable&gt;']]"
		[Register ("retry", "(JLio/reactivex/functions/Predicate;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Retry (long times, global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_retry_JLio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_retry_JLio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "retry", "(JLio/reactivex/functions/Predicate;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (times);
				__args [1] = new JValue (predicate);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retry_JLio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retryUntil_Lio_reactivex_functions_BooleanSupplier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='retryUntil' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BooleanSupplier']]"
		[Register ("retryUntil", "(Lio/reactivex/functions/BooleanSupplier;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable RetryUntil (global::IO.Reactivex.Functions.IBooleanSupplier stop)
		{
			if (id_retryUntil_Lio_reactivex_functions_BooleanSupplier_ == IntPtr.Zero)
				id_retryUntil_Lio_reactivex_functions_BooleanSupplier_ = JNIEnv.GetMethodID (class_ref, "retryUntil", "(Lio/reactivex/functions/BooleanSupplier;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (stop);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retryUntil_Lio_reactivex_functions_BooleanSupplier_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_retryWhen_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='retryWhen' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;java.lang.Throwable&gt;, ? extends io.reactivex.ObservableSource&lt;?&gt;&gt;']]"
		[Register ("retryWhen", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable RetryWhen (global::IO.Reactivex.Functions.IFunction handler)
		{
			if (id_retryWhen_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_retryWhen_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "retryWhen", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (handler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retryWhen_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_safeSubscribe_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='safeSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("safeSubscribe", "(Lio/reactivex/Observer;)V", "")]
		public unsafe void SafeSubscribe (global::IO.Reactivex.IObserver observer)
		{
			if (id_safeSubscribe_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_safeSubscribe_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "safeSubscribe", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_safeSubscribe_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

		static IntPtr id_sample_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sample' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;U&gt;']]"
		[Register ("sample", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable Sample (global::IO.Reactivex.IObservableSource sampler)
		{
			if (id_sample_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_sample_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "sample", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sampler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sample_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sample_Lio_reactivex_ObservableSource_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sample' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;U&gt;'] and parameter[2][@type='boolean']]"
		[Register ("sample", "(Lio/reactivex/ObservableSource;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable Sample (global::IO.Reactivex.IObservableSource sampler, bool emitLast)
		{
			if (id_sample_Lio_reactivex_ObservableSource_Z == IntPtr.Zero)
				id_sample_Lio_reactivex_ObservableSource_Z = JNIEnv.GetMethodID (class_ref, "sample", "(Lio/reactivex/ObservableSource;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sampler);
				__args [1] = new JValue (emitLast);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sample_Lio_reactivex_ObservableSource_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sample_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sample' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("sample", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Sample (long period, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_sample_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_sample_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "sample", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (period);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sample_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sample_JLjava_util_concurrent_TimeUnit_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sample' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='boolean']]"
		[Register ("sample", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Sample (long period, global::Java.Util.Concurrent.TimeUnit unit, bool emitLast)
		{
			if (id_sample_JLjava_util_concurrent_TimeUnit_Z == IntPtr.Zero)
				id_sample_JLjava_util_concurrent_TimeUnit_Z = JNIEnv.GetMethodID (class_ref, "sample", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (period);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (emitLast);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sample_JLjava_util_concurrent_TimeUnit_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sample_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sample' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("sample", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Sample (long period, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_sample_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_sample_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "sample", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (period);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sample_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sample_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sample' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='boolean']]"
		[Register ("sample", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Sample (long period, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, bool emitLast)
		{
			if (id_sample_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z == IntPtr.Zero)
				id_sample_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z = JNIEnv.GetMethodID (class_ref, "sample", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (period);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (emitLast);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sample_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_scan_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='scan' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiFunction&lt;T, T, T&gt;']]"
		[Register ("scan", "(Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Scan (global::IO.Reactivex.Functions.IBiFunction accumulator)
		{
			if (id_scan_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_scan_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "scan", "(Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (accumulator);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scan_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_scan_Ljava_lang_Object_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='scan' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;R, ? super T, R&gt;']]"
		[Register ("scan", "(Ljava/lang/Object;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable Scan (global::Java.Lang.Object initialValue, global::IO.Reactivex.Functions.IBiFunction accumulator)
		{
			if (id_scan_Ljava_lang_Object_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_scan_Ljava_lang_Object_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "scan", "(Ljava/lang/Object;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			IntPtr native_initialValue = JNIEnv.ToLocalJniHandle (initialValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_initialValue);
				__args [1] = new JValue (accumulator);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scan_Ljava_lang_Object_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_initialValue);
			}
		}

		static IntPtr id_scanWith_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='scanWith' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;R&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;R, ? super T, R&gt;']]"
		[Register ("scanWith", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable ScanWith (global::Java.Util.Concurrent.ICallable seedSupplier, global::IO.Reactivex.Functions.IBiFunction accumulator)
		{
			if (id_scanWith_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_scanWith_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "scanWith", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (seedSupplier);
				__args [1] = new JValue (accumulator);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scanWith_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sequenceEqual' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("sequenceEqual", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single SequenceEqual (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2)
		{
			if (id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "sequenceEqual", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sequenceEqual' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[3][@type='int']]"
		[Register ("sequenceEqual", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;I)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single SequenceEqual (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, int bufferSize)
		{
			if (id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_I == IntPtr.Zero)
				id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_I = JNIEnv.GetStaticMethodID (class_ref, "sequenceEqual", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;I)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (bufferSize);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sequenceEqual' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[3][@type='io.reactivex.functions.BiPredicate&lt;? super T, ? super T&gt;']]"
		[Register ("sequenceEqual", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single SequenceEqual (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.Functions.IBiPredicate isEqual)
		{
			if (id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_ == IntPtr.Zero)
				id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_ = JNIEnv.GetStaticMethodID (class_ref, "sequenceEqual", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiPredicate;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (isEqual);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sequenceEqual' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[3][@type='io.reactivex.functions.BiPredicate&lt;? super T, ? super T&gt;'] and parameter[4][@type='int']]"
		[Register ("sequenceEqual", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiPredicate;I)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Single SequenceEqual (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.Functions.IBiPredicate isEqual, int bufferSize)
		{
			if (id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_I == IntPtr.Zero)
				id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_I = JNIEnv.GetStaticMethodID (class_ref, "sequenceEqual", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiPredicate;I)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (isEqual);
				__args [3] = new JValue (bufferSize);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sequenceEqual_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiPredicate_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_serialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='serialize' and count(parameter)=0]"
		[Register ("serialize", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Serialize ()
		{
			if (id_serialize == IntPtr.Zero)
				id_serialize = JNIEnv.GetMethodID (class_ref, "serialize", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_serialize), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_share;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='share' and count(parameter)=0]"
		[Register ("share", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Share ()
		{
			if (id_share == IntPtr.Zero)
				id_share = JNIEnv.GetMethodID (class_ref, "share", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_share), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_single_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='single' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("single", "(Ljava/lang/Object;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single Single (global::Java.Lang.Object defaultItem)
		{
			if (id_single_Ljava_lang_Object_ == IntPtr.Zero)
				id_single_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "single", "(Ljava/lang/Object;)Lio/reactivex/Single;");
			IntPtr native_defaultItem = JNIEnv.ToLocalJniHandle (defaultItem);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultItem);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_single_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultItem);
			}
		}

		static IntPtr id_singleElement;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='singleElement' and count(parameter)=0]"
		[Register ("singleElement", "()Lio/reactivex/Maybe;", "")]
		public unsafe global::IO.Reactivex.Maybe SingleElement ()
		{
			if (id_singleElement == IntPtr.Zero)
				id_singleElement = JNIEnv.GetMethodID (class_ref, "singleElement", "()Lio/reactivex/Maybe;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Maybe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_singleElement), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_singleOrError;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='singleOrError' and count(parameter)=0]"
		[Register ("singleOrError", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single SingleOrError ()
		{
			if (id_singleOrError == IntPtr.Zero)
				id_singleOrError = JNIEnv.GetMethodID (class_ref, "singleOrError", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_singleOrError), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_skip_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skip", "(J)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Skip (long count)
		{
			if (id_skip_J == IntPtr.Zero)
				id_skip_J = JNIEnv.GetMethodID (class_ref, "skip", "(J)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skip_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_skip_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='skip' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("skip", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Skip (long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_skip_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_skip_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "skip", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skip_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_skip_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='skip' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("skip", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Skip (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_skip_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_skip_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "skip", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skip_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_skipLast_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='skipLast' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipLast", "(I)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable SkipLast (int count)
		{
			if (id_skipLast_I == IntPtr.Zero)
				id_skipLast_I = JNIEnv.GetMethodID (class_ref, "skipLast", "(I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skipLast_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_skipLast_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='skipLast' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("skipLast", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable SkipLast (long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_skipLast_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_skipLast_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "skipLast", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skipLast_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_skipLast_JLjava_util_concurrent_TimeUnit_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='skipLast' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='boolean']]"
		[Register ("skipLast", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable SkipLast (long time, global::Java.Util.Concurrent.TimeUnit unit, bool delayError)
		{
			if (id_skipLast_JLjava_util_concurrent_TimeUnit_Z == IntPtr.Zero)
				id_skipLast_JLjava_util_concurrent_TimeUnit_Z = JNIEnv.GetMethodID (class_ref, "skipLast", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (delayError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skipLast_JLjava_util_concurrent_TimeUnit_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='skipLast' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("skipLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable SkipLast (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "skipLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='skipLast' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='boolean']]"
		[Register ("skipLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable SkipLast (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, bool delayError)
		{
			if (id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z == IntPtr.Zero)
				id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z = JNIEnv.GetMethodID (class_ref, "skipLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (delayError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='skipLast' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
		[Register ("skipLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;ZI)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable SkipLast (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, bool delayError, int bufferSize)
		{
			if (id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI == IntPtr.Zero)
				id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI = JNIEnv.GetMethodID (class_ref, "skipLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (delayError);
				__args [4] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skipLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_skipUntil_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='skipUntil' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;U&gt;']]"
		[Register ("skipUntil", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable SkipUntil (global::IO.Reactivex.IObservableSource other)
		{
			if (id_skipUntil_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_skipUntil_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "skipUntil", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skipUntil_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_skipWhile_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='skipWhile' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;']]"
		[Register ("skipWhile", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable SkipWhile (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_skipWhile_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_skipWhile_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "skipWhile", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_skipWhile_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sorted;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sorted' and count(parameter)=0]"
		[Register ("sorted", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Sorted ()
		{
			if (id_sorted == IntPtr.Zero)
				id_sorted = JNIEnv.GetMethodID (class_ref, "sorted", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sorted), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_sorted_Ljava_util_Comparator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='sorted' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("sorted", "(Ljava/util/Comparator;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Sorted (global::Java.Util.IComparator sortFunction)
		{
			if (id_sorted_Ljava_util_Comparator_ == IntPtr.Zero)
				id_sorted_Ljava_util_Comparator_ = JNIEnv.GetMethodID (class_ref, "sorted", "(Ljava/util/Comparator;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sortFunction);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sorted_Ljava_util_Comparator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_startWith_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='startWith' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("startWith", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable StartWith (global::IO.Reactivex.IObservableSource other)
		{
			if (id_startWith_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_startWith_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "startWith", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startWith_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_startWith_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='startWith' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends T&gt;']]"
		[Register ("startWith", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable StartWith (global::Java.Lang.IIterable items)
		{
			if (id_startWith_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_startWith_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "startWith", "(Ljava/lang/Iterable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (items);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startWith_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_startWith_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='startWith' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("startWith", "(Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable StartWith (global::Java.Lang.Object item)
		{
			if (id_startWith_Ljava_lang_Object_ == IntPtr.Zero)
				id_startWith_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "startWith", "(Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_item);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startWith_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_item);
			}
		}

		static IntPtr id_startWithArray_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='startWithArray' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("startWithArray", "([Ljava/lang/Object;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable StartWithArray (params global::Java.Lang.Object[] items)
		{
			if (id_startWithArray_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_startWithArray_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "startWithArray", "([Ljava/lang/Object;)Lio/reactivex/Observable;");
			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_items);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startWithArray_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (items != null) {
					JNIEnv.CopyArray (native_items, items);
					JNIEnv.DeleteLocalRef (native_items);
				}
			}
		}

		static IntPtr id_subscribe;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='subscribe' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Subscribe (global::IO.Reactivex.Functions.IConsumer onNext)
		{
			if (id_subscribe_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onNext);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Subscribe (global::IO.Reactivex.Functions.IConsumer onNext, global::IO.Reactivex.Functions.IConsumer onError)
		{
			if (id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (onNext);
				__args [1] = new JValue (onError);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;'] and parameter[3][@type='io.reactivex.functions.Action']]"
		[Register ("subscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Subscribe (global::IO.Reactivex.Functions.IConsumer onNext, global::IO.Reactivex.Functions.IConsumer onError, global::IO.Reactivex.Functions.IAction onComplete)
		{
			if (id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (onNext);
				__args [1] = new JValue (onError);
				__args [2] = new JValue (onComplete);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='subscribe' and count(parameter)=4 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;'] and parameter[3][@type='io.reactivex.functions.Action'] and parameter[4][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;", "")]
		public unsafe global::IO.Reactivex.Disposables.IDisposable Subscribe (global::IO.Reactivex.Functions.IConsumer onNext, global::IO.Reactivex.Functions.IConsumer onError, global::IO.Reactivex.Functions.IAction onComplete, global::IO.Reactivex.Functions.IConsumer onSubscribe)
		{
			if (id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;Lio/reactivex/functions/Consumer;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (onNext);
				__args [1] = new JValue (onError);
				__args [2] = new JValue (onComplete);
				__args [3] = new JValue (onSubscribe);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/Observer;)V", "")]
		public unsafe void Subscribe (global::IO.Reactivex.IObserver observer)
		{
			if (id_subscribe_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

		static Delegate cb_subscribeActual_Lio_reactivex_Observer_;
#pragma warning disable 0169
		static Delegate GetSubscribeActual_Lio_reactivex_Observer_Handler ()
		{
			if (cb_subscribeActual_Lio_reactivex_Observer_ == null)
				cb_subscribeActual_Lio_reactivex_Observer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SubscribeActual_Lio_reactivex_Observer_);
			return cb_subscribeActual_Lio_reactivex_Observer_;
		}

		static void n_SubscribeActual_Lio_reactivex_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.IObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubscribeActual (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/Observer;)V", "GetSubscribeActual_Lio_reactivex_Observer_Handler")]
		protected abstract void SubscribeActual (global::IO.Reactivex.IObserver p0);

		static IntPtr id_subscribeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='subscribeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("subscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable SubscribeOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_subscribeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_subscribeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "subscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribeWith_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='subscribeWith' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("subscribeWith", "(Lio/reactivex/Observer;)Lio/reactivex/Observer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends io.reactivex.Observer<? super T>"})]
		public unsafe global::Java.Lang.Object SubscribeWith (global::Java.Lang.Object observer)
		{
			if (id_subscribeWith_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribeWith_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "subscribeWith", "(Lio/reactivex/Observer;)Lio/reactivex/Observer;");
			IntPtr native_observer = JNIEnv.ToLocalJniHandle (observer);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_observer);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribeWith_Lio_reactivex_Observer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_observer);
			}
		}

		static IntPtr id_switchIfEmpty_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchIfEmpty' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("switchIfEmpty", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable SwitchIfEmpty (global::IO.Reactivex.IObservableSource other)
		{
			if (id_switchIfEmpty_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_switchIfEmpty_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "switchIfEmpty", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchIfEmpty_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchMap_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchMap' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;']]"
		[Register ("switchMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable SwitchMap (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_switchMap_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_switchMap_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "switchMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchMap_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchMap_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchMap' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("switchMap", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable SwitchMap (global::IO.Reactivex.Functions.IFunction mapper, int bufferSize)
		{
			if (id_switchMap_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_switchMap_Lio_reactivex_functions_Function_I = JNIEnv.GetMethodID (class_ref, "switchMap", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchMap_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchMapCompletable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchMapCompletable' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.CompletableSource&gt;']]"
		[Register ("switchMapCompletable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable SwitchMapCompletable (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_switchMapCompletable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_switchMapCompletable_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "switchMapCompletable", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchMapCompletable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchMapCompletableDelayError_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchMapCompletableDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.CompletableSource&gt;']]"
		[Register ("switchMapCompletableDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;", "")]
		public unsafe global::IO.Reactivex.Completable SwitchMapCompletableDelayError (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_switchMapCompletableDelayError_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_switchMapCompletableDelayError_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "switchMapCompletableDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Completable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Completable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Completable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchMapCompletableDelayError_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchMapDelayError_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchMapDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;']]"
		[Register ("switchMapDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable SwitchMapDelayError (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_switchMapDelayError_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_switchMapDelayError_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "switchMapDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchMapDelayError_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchMapDelayError_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchMapDelayError' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("switchMapDelayError", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable SwitchMapDelayError (global::IO.Reactivex.Functions.IFunction mapper, int bufferSize)
		{
			if (id_switchMapDelayError_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_switchMapDelayError_Lio_reactivex_functions_Function_I = JNIEnv.GetMethodID (class_ref, "switchMapDelayError", "(Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mapper);
				__args [1] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchMapDelayError_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchMapMaybe_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchMapMaybe' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;']]"
		[Register ("switchMapMaybe", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable SwitchMapMaybe (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_switchMapMaybe_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_switchMapMaybe_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "switchMapMaybe", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchMapMaybe_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchMapMaybeDelayError_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchMapMaybeDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.MaybeSource&lt;? extends R&gt;&gt;']]"
		[Register ("switchMapMaybeDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable SwitchMapMaybeDelayError (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_switchMapMaybeDelayError_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_switchMapMaybeDelayError_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "switchMapMaybeDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchMapMaybeDelayError_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchMapSingle_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchMapSingle' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;']]"
		[Register ("switchMapSingle", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable SwitchMapSingle (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_switchMapSingle_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_switchMapSingle_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "switchMapSingle", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchMapSingle_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchMapSingleDelayError_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchMapSingleDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.SingleSource&lt;? extends R&gt;&gt;']]"
		[Register ("switchMapSingleDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable SwitchMapSingleDelayError (global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_switchMapSingleDelayError_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_switchMapSingleDelayError_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "switchMapSingleDelayError", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchMapSingleDelayError_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchOnNext_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchOnNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("switchOnNext", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable SwitchOnNext (global::IO.Reactivex.IObservableSource sources)
		{
			if (id_switchOnNext_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_switchOnNext_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "switchOnNext", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_switchOnNext_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchOnNext_Lio_reactivex_ObservableSource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchOnNext' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("switchOnNext", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable SwitchOnNext (global::IO.Reactivex.IObservableSource sources, int bufferSize)
		{
			if (id_switchOnNext_Lio_reactivex_ObservableSource_I == IntPtr.Zero)
				id_switchOnNext_Lio_reactivex_ObservableSource_I = JNIEnv.GetStaticMethodID (class_ref, "switchOnNext", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_switchOnNext_Lio_reactivex_ObservableSource_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchOnNextDelayError_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchOnNextDelayError' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;']]"
		[Register ("switchOnNextDelayError", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable SwitchOnNextDelayError (global::IO.Reactivex.IObservableSource sources)
		{
			if (id_switchOnNextDelayError_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_switchOnNextDelayError_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "switchOnNextDelayError", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_switchOnNextDelayError_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchOnNextDelayError_Lio_reactivex_ObservableSource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='switchOnNextDelayError' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("switchOnNextDelayError", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable SwitchOnNextDelayError (global::IO.Reactivex.IObservableSource sources, int prefetch)
		{
			if (id_switchOnNextDelayError_Lio_reactivex_ObservableSource_I == IntPtr.Zero)
				id_switchOnNextDelayError_Lio_reactivex_ObservableSource_I = JNIEnv.GetStaticMethodID (class_ref, "switchOnNextDelayError", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (prefetch);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_switchOnNextDelayError_Lio_reactivex_ObservableSource_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_take_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='take' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("take", "(J)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Take (long count)
		{
			if (id_take_J == IntPtr.Zero)
				id_take_J = JNIEnv.GetMethodID (class_ref, "take", "(J)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_take_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_take_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='take' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("take", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Take (long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_take_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_take_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "take", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_take_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_take_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='take' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("take", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Take (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_take_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_take_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "take", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_take_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeLast_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeLast' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("takeLast", "(I)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TakeLast (int count)
		{
			if (id_takeLast_I == IntPtr.Zero)
				id_takeLast_I = JNIEnv.GetMethodID (class_ref, "takeLast", "(I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeLast_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_takeLast_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeLast' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("takeLast", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TakeLast (long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_takeLast_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_takeLast_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "takeLast", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeLast_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeLast_JLjava_util_concurrent_TimeUnit_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeLast' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='boolean']]"
		[Register ("takeLast", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TakeLast (long time, global::Java.Util.Concurrent.TimeUnit unit, bool delayError)
		{
			if (id_takeLast_JLjava_util_concurrent_TimeUnit_Z == IntPtr.Zero)
				id_takeLast_JLjava_util_concurrent_TimeUnit_Z = JNIEnv.GetMethodID (class_ref, "takeLast", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (delayError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeLast_JLjava_util_concurrent_TimeUnit_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeLast' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("takeLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TakeLast (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "takeLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeLast' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='boolean']]"
		[Register ("takeLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TakeLast (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, bool delayError)
		{
			if (id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z == IntPtr.Zero)
				id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z = JNIEnv.GetMethodID (class_ref, "takeLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (delayError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeLast' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
		[Register ("takeLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;ZI)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TakeLast (long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, bool delayError, int bufferSize)
		{
			if (id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI == IntPtr.Zero)
				id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI = JNIEnv.GetMethodID (class_ref, "takeLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (delayError);
				__args [4] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeLast_JJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeLast' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("takeLast", "(JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TakeLast (long count, long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_takeLast_JJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_takeLast_JJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "takeLast", "(JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (count);
				__args [1] = new JValue (time);
				__args [2] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeLast_JJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeLast_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeLast' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler']]"
		[Register ("takeLast", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TakeLast (long count, long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_takeLast_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_takeLast_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "takeLast", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (count);
				__args [1] = new JValue (time);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeLast_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeLast_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeLast' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler'] and parameter[5][@type='boolean'] and parameter[6][@type='int']]"
		[Register ("takeLast", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;ZI)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TakeLast (long count, long time, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, bool delayError, int bufferSize)
		{
			if (id_takeLast_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI == IntPtr.Zero)
				id_takeLast_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI = JNIEnv.GetMethodID (class_ref, "takeLast", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (count);
				__args [1] = new JValue (time);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				__args [4] = new JValue (delayError);
				__args [5] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeLast_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeUntil_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeUntil' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;']]"
		[Register ("takeUntil", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TakeUntil (global::IO.Reactivex.Functions.IPredicate stopPredicate)
		{
			if (id_takeUntil_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_takeUntil_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "takeUntil", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (stopPredicate);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeUntil_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeUntil_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeUntil' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;U&gt;']]"
		[Register ("takeUntil", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::IO.Reactivex.Observable TakeUntil (global::IO.Reactivex.IObservableSource other)
		{
			if (id_takeUntil_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_takeUntil_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "takeUntil", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeUntil_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_takeWhile_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='takeWhile' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;']]"
		[Register ("takeWhile", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TakeWhile (global::IO.Reactivex.Functions.IPredicate predicate)
		{
			if (id_takeWhile_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_takeWhile_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "takeWhile", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeWhile_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_test;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='test' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='test' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("test", "(Z)Lio/reactivex/observers/TestObserver;", "")]
		public unsafe global::IO.Reactivex.Observers.TestObserver Test (bool dispose)
		{
			if (id_test_Z == IntPtr.Zero)
				id_test_Z = JNIEnv.GetMethodID (class_ref, "test", "(Z)Lio/reactivex/observers/TestObserver;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (dispose);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.TestObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_test_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_throttleFirst_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='throttleFirst' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("throttleFirst", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ThrottleFirst (long windowDuration, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_throttleFirst_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_throttleFirst_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "throttleFirst", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (windowDuration);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_throttleFirst_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throttleFirst_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='throttleFirst' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("throttleFirst", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ThrottleFirst (long skipDuration, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_throttleFirst_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_throttleFirst_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "throttleFirst", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (skipDuration);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_throttleFirst_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throttleLast_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='throttleLast' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("throttleLast", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ThrottleLast (long intervalDuration, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_throttleLast_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_throttleLast_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "throttleLast", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (intervalDuration);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_throttleLast_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throttleLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='throttleLast' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("throttleLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ThrottleLast (long intervalDuration, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_throttleLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_throttleLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "throttleLast", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (intervalDuration);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_throttleLast_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throttleLatest_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='throttleLatest' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("throttleLatest", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ThrottleLatest (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_throttleLatest_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_throttleLatest_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "throttleLatest", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_throttleLatest_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throttleLatest_JLjava_util_concurrent_TimeUnit_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='throttleLatest' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='boolean']]"
		[Register ("throttleLatest", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ThrottleLatest (long timeout, global::Java.Util.Concurrent.TimeUnit unit, bool emitLast)
		{
			if (id_throttleLatest_JLjava_util_concurrent_TimeUnit_Z == IntPtr.Zero)
				id_throttleLatest_JLjava_util_concurrent_TimeUnit_Z = JNIEnv.GetMethodID (class_ref, "throttleLatest", "(JLjava/util/concurrent/TimeUnit;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (emitLast);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_throttleLatest_JLjava_util_concurrent_TimeUnit_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throttleLatest_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='throttleLatest' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("throttleLatest", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ThrottleLatest (long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_throttleLatest_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_throttleLatest_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "throttleLatest", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_throttleLatest_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throttleLatest_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='throttleLatest' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='boolean']]"
		[Register ("throttleLatest", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ThrottleLatest (long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, bool emitLast)
		{
			if (id_throttleLatest_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z == IntPtr.Zero)
				id_throttleLatest_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z = JNIEnv.GetMethodID (class_ref, "throttleLatest", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (emitLast);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_throttleLatest_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throttleWithTimeout_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='throttleWithTimeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("throttleWithTimeout", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ThrottleWithTimeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_throttleWithTimeout_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_throttleWithTimeout_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "throttleWithTimeout", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_throttleWithTimeout_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throttleWithTimeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='throttleWithTimeout' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("throttleWithTimeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable ThrottleWithTimeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_throttleWithTimeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_throttleWithTimeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "throttleWithTimeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_throttleWithTimeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeInterval;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeInterval' and count(parameter)=0]"
		[Register ("timeInterval", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TimeInterval ()
		{
			if (id_timeInterval == IntPtr.Zero)
				id_timeInterval = JNIEnv.GetMethodID (class_ref, "timeInterval", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeInterval), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_timeInterval_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeInterval' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("timeInterval", "(Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TimeInterval (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timeInterval_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timeInterval_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "timeInterval", "(Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeInterval_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeInterval_Ljava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeInterval' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timeInterval", "(Ljava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TimeInterval (global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_timeInterval_Ljava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timeInterval_Ljava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "timeInterval", "(Ljava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeInterval_Ljava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeInterval_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeInterval' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.TimeUnit'] and parameter[2][@type='io.reactivex.Scheduler']]"
		[Register ("timeInterval", "(Ljava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable TimeInterval (global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timeInterval_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timeInterval_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "timeInterval", "(Ljava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (unit);
				__args [1] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeInterval_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeout' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;V&gt;&gt;']]"
		[Register ("timeout", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public unsafe global::IO.Reactivex.Observable Timeout (global::IO.Reactivex.Functions.IFunction itemTimeoutIndicator)
		{
			if (id_timeout_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_timeout_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "timeout", "(Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (itemTimeoutIndicator);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_Lio_reactivex_functions_Function_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeout' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;V&gt;&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("timeout", "(Lio/reactivex/functions/Function;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public unsafe global::IO.Reactivex.Observable Timeout (global::IO.Reactivex.Functions.IFunction itemTimeoutIndicator, global::IO.Reactivex.IObservableSource other)
		{
			if (id_timeout_Lio_reactivex_functions_Function_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_timeout_Lio_reactivex_functions_Function_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(Lio/reactivex/functions/Function;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (itemTimeoutIndicator);
				__args [1] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_Lio_reactivex_functions_Function_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeout' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;U&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;V&gt;&gt;']]"
		[Register ("timeout", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "V"})]
		public unsafe global::IO.Reactivex.Observable Timeout (global::IO.Reactivex.IObservableSource firstTimeoutIndicator, global::IO.Reactivex.Functions.IFunction itemTimeoutIndicator)
		{
			if (id_timeout_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_timeout_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "timeout", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (firstTimeoutIndicator);
				__args [1] = new JValue (itemTimeoutIndicator);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeout' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;U&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;V&gt;&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("timeout", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "V"})]
		public unsafe global::IO.Reactivex.Observable Timeout (global::IO.Reactivex.IObservableSource firstTimeoutIndicator, global::IO.Reactivex.Functions.IFunction itemTimeoutIndicator, global::IO.Reactivex.IObservableSource other)
		{
			if (id_timeout_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_timeout_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (firstTimeoutIndicator);
				__args [1] = new JValue (itemTimeoutIndicator);
				__args [2] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit timeUnit)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (timeUnit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeout' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit timeUnit, global::IO.Reactivex.IObservableSource other)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (timeUnit);
				__args [2] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeout' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit timeUnit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (timeUnit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timeout' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Timeout (long timeout, global::Java.Util.Concurrent.TimeUnit timeUnit, global::IO.Reactivex.Scheduler scheduler, global::IO.Reactivex.IObservableSource other)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (timeUnit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (other);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timer_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timer", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public static unsafe global::IO.Reactivex.Observable Timer (long delay, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_timer_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timer_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "timer", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_timer_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timer' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("timer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public static unsafe global::IO.Reactivex.Observable Timer (long delay, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "timer", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (delay);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_timer_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timestamp;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timestamp' and count(parameter)=0]"
		[Register ("timestamp", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Timestamp ()
		{
			if (id_timestamp == IntPtr.Zero)
				id_timestamp = JNIEnv.GetMethodID (class_ref, "timestamp", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timestamp), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_timestamp_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timestamp' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("timestamp", "(Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Timestamp (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timestamp_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timestamp_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "timestamp", "(Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timestamp_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timestamp_Ljava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timestamp' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timestamp", "(Ljava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Timestamp (global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_timestamp_Ljava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timestamp_Ljava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "timestamp", "(Ljava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timestamp_Ljava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timestamp_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='timestamp' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.TimeUnit'] and parameter[2][@type='io.reactivex.Scheduler']]"
		[Register ("timestamp", "(Ljava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Timestamp (global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timestamp_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timestamp_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "timestamp", "(Ljava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (unit);
				__args [1] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timestamp_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_to_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='to' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super io.reactivex.Observable&lt;T&gt;, R&gt;']]"
		[Register ("to", "(Lio/reactivex/functions/Function;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
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

		static IntPtr id_toFuture;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toFuture' and count(parameter)=0]"
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

		static IntPtr id_toList;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toList' and count(parameter)=0]"
		[Register ("toList", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single ToList ()
		{
			if (id_toList == IntPtr.Zero)
				id_toList = JNIEnv.GetMethodID (class_ref, "toList", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toList), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toList", "(I)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single ToList (int capacityHint)
		{
			if (id_toList_I == IntPtr.Zero)
				id_toList_I = JNIEnv.GetMethodID (class_ref, "toList", "(I)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (capacityHint);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toList_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toList_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toList' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;U&gt;']]"
		[Register ("toList", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U extends java.util.Collection<? super T>"})]
		public unsafe global::IO.Reactivex.Single ToList (global::Java.Util.Concurrent.ICallable collectionSupplier)
		{
			if (id_toList_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_toList_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "toList", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (collectionSupplier);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toList_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMap_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toMap' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;']]"
		[Register ("toMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public unsafe global::IO.Reactivex.Single ToMap (global::IO.Reactivex.Functions.IFunction keySelector)
		{
			if (id_toMap_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_toMap_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "toMap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (keySelector);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toMap_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toMap' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;']]"
		[Register ("toMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public unsafe global::IO.Reactivex.Single ToMap (global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector)
		{
			if (id_toMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_toMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "toMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (valueSelector);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toMap' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;'] and parameter[3][@type='java.util.concurrent.Callable&lt;? extends java.util.Map&lt;K, V&gt;&gt;']]"
		[Register ("toMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public unsafe global::IO.Reactivex.Single ToMap (global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector, global::Java.Util.Concurrent.ICallable mapSupplier)
		{
			if (id_toMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_toMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "toMap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (valueSelector);
				__args [2] = new JValue (mapSupplier);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toMap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMultimap_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toMultimap' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;']]"
		[Register ("toMultimap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public unsafe global::IO.Reactivex.Single ToMultimap (global::IO.Reactivex.Functions.IFunction keySelector)
		{
			if (id_toMultimap_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_toMultimap_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "toMultimap", "(Lio/reactivex/functions/Function;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (keySelector);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toMultimap_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toMultimap' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;']]"
		[Register ("toMultimap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public unsafe global::IO.Reactivex.Single ToMultimap (global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector)
		{
			if (id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "toMultimap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (valueSelector);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toMultimap' and count(parameter)=4 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;'] and parameter[3][@type='java.util.concurrent.Callable&lt;? extends java.util.Map&lt;K, java.util.Collection&lt;V&gt;&gt;&gt;'] and parameter[4][@type='io.reactivex.functions.Function&lt;? super K, ? extends java.util.Collection&lt;? super V&gt;&gt;']]"
		[Register ("toMultimap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public unsafe global::IO.Reactivex.Single ToMultimap (global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector, global::Java.Util.Concurrent.ICallable mapSupplier, global::IO.Reactivex.Functions.IFunction collectionFactory)
		{
			if (id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "toMultimap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (valueSelector);
				__args [2] = new JValue (mapSupplier);
				__args [3] = new JValue (collectionFactory);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toMultimap' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;'] and parameter[3][@type='java.util.concurrent.Callable&lt;java.util.Map&lt;K, java.util.Collection&lt;V&gt;&gt;&gt;']]"
		[Register ("toMultimap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Single;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public unsafe global::IO.Reactivex.Single ToMultimap (global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector, global::Java.Util.Concurrent.ICallable mapSupplier)
		{
			if (id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "toMultimap", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Ljava/util/concurrent/Callable;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (valueSelector);
				__args [2] = new JValue (mapSupplier);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toMultimap_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toSortedList;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toSortedList' and count(parameter)=0]"
		[Register ("toSortedList", "()Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single ToSortedList ()
		{
			if (id_toSortedList == IntPtr.Zero)
				id_toSortedList = JNIEnv.GetMethodID (class_ref, "toSortedList", "()Lio/reactivex/Single;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toSortedList), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toSortedList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toSortedList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toSortedList", "(I)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single ToSortedList (int capacityHint)
		{
			if (id_toSortedList_I == IntPtr.Zero)
				id_toSortedList_I = JNIEnv.GetMethodID (class_ref, "toSortedList", "(I)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (capacityHint);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toSortedList_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toSortedList_Ljava_util_Comparator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toSortedList' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("toSortedList", "(Ljava/util/Comparator;)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single ToSortedList (global::Java.Util.IComparator comparator)
		{
			if (id_toSortedList_Ljava_util_Comparator_ == IntPtr.Zero)
				id_toSortedList_Ljava_util_Comparator_ = JNIEnv.GetMethodID (class_ref, "toSortedList", "(Ljava/util/Comparator;)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (comparator);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toSortedList_Ljava_util_Comparator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toSortedList_Ljava_util_Comparator_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='toSortedList' and count(parameter)=2 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;'] and parameter[2][@type='int']]"
		[Register ("toSortedList", "(Ljava/util/Comparator;I)Lio/reactivex/Single;", "")]
		public unsafe global::IO.Reactivex.Single ToSortedList (global::Java.Util.IComparator comparator, int capacityHint)
		{
			if (id_toSortedList_Ljava_util_Comparator_I == IntPtr.Zero)
				id_toSortedList_Ljava_util_Comparator_I = JNIEnv.GetMethodID (class_ref, "toSortedList", "(Ljava/util/Comparator;I)Lio/reactivex/Single;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (comparator);
				__args [1] = new JValue (capacityHint);
				global::IO.Reactivex.Single __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Single> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toSortedList_Ljava_util_Comparator_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_unsafeCreate_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='unsafeCreate' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;']]"
		[Register ("unsafeCreate", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable UnsafeCreate (global::IO.Reactivex.IObservableSource onSubscribe)
		{
			if (id_unsafeCreate_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_unsafeCreate_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "unsafeCreate", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSubscribe);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_unsafeCreate_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_unsubscribeOn_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='unsubscribeOn' and count(parameter)=1 and parameter[1][@type='io.reactivex.Scheduler']]"
		[Register ("unsubscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable UnsubscribeOn (global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_unsubscribeOn_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_unsubscribeOn_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "unsubscribeOn", "(Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribeOn_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='using' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends D&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super D, ? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super D&gt;']]"
		[Register ("using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "D"})]
		public static unsafe global::IO.Reactivex.Observable Using (global::Java.Util.Concurrent.ICallable resourceSupplier, global::IO.Reactivex.Functions.IFunction sourceSupplier, global::IO.Reactivex.Functions.IConsumer disposer)
		{
			if (id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (resourceSupplier);
				__args [1] = new JValue (sourceSupplier);
				__args [2] = new JValue (disposer);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='using' and count(parameter)=4 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends D&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super D, ? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super D&gt;'] and parameter[4][@type='boolean']]"
		[Register ("using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "D"})]
		public static unsafe global::IO.Reactivex.Observable Using (global::Java.Util.Concurrent.ICallable resourceSupplier, global::IO.Reactivex.Functions.IFunction sourceSupplier, global::IO.Reactivex.Functions.IConsumer disposer, bool eager)
		{
			if (id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z == IntPtr.Zero)
				id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z = JNIEnv.GetStaticMethodID (class_ref, "using", "(Ljava/util/concurrent/Callable;Lio/reactivex/functions/Function;Lio/reactivex/functions/Consumer;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (resourceSupplier);
				__args [1] = new JValue (sourceSupplier);
				__args [2] = new JValue (disposer);
				__args [3] = new JValue (eager);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_using_Ljava_util_concurrent_Callable_Lio_reactivex_functions_Function_Lio_reactivex_functions_Consumer_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;B&gt;']]"
		[Register ("window", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B"})]
		public unsafe global::IO.Reactivex.Observable Window (global::IO.Reactivex.IObservableSource boundary)
		{
			if (id_window_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_window_Lio_reactivex_ObservableSource_ = JNIEnv.GetMethodID (class_ref, "window", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (boundary);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_Lio_reactivex_ObservableSource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;B&gt;'] and parameter[2][@type='int']]"
		[Register ("window", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B"})]
		public unsafe global::IO.Reactivex.Observable Window (global::IO.Reactivex.IObservableSource boundary, int bufferSize)
		{
			if (id_window_Lio_reactivex_ObservableSource_I == IntPtr.Zero)
				id_window_Lio_reactivex_ObservableSource_I = JNIEnv.GetMethodID (class_ref, "window", "(Lio/reactivex/ObservableSource;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (boundary);
				__args [1] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_Lio_reactivex_ObservableSource_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;U&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super U, ? extends io.reactivex.ObservableSource&lt;V&gt;&gt;']]"
		[Register ("window", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "V"})]
		public unsafe global::IO.Reactivex.Observable Window (global::IO.Reactivex.IObservableSource openingIndicator, global::IO.Reactivex.Functions.IFunction closingIndicator)
		{
			if (id_window_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_window_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "window", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (openingIndicator);
				__args [1] = new JValue (closingIndicator);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;U&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super U, ? extends io.reactivex.ObservableSource&lt;V&gt;&gt;'] and parameter[3][@type='int']]"
		[Register ("window", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "V"})]
		public unsafe global::IO.Reactivex.Observable Window (global::IO.Reactivex.IObservableSource openingIndicator, global::IO.Reactivex.Functions.IFunction closingIndicator, int bufferSize)
		{
			if (id_window_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I == IntPtr.Zero)
				id_window_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I = JNIEnv.GetMethodID (class_ref, "window", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (openingIndicator);
				__args [1] = new JValue (closingIndicator);
				__args [2] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.ObservableSource&lt;B&gt;&gt;']]"
		[Register ("window", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B"})]
		public unsafe global::IO.Reactivex.Observable Window (global::Java.Util.Concurrent.ICallable boundary)
		{
			if (id_window_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_window_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "window", "(Ljava/util/concurrent/Callable;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (boundary);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_Ljava_util_concurrent_Callable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;? extends io.reactivex.ObservableSource&lt;B&gt;&gt;'] and parameter[2][@type='int']]"
		[Register ("window", "(Ljava/util/concurrent/Callable;I)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"B"})]
		public unsafe global::IO.Reactivex.Observable Window (global::Java.Util.Concurrent.ICallable boundary, int bufferSize)
		{
			if (id_window_Ljava_util_concurrent_Callable_I == IntPtr.Zero)
				id_window_Ljava_util_concurrent_Callable_I = JNIEnv.GetMethodID (class_ref, "window", "(Ljava/util/concurrent/Callable;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (boundary);
				__args [1] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_Ljava_util_concurrent_Callable_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("window", "(J)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long count)
		{
			if (id_window_J == IntPtr.Zero)
				id_window_J = JNIEnv.GetMethodID (class_ref, "window", "(J)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_window_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("window", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long timespan, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_window_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_window_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "window", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler']]"
		[Register ("window", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long timespan, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "window", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='long']]"
		[Register ("window", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;J)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long timespan, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, long count)
		{
			if (id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_J == IntPtr.Zero)
				id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_J = JNIEnv.GetMethodID (class_ref, "window", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;J)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (count);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='long'] and parameter[5][@type='boolean']]"
		[Register ("window", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;JZ)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long timespan, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, long count, bool restart)
		{
			if (id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_JZ == IntPtr.Zero)
				id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_JZ = JNIEnv.GetMethodID (class_ref, "window", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;JZ)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (count);
				__args [4] = new JValue (restart);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_JZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_JZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='io.reactivex.Scheduler'] and parameter[4][@type='long'] and parameter[5][@type='boolean'] and parameter[6][@type='int']]"
		[Register ("window", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;JZI)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long timespan, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, long count, bool restart, int bufferSize)
		{
			if (id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_JZI == IntPtr.Zero)
				id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_JZI = JNIEnv.GetMethodID (class_ref, "window", "(JLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;JZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (scheduler);
				__args [3] = new JValue (count);
				__args [4] = new JValue (restart);
				__args [5] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_JZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_JLjava_util_concurrent_TimeUnit_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='long']]"
		[Register ("window", "(JLjava/util/concurrent/TimeUnit;J)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long timespan, global::Java.Util.Concurrent.TimeUnit unit, long count)
		{
			if (id_window_JLjava_util_concurrent_TimeUnit_J == IntPtr.Zero)
				id_window_JLjava_util_concurrent_TimeUnit_J = JNIEnv.GetMethodID (class_ref, "window", "(JLjava/util/concurrent/TimeUnit;J)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (count);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JLjava_util_concurrent_TimeUnit_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_JLjava_util_concurrent_TimeUnit_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='long'] and parameter[4][@type='boolean']]"
		[Register ("window", "(JLjava/util/concurrent/TimeUnit;JZ)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long timespan, global::Java.Util.Concurrent.TimeUnit unit, long count, bool restart)
		{
			if (id_window_JLjava_util_concurrent_TimeUnit_JZ == IntPtr.Zero)
				id_window_JLjava_util_concurrent_TimeUnit_JZ = JNIEnv.GetMethodID (class_ref, "window", "(JLjava/util/concurrent/TimeUnit;JZ)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (unit);
				__args [2] = new JValue (count);
				__args [3] = new JValue (restart);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JLjava_util_concurrent_TimeUnit_JZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("window", "(JJ)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long count, long skip)
		{
			if (id_window_JJ == IntPtr.Zero)
				id_window_JJ = JNIEnv.GetMethodID (class_ref, "window", "(JJ)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (count);
				__args [1] = new JValue (skip);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JJ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_window_JJI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("window", "(JJI)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long count, long skip, int bufferSize)
		{
			if (id_window_JJI == IntPtr.Zero)
				id_window_JJI = JNIEnv.GetMethodID (class_ref, "window", "(JJI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (count);
				__args [1] = new JValue (skip);
				__args [2] = new JValue (bufferSize);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JJI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_window_JJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("window", "(JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long timespan, long timeskip, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_window_JJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_window_JJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "window", "(JJLjava/util/concurrent/TimeUnit;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (timeskip);
				__args [2] = new JValue (unit);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler']]"
		[Register ("window", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long timespan, long timeskip, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_window_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_window_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetMethodID (class_ref, "window", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (timeskip);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_window_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='window' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='io.reactivex.Scheduler'] and parameter[5][@type='int']]"
		[Register ("window", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;I)Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable Window (long timespan, long timeskip, global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler, int bufferSize)
		{
			if (id_window_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I == IntPtr.Zero)
				id_window_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I = JNIEnv.GetMethodID (class_ref, "window", "(JJLjava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;I)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (timespan);
				__args [1] = new JValue (timeskip);
				__args [2] = new JValue (unit);
				__args [3] = new JValue (scheduler);
				__args [4] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_window_JJLjava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='withLatestFrom' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends U&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;']]"
		[Register ("withLatestFrom", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Observable WithLatestFrom (global::IO.Reactivex.IObservableSource other, global::IO.Reactivex.Functions.IBiFunction combiner)
		{
			if (id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "withLatestFrom", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (other);
				__args [1] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_withLatestFrom_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='withLatestFrom' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;?&gt;[]'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], R&gt;']]"
		[Register ("withLatestFrom", "([Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable WithLatestFrom (global::IO.Reactivex.IObservableSource[] others, global::IO.Reactivex.Functions.IFunction combiner)
		{
			if (id_withLatestFrom_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_withLatestFrom_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "withLatestFrom", "([Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			IntPtr native_others = JNIEnv.NewArray (others);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_others);
				__args [1] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withLatestFrom_arrayLio_reactivex_ObservableSource_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (others != null) {
					JNIEnv.CopyArray (native_others, others);
					JNIEnv.DeleteLocalRef (native_others);
				}
			}
		}

		static IntPtr id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='withLatestFrom' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;T2&gt;'] and parameter[3][@type='io.reactivex.functions.Function3&lt;? super T, ? super T1, ? super T2, R&gt;']]"
		[Register ("withLatestFrom", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function3;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "R"})]
		public unsafe global::IO.Reactivex.Observable WithLatestFrom (global::IO.Reactivex.IObservableSource o1, global::IO.Reactivex.IObservableSource o2, global::IO.Reactivex.Functions.IFunction3 combiner)
		{
			if (id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_ == IntPtr.Zero)
				id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_ = JNIEnv.GetMethodID (class_ref, "withLatestFrom", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function3;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (o1);
				__args [1] = new JValue (o2);
				__args [2] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='withLatestFrom' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;T3&gt;'] and parameter[4][@type='io.reactivex.functions.Function4&lt;? super T, ? super T1, ? super T2, ? super T3, R&gt;']]"
		[Register ("withLatestFrom", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function4;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "R"})]
		public unsafe global::IO.Reactivex.Observable WithLatestFrom (global::IO.Reactivex.IObservableSource o1, global::IO.Reactivex.IObservableSource o2, global::IO.Reactivex.IObservableSource o3, global::IO.Reactivex.Functions.IFunction4 combiner)
		{
			if (id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_ == IntPtr.Zero)
				id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_ = JNIEnv.GetMethodID (class_ref, "withLatestFrom", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function4;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (o1);
				__args [1] = new JValue (o2);
				__args [2] = new JValue (o3);
				__args [3] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='withLatestFrom' and count(parameter)=5 and parameter[1][@type='io.reactivex.ObservableSource&lt;T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;T4&gt;'] and parameter[5][@type='io.reactivex.functions.Function5&lt;? super T, ? super T1, ? super T2, ? super T3, ? super T4, R&gt;']]"
		[Register ("withLatestFrom", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function5;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "R"})]
		public unsafe global::IO.Reactivex.Observable WithLatestFrom (global::IO.Reactivex.IObservableSource o1, global::IO.Reactivex.IObservableSource o2, global::IO.Reactivex.IObservableSource o3, global::IO.Reactivex.IObservableSource o4, global::IO.Reactivex.Functions.IFunction5 combiner)
		{
			if (id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_ == IntPtr.Zero)
				id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_ = JNIEnv.GetMethodID (class_ref, "withLatestFrom", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function5;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (o1);
				__args [1] = new JValue (o2);
				__args [2] = new JValue (o3);
				__args [3] = new JValue (o4);
				__args [4] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withLatestFrom_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_withLatestFrom_Ljava_lang_Iterable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='withLatestFrom' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;?&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], R&gt;']]"
		[Register ("withLatestFrom", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::IO.Reactivex.Observable WithLatestFrom (global::Java.Lang.IIterable others, global::IO.Reactivex.Functions.IFunction combiner)
		{
			if (id_withLatestFrom_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_withLatestFrom_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "withLatestFrom", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (others);
				__args [1] = new JValue (combiner);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withLatestFrom_Ljava_lang_Iterable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_wrap_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;']]"
		[Register ("wrap", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observable Wrap (global::IO.Reactivex.IObservableSource source)
		{
			if (id_wrap_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_wrap_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::IO.Reactivex.IObservableSource sources, global::IO.Reactivex.Functions.IFunction zipper)
		{
			if (id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (zipper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.functions.BiFunction&lt;? super T1, ? super T2, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.Functions.IBiFunction zipper)
		{
			if (id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (zipper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.functions.BiFunction&lt;? super T1, ? super T2, ? extends R&gt;'] and parameter[4][@type='boolean']]"
		[Register ("zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.Functions.IBiFunction zipper, bool delayError)
		{
			if (id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_Z == IntPtr.Zero)
				id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_Z = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (zipper);
				__args [3] = new JValue (delayError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=5 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.functions.BiFunction&lt;? super T1, ? super T2, ? extends R&gt;'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
		[Register ("zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;ZI)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.Functions.IBiFunction zipper, bool delayError, int bufferSize)
		{
			if (id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ZI == IntPtr.Zero)
				id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ZI = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (zipper);
				__args [3] = new JValue (delayError);
				__args [4] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.functions.Function3&lt;? super T1, ? super T2, ? super T3, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function3;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.Functions.IFunction3 zipper)
		{
			if (id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_ == IntPtr.Zero)
				id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function3;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (zipper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function3_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=5 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.functions.Function4&lt;? super T1, ? super T2, ? super T3, ? super T4, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function4;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.Functions.IFunction4 zipper)
		{
			if (id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_ == IntPtr.Zero)
				id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function4;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (zipper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function4_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=6 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.ObservableSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.functions.Function5&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function5;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.IObservableSource source5, global::IO.Reactivex.Functions.IFunction5 zipper)
		{
			if (id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_ == IntPtr.Zero)
				id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function5;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (zipper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function5_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function6_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=7 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.ObservableSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.ObservableSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.functions.Function6&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function6;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.IObservableSource source5, global::IO.Reactivex.IObservableSource source6, global::IO.Reactivex.Functions.IFunction6 zipper)
		{
			if (id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function6_ == IntPtr.Zero)
				id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function6_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function6;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (source3);
				__args [3] = new JValue (source4);
				__args [4] = new JValue (source5);
				__args [5] = new JValue (source6);
				__args [6] = new JValue (zipper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function6_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function7_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=8 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.ObservableSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.ObservableSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.ObservableSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.functions.Function7&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function7;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.IObservableSource source5, global::IO.Reactivex.IObservableSource source6, global::IO.Reactivex.IObservableSource source7, global::IO.Reactivex.Functions.IFunction7 zipper)
		{
			if (id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function7_ == IntPtr.Zero)
				id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function7_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function7;)Lio/reactivex/Observable;");
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
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function7_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function8_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=9 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.ObservableSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.ObservableSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.ObservableSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.ObservableSource&lt;? extends T8&gt;'] and parameter[9][@type='io.reactivex.functions.Function8&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function8;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.IObservableSource source5, global::IO.Reactivex.IObservableSource source6, global::IO.Reactivex.IObservableSource source7, global::IO.Reactivex.IObservableSource source8, global::IO.Reactivex.Functions.IFunction8 zipper)
		{
			if (id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function8_ == IntPtr.Zero)
				id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function8_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function8;)Lio/reactivex/Observable;");
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
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function8_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function9_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=10 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T1&gt;'] and parameter[2][@type='io.reactivex.ObservableSource&lt;? extends T2&gt;'] and parameter[3][@type='io.reactivex.ObservableSource&lt;? extends T3&gt;'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T4&gt;'] and parameter[5][@type='io.reactivex.ObservableSource&lt;? extends T5&gt;'] and parameter[6][@type='io.reactivex.ObservableSource&lt;? extends T6&gt;'] and parameter[7][@type='io.reactivex.ObservableSource&lt;? extends T7&gt;'] and parameter[8][@type='io.reactivex.ObservableSource&lt;? extends T8&gt;'] and parameter[9][@type='io.reactivex.ObservableSource&lt;? extends T9&gt;'] and parameter[10][@type='io.reactivex.functions.Function9&lt;? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? super T9, ? extends R&gt;']]"
		[Register ("zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function9;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::IO.Reactivex.IObservableSource source1, global::IO.Reactivex.IObservableSource source2, global::IO.Reactivex.IObservableSource source3, global::IO.Reactivex.IObservableSource source4, global::IO.Reactivex.IObservableSource source5, global::IO.Reactivex.IObservableSource source6, global::IO.Reactivex.IObservableSource source7, global::IO.Reactivex.IObservableSource source8, global::IO.Reactivex.IObservableSource source9, global::IO.Reactivex.Functions.IFunction9 zipper)
		{
			if (id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function9_ == IntPtr.Zero)
				id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function9_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function9;)Lio/reactivex/Observable;");
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
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function9_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zip' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;']]"
		[Register ("zip", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable Zip (global::Java.Lang.IIterable sources, global::IO.Reactivex.Functions.IFunction zipper)
		{
			if (id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "zip", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (zipper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zip_Ljava_lang_Iterable_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zipArray_Lio_reactivex_functions_Function_ZIarrayLio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zipArray' and count(parameter)=4 and parameter[1][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='io.reactivex.ObservableSource&lt;? extends T&gt;...']]"
		[Register ("zipArray", "(Lio/reactivex/functions/Function;ZI[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable ZipArray (global::IO.Reactivex.Functions.IFunction zipper, bool delayError, int bufferSize, params global::IO.Reactivex.IObservableSource[] sources)
		{
			if (id_zipArray_Lio_reactivex_functions_Function_ZIarrayLio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_zipArray_Lio_reactivex_functions_Function_ZIarrayLio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "zipArray", "(Lio/reactivex/functions/Function;ZI[Lio/reactivex/ObservableSource;)Lio/reactivex/Observable;");
			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (zipper);
				__args [1] = new JValue (delayError);
				__args [2] = new JValue (bufferSize);
				__args [3] = new JValue (native_sources);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zipArray_Lio_reactivex_functions_Function_ZIarrayLio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_zipIterable_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zipIterable' and count(parameter)=4 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("zipIterable", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;ZI)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::IO.Reactivex.Observable ZipIterable (global::Java.Lang.IIterable sources, global::IO.Reactivex.Functions.IFunction zipper, bool delayError, int bufferSize)
		{
			if (id_zipIterable_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ZI == IntPtr.Zero)
				id_zipIterable_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ZI = JNIEnv.GetStaticMethodID (class_ref, "zipIterable", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (zipper);
				__args [2] = new JValue (delayError);
				__args [3] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zipIterable_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zipWith' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends U&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;']]"
		[Register ("zipWith", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Observable ZipWith (global::IO.Reactivex.IObservableSource other, global::IO.Reactivex.Functions.IBiFunction zipper)
		{
			if (id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "zipWith", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (other);
				__args [1] = new JValue (zipper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zipWith' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends U&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;'] and parameter[3][@type='boolean']]"
		[Register ("zipWith", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;Z)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Observable ZipWith (global::IO.Reactivex.IObservableSource other, global::IO.Reactivex.Functions.IBiFunction zipper, bool delayError)
		{
			if (id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_Z == IntPtr.Zero)
				id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_Z = JNIEnv.GetMethodID (class_ref, "zipWith", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;Z)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (other);
				__args [1] = new JValue (zipper);
				__args [2] = new JValue (delayError);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zipWith' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends U&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("zipWith", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;ZI)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Observable ZipWith (global::IO.Reactivex.IObservableSource other, global::IO.Reactivex.Functions.IBiFunction zipper, bool delayError, int bufferSize)
		{
			if (id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ZI == IntPtr.Zero)
				id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ZI = JNIEnv.GetMethodID (class_ref, "zipWith", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/BiFunction;ZI)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (other);
				__args [1] = new JValue (zipper);
				__args [2] = new JValue (delayError);
				__args [3] = new JValue (bufferSize);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zipWith_Lio_reactivex_ObservableSource_Lio_reactivex_functions_BiFunction_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zipWith_Ljava_lang_Iterable_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='zipWith' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;U&gt;'] and parameter[2][@type='io.reactivex.functions.BiFunction&lt;? super T, ? super U, ? extends R&gt;']]"
		[Register ("zipWith", "(Ljava/lang/Iterable;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "R"})]
		public unsafe global::IO.Reactivex.Observable ZipWith (global::Java.Lang.IIterable other, global::IO.Reactivex.Functions.IBiFunction zipper)
		{
			if (id_zipWith_Ljava_lang_Iterable_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_zipWith_Ljava_lang_Iterable_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "zipWith", "(Ljava/lang/Iterable;Lio/reactivex/functions/BiFunction;)Lio/reactivex/Observable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (other);
				__args [1] = new JValue (zipper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zipWith_Ljava_lang_Iterable_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/Observable", DoNotGenerateAcw=true)]
	internal partial class ObservableInvoker : Observable, global::IO.Reactivex.IObservableSource {

		public ObservableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableInvoker); }
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Observable']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/Observer;)V", "GetSubscribeActual_Lio_reactivex_Observer_Handler")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IObserver p0)
		{
			if (id_subscribeActual_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

	}

}
