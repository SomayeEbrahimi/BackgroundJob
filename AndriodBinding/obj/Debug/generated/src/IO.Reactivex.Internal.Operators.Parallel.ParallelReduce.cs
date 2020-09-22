using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Parallel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.parallel']/class[@name='ParallelReduce']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/parallel/ParallelReduce", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public sealed partial class ParallelReduce : global::IO.Reactivex.Parallel.ParallelFlowable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/parallel/ParallelReduce", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParallelReduce); }
		}

		internal ParallelReduce (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_parallel_ParallelFlowable_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.parallel']/class[@name='ParallelReduce']/constructor[@name='ParallelReduce' and count(parameter)=3 and parameter[1][@type='io.reactivex.parallel.ParallelFlowable&lt;? extends T&gt;'] and parameter[2][@type='java.util.concurrent.Callable&lt;R&gt;'] and parameter[3][@type='io.reactivex.functions.BiFunction&lt;R, ? super T, R&gt;']]"
		[Register (".ctor", "(Lio/reactivex/parallel/ParallelFlowable;Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)V", "")]
		public unsafe ParallelReduce (global::IO.Reactivex.Parallel.ParallelFlowable source, global::Java.Util.Concurrent.ICallable initialSupplier, global::IO.Reactivex.Functions.IBiFunction reducer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (initialSupplier);
				__args [2] = new JValue (reducer);
				if (((object) this).GetType () != typeof (ParallelReduce)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/parallel/ParallelFlowable;Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/parallel/ParallelFlowable;Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_parallel_ParallelFlowable_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_parallel_ParallelFlowable_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/parallel/ParallelFlowable;Ljava/util/concurrent/Callable;Lio/reactivex/functions/BiFunction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_parallel_ParallelFlowable_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_parallel_ParallelFlowable_Ljava_util_concurrent_Callable_Lio_reactivex_functions_BiFunction_, __args);
			} finally {
			}
		}

		static IntPtr id_parallelism;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.parallel']/class[@name='ParallelReduce']/method[@name='parallelism' and count(parameter)=0]"
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
