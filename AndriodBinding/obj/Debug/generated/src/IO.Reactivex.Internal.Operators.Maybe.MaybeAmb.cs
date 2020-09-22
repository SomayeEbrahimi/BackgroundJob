using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Maybe {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeAmb']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/maybe/MaybeAmb", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class MaybeAmb : global::IO.Reactivex.Maybe {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/maybe/MaybeAmb", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaybeAmb); }
		}

		internal MaybeAmb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLio_reactivex_MaybeSource_Ljava_lang_Iterable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeAmb']/constructor[@name='MaybeAmb' and count(parameter)=2 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;[]'] and parameter[2][@type='java.lang.Iterable&lt;? extends io.reactivex.MaybeSource&lt;? extends T&gt;&gt;']]"
		[Register (".ctor", "([Lio/reactivex/MaybeSource;Ljava/lang/Iterable;)V", "")]
		public unsafe MaybeAmb (global::IO.Reactivex.IMaybeSource[] sources, global::Java.Lang.IIterable sourcesIterable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sources = JNIEnv.NewArray (sources);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_sources);
				__args [1] = new JValue (sourcesIterable);
				if (((object) this).GetType () != typeof (MaybeAmb)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lio/reactivex/MaybeSource;Ljava/lang/Iterable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lio/reactivex/MaybeSource;Ljava/lang/Iterable;)V", __args);
					return;
				}

				if (id_ctor_arrayLio_reactivex_MaybeSource_Ljava_lang_Iterable_ == IntPtr.Zero)
					id_ctor_arrayLio_reactivex_MaybeSource_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lio/reactivex/MaybeSource;Ljava/lang/Iterable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLio_reactivex_MaybeSource_Ljava_lang_Iterable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLio_reactivex_MaybeSource_Ljava_lang_Iterable_, __args);
			} finally {
				if (sources != null) {
					JNIEnv.CopyArray (native_sources, sources);
					JNIEnv.DeleteLocalRef (native_sources);
				}
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_MaybeObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeAmb']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;? super T&gt;']]"
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
