using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ArrayListSupplier']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/ArrayListSupplier", DoNotGenerateAcw=true)]
	public sealed partial class ArrayListSupplier : global::Java.Lang.Enum, global::IO.Reactivex.Functions.IFunction, global::Java.Util.Concurrent.ICallable {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ArrayListSupplier']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::IO.Reactivex.Internal.Util.ArrayListSupplier Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lio/reactivex/internal/util/ArrayListSupplier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.ArrayListSupplier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/ArrayListSupplier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayListSupplier); }
		}

		internal ArrayListSupplier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_apply_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ArrayListSupplier']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("apply", "(Ljava/lang/Object;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Object> Apply (global::Java.Lang.Object o)
		{
			if (id_apply_Ljava_lang_Object_ == IntPtr.Zero)
				id_apply_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "apply", "(Ljava/lang/Object;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::System.Collections.Generic.IList<global::Java.Lang.Object> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_asCallable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ArrayListSupplier']/method[@name='asCallable' and count(parameter)=0]"
		[Register ("asCallable", "()Ljava/util/concurrent/Callable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.Concurrent.ICallable AsCallable ()
		{
			if (id_asCallable == IntPtr.Zero)
				id_asCallable = JNIEnv.GetStaticMethodID (class_ref, "asCallable", "()Ljava/util/concurrent/Callable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asCallable), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_asFunction;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ArrayListSupplier']/method[@name='asFunction' and count(parameter)=0]"
		[Register ("asFunction", "()Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "O"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction AsFunction ()
		{
			if (id_asFunction == IntPtr.Zero)
				id_asFunction = JNIEnv.GetStaticMethodID (class_ref, "asFunction", "()Lio/reactivex/functions/Function;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asFunction), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_call;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ArrayListSupplier']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Object> Call ()
		{
			if (id_call == IntPtr.Zero)
				id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ArrayListSupplier']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/util/ArrayListSupplier;", "")]
		public static unsafe global::IO.Reactivex.Internal.Util.ArrayListSupplier ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/util/ArrayListSupplier;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::IO.Reactivex.Internal.Util.ArrayListSupplier __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.ArrayListSupplier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ArrayListSupplier']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/reactivex/internal/util/ArrayListSupplier;", "")]
		public static unsafe global::IO.Reactivex.Internal.Util.ArrayListSupplier[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/internal/util/ArrayListSupplier;");
			try {
				return (global::IO.Reactivex.Internal.Util.ArrayListSupplier[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.Internal.Util.ArrayListSupplier));
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated IO.Reactivex.Functions.IFunction
		global::Java.Lang.Object global::IO.Reactivex.Functions.IFunction.Apply (global::Java.Lang.Object p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Apply (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Object>(p0)));
		}

	}
}
