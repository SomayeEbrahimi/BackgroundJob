using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ListAddBiConsumer']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/ListAddBiConsumer", DoNotGenerateAcw=true)]
	public sealed partial class ListAddBiConsumer : global::Java.Lang.Enum, global::IO.Reactivex.Functions.IBiFunction {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/ListAddBiConsumer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ListAddBiConsumer); }
		}

		internal ListAddBiConsumer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_apply_Ljava_util_List_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ListAddBiConsumer']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='java.lang.Object']]"
		[Register ("apply", "(Ljava/util/List;Ljava/lang/Object;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.IList Apply (global::System.Collections.IList t1, global::Java.Lang.Object t2)
		{
			if (id_apply_Ljava_util_List_Ljava_lang_Object_ == IntPtr.Zero)
				id_apply_Ljava_util_List_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "apply", "(Ljava/util/List;Ljava/lang/Object;)Ljava/util/List;");
			IntPtr native_t1 = global::Android.Runtime.JavaList.ToLocalJniHandle (t1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_t1);
				__args [1] = new JValue (t2);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Ljava_util_List_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_t1);
			}
		}

		static IntPtr id_instance;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ListAddBiConsumer']/method[@name='instance' and count(parameter)=0]"
		[Register ("instance", "()Lio/reactivex/functions/BiFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IBiFunction Instance ()
		{
			if (id_instance == IntPtr.Zero)
				id_instance = JNIEnv.GetStaticMethodID (class_ref, "instance", "()Lio/reactivex/functions/BiFunction;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_instance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ListAddBiConsumer']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/util/ListAddBiConsumer;", "")]
		public static unsafe global::IO.Reactivex.Internal.Util.ListAddBiConsumer ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/util/ListAddBiConsumer;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::IO.Reactivex.Internal.Util.ListAddBiConsumer __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.ListAddBiConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ListAddBiConsumer']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/reactivex/internal/util/ListAddBiConsumer;", "")]
		public static unsafe global::IO.Reactivex.Internal.Util.ListAddBiConsumer[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/internal/util/ListAddBiConsumer;");
			try {
				return (global::IO.Reactivex.Internal.Util.ListAddBiConsumer[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.Internal.Util.ListAddBiConsumer));
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated IO.Reactivex.Functions.IBiFunction
		global::Java.Lang.Object global::IO.Reactivex.Functions.IBiFunction.Apply (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<JavaList>(native_Apply (global::Java.Interop.JavaObjectExtensions.JavaCast<JavaList>(p0), global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Object>(p1)));
		}

	}
}
