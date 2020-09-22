using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Single {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleInternalHelper']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/single/SingleInternalHelper", DoNotGenerateAcw=true)]
	public sealed partial class SingleInternalHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/single/SingleInternalHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleInternalHelper); }
		}

		internal SingleInternalHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_emptyThrower;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleInternalHelper']/method[@name='emptyThrower' and count(parameter)=0]"
		[Register ("emptyThrower", "()Ljava/util/concurrent/Callable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.Concurrent.ICallable EmptyThrower ()
		{
			if (id_emptyThrower == IntPtr.Zero)
				id_emptyThrower = JNIEnv.GetStaticMethodID (class_ref, "emptyThrower", "()Ljava/util/concurrent/Callable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_emptyThrower), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toObservable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleInternalHelper']/method[@name='toObservable' and count(parameter)=0]"
		[Register ("toObservable", "()Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ToObservable ()
		{
			if (id_toObservable == IntPtr.Zero)
				id_toObservable = JNIEnv.GetStaticMethodID (class_ref, "toObservable", "()Lio/reactivex/functions/Function;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toObservable), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
