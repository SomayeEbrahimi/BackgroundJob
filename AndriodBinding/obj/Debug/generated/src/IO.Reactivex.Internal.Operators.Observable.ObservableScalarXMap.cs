using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableScalarXMap", DoNotGenerateAcw=true)]
	public sealed partial class ObservableScalarXMap : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap.ScalarDisposable']"
		[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableScalarXMap$ScalarDisposable", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public sealed partial class ScalarDisposable : global::Java.Util.Concurrent.Atomic.AtomicInteger, global::IO.Reactivex.Internal.Fuseable.IQueueDisposable, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableScalarXMap$ScalarDisposable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ScalarDisposable); }
			}

			internal ScalarDisposable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lio_reactivex_Observer_Ljava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap.ScalarDisposable']/constructor[@name='ObservableScalarXMap.ScalarDisposable' and count(parameter)=2 and parameter[1][@type='io.reactivex.Observer&lt;? super T&gt;'] and parameter[2][@type='T']]"
			[Register (".ctor", "(Lio/reactivex/Observer;Ljava/lang/Object;)V", "")]
			public unsafe ScalarDisposable (global::IO.Reactivex.IObserver observer, global::Java.Lang.Object value)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (observer);
					__args [1] = new JValue (native_value);
					if (((object) this).GetType () != typeof (ScalarDisposable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/Observer;Ljava/lang/Object;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/Observer;Ljava/lang/Object;)V", __args);
						return;
					}

					if (id_ctor_Lio_reactivex_Observer_Ljava_lang_Object_ == IntPtr.Zero)
						id_ctor_Lio_reactivex_Observer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/Observer;Ljava/lang/Object;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_Observer_Ljava_lang_Object_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_Observer_Ljava_lang_Object_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_isDisposed;
			public unsafe bool IsDisposed {
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap.ScalarDisposable']/method[@name='isDisposed' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap.ScalarDisposable']/method[@name='isEmpty' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap.ScalarDisposable']/method[@name='clear' and count(parameter)=0]"
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

			static IntPtr id_dispose;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap.ScalarDisposable']/method[@name='dispose' and count(parameter)=0]"
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

			static IntPtr id_offer_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap.ScalarDisposable']/method[@name='offer' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("offer", "(Ljava/lang/Object;)Z", "")]
			public unsafe bool Offer (global::Java.Lang.Object value)
			{
				if (id_offer_Ljava_lang_Object_ == IntPtr.Zero)
					id_offer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;)Z");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offer_Ljava_lang_Object_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_offer_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap.ScalarDisposable']/method[@name='offer' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
			[Register ("offer", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
			public unsafe bool Offer (global::Java.Lang.Object v1, global::Java.Lang.Object v2)
			{
				if (id_offer_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_offer_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
				IntPtr native_v1 = JNIEnv.ToLocalJniHandle (v1);
				IntPtr native_v2 = JNIEnv.ToLocalJniHandle (v2);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_v1);
					__args [1] = new JValue (native_v2);
					bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offer_Ljava_lang_Object_Ljava_lang_Object_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_v1);
					JNIEnv.DeleteLocalRef (native_v2);
				}
			}

			static IntPtr id_poll;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap.ScalarDisposable']/method[@name='poll' and count(parameter)=0]"
			[Register ("poll", "()Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object Poll ()
			{
				if (id_poll == IntPtr.Zero)
					id_poll = JNIEnv.GetMethodID (class_ref, "poll", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_poll), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_requestFusion_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap.ScalarDisposable']/method[@name='requestFusion' and count(parameter)=1 and parameter[1][@type='int']]"
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

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap.ScalarDisposable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "")]
			public unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableScalarXMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableScalarXMap); }
		}

		internal ObservableScalarXMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_scalarXMap_Ljava_lang_Object_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap']/method[@name='scalarXMap' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends U&gt;&gt;']]"
		[Register ("scalarXMap", "(Ljava/lang/Object;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe global::IO.Reactivex.Observable ScalarXMap (global::Java.Lang.Object value, global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_scalarXMap_Ljava_lang_Object_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_scalarXMap_Ljava_lang_Object_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "scalarXMap", "(Ljava/lang/Object;Lio/reactivex/functions/Function;)Lio/reactivex/Observable;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_value);
				__args [1] = new JValue (mapper);
				global::IO.Reactivex.Observable __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_scalarXMap_Ljava_lang_Object_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_tryScalarXMapSubscribe_Lio_reactivex_ObservableSource_Lio_reactivex_Observer_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableScalarXMap']/method[@name='tryScalarXMapSubscribe' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;'] and parameter[2][@type='io.reactivex.Observer&lt;? super R&gt;'] and parameter[3][@type='io.reactivex.functions.Function&lt;? super T, ? extends io.reactivex.ObservableSource&lt;? extends R&gt;&gt;']]"
		[Register ("tryScalarXMapSubscribe", "(Lio/reactivex/ObservableSource;Lio/reactivex/Observer;Lio/reactivex/functions/Function;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe bool TryScalarXMapSubscribe (global::IO.Reactivex.IObservableSource source, global::IO.Reactivex.IObserver observer, global::IO.Reactivex.Functions.IFunction mapper)
		{
			if (id_tryScalarXMapSubscribe_Lio_reactivex_ObservableSource_Lio_reactivex_Observer_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_tryScalarXMapSubscribe_Lio_reactivex_ObservableSource_Lio_reactivex_Observer_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "tryScalarXMapSubscribe", "(Lio/reactivex/ObservableSource;Lio/reactivex/Observer;Lio/reactivex/functions/Function;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (observer);
				__args [2] = new JValue (mapper);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_tryScalarXMapSubscribe_Lio_reactivex_ObservableSource_Lio_reactivex_Observer_Lio_reactivex_functions_Function_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
