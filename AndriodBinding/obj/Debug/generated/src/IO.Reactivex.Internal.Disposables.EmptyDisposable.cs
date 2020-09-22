using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Disposables {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']"
	[global::Android.Runtime.Register ("io/reactivex/internal/disposables/EmptyDisposable", DoNotGenerateAcw=true)]
	public sealed partial class EmptyDisposable : global::Java.Lang.Enum, global::IO.Reactivex.Internal.Fuseable.IQueueDisposable {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::IO.Reactivex.Internal.Disposables.EmptyDisposable Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lio/reactivex/internal/disposables/EmptyDisposable;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Disposables.EmptyDisposable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NEVER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/field[@name='NEVER']"
		[Register ("NEVER")]
		public static global::IO.Reactivex.Internal.Disposables.EmptyDisposable Never {
			get {
				if (NEVER_jfieldId == IntPtr.Zero)
					NEVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEVER", "Lio/reactivex/internal/disposables/EmptyDisposable;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEVER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Disposables.EmptyDisposable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/disposables/EmptyDisposable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EmptyDisposable); }
		}

		internal EmptyDisposable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isDisposed;
		public unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='isDisposed' and count(parameter)=0]"
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

		static IntPtr id_isEmpty;
		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
				} finally {
				}
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_complete_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='complete' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
		[Register ("complete", "(Lio/reactivex/CompletableObserver;)V", "")]
		public static unsafe void Complete (global::IO.Reactivex.ICompletableObserver observer)
		{
			if (id_complete_Lio_reactivex_CompletableObserver_ == IntPtr.Zero)
				id_complete_Lio_reactivex_CompletableObserver_ = JNIEnv.GetStaticMethodID (class_ref, "complete", "(Lio/reactivex/CompletableObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_complete_Lio_reactivex_CompletableObserver_, __args);
			} finally {
			}
		}

		static IntPtr id_complete_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='complete' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;?&gt;']]"
		[Register ("complete", "(Lio/reactivex/MaybeObserver;)V", "")]
		public static unsafe void Complete (global::IO.Reactivex.IMaybeObserver observer)
		{
			if (id_complete_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_complete_Lio_reactivex_MaybeObserver_ = JNIEnv.GetStaticMethodID (class_ref, "complete", "(Lio/reactivex/MaybeObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_complete_Lio_reactivex_MaybeObserver_, __args);
			} finally {
			}
		}

		static IntPtr id_complete_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='complete' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;?&gt;']]"
		[Register ("complete", "(Lio/reactivex/Observer;)V", "")]
		public static unsafe void Complete (global::IO.Reactivex.IObserver observer)
		{
			if (id_complete_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_complete_Lio_reactivex_Observer_ = JNIEnv.GetStaticMethodID (class_ref, "complete", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_complete_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='dispose' and count(parameter)=0]"
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

		static IntPtr id_error_Ljava_lang_Throwable_Lio_reactivex_CompletableObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='io.reactivex.CompletableObserver']]"
		[Register ("error", "(Ljava/lang/Throwable;Lio/reactivex/CompletableObserver;)V", "")]
		public static unsafe void Error (global::Java.Lang.Throwable e, global::IO.Reactivex.ICompletableObserver observer)
		{
			if (id_error_Ljava_lang_Throwable_Lio_reactivex_CompletableObserver_ == IntPtr.Zero)
				id_error_Ljava_lang_Throwable_Lio_reactivex_CompletableObserver_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/Throwable;Lio/reactivex/CompletableObserver;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (e);
				__args [1] = new JValue (observer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_error_Ljava_lang_Throwable_Lio_reactivex_CompletableObserver_, __args);
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_Throwable_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='io.reactivex.MaybeObserver&lt;?&gt;']]"
		[Register ("error", "(Ljava/lang/Throwable;Lio/reactivex/MaybeObserver;)V", "")]
		public static unsafe void Error (global::Java.Lang.Throwable e, global::IO.Reactivex.IMaybeObserver observer)
		{
			if (id_error_Ljava_lang_Throwable_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_error_Ljava_lang_Throwable_Lio_reactivex_MaybeObserver_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/Throwable;Lio/reactivex/MaybeObserver;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (e);
				__args [1] = new JValue (observer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_error_Ljava_lang_Throwable_Lio_reactivex_MaybeObserver_, __args);
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_Throwable_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='io.reactivex.Observer&lt;?&gt;']]"
		[Register ("error", "(Ljava/lang/Throwable;Lio/reactivex/Observer;)V", "")]
		public static unsafe void Error (global::Java.Lang.Throwable e, global::IO.Reactivex.IObserver observer)
		{
			if (id_error_Ljava_lang_Throwable_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_error_Ljava_lang_Throwable_Lio_reactivex_Observer_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/Throwable;Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (e);
				__args [1] = new JValue (observer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_error_Ljava_lang_Throwable_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_Throwable_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='io.reactivex.SingleObserver&lt;?&gt;']]"
		[Register ("error", "(Ljava/lang/Throwable;Lio/reactivex/SingleObserver;)V", "")]
		public static unsafe void Error (global::Java.Lang.Throwable e, global::IO.Reactivex.ISingleObserver observer)
		{
			if (id_error_Ljava_lang_Throwable_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_error_Ljava_lang_Throwable_Lio_reactivex_SingleObserver_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/Throwable;Lio/reactivex/SingleObserver;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (e);
				__args [1] = new JValue (observer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_error_Ljava_lang_Throwable_Lio_reactivex_SingleObserver_, __args);
			} finally {
			}
		}

		static IntPtr id_offer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='offer' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("offer", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Offer (global::Java.Lang.Object value)
		{
			if (id_offer_Ljava_lang_Object_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offer_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_offer_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='offer' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("offer", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public unsafe bool Offer (global::Java.Lang.Object v1, global::Java.Lang.Object v2)
		{
			if (id_offer_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (v1);
				__args [1] = new JValue (v2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offer_Ljava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_poll;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='poll' and count(parameter)=0]"
		[Register ("poll", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Poll ()
		{
			if (id_poll == IntPtr.Zero)
				id_poll = JNIEnv.GetMethodID (class_ref, "poll", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_poll), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_requestFusion_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='requestFusion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestFusion", "(I)I", "")]
		public unsafe int RequestFusion (int mode)
		{
			if (id_requestFusion_I == IntPtr.Zero)
				id_requestFusion_I = JNIEnv.GetMethodID (class_ref, "requestFusion", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mode);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_requestFusion_I, __args);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/disposables/EmptyDisposable;", "")]
		public static unsafe global::IO.Reactivex.Internal.Disposables.EmptyDisposable ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/disposables/EmptyDisposable;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::IO.Reactivex.Internal.Disposables.EmptyDisposable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Disposables.EmptyDisposable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.disposables']/class[@name='EmptyDisposable']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/reactivex/internal/disposables/EmptyDisposable;", "")]
		public static unsafe global::IO.Reactivex.Internal.Disposables.EmptyDisposable[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/internal/disposables/EmptyDisposable;");
			try {
				return (global::IO.Reactivex.Internal.Disposables.EmptyDisposable[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.Internal.Disposables.EmptyDisposable));
			} finally {
			}
		}

	}
}
