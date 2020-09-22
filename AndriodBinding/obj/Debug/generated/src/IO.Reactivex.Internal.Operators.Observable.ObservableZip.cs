using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableZip']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableZip", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public sealed partial class ObservableZip : global::IO.Reactivex.Observable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableZip", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableZip); }
		}

		internal ObservableZip (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLio_reactivex_ObservableSource_Ljava_lang_Iterable_Lio_reactivex_functions_Function_IZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableZip']/constructor[@name='ObservableZip' and count(parameter)=5 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;[]'] and parameter[2][@type='java.lang.Iterable&lt;? extends io.reactivex.ObservableSource&lt;? extends T&gt;&gt;'] and parameter[3][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "([Lio/reactivex/ObservableSource;Ljava/lang/Iterable;Lio/reactivex/functions/Function;IZ)V", "")]
		public unsafe ObservableZip (global::IO.Reactivex.IObservableSource[] sources, global::Java.Lang.IIterable sourcesIterable, global::IO.Reactivex.Functions.IFunction zipper, int bufferSize, bool delayError)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_sources);
				__args [1] = new JValue (sourcesIterable);
				__args [2] = new JValue (zipper);
				__args [3] = new JValue (bufferSize);
				__args [4] = new JValue (delayError);
				if (((object) this).GetType () != typeof (ObservableZip)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lio/reactivex/ObservableSource;Ljava/lang/Iterable;Lio/reactivex/functions/Function;IZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lio/reactivex/ObservableSource;Ljava/lang/Iterable;Lio/reactivex/functions/Function;IZ)V", __args);
					return;
				}

				if (id_ctor_arrayLio_reactivex_ObservableSource_Ljava_lang_Iterable_Lio_reactivex_functions_Function_IZ == IntPtr.Zero)
					id_ctor_arrayLio_reactivex_ObservableSource_Ljava_lang_Iterable_Lio_reactivex_functions_Function_IZ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lio/reactivex/ObservableSource;Ljava/lang/Iterable;Lio/reactivex/functions/Function;IZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLio_reactivex_ObservableSource_Ljava_lang_Iterable_Lio_reactivex_functions_Function_IZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLio_reactivex_ObservableSource_Ljava_lang_Iterable_Lio_reactivex_functions_Function_IZ, __args);
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableZip']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super R&gt;']]"
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
