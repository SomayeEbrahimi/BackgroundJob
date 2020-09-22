using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='EndConsumerHelper']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/EndConsumerHelper", DoNotGenerateAcw=true)]
	public sealed partial class EndConsumerHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/EndConsumerHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EndConsumerHelper); }
		}

		internal EndConsumerHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_composeMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='EndConsumerHelper']/method[@name='composeMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("composeMessage", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ComposeMessage (string consumer)
		{
			if (id_composeMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_composeMessage_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "composeMessage", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_consumer = JNIEnv.NewString (consumer);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_consumer);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_composeMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_consumer);
			}
		}

		static IntPtr id_reportDoubleSubscription_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='EndConsumerHelper']/method[@name='reportDoubleSubscription' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("reportDoubleSubscription", "(Ljava/lang/Class;)V", "")]
		public static unsafe void ReportDoubleSubscription (global::Java.Lang.Class consumer)
		{
			if (id_reportDoubleSubscription_Ljava_lang_Class_ == IntPtr.Zero)
				id_reportDoubleSubscription_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "reportDoubleSubscription", "(Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (consumer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportDoubleSubscription_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnce_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='EndConsumerHelper']/method[@name='setOnce' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.atomic.AtomicReference&lt;io.reactivex.disposables.Disposable&gt;'] and parameter[2][@type='io.reactivex.disposables.Disposable'] and parameter[3][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("setOnce", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/disposables/Disposable;Ljava/lang/Class;)Z", "")]
		public static unsafe bool SetOnce (global::Java.Util.Concurrent.Atomic.AtomicReference upstream, global::IO.Reactivex.Disposables.IDisposable next, global::Java.Lang.Class observer)
		{
			if (id_setOnce_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_Ljava_lang_Class_ == IntPtr.Zero)
				id_setOnce_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "setOnce", "(Ljava/util/concurrent/atomic/AtomicReference;Lio/reactivex/disposables/Disposable;Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (upstream);
				__args [1] = new JValue (next);
				__args [2] = new JValue (observer);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_setOnce_Ljava_util_concurrent_atomic_AtomicReference_Lio_reactivex_disposables_Disposable_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_validate_Lio_reactivex_disposables_Disposable_Lio_reactivex_disposables_Disposable_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='EndConsumerHelper']/method[@name='validate' and count(parameter)=3 and parameter[1][@type='io.reactivex.disposables.Disposable'] and parameter[2][@type='io.reactivex.disposables.Disposable'] and parameter[3][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("validate", "(Lio/reactivex/disposables/Disposable;Lio/reactivex/disposables/Disposable;Ljava/lang/Class;)Z", "")]
		public static unsafe bool Validate (global::IO.Reactivex.Disposables.IDisposable upstream, global::IO.Reactivex.Disposables.IDisposable next, global::Java.Lang.Class observer)
		{
			if (id_validate_Lio_reactivex_disposables_Disposable_Lio_reactivex_disposables_Disposable_Ljava_lang_Class_ == IntPtr.Zero)
				id_validate_Lio_reactivex_disposables_Disposable_Lio_reactivex_disposables_Disposable_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "validate", "(Lio/reactivex/disposables/Disposable;Lio/reactivex/disposables/Disposable;Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (upstream);
				__args [1] = new JValue (next);
				__args [2] = new JValue (observer);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_validate_Lio_reactivex_disposables_Disposable_Lio_reactivex_disposables_Disposable_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
