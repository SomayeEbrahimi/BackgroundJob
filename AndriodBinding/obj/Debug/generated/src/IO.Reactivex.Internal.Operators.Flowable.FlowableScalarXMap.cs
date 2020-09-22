using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Flowable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.flowable']/class[@name='FlowableScalarXMap']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/flowable/FlowableScalarXMap", DoNotGenerateAcw=true)]
	public sealed partial class FlowableScalarXMap : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/flowable/FlowableScalarXMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlowableScalarXMap); }
		}

		internal FlowableScalarXMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
