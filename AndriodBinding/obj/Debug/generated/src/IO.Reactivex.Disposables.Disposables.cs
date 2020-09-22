using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Disposables {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='Disposables']"
	[global::Android.Runtime.Register ("io/reactivex/disposables/Disposables", DoNotGenerateAcw=true)]
	public sealed partial class Disposables : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/disposables/Disposables", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Disposables); }
		}

		internal Disposables (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_disposed;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='Disposables']/method[@name='disposed' and count(parameter)=0]"
		[Register ("disposed", "()Lio/reactivex/disposables/Disposable;", "")]
		public static unsafe global::IO.Reactivex.Disposables.IDisposable Disposed ()
		{
			if (id_disposed == IntPtr.Zero)
				id_disposed = JNIEnv.GetStaticMethodID (class_ref, "disposed", "()Lio/reactivex/disposables/Disposable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_disposed), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_empty;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='Disposables']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lio/reactivex/disposables/Disposable;", "")]
		public static unsafe global::IO.Reactivex.Disposables.IDisposable Empty ()
		{
			if (id_empty == IntPtr.Zero)
				id_empty = JNIEnv.GetStaticMethodID (class_ref, "empty", "()Lio/reactivex/disposables/Disposable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_empty), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fromAction_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='Disposables']/method[@name='fromAction' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("fromAction", "(Lio/reactivex/functions/Action;)Lio/reactivex/disposables/Disposable;", "")]
		public static unsafe global::IO.Reactivex.Disposables.IDisposable FromAction (global::IO.Reactivex.Functions.IAction run)
		{
			if (id_fromAction_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_fromAction_Lio_reactivex_functions_Action_ = JNIEnv.GetStaticMethodID (class_ref, "fromAction", "(Lio/reactivex/functions/Action;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (run);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAction_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='Disposables']/method[@name='fromFuture' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Future&lt;?&gt;']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;)Lio/reactivex/disposables/Disposable;", "")]
		public static unsafe global::IO.Reactivex.Disposables.IDisposable FromFuture (global::Java.Util.Concurrent.IFuture future)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_ == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_ = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (future);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFuture_Ljava_util_concurrent_Future_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='Disposables']/method[@name='fromFuture' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Future&lt;?&gt;'] and parameter[2][@type='boolean']]"
		[Register ("fromFuture", "(Ljava/util/concurrent/Future;Z)Lio/reactivex/disposables/Disposable;", "")]
		public static unsafe global::IO.Reactivex.Disposables.IDisposable FromFuture (global::Java.Util.Concurrent.IFuture future, bool allowInterrupt)
		{
			if (id_fromFuture_Ljava_util_concurrent_Future_Z == IntPtr.Zero)
				id_fromFuture_Ljava_util_concurrent_Future_Z = JNIEnv.GetStaticMethodID (class_ref, "fromFuture", "(Ljava/util/concurrent/Future;Z)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (future);
				__args [1] = new JValue (allowInterrupt);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFuture_Ljava_util_concurrent_Future_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/class[@name='Disposables']/method[@name='fromRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("fromRunnable", "(Ljava/lang/Runnable;)Lio/reactivex/disposables/Disposable;", "")]
		public static unsafe global::IO.Reactivex.Disposables.IDisposable FromRunnable (global::Java.Lang.IRunnable run)
		{
			if (id_fromRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_fromRunnable_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "fromRunnable", "(Ljava/lang/Runnable;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (run);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromRunnable_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
