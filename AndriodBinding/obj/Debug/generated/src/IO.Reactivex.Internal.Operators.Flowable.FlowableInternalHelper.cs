using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Flowable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.flowable']/class[@name='FlowableInternalHelper']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/flowable/FlowableInternalHelper", DoNotGenerateAcw=true)]
	public sealed partial class FlowableInternalHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/flowable/FlowableInternalHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlowableInternalHelper); }
		}

		internal FlowableInternalHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_simpleBiGenerator_Lio_reactivex_functions_BiConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.flowable']/class[@name='FlowableInternalHelper']/method[@name='simpleBiGenerator' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiConsumer&lt;S, io.reactivex.Emitter&lt;T&gt;&gt;']]"
		[Register ("simpleBiGenerator", "(Lio/reactivex/functions/BiConsumer;)Lio/reactivex/functions/BiFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "S"})]
		public static unsafe global::IO.Reactivex.Functions.IBiFunction SimpleBiGenerator (global::IO.Reactivex.Functions.IBiConsumer consumer)
		{
			if (id_simpleBiGenerator_Lio_reactivex_functions_BiConsumer_ == IntPtr.Zero)
				id_simpleBiGenerator_Lio_reactivex_functions_BiConsumer_ = JNIEnv.GetStaticMethodID (class_ref, "simpleBiGenerator", "(Lio/reactivex/functions/BiConsumer;)Lio/reactivex/functions/BiFunction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (consumer);
				global::IO.Reactivex.Functions.IBiFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_simpleBiGenerator_Lio_reactivex_functions_BiConsumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_simpleGenerator_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.flowable']/class[@name='FlowableInternalHelper']/method[@name='simpleGenerator' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;io.reactivex.Emitter&lt;T&gt;&gt;']]"
		[Register ("simpleGenerator", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/functions/BiFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "S"})]
		public static unsafe global::IO.Reactivex.Functions.IBiFunction SimpleGenerator (global::IO.Reactivex.Functions.IConsumer consumer)
		{
			if (id_simpleGenerator_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_simpleGenerator_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "simpleGenerator", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/functions/BiFunction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (consumer);
				global::IO.Reactivex.Functions.IBiFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_simpleGenerator_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
