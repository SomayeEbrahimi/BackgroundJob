using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Parallel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.parallel']/class[@name='ParallelPeek']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/parallel/ParallelPeek", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ParallelPeek : global::IO.Reactivex.Parallel.ParallelFlowable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/parallel/ParallelPeek", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParallelPeek); }
		}

		internal ParallelPeek (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_parallelism;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.parallel']/class[@name='ParallelPeek']/method[@name='parallelism' and count(parameter)=0]"
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
