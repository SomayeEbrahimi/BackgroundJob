using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ExceptionHelper']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/ExceptionHelper", DoNotGenerateAcw=true)]
	public sealed partial class ExceptionHelper : global::Java.Lang.Object {


		static IntPtr TERMINATED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ExceptionHelper']/field[@name='TERMINATED']"
		[Register ("TERMINATED")]
		public static global::Java.Lang.Throwable Terminated {
			get {
				if (TERMINATED_jfieldId == IntPtr.Zero)
					TERMINATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TERMINATED", "Ljava/lang/Throwable;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TERMINATED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/ExceptionHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExceptionHelper); }
		}

		internal ExceptionHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_addThrowable_Ljava_util_concurrent_atomic_AtomicReference_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ExceptionHelper']/method[@name='addThrowable' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.atomic.AtomicReference&lt;java.lang.Throwable&gt;'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("addThrowable", "(Ljava/util/concurrent/atomic/AtomicReference;Ljava/lang/Throwable;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe bool AddThrowable (global::Java.Util.Concurrent.Atomic.AtomicReference field, global::Java.Lang.Throwable exception)
		{
			if (id_addThrowable_Ljava_util_concurrent_atomic_AtomicReference_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_addThrowable_Ljava_util_concurrent_atomic_AtomicReference_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "addThrowable", "(Ljava/util/concurrent/atomic/AtomicReference;Ljava/lang/Throwable;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (field);
				__args [1] = new JValue (exception);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_addThrowable_Ljava_util_concurrent_atomic_AtomicReference_Ljava_lang_Throwable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flatten_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ExceptionHelper']/method[@name='flatten' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("flatten", "(Ljava/lang/Throwable;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Throwable> Flatten (global::Java.Lang.Throwable t)
		{
			if (id_flatten_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_flatten_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "flatten", "(Ljava/lang/Throwable;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				global::System.Collections.Generic.IList<global::Java.Lang.Throwable> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Throwable>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_flatten_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_terminate_Ljava_util_concurrent_atomic_AtomicReference_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ExceptionHelper']/method[@name='terminate' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.atomic.AtomicReference&lt;java.lang.Throwable&gt;']]"
		[Register ("terminate", "(Ljava/util/concurrent/atomic/AtomicReference;)Ljava/lang/Throwable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Throwable Terminate (global::Java.Util.Concurrent.Atomic.AtomicReference field)
		{
			if (id_terminate_Ljava_util_concurrent_atomic_AtomicReference_ == IntPtr.Zero)
				id_terminate_Ljava_util_concurrent_atomic_AtomicReference_ = JNIEnv.GetStaticMethodID (class_ref, "terminate", "(Ljava/util/concurrent/atomic/AtomicReference;)Ljava/lang/Throwable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (field);
				global::Java.Lang.Throwable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_terminate_Ljava_util_concurrent_atomic_AtomicReference_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throwIfThrowable_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ExceptionHelper']/method[@name='throwIfThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("throwIfThrowable", "(Ljava/lang/Throwable;)Ljava/lang/Exception;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
		public static unsafe global::Java.Lang.Exception ThrowIfThrowable (global::Java.Lang.Throwable e)
		{
			if (id_throwIfThrowable_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_throwIfThrowable_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "throwIfThrowable", "(Ljava/lang/Throwable;)Ljava/lang/Exception;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				global::Java.Lang.Exception __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallStaticObjectMethod  (class_ref, id_throwIfThrowable_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timeoutMessage_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ExceptionHelper']/method[@name='timeoutMessage' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timeoutMessage", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/String;", "")]
		public static unsafe string TimeoutMessage (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_timeoutMessage_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timeoutMessage_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "timeoutMessage", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (timeout);
				__args [1] = new JValue (unit);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_timeoutMessage_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_wrapOrThrow_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ExceptionHelper']/method[@name='wrapOrThrow' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("wrapOrThrow", "(Ljava/lang/Throwable;)Ljava/lang/RuntimeException;", "")]
		public static unsafe global::Java.Lang.RuntimeException WrapOrThrow (global::Java.Lang.Throwable error)
		{
			if (id_wrapOrThrow_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_wrapOrThrow_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "wrapOrThrow", "(Ljava/lang/Throwable;)Ljava/lang/RuntimeException;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (error);
				global::Java.Lang.RuntimeException __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.RuntimeException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrapOrThrow_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
