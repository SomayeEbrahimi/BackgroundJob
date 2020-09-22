using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Parallel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.parallel']/class[@name='ParallelFilterTry']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/parallel/ParallelFilterTry", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ParallelFilterTry : global::IO.Reactivex.Parallel.ParallelFlowable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/parallel/ParallelFilterTry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParallelFilterTry); }
		}

		internal ParallelFilterTry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_parallel_ParallelFlowable_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.parallel']/class[@name='ParallelFilterTry']/constructor[@name='ParallelFilterTry' and count(parameter)=3 and parameter[1][@type='io.reactivex.parallel.ParallelFlowable&lt;T&gt;'] and parameter[2][@type='io.reactivex.functions.Predicate&lt;? super T&gt;'] and parameter[3][@type='io.reactivex.functions.BiFunction&lt;? super java.lang.Long, ? super java.lang.Throwable, io.reactivex.parallel.ParallelFailureHandling&gt;']]"
		[Register (".ctor", "(Lio/reactivex/parallel/ParallelFlowable;Lio/reactivex/functions/Predicate;Lio/reactivex/functions/BiFunction;)V", "")]
		public unsafe ParallelFilterTry (global::IO.Reactivex.Parallel.ParallelFlowable source, global::IO.Reactivex.Functions.IPredicate predicate, global::IO.Reactivex.Functions.IBiFunction errorHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (predicate);
				__args [2] = new JValue (errorHandler);
				if (((object) this).GetType () != typeof (ParallelFilterTry)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/parallel/ParallelFlowable;Lio/reactivex/functions/Predicate;Lio/reactivex/functions/BiFunction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/parallel/ParallelFlowable;Lio/reactivex/functions/Predicate;Lio/reactivex/functions/BiFunction;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_parallel_ParallelFlowable_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_parallel_ParallelFlowable_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/parallel/ParallelFlowable;Lio/reactivex/functions/Predicate;Lio/reactivex/functions/BiFunction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_parallel_ParallelFlowable_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_BiFunction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_parallel_ParallelFlowable_Lio_reactivex_functions_Predicate_Lio_reactivex_functions_BiFunction_, __args);
			} finally {
			}
		}

		static IntPtr id_parallelism;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.parallel']/class[@name='ParallelFilterTry']/method[@name='parallelism' and count(parameter)=0]"
		[Register ("parallelism", "()I", "")]
		public override unsafe int Parallelism ()
		{
			if (id_parallelism == IntPtr.Zero)
				id_parallelism = JNIEnv.GetMethodID (class_ref, "parallelism", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_parallelism);
			} finally {
			}
		}

	}
}
