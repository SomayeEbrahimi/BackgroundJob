using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservablePublish']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservablePublish", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ObservablePublish : global::IO.Reactivex.Observables.ConnectableObservable, global::IO.Reactivex.Internal.Fuseable.IHasUpstreamObservableSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservablePublish", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservablePublish); }
		}

		internal ObservablePublish (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_connect_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservablePublish']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.disposables.Disposable&gt;']]"
		[Register ("connect", "(Lio/reactivex/functions/Consumer;)V", "")]
		public override unsafe void Connect (global::IO.Reactivex.Functions.IConsumer connection)
		{
			if (id_connect_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_connect_Lio_reactivex_functions_Consumer_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lio/reactivex/functions/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (connection);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lio_reactivex_functions_Consumer_, __args);
			} finally {
			}
		}

		static IntPtr id_create_Lio_reactivex_ObservableSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservablePublish']/method[@name='create' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;']]"
		[Register ("create", "(Lio/reactivex/ObservableSource;)Lio/reactivex/observables/ConnectableObservable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Observables.ConnectableObservable Create (global::IO.Reactivex.IObservableSource source)
		{
			if (id_create_Lio_reactivex_ObservableSource_ == IntPtr.Zero)
				id_create_Lio_reactivex_ObservableSource_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lio/reactivex/ObservableSource;)Lio/reactivex/observables/ConnectableObservable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				global::IO.Reactivex.Observables.ConnectableObservable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observables.ConnectableObservable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lio_reactivex_ObservableSource_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_source;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservablePublish']/method[@name='source' and count(parameter)=0]"
		[Register ("source", "()Lio/reactivex/ObservableSource;", "")]
		public unsafe global::IO.Reactivex.IObservableSource Source ()
		{
			if (id_source == IntPtr.Zero)
				id_source = JNIEnv.GetMethodID (class_ref, "source", "()Lio/reactivex/ObservableSource;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObservableSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_source), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservablePublish']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;']]"
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
