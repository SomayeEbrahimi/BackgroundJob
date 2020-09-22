using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Single {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleZipIterable']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/single/SingleZipIterable", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public sealed partial class SingleZipIterable : global::IO.Reactivex.Single {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/single/SingleZipIterable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleZipIterable); }
		}

		internal SingleZipIterable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Iterable_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleZipIterable']/constructor[@name='SingleZipIterable' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;? extends io.reactivex.SingleSource&lt;? extends T&gt;&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Object[], ? extends R&gt;']]"
		[Register (".ctor", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)V", "")]
		public unsafe SingleZipIterable (global::Java.Lang.IIterable sources, global::IO.Reactivex.Functions.IFunction zipper)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sources);
				__args [1] = new JValue (zipper);
				if (((object) this).GetType () != typeof (SingleZipIterable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Iterable_Lio_reactivex_functions_Function_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Iterable;Lio/reactivex/functions/Function;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Iterable_Lio_reactivex_functions_Function_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Iterable_Lio_reactivex_functions_Function_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleZipIterable']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super R&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/SingleObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.ISingleObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/SingleObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_SingleObserver_, __args);
			} finally {
			}
		}

	}
}
