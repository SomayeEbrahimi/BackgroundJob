using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableGroupBy", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "V"})]
	public sealed partial class ObservableGroupBy : global::IO.Reactivex.Observable {

		// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy.GroupByObserver']"
		[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableGroupBy$GroupByObserver", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "V"})]
		public sealed partial class GroupByObserver : global::Java.Util.Concurrent.Atomic.AtomicInteger, global::IO.Reactivex.IObserver, global::IO.Reactivex.Disposables.IDisposable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableGroupBy$GroupByObserver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GroupByObserver); }
			}

			internal GroupByObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lio_reactivex_Observer_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_IZ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy.GroupByObserver']/constructor[@name='ObservableGroupBy.GroupByObserver' and count(parameter)=5 and parameter[1][@type='io.reactivex.Observer&lt;? super io.reactivex.observables.GroupedObservable&lt;K, V&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[3][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
			[Register (".ctor", "(Lio/reactivex/Observer;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;IZ)V", "")]
			public unsafe GroupByObserver (global::IO.Reactivex.IObserver actual, global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector, int bufferSize, bool delayError)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (actual);
					__args [1] = new JValue (keySelector);
					__args [2] = new JValue (valueSelector);
					__args [3] = new JValue (bufferSize);
					__args [4] = new JValue (delayError);
					if (((object) this).GetType () != typeof (GroupByObserver)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/Observer;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;IZ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/Observer;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;IZ)V", __args);
						return;
					}

					if (id_ctor_Lio_reactivex_Observer_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_IZ == IntPtr.Zero)
						id_ctor_Lio_reactivex_Observer_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_IZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/Observer;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;IZ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_Observer_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_IZ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_Observer_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_IZ, __args);
				} finally {
				}
			}

			static IntPtr id_isDisposed;
			public unsafe bool IsDisposed {
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy.GroupByObserver']/method[@name='isDisposed' and count(parameter)=0]"
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

			static IntPtr id_cancel_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy.GroupByObserver']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='K']]"
			[Register ("cancel", "(Ljava/lang/Object;)V", "")]
			public unsafe void Cancel (global::Java.Lang.Object key)
			{
				if (id_cancel_Ljava_lang_Object_ == IntPtr.Zero)
					id_cancel_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Ljava/lang/Object;)V");
				IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_key);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Ljava_lang_Object_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
				}
			}

			static IntPtr id_dispose;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy.GroupByObserver']/method[@name='dispose' and count(parameter)=0]"
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

			static IntPtr id_onComplete;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy.GroupByObserver']/method[@name='onComplete' and count(parameter)=0]"
			[Register ("onComplete", "()V", "")]
			public unsafe void OnComplete ()
			{
				if (id_onComplete == IntPtr.Zero)
					id_onComplete = JNIEnv.GetMethodID (class_ref, "onComplete", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete);
				} finally {
				}
			}

			static IntPtr id_onError_Ljava_lang_Throwable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy.GroupByObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onError", "(Ljava/lang/Throwable;)V", "")]
			public unsafe void OnError (global::Java.Lang.Throwable t)
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy.GroupByObserver']/method[@name='onNext' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("onNext", "(Ljava/lang/Object;)V", "")]
			public unsafe void OnNext (global::Java.Lang.Object t)
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy.GroupByObserver']/method[@name='onSubscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableGroupBy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableGroupBy); }
		}

		internal ObservableGroupBy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_IZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy']/constructor[@name='ObservableGroupBy' and count(parameter)=5 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[3][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;IZ)V", "")]
		public unsafe ObservableGroupBy (global::IO.Reactivex.IObservableSource source, global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector, int bufferSize, bool delayError)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (source);
				__args [1] = new JValue (keySelector);
				__args [2] = new JValue (valueSelector);
				__args [3] = new JValue (bufferSize);
				__args [4] = new JValue (delayError);
				if (((object) this).GetType () != typeof (ObservableGroupBy)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;IZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;IZ)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_IZ == IntPtr.Zero)
					id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_IZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/ObservableSource;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;IZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_IZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_ObservableSource_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableGroupBy']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super io.reactivex.observables.GroupedObservable&lt;K, V&gt;&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/Observer;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IObserver t)
		{
			if (id_subscribeActual_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_Observer_, __args);
			} finally {
			}
		}

		static IntPtr id_source;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='AbstractObservableWithUpstream']/method[@name='source' and count(parameter)=0]"
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

	}
}
