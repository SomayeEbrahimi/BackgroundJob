using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='Pow2']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/Pow2", DoNotGenerateAcw=true)]
	public sealed partial class Pow2 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/Pow2", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Pow2); }
		}

		internal Pow2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isPowerOfTwo_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='Pow2']/method[@name='isPowerOfTwo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPowerOfTwo", "(I)Z", "")]
		public static unsafe bool IsPowerOfTwo (int value)
		{
			if (id_isPowerOfTwo_I == IntPtr.Zero)
				id_isPowerOfTwo_I = JNIEnv.GetStaticMethodID (class_ref, "isPowerOfTwo", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPowerOfTwo_I, __args);
			} finally {
			}
		}

		static IntPtr id_roundToPowerOfTwo_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='Pow2']/method[@name='roundToPowerOfTwo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("roundToPowerOfTwo", "(I)I", "")]
		public static unsafe int RoundToPowerOfTwo (int value)
		{
			if (id_roundToPowerOfTwo_I == IntPtr.Zero)
				id_roundToPowerOfTwo_I = JNIEnv.GetStaticMethodID (class_ref, "roundToPowerOfTwo", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_roundToPowerOfTwo_I, __args);
			} finally {
			}
		}

	}
}
