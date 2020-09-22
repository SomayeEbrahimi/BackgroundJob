using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.exceptions']/class[@name='Exceptions']"
	[global::Android.Runtime.Register ("io/reactivex/exceptions/Exceptions", DoNotGenerateAcw=true)]
	public sealed partial class Exceptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/exceptions/Exceptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Exceptions); }
		}

		internal Exceptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_propagate_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.exceptions']/class[@name='Exceptions']/method[@name='propagate' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("propagate", "(Ljava/lang/Throwable;)Ljava/lang/RuntimeException;", "")]
		public static unsafe global::Java.Lang.RuntimeException Propagate (global::Java.Lang.Throwable t)
		{
			if (id_propagate_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_propagate_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "propagate", "(Ljava/lang/Throwable;)Ljava/lang/RuntimeException;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				global::Java.Lang.RuntimeException __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.RuntimeException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_propagate_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throwIfFatal_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.exceptions']/class[@name='Exceptions']/method[@name='throwIfFatal' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("throwIfFatal", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void ThrowIfFatal (global::Java.Lang.Throwable t)
		{
			if (id_throwIfFatal_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_throwIfFatal_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "throwIfFatal", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_throwIfFatal_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

	}
}
