using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='HashMapSupplier']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/HashMapSupplier", DoNotGenerateAcw=true)]
	public sealed partial class HashMapSupplier : global::Java.Lang.Enum, global::Java.Util.Concurrent.ICallable {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='HashMapSupplier']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::IO.Reactivex.Internal.Util.HashMapSupplier Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lio/reactivex/internal/util/HashMapSupplier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.HashMapSupplier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/HashMapSupplier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HashMapSupplier); }
		}

		internal HashMapSupplier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_asCallable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='HashMapSupplier']/method[@name='asCallable' and count(parameter)=0]"
		[Register ("asCallable", "()Ljava/util/concurrent/Callable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe global::Java.Util.Concurrent.ICallable AsCallable ()
		{
			if (id_asCallable == IntPtr.Zero)
				id_asCallable = JNIEnv.GetStaticMethodID (class_ref, "asCallable", "()Ljava/util/concurrent/Callable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asCallable), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_call;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='HashMapSupplier']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<global::Java.Lang.Object, global::Java.Lang.Object> Call ()
		{
			if (id_call == IntPtr.Zero)
				id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/util/Map;");
			try {
				return global::Android.Runtime.JavaDictionary<global::Java.Lang.Object, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='HashMapSupplier']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/util/HashMapSupplier;", "")]
		public static unsafe global::IO.Reactivex.Internal.Util.HashMapSupplier ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/util/HashMapSupplier;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::IO.Reactivex.Internal.Util.HashMapSupplier __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.HashMapSupplier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='HashMapSupplier']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/reactivex/internal/util/HashMapSupplier;", "")]
		public static unsafe global::IO.Reactivex.Internal.Util.HashMapSupplier[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/internal/util/HashMapSupplier;");
			try {
				return (global::IO.Reactivex.Internal.Util.HashMapSupplier[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.Internal.Util.HashMapSupplier));
			} finally {
			}
		}

	}
}
