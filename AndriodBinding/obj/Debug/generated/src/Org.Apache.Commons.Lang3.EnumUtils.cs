using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/EnumUtils", DoNotGenerateAcw=true)]
	public partial class EnumUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/EnumUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EnumUtils); }
		}

		protected EnumUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/constructor[@name='EnumUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EnumUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EnumUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_generateBitVector_Ljava_lang_Class_arrayLjava_lang_Enum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='generateBitVector' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;E&gt;'] and parameter[2][@type='E...']]"
		[Register ("generateBitVector", "(Ljava/lang/Class;[Ljava/lang/Enum;)J", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe long GenerateBitVector (global::Java.Lang.Class enumClass, params global::Java.Lang.Object[] values)
		{
			if (id_generateBitVector_Ljava_lang_Class_arrayLjava_lang_Enum_ == IntPtr.Zero)
				id_generateBitVector_Ljava_lang_Class_arrayLjava_lang_Enum_ = JNIEnv.GetStaticMethodID (class_ref, "generateBitVector", "(Ljava/lang/Class;[Ljava/lang/Enum;)J");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (enumClass);
				__args [1] = new JValue (native_values);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_generateBitVector_Ljava_lang_Class_arrayLjava_lang_Enum_, __args);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_generateBitVector_Ljava_lang_Class_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='generateBitVector' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;E&gt;'] and parameter[2][@type='java.lang.Iterable&lt;? extends E&gt;']]"
		[Register ("generateBitVector", "(Ljava/lang/Class;Ljava/lang/Iterable;)J", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe long GenerateBitVector (global::Java.Lang.Class enumClass, global::Java.Lang.IIterable values)
		{
			if (id_generateBitVector_Ljava_lang_Class_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_generateBitVector_Ljava_lang_Class_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "generateBitVector", "(Ljava/lang/Class;Ljava/lang/Iterable;)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (enumClass);
				__args [1] = new JValue (values);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_generateBitVector_Ljava_lang_Class_Ljava_lang_Iterable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_generateBitVectors_Ljava_lang_Class_arrayLjava_lang_Enum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='generateBitVectors' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;E&gt;'] and parameter[2][@type='E...']]"
		[Register ("generateBitVectors", "(Ljava/lang/Class;[Ljava/lang/Enum;)[J", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe long[] GenerateBitVectors (global::Java.Lang.Class enumClass, params global::Java.Lang.Object[] values)
		{
			if (id_generateBitVectors_Ljava_lang_Class_arrayLjava_lang_Enum_ == IntPtr.Zero)
				id_generateBitVectors_Ljava_lang_Class_arrayLjava_lang_Enum_ = JNIEnv.GetStaticMethodID (class_ref, "generateBitVectors", "(Ljava/lang/Class;[Ljava/lang/Enum;)[J");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (enumClass);
				__args [1] = new JValue (native_values);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateBitVectors_Ljava_lang_Class_arrayLjava_lang_Enum_, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_generateBitVectors_Ljava_lang_Class_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='generateBitVectors' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;E&gt;'] and parameter[2][@type='java.lang.Iterable&lt;? extends E&gt;']]"
		[Register ("generateBitVectors", "(Ljava/lang/Class;Ljava/lang/Iterable;)[J", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe long[] GenerateBitVectors (global::Java.Lang.Class enumClass, global::Java.Lang.IIterable values)
		{
			if (id_generateBitVectors_Ljava_lang_Class_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_generateBitVectors_Ljava_lang_Class_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "generateBitVectors", "(Ljava/lang/Class;Ljava/lang/Iterable;)[J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (enumClass);
				__args [1] = new JValue (values);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateBitVectors_Ljava_lang_Class_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getEnum_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='getEnum' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;E&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getEnum", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe global::Java.Lang.Object GetEnum (global::Java.Lang.Class enumClass, string enumName)
		{
			if (id_getEnum_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_getEnum_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getEnum", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;");
			IntPtr native_enumName = JNIEnv.NewString (enumName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (enumClass);
				__args [1] = new JValue (native_enumName);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEnum_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_enumName);
			}
		}

		static IntPtr id_getEnumIgnoreCase_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='getEnumIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;E&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getEnumIgnoreCase", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe global::Java.Lang.Object GetEnumIgnoreCase (global::Java.Lang.Class enumClass, string enumName)
		{
			if (id_getEnumIgnoreCase_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_getEnumIgnoreCase_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getEnumIgnoreCase", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;");
			IntPtr native_enumName = JNIEnv.NewString (enumName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (enumClass);
				__args [1] = new JValue (native_enumName);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEnumIgnoreCase_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_enumName);
			}
		}

		static IntPtr id_getEnumList_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='getEnumList' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;E&gt;']]"
		[Register ("getEnumList", "(Ljava/lang/Class;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe global::System.Collections.IList GetEnumList (global::Java.Lang.Class enumClass)
		{
			if (id_getEnumList_Ljava_lang_Class_ == IntPtr.Zero)
				id_getEnumList_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getEnumList", "(Ljava/lang/Class;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (enumClass);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEnumList_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getEnumMap_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='getEnumMap' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;E&gt;']]"
		[Register ("getEnumMap", "(Ljava/lang/Class;)Ljava/util/Map;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe global::System.Collections.IDictionary GetEnumMap (global::Java.Lang.Class enumClass)
		{
			if (id_getEnumMap_Ljava_lang_Class_ == IntPtr.Zero)
				id_getEnumMap_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getEnumMap", "(Ljava/lang/Class;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (enumClass);
				global::System.Collections.IDictionary __ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEnumMap_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isValidEnum_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='isValidEnum' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;E&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("isValidEnum", "(Ljava/lang/Class;Ljava/lang/String;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe bool IsValidEnum (global::Java.Lang.Class enumClass, string enumName)
		{
			if (id_isValidEnum_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_isValidEnum_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isValidEnum", "(Ljava/lang/Class;Ljava/lang/String;)Z");
			IntPtr native_enumName = JNIEnv.NewString (enumName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (enumClass);
				__args [1] = new JValue (native_enumName);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isValidEnum_Ljava_lang_Class_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_enumName);
			}
		}

		static IntPtr id_isValidEnumIgnoreCase_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='isValidEnumIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;E&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("isValidEnumIgnoreCase", "(Ljava/lang/Class;Ljava/lang/String;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe bool IsValidEnumIgnoreCase (global::Java.Lang.Class enumClass, string enumName)
		{
			if (id_isValidEnumIgnoreCase_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_isValidEnumIgnoreCase_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isValidEnumIgnoreCase", "(Ljava/lang/Class;Ljava/lang/String;)Z");
			IntPtr native_enumName = JNIEnv.NewString (enumName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (enumClass);
				__args [1] = new JValue (native_enumName);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isValidEnumIgnoreCase_Ljava_lang_Class_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_enumName);
			}
		}

		static IntPtr id_processBitVector_Ljava_lang_Class_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='processBitVector' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;E&gt;'] and parameter[2][@type='long']]"
		[Register ("processBitVector", "(Ljava/lang/Class;J)Ljava/util/EnumSet;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe global::Java.Util.EnumSet ProcessBitVector (global::Java.Lang.Class enumClass, long value)
		{
			if (id_processBitVector_Ljava_lang_Class_J == IntPtr.Zero)
				id_processBitVector_Ljava_lang_Class_J = JNIEnv.GetStaticMethodID (class_ref, "processBitVector", "(Ljava/lang/Class;J)Ljava/util/EnumSet;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (enumClass);
				__args [1] = new JValue (value);
				global::Java.Util.EnumSet __ret = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_processBitVector_Ljava_lang_Class_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_processBitVectors_Ljava_lang_Class_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='EnumUtils']/method[@name='processBitVectors' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;E&gt;'] and parameter[2][@type='long...']]"
		[Register ("processBitVectors", "(Ljava/lang/Class;[J)Ljava/util/EnumSet;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Enum<E>"})]
		public static unsafe global::Java.Util.EnumSet ProcessBitVectors (global::Java.Lang.Class enumClass, params long[] values)
		{
			if (id_processBitVectors_Ljava_lang_Class_arrayJ == IntPtr.Zero)
				id_processBitVectors_Ljava_lang_Class_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "processBitVectors", "(Ljava/lang/Class;[J)Ljava/util/EnumSet;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (enumClass);
				__args [1] = new JValue (native_values);
				global::Java.Util.EnumSet __ret = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_processBitVectors_Ljava_lang_Class_arrayJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

	}
}
