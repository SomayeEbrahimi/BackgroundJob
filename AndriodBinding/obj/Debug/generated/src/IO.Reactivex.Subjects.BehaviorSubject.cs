using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Subjects {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']"
	[global::Android.Runtime.Register ("io/reactivex/subjects/BehaviorSubject", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class BehaviorSubject : global::IO.Reactivex.Subjects.Subject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/subjects/BehaviorSubject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BehaviorSubject); }
		}

		internal BehaviorSubject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_hasComplete;
		public override unsafe bool HasComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='hasComplete' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='hasObservers' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='hasThrowable' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='hasValue' and count(parameter)=0]"
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
		public override unsafe global::Java.Lang.Throwable Throwable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='getThrowable' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='getValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lio/reactivex/subjects/BehaviorSubject;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Subjects.BehaviorSubject Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lio/reactivex/subjects/BehaviorSubject;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.BehaviorSubject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createDefault_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='createDefault' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("createDefault", "(Ljava/lang/Object;)Lio/reactivex/subjects/BehaviorSubject;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Subjects.BehaviorSubject CreateDefault (global::Java.Lang.Object defaultValue)
		{
			if (id_createDefault_Ljava_lang_Object_ == IntPtr.Zero)
				id_createDefault_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "createDefault", "(Ljava/lang/Object;)Lio/reactivex/subjects/BehaviorSubject;");
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_defaultValue);
				global::IO.Reactivex.Subjects.BehaviorSubject __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Subjects.BehaviorSubject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createDefault_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static IntPtr id_getValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='getValues' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("getValues", "()[Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object[] GetValues ()
		{
			if (id_getValues == IntPtr.Zero)
				id_getValues = JNIEnv.GetMethodID (class_ref, "getValues", "()[Ljava/lang/Object;");
			try {
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValues), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static IntPtr id_getValues_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='getValues' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Obsolete (@"deprecated")]
		[Register ("getValues", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object[] GetValues (global::Java.Lang.Object[] array)
		{
			if (id_getValues_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getValues_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getValues", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValues_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_onComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='onComplete' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='onNext' and count(parameter)=1 and parameter[1][@type='T']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.subjects']/class[@name='BehaviorSubject']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
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
