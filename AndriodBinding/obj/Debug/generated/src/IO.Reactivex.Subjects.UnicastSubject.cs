using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Subjects {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']"
	[global::Android.Runtime.Register ("io/reactivex/subjects/UnicastSubject", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class UnicastSubject : global::IO.Reactivex.Subjects.Subject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/subjects/UnicastSubject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnicastSubject); }
		}

		internal UnicastSubject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_hasComplete;
		public override unsafe bool HasComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='hasComplete' and count(parameter)=0]"
			[Register ("hasComplete", "()Z", "")]
			get {
				if (id_hasComplete == IntPtr.Zero)
					id_hasComplete = JNIEnv.GetMethodID (class_ref, "hasComplete", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasComplete);
				} finally {
				}
			}
		}

		static IntPtr id_hasObservers;
		public override unsafe bool HasObservers {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='hasObservers' and count(parameter)=0]"
			[Register ("hasObservers", "()Z", "")]
			get {
				if (id_hasObservers == IntPtr.Zero)
					id_hasObservers = JNIEnv.GetMethodID (class_ref, "hasObservers", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasObservers);
				} finally {
				}
			}
		}

		static IntPtr id_hasThrowable;
		public override unsafe bool HasThrowable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='hasThrowable' and count(parameter)=0]"
			[Register ("hasThrowable", "()Z", "")]
			get {
				if (id_hasThrowable == IntPtr.Zero)
					id_hasThrowable = JNIEnv.GetMethodID (class_ref, "hasThrowable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasThrowable);
				} finally {
				}
			}
		}

		static IntPtr id_getThrowable;
		public override unsafe global::Java.Lang.Throwable Throwable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='getThrowable' and count(parameter)=0]"
			[Register ("getThrowable", "()Ljava/lang/Throwable;", "")]
			get {
				if (id_getThrowable == IntPtr.Zero)
					id_getThrowable = JNIEnv.GetMethodID (class_ref, "getThrowable", "()Ljava/lang/Throwable;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThrowable), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lio/reactivex/subjects/UnicastSubject;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Subjects.UnicastSubject Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lio/reactivex/subjects/UnicastSubject;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.UnicastSubject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("create", "(Z)Lio/reactivex/subjects/UnicastSubject;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Subjects.UnicastSubject Create (bool delayError)
		{
			if (id_create_Z == IntPtr.Zero)
				id_create_Z = JNIEnv.GetStaticMethodID (class_ref, "create", "(Z)Lio/reactivex/subjects/UnicastSubject;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (delayError);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.UnicastSubject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("create", "(I)Lio/reactivex/subjects/UnicastSubject;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Subjects.UnicastSubject Create (int capacityHint)
		{
			if (id_create_I == IntPtr.Zero)
				id_create_I = JNIEnv.GetStaticMethodID (class_ref, "create", "(I)Lio/reactivex/subjects/UnicastSubject;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (capacityHint);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.UnicastSubject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_ILjava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='create' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("create", "(ILjava/lang/Runnable;)Lio/reactivex/subjects/UnicastSubject;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Subjects.UnicastSubject Create (int capacityHint, global::Java.Lang.IRunnable onTerminate)
		{
			if (id_create_ILjava_lang_Runnable_ == IntPtr.Zero)
				id_create_ILjava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(ILjava/lang/Runnable;)Lio/reactivex/subjects/UnicastSubject;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (capacityHint);
				__args [1] = new JValue (onTerminate);
				global::IO.Reactivex.Subjects.UnicastSubject __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.UnicastSubject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_ILjava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create_ILjava_lang_Runnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='create' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Runnable'] and parameter[3][@type='boolean']]"
		[Register ("create", "(ILjava/lang/Runnable;Z)Lio/reactivex/subjects/UnicastSubject;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Subjects.UnicastSubject Create (int capacityHint, global::Java.Lang.IRunnable onTerminate, bool delayError)
		{
			if (id_create_ILjava_lang_Runnable_Z == IntPtr.Zero)
				id_create_ILjava_lang_Runnable_Z = JNIEnv.GetStaticMethodID (class_ref, "create", "(ILjava/lang/Runnable;Z)Lio/reactivex/subjects/UnicastSubject;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (capacityHint);
				__args [1] = new JValue (onTerminate);
				__args [2] = new JValue (delayError);
				global::IO.Reactivex.Subjects.UnicastSubject __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.UnicastSubject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_ILjava_lang_Runnable_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "")]
		public override unsafe void OnComplete ()
		{
			if (id_onComplete == IntPtr.Zero)
				id_onComplete = JNIEnv.GetMethodID (class_ref, "onComplete", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete);
			} finally {
			}
		}

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "")]
		public override unsafe void OnError (global::Java.Lang.Throwable t)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_onNext_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='onNext' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onNext", "(Ljava/lang/Object;)V", "")]
		public override unsafe void OnNext (global::Java.Lang.Object t)
		{
			if (id_onNext_Ljava_lang_Object_ == IntPtr.Zero)
				id_onNext_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onNext", "(Ljava/lang/Object;)V");
			IntPtr native_t = JNIEnv.ToLocalJniHandle (t);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNext_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_t);
			}
		}

		static IntPtr id_onSubscribe_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("onSubscribe", "(Lio/reactivex/disposables/Disposable;)V", "")]
		public override unsafe void OnSubscribe (global::IO.Reactivex.Disposables.IDisposable d)
		{
			if (id_onSubscribe_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_onSubscribe_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "onSubscribe", "(Lio/reactivex/disposables/Disposable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (d);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSubscribe_Lio_reactivex_disposables_Disposable_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='UnicastSubject']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/Observer;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

	}
}
