using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Subjects {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='SingleSubject']"
	[global::Android.Runtime.Register ("io/reactivex/subjects/SingleSubject", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class SingleSubject : global::IO.Reactivex.Single, global::IO.Reactivex.ISingleObserver {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/subjects/SingleSubject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleSubject); }
		}

		internal SingleSubject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_hasObservers;
		public unsafe bool HasObservers {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='SingleSubject']/method[@name='hasObservers' and count(parameter)=0]"
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
		public unsafe bool HasThrowable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='SingleSubject']/method[@name='hasThrowable' and count(parameter)=0]"
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

		static IntPtr id_hasValue;
		public unsafe bool HasValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='SingleSubject']/method[@name='hasValue' and count(parameter)=0]"
			[Register ("hasValue", "()Z", "")]
			get {
				if (id_hasValue == IntPtr.Zero)
					id_hasValue = JNIEnv.GetMethodID (class_ref, "hasValue", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasValue);
				} finally {
				}
			}
		}

		static IntPtr id_getThrowable;
		public unsafe global::Java.Lang.Throwable Throwable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='SingleSubject']/method[@name='getThrowable' and count(parameter)=0]"
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

		static IntPtr id_getValue;
		public unsafe global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='SingleSubject']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='SingleSubject']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lio/reactivex/subjects/SingleSubject;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Subjects.SingleSubject Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lio/reactivex/subjects/SingleSubject;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.SingleSubject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='SingleSubject']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "")]
		public unsafe void OnError (global::Java.Lang.Throwable e)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_onSubscribe_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='SingleSubject']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("onSubscribe", "(Lio/reactivex/disposables/Disposable;)V", "")]
		public unsafe void OnSubscribe (global::IO.Reactivex.Disposables.IDisposable d)
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

		static IntPtr id_onSuccess_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='SingleSubject']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "")]
		public unsafe void OnSuccess (global::Java.Lang.Object value)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='SingleSubject']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/SingleObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.ISingleObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/SingleObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_SingleObserver_, __args);
			} finally {
			}
		}

	}
}
