using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Parallel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.parallel']/class[@name='ParallelRunOn']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/parallel/ParallelRunOn", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ParallelRunOn : global::IO.Reactivex.Parallel.ParallelFlowable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/parallel/ParallelRunOn", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParallelRunOn); }
		}

		internal ParallelRunOn (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_parallel_ParallelFlowable_Lio_reactivex_Scheduler_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.parallel']/class[@name='ParallelRunOn']/constructor[@name='ParallelRunOn' and count(parameter)=3 and parameter[1][@type='io.reactivex.parallel.ParallelFlowable&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.Scheduler'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lio/reactivex/parallel/ParallelFlowable;Lio/reactivex/Scheduler;I)V", "")]
		public unsafe ParallelRunOn (global::IO.Reactivex.Parallel.ParallelFlowable parent, global::IO.Reactivex.Scheduler scheduler, int prefetch)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (parent);
				__args [1] = new JValue (scheduler);
				__args [2] = new JValue (prefetch);
				if (((object) this).GetType () != typeof (ParallelRunOn)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/parallel/ParallelFlowable;Lio/reactivex/Scheduler;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/parallel/ParallelFlowable;Lio/reactivex/Scheduler;I)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_parallel_ParallelFlowable_Lio_reactivex_Scheduler_I == IntPtr.Zero)
					id_ctor_Lio_reactivex_parallel_ParallelFlowable_Lio_reactivex_Scheduler_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/parallel/ParallelFlowable;Lio/reactivex/Scheduler;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_parallel_ParallelFlowable_Lio_reactivex_Scheduler_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_parallel_ParallelFlowable_Lio_reactivex_Scheduler_I, __args);
			} finally {
			}
		}

		static IntPtr id_parallelism;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.parallel']/class[@name='ParallelRunOn']/method[@name='parallelism' and count(parameter)=0]"
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
