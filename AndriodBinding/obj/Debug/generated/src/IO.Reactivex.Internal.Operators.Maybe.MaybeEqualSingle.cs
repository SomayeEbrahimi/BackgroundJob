using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Maybe {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeEqualSingle']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/maybe/MaybeEqualSingle", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class MaybeEqualSingle : global::IO.Reactivex.Single {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/maybe/MaybeEqualSingle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaybeEqualSingle); }
		}

		internal MaybeEqualSingle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiPredicate_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeEqualSingle']/constructor[@name='MaybeEqualSingle' and count(parameter)=3 and parameter[1][@type='io.reactivex.MaybeSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.MaybeSource&lt;? extends T&gt;'] and parameter[3][@type='io.reactivex.functions.BiPredicate&lt;? super T, ? super T&gt;']]"
		[Register (".ctor", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/BiPredicate;)V", "")]
		public unsafe MaybeEqualSingle (global::IO.Reactivex.IMaybeSource source1, global::IO.Reactivex.IMaybeSource source2, global::IO.Reactivex.Functions.IBiPredicate isEqual)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source1);
				__args [1] = new JValue (source2);
				__args [2] = new JValue (isEqual);
				if (((object) this).GetType () != typeof (MaybeEqualSingle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/BiPredicate;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/BiPredicate;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiPredicate_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiPredicate_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/MaybeSource;Lio/reactivex/MaybeSource;Lio/reactivex/functions/BiPredicate;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiPredicate_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_MaybeSource_Lio_reactivex_functions_BiPredicate_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeEqualSingle']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super java.lang.Boolean&gt;']]"
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
