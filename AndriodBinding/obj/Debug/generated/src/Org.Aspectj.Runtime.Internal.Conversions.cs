using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Runtime.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/Conversions", DoNotGenerateAcw=true)]
	public sealed partial class Conversions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/runtime/internal/Conversions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Conversions); }
		}

		internal Conversions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_booleanObject_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='booleanObject' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("booleanObject", "(Z)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object BooleanObject (bool i)
		{
			if (id_booleanObject_Z == IntPtr.Zero)
				id_booleanObject_Z = JNIEnv.GetStaticMethodID (class_ref, "booleanObject", "(Z)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_booleanObject_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_booleanValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='booleanValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("booleanValue", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool BooleanValue (global::Java.Lang.Object o)
		{
			if (id_booleanValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_booleanValue_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "booleanValue", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_booleanValue_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_byteObject_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='byteObject' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("byteObject", "(B)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ByteObject (sbyte i)
		{
			if (id_byteObject_B == IntPtr.Zero)
				id_byteObject_B = JNIEnv.GetStaticMethodID (class_ref, "byteObject", "(B)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteObject_B, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_byteValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='byteValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("byteValue", "(Ljava/lang/Object;)B", "")]
		public static unsafe sbyte ByteValue (global::Java.Lang.Object o)
		{
			if (id_byteValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_byteValue_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "byteValue", "(Ljava/lang/Object;)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				sbyte __ret = JNIEnv.CallStaticByteMethod  (class_ref, id_byteValue_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_charObject_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='charObject' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("charObject", "(C)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CharObject (char i)
		{
			if (id_charObject_C == IntPtr.Zero)
				id_charObject_C = JNIEnv.GetStaticMethodID (class_ref, "charObject", "(C)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_charObject_C, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_charValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='charValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("charValue", "(Ljava/lang/Object;)C", "")]
		public static unsafe char CharValue (global::Java.Lang.Object o)
		{
			if (id_charValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_charValue_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "charValue", "(Ljava/lang/Object;)C");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				char __ret = JNIEnv.CallStaticCharMethod  (class_ref, id_charValue_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doubleObject_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='doubleObject' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("doubleObject", "(D)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object DoubleObject (double i)
		{
			if (id_doubleObject_D == IntPtr.Zero)
				id_doubleObject_D = JNIEnv.GetStaticMethodID (class_ref, "doubleObject", "(D)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_doubleObject_D, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_doubleValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='doubleValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("doubleValue", "(Ljava/lang/Object;)D", "")]
		public static unsafe double DoubleValue (global::Java.Lang.Object o)
		{
			if (id_doubleValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_doubleValue_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "doubleValue", "(Ljava/lang/Object;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_doubleValue_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_floatObject_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='floatObject' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("floatObject", "(F)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object FloatObject (float i)
		{
			if (id_floatObject_F == IntPtr.Zero)
				id_floatObject_F = JNIEnv.GetStaticMethodID (class_ref, "floatObject", "(F)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_floatObject_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_floatValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='floatValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("floatValue", "(Ljava/lang/Object;)F", "")]
		public static unsafe float FloatValue (global::Java.Lang.Object o)
		{
			if (id_floatValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_floatValue_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "floatValue", "(Ljava/lang/Object;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_floatValue_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_intObject_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='intObject' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("intObject", "(I)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object IntObject (int i)
		{
			if (id_intObject_I == IntPtr.Zero)
				id_intObject_I = JNIEnv.GetStaticMethodID (class_ref, "intObject", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_intObject_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_intValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='intValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("intValue", "(Ljava/lang/Object;)I", "")]
		public static unsafe int IntValue (global::Java.Lang.Object o)
		{
			if (id_intValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_intValue_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "intValue", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_intValue_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_longObject_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='longObject' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("longObject", "(J)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object LongObject (long i)
		{
			if (id_longObject_J == IntPtr.Zero)
				id_longObject_J = JNIEnv.GetStaticMethodID (class_ref, "longObject", "(J)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_longObject_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_longValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='longValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("longValue", "(Ljava/lang/Object;)J", "")]
		public static unsafe long LongValue (global::Java.Lang.Object o)
		{
			if (id_longValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_longValue_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "longValue", "(Ljava/lang/Object;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_longValue_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shortObject_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='shortObject' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("shortObject", "(S)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ShortObject (short i)
		{
			if (id_shortObject_S == IntPtr.Zero)
				id_shortObject_S = JNIEnv.GetStaticMethodID (class_ref, "shortObject", "(S)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_shortObject_S, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_shortValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='shortValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("shortValue", "(Ljava/lang/Object;)S", "")]
		public static unsafe short ShortValue (global::Java.Lang.Object o)
		{
			if (id_shortValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_shortValue_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "shortValue", "(Ljava/lang/Object;)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				short __ret = JNIEnv.CallStaticShortMethod  (class_ref, id_shortValue_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_voidObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='voidObject' and count(parameter)=0]"
		[Register ("voidObject", "()Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object VoidObject ()
		{
			if (id_voidObject == IntPtr.Zero)
				id_voidObject = JNIEnv.GetStaticMethodID (class_ref, "voidObject", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_voidObject), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_voidValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='voidValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("voidValue", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object VoidValue (global::Java.Lang.Object o)
		{
			if (id_voidValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_voidValue_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "voidValue", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_voidValue_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
