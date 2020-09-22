using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableBlockingSubscribe']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableBlockingSubscribe", DoNotGenerateAcw=true)]
	public sealed partial class ObservableBlockingSubscribe : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableBlockingSubscribe", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableBlockingSubscribe); }
		}

		internal ObservableBlockingSubscribe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_subscribe_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableBlockingSubscribe']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/ObservableSource;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void Subscribe (global::IO.Reactivex.IObservableSource o)
		{
			if (id_subscribe_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "subscribe", "(Lio/reactivex/ObservableSource;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subscribe_Lio_reactivex_ObservableSource_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableBlockingSubscribe']/method[@name='subscribe' and count(parameter)=4 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.functions.Consumer&lt;? super T&gt;'] and parameter[3][@type='io.reactivex.functions.Consumer&lt;? super java.lang.Throwable&gt;'] and parameter[4][@type='io.reactivex.functions.Action']]"
		[Register ("subscribe", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void Subscribe (global::IO.Reactivex.IObservableSource o, global::IO.Reactivex.Functions.IConsumer onNext, global::IO.Reactivex.Functions.IConsumer onError, global::IO.Reactivex.Functions.IAction onComplete)
		{
			if (id_subscribe_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_ = JNIEnv.GetStaticMethodID (class_ref, "subscribe", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Consumer;Lio/reactivex/functions/Action;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (o);
				__args [1] = new JValue (onNext);
				__args [2] = new JValue (onError);
				__args [3] = new JValue (onComplete);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subscribe_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Consumer_Lio_reactivex_functions_Action_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribe_Lio_reactivex_ObservableSource_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableBlockingSubscribe']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.Observer&lt;? super T&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/ObservableSource;Lio/reactivex/Observer;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void Subscribe (global::IO.Reactivex.IObservableSource o, global::IO.Reactivex.IObserver observer)
		{
			if (id_subscribe_Lio_reactivex_ObservableSource_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_ObservableSource_Lio_reactivex_Observer_ = JNIEnv.GetStaticMethodID (class_ref, "subscribe", "(Lio/reactivex/ObservableSource;Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (o);
				__args [1] = new JValue (observer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subscribe_Lio_reactivex_ObservableSource_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

	}
}
