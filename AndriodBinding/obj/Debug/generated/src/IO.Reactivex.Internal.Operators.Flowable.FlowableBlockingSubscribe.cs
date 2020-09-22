using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Flowable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.flowable']/class[@name='FlowableBlockingSubscribe']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/flowable/FlowableBlockingSubscribe", DoNotGenerateAcw=true)]
	public sealed partial class FlowableBlockingSubscribe : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/flowable/FlowableBlockingSubscribe", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlowableBlockingSubscribe); }
		}

		internal FlowableBlockingSubscribe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
