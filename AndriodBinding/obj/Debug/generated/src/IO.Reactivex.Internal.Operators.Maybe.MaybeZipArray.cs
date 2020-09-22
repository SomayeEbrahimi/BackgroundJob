using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Maybe {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeZipArray']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/maybe/MaybeZipArray", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public sealed partial class MaybeZipArray : global::IO.Reactivex.Maybe {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/maybe/MaybeZipArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaybeZipArray); }
		}

		internal MaybeZipArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLio_reactivex_MaybeSource_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeZipArray']/constructor[@name='MaybeZipArray' and count(parameter)=2 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;[]'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;']]"
		[Register (".ctor", "([Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function;)V", "")]
		public unsafe MaybeZipArray (global::IO.Reactivex.IMaybeSource[] sources, global::IO.Reactivex.Functions.IFunction zipper)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_sources);
				__args [1] = new JValue (zipper);
				if (((object) this).GetType () != typeof (MaybeZipArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function;)V", __args);
					return;
				}

				if (id_ctor_arrayLio_reactivex_MaybeSource_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_ctor_arrayLio_reactivex_MaybeSource_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lio/reactivex/MaybeSource;Lio/reactivex/functions/Function;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLio_reactivex_MaybeSource_Lio_reactivex_functions_Function_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLio_reactivex_MaybeSource_Lio_reactivex_functions_Function_, __args);
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeZipArray']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;? super R&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/MaybeObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.IMaybeObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_MaybeObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/MaybeObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_MaybeObserver_, __args);
			} finally {
			}
		}

	}
}
