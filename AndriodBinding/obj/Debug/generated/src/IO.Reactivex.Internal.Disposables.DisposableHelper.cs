using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Disposables {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']"
	[global::Android.Runtime.Register ("io/reactivex/internal/disposables/DisposableHelper", DoNotGenerateAcw=true)]
	public sealed partial class DisposableHelper : global::Java.Lang.Enum, global::IO.Reactivex.Disposables.IDisposable {


		static IntPtr DISPOSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/field[@name='DISPOSED']"
		[Register ("DISPOSED")]
		public static global::IO.Reactivex.Internal.Disposables.DisposableHelper Disposed {
			get {
				if (DISPOSED_jfieldId == IntPtr.Zero)
					DISPOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISPOSED", "Lio/reactivex/internal/disposables/DisposableHelper;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISPOSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Disposables.DisposableHelper> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/disposables/DisposableHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DisposableHelper); }
		}

		internal DisposableHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isDisposed;
		public unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='isDisposed' and count(parameter)=0]"
			[Register ("isDisposed", "()Z", "")]
			get {
				if (id_isDisposed == IntPtr.Zero)
					id_isDisposed = JNIEnv.GetMethodID (class_ref, "isDisposed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDisposed);
				} finally {
				}
			}
		}

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
			} finally {
			}
		}

		static IntPtr id_dispose_Ljava_util_concurrent_atomic_AtomicReference_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='dispose' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.atomic.AtomicReference&lt;io.reactivex.disposables.Disposable&gt;']]"
		[Register ("dispose", "(Ljava/util/concurrent/atomic/AtomicReference;)Z", "")]
		public static unsafe bool Dispose (global::Java.Util.Concurrent.Atomic.AtomicReference field)
		{
			if (id_dispose_Ljava_util_concurrent_atomic_AtomicReference_ == IntPtr.Zero)
				id_dispose_Ljava_util_concurrent_atomic_AtomicReference_ = JNIEnv.GetStaticMethodID (class_ref, "dispose", "(Ljava/util/concurrent/atomic/AtomicReference;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (field);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_dispose_Ljava_util_concurrent_atomic_AtomicReference_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isDisposed_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='isDisposed' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("isDisposed", "(Lio/reactivex/disposables/Disposable;)Z", "")]
		public static unsafe bool InvokeIsDisposed (global::IO.Reactivex.Disposables.IDisposable d)
		{
			if (id_isDisposed_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_isDisposed_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetStaticMethodID (class_ref, "isDisposed", "(Lio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (d);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDisposed_Lio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replace_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='replace' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.atomic.AtomicReference&lt;io.reactivex.disposables.Disposable&gt;'] and parameter[2][@type='io.reactivex.disposables.Disposable']]"
		[Register ("replace", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/disposables/Disposable;)Z", "")]
		public static unsafe bool Replace (global::Java.Util.Concurrent.Atomic.AtomicReference field, global::IO.Reactivex.Disposables.IDisposable d)
		{
			if (id_replace_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_replace_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetStaticMethodID (class_ref, "replace", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (field);
				__args [1] = new JValue (d);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_replace_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reportDisposableSet;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='reportDisposableSet' and count(parameter)=0]"
		[Register ("reportDisposableSet", "()V", "")]
		public static unsafe void ReportDisposableSet ()
		{
			if (id_reportDisposableSet == IntPtr.Zero)
				id_reportDisposableSet = JNIEnv.GetStaticMethodID (class_ref, "reportDisposableSet", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportDisposableSet);
			} finally {
			}
		}

		static IntPtr id_set_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.atomic.AtomicReference&lt;io.reactivex.disposables.Disposable&gt;'] and parameter[2][@type='io.reactivex.disposables.Disposable']]"
		[Register ("set", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/disposables/Disposable;)Z", "")]
		public static unsafe bool Set (global::Java.Util.Concurrent.Atomic.AtomicReference field, global::IO.Reactivex.Disposables.IDisposable d)
		{
			if (id_set_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_set_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetStaticMethodID (class_ref, "set", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (field);
				__args [1] = new JValue (d);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_set_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setOnce_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='setOnce' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.atomic.AtomicReference&lt;io.reactivex.disposables.Disposable&gt;'] and parameter[2][@type='io.reactivex.disposables.Disposable']]"
		[Register ("setOnce", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/disposables/Disposable;)Z", "")]
		public static unsafe bool SetOnce (global::Java.Util.Concurrent.Atomic.AtomicReference field, global::IO.Reactivex.Disposables.IDisposable d)
		{
			if (id_setOnce_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_setOnce_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetStaticMethodID (class_ref, "setOnce", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (field);
				__args [1] = new JValue (d);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_setOnce_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_trySet_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='trySet' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.atomic.AtomicReference&lt;io.reactivex.disposables.Disposable&gt;'] and parameter[2][@type='io.reactivex.disposables.Disposable']]"
		[Register ("trySet", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/disposables/Disposable;)Z", "")]
		public static unsafe bool TrySet (global::Java.Util.Concurrent.Atomic.AtomicReference field, global::IO.Reactivex.Disposables.IDisposable d)
		{
			if (id_trySet_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_trySet_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetStaticMethodID (class_ref, "trySet", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (field);
				__args [1] = new JValue (d);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_trySet_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_validate_Lio_reactivex_disposables_Disposable_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='validate' and count(parameter)=2 and parameter[1][@type='io.reactivex.disposables.Disposable'] and parameter[2][@type='io.reactivex.disposables.Disposable']]"
		[Register ("validate", "(Lio/reactivex/disposables/Disposable;Lio/reactivex/disposables/Disposable;)Z", "")]
		public static unsafe bool Validate (global::IO.Reactivex.Disposables.IDisposable current, global::IO.Reactivex.Disposables.IDisposable next)
		{
			if (id_validate_Lio_reactivex_disposables_Disposable_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_validate_Lio_reactivex_disposables_Disposable_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetStaticMethodID (class_ref, "validate", "(Lio/reactivex/disposables/Disposable;Lio/reactivex/disposables/Disposable;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (current);
				__args [1] = new JValue (next);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_validate_Lio_reactivex_disposables_Disposable_Lio_reactivex_disposables_Disposable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/disposables/DisposableHelper;", "")]
		public static unsafe global::IO.Reactivex.Internal.Disposables.DisposableHelper ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/disposables/DisposableHelper;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::IO.Reactivex.Internal.Disposables.DisposableHelper __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Disposables.DisposableHelper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='DisposableHelper']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/reactivex/internal/disposables/DisposableHelper;", "")]
		public static unsafe global::IO.Reactivex.Internal.Disposables.DisposableHelper[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/internal/disposables/DisposableHelper;");
			try {
				return (global::IO.Reactivex.Internal.Disposables.DisposableHelper[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.Internal.Disposables.DisposableHelper));
			} finally {
			}
		}

	}
}
