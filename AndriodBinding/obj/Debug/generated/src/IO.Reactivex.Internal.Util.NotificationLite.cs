using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/NotificationLite", DoNotGenerateAcw=true)]
	public sealed partial class NotificationLite : global::Java.Lang.Enum {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/NotificationLite", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotificationLite); }
		}

		internal NotificationLite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_accept_Ljava_lang_Object_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("accept", "(Ljava/lang/Object;Lio/reactivex/Observer;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe bool Accept (global::Java.Lang.Object o, global::IO.Reactivex.IObserver observer)
		{
			if (id_accept_Ljava_lang_Object_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_accept_Ljava_lang_Object_Lio_reactivex_Observer_ = JNIEnv.GetStaticMethodID (class_ref, "accept", "(Ljava/lang/Object;Lio/reactivex/Observer;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (o);
				__args [1] = new JValue (observer);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_accept_Ljava_lang_Object_Lio_reactivex_Observer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_acceptFull_Ljava_lang_Object_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='acceptFull' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("acceptFull", "(Ljava/lang/Object;Lio/reactivex/Observer;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe bool AcceptFull (global::Java.Lang.Object o, global::IO.Reactivex.IObserver observer)
		{
			if (id_acceptFull_Ljava_lang_Object_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_acceptFull_Ljava_lang_Object_Lio_reactivex_Observer_ = JNIEnv.GetStaticMethodID (class_ref, "acceptFull", "(Ljava/lang/Object;Lio/reactivex/Observer;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (o);
				__args [1] = new JValue (observer);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_acceptFull_Ljava_lang_Object_Lio_reactivex_Observer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_complete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='complete' and count(parameter)=0]"
		[Register ("complete", "()Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object Complete ()
		{
			if (id_complete == IntPtr.Zero)
				id_complete = JNIEnv.GetStaticMethodID (class_ref, "complete", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_complete), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_disposable_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='disposable' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("disposable", "(Lio/reactivex/disposables/Disposable;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object Disposable (global::IO.Reactivex.Disposables.IDisposable d)
		{
			if (id_disposable_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_disposable_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetStaticMethodID (class_ref, "disposable", "(Lio/reactivex/disposables/Disposable;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (d);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_disposable_Lio_reactivex_disposables_Disposable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/Throwable;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object Error (global::Java.Lang.Throwable e)
		{
			if (id_error_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_error_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/Throwable;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDisposable_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='getDisposable' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getDisposable", "(Ljava/lang/Object;)Lio/reactivex/disposables/Disposable;", "")]
		public static unsafe global::IO.Reactivex.Disposables.IDisposable GetDisposable (global::Java.Lang.Object o)
		{
			if (id_getDisposable_Ljava_lang_Object_ == IntPtr.Zero)
				id_getDisposable_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getDisposable", "(Ljava/lang/Object;)Lio/reactivex/disposables/Disposable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::IO.Reactivex.Disposables.IDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDisposable_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getError_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='getError' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getError", "(Ljava/lang/Object;)Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable GetError (global::Java.Lang.Object o)
		{
			if (id_getError_Ljava_lang_Object_ == IntPtr.Zero)
				id_getError_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getError", "(Ljava/lang/Object;)Ljava/lang/Throwable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::Java.Lang.Throwable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getError_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getValue", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetValue (global::Java.Lang.Object o)
		{
			if (id_getValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_getValue_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getValue", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getValue_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isComplete_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='isComplete' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isComplete", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsComplete (global::Java.Lang.Object o)
		{
			if (id_isComplete_Ljava_lang_Object_ == IntPtr.Zero)
				id_isComplete_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isComplete", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isComplete_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isDisposable_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='isDisposable' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isDisposable", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsDisposable (global::Java.Lang.Object o)
		{
			if (id_isDisposable_Ljava_lang_Object_ == IntPtr.Zero)
				id_isDisposable_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isDisposable", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDisposable_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isError_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='isError' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isError", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsError (global::Java.Lang.Object o)
		{
			if (id_isError_Ljava_lang_Object_ == IntPtr.Zero)
				id_isError_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isError", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isError_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isSubscription_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='isSubscription' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isSubscription", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsSubscription (global::Java.Lang.Object o)
		{
			if (id_isSubscription_Ljava_lang_Object_ == IntPtr.Zero)
				id_isSubscription_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isSubscription", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSubscription_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_next_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='next' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("next", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Next (global::Java.Lang.Object value)
		{
			if (id_next_Ljava_lang_Object_ == IntPtr.Zero)
				id_next_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "next", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_next_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/util/NotificationLite;", "")]
		public static unsafe global::IO.Reactivex.Internal.Util.NotificationLite ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/util/NotificationLite;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::IO.Reactivex.Internal.Util.NotificationLite __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.NotificationLite> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='NotificationLite']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/reactivex/internal/util/NotificationLite;", "")]
		public static unsafe global::IO.Reactivex.Internal.Util.NotificationLite[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/internal/util/NotificationLite;");
			try {
				return (global::IO.Reactivex.Internal.Util.NotificationLite[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.Internal.Util.NotificationLite));
			} finally {
			}
		}

	}
}
