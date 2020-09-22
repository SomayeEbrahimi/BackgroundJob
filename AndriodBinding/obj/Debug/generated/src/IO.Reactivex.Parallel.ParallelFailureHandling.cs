using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Parallel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFailureHandling']"
	[global::Android.Runtime.Register ("io/reactivex/parallel/ParallelFailureHandling", DoNotGenerateAcw=true)]
	public sealed partial class ParallelFailureHandling : global::Java.Lang.Enum, global::IO.Reactivex.Functions.IBiFunction {


		static IntPtr ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFailureHandling']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::IO.Reactivex.Parallel.ParallelFailureHandling Error {
			get {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lio/reactivex/parallel/ParallelFailureHandling;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFailureHandling> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RETRY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFailureHandling']/field[@name='RETRY']"
		[Register ("RETRY")]
		public static global::IO.Reactivex.Parallel.ParallelFailureHandling Retry {
			get {
				if (RETRY_jfieldId == IntPtr.Zero)
					RETRY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RETRY", "Lio/reactivex/parallel/ParallelFailureHandling;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RETRY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFailureHandling> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SKIP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFailureHandling']/field[@name='SKIP']"
		[Register ("SKIP")]
		public static global::IO.Reactivex.Parallel.ParallelFailureHandling Skip {
			get {
				if (SKIP_jfieldId == IntPtr.Zero)
					SKIP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SKIP", "Lio/reactivex/parallel/ParallelFailureHandling;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SKIP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFailureHandling> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STOP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFailureHandling']/field[@name='STOP']"
		[Register ("STOP")]
		public static global::IO.Reactivex.Parallel.ParallelFailureHandling Stop {
			get {
				if (STOP_jfieldId == IntPtr.Zero)
					STOP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOP", "Lio/reactivex/parallel/ParallelFailureHandling;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFailureHandling> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/parallel/ParallelFailureHandling", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParallelFailureHandling); }
		}

		internal ParallelFailureHandling (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_apply_Ljava_lang_Long_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFailureHandling']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("apply", "(Ljava/lang/Long;Ljava/lang/Throwable;)Lio/reactivex/parallel/ParallelFailureHandling;", "")]
		public unsafe global::IO.Reactivex.Parallel.ParallelFailureHandling Apply (global::Java.Lang.Long t1, global::Java.Lang.Throwable t2)
		{
			if (id_apply_Ljava_lang_Long_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_apply_Ljava_lang_Long_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "apply", "(Ljava/lang/Long;Ljava/lang/Throwable;)Lio/reactivex/parallel/ParallelFailureHandling;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (t1);
				__args [1] = new JValue (t2);
				global::IO.Reactivex.Parallel.ParallelFailureHandling __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFailureHandling> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Ljava_lang_Long_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFailureHandling']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/parallel/ParallelFailureHandling;", "")]
		public static unsafe global::IO.Reactivex.Parallel.ParallelFailureHandling ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/parallel/ParallelFailureHandling;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::IO.Reactivex.Parallel.ParallelFailureHandling __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Parallel.ParallelFailureHandling> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.parallel']/class[@name='ParallelFailureHandling']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/reactivex/parallel/ParallelFailureHandling;", "")]
		public static unsafe global::IO.Reactivex.Parallel.ParallelFailureHandling[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/parallel/ParallelFailureHandling;");
			try {
				return (global::IO.Reactivex.Parallel.ParallelFailureHandling[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.Parallel.ParallelFailureHandling));
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated IO.Reactivex.Functions.IBiFunction
		global::Java.Lang.Object global::IO.Reactivex.Functions.IBiFunction.Apply (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Apply (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Long>(p0), global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Throwable>(p1)));
		}

	}
}
