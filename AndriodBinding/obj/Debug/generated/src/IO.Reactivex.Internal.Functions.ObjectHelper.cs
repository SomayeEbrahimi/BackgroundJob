using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Functions {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='ObjectHelper']"
	[global::Android.Runtime.Register ("io/reactivex/internal/functions/ObjectHelper", DoNotGenerateAcw=true)]
	public sealed partial class ObjectHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/functions/ObjectHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectHelper); }
		}

		internal ObjectHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_compare_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='ObjectHelper']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("compare", "(II)I", "")]
		public static unsafe int Compare (int v1, int v2)
		{
			if (id_compare_II == IntPtr.Zero)
				id_compare_II = JNIEnv.GetStaticMethodID (class_ref, "compare", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (v1);
				__args [1] = new JValue (v2);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compare_II, __args);
			} finally {
			}
		}

		static IntPtr id_compare_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='ObjectHelper']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("compare", "(JJ)I", "")]
		public static unsafe int Compare (long v1, long v2)
		{
			if (id_compare_JJ == IntPtr.Zero)
				id_compare_JJ = JNIEnv.GetStaticMethodID (class_ref, "compare", "(JJ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (v1);
				__args [1] = new JValue (v2);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compare_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='ObjectHelper']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool Equals (global::Java.Lang.Object o1, global::Java.Lang.Object o2)
		{
			if (id_equals_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (o1);
				__args [1] = new JValue (o2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_Ljava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_equalsPredicate;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='ObjectHelper']/method[@name='equalsPredicate' and count(parameter)=0]"
		[Register ("equalsPredicate", "()Lio/reactivex/functions/BiPredicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IBiPredicate EqualsPredicate ()
		{
			if (id_equalsPredicate == IntPtr.Zero)
				id_equalsPredicate = JNIEnv.GetStaticMethodID (class_ref, "equalsPredicate", "()Lio/reactivex/functions/BiPredicate;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiPredicate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_equalsPredicate), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_hashCode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='ObjectHelper']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("hashCode", "(Ljava/lang/Object;)I", "")]
		public static unsafe int HashCode (global::Java.Lang.Object o)
		{
			if (id_hashCode_Ljava_lang_Object_ == IntPtr.Zero)
				id_hashCode_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_requireNonNull_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='ObjectHelper']/method[@name='requireNonNull' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("requireNonNull", "(JLjava/lang/String;)J", "")]
		public static unsafe long RequireNonNull (long value, string message)
		{
			if (id_requireNonNull_JLjava_lang_String_ == IntPtr.Zero)
				id_requireNonNull_JLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "requireNonNull", "(JLjava/lang/String;)J");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (value);
				__args [1] = new JValue (native_message);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_requireNonNull_JLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_requireNonNull_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='ObjectHelper']/method[@name='requireNonNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String']]"
		[Register ("requireNonNull", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object RequireNonNull (global::Java.Lang.Object @object, string message)
		{
			if (id_requireNonNull_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_requireNonNull_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "requireNonNull", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__object);
				__args [1] = new JValue (native_message);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_requireNonNull_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_verifyPositive_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='ObjectHelper']/method[@name='verifyPositive' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("verifyPositive", "(ILjava/lang/String;)I", "")]
		public static unsafe int VerifyPositive (int value, string paramName)
		{
			if (id_verifyPositive_ILjava_lang_String_ == IntPtr.Zero)
				id_verifyPositive_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "verifyPositive", "(ILjava/lang/String;)I");
			IntPtr native_paramName = JNIEnv.NewString (paramName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (value);
				__args [1] = new JValue (native_paramName);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_verifyPositive_ILjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_paramName);
			}
		}

		static IntPtr id_verifyPositive_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='ObjectHelper']/method[@name='verifyPositive' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("verifyPositive", "(JLjava/lang/String;)J", "")]
		public static unsafe long VerifyPositive (long value, string paramName)
		{
			if (id_verifyPositive_JLjava_lang_String_ == IntPtr.Zero)
				id_verifyPositive_JLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "verifyPositive", "(JLjava/lang/String;)J");
			IntPtr native_paramName = JNIEnv.NewString (paramName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (value);
				__args [1] = new JValue (native_paramName);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_verifyPositive_JLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_paramName);
			}
		}

	}
}
