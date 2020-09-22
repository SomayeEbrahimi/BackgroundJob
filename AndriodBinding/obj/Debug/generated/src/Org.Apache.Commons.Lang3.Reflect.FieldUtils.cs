using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/reflect/FieldUtils", DoNotGenerateAcw=true)]
	public partial class FieldUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/reflect/FieldUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FieldUtils); }
		}

		protected FieldUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/constructor[@name='FieldUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FieldUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FieldUtils)) {
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

		static IntPtr id_getAllFields_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='getAllFields' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getAllFields", "(Ljava/lang/Class;)[Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field[] GetAllFields (global::Java.Lang.Class cls)
		{
			if (id_getAllFields_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAllFields_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getAllFields", "(Ljava/lang/Class;)[Ljava/lang/reflect/Field;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				global::Java.Lang.Reflect.Field[] __ret = (global::Java.Lang.Reflect.Field[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllFields_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Field));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAllFieldsList_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='getAllFieldsList' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getAllFieldsList", "(Ljava/lang/Class;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Reflect.Field> GetAllFieldsList (global::Java.Lang.Class cls)
		{
			if (id_getAllFieldsList_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAllFieldsList_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getAllFieldsList", "(Ljava/lang/Class;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				global::System.Collections.Generic.IList<global::Java.Lang.Reflect.Field> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Reflect.Field>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllFieldsList_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='getDeclaredField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDeclaredField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field GetDeclaredField (global::Java.Lang.Class cls, string fieldName)
		{
			if (id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDeclaredField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				global::Java.Lang.Reflect.Field __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='getDeclaredField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getDeclaredField", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field GetDeclaredField (global::Java.Lang.Class cls, string fieldName, bool forceAccess)
		{
			if (id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_Z == IntPtr.Zero)
				id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getDeclaredField", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/reflect/Field;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (forceAccess);
				global::Java.Lang.Reflect.Field __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeclaredField_Ljava_lang_Class_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_getField_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='getField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field GetField (global::Java.Lang.Class cls, string fieldName)
		{
			if (id_getField_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_getField_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				global::Java.Lang.Reflect.Field __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getField_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_getField_Ljava_lang_Class_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='getField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getField", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field GetField (global::Java.Lang.Class cls, string fieldName, bool forceAccess)
		{
			if (id_getField_Ljava_lang_Class_Ljava_lang_String_Z == IntPtr.Zero)
				id_getField_Ljava_lang_Class_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getField", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/reflect/Field;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (forceAccess);
				global::Java.Lang.Reflect.Field __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getField_Ljava_lang_Class_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_getFieldsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='getFieldsListWithAnnotation' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;? extends java.lang.annotation.Annotation&gt;']]"
		[Register ("getFieldsListWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Reflect.Field> GetFieldsListWithAnnotation (global::Java.Lang.Class cls, global::Java.Lang.Class annotationCls)
		{
			if (id_getFieldsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_getFieldsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getFieldsListWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (annotationCls);
				global::System.Collections.Generic.IList<global::Java.Lang.Reflect.Field> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Reflect.Field>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFieldsListWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFieldsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='getFieldsWithAnnotation' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;? extends java.lang.annotation.Annotation&gt;']]"
		[Register ("getFieldsWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;)[Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field[] GetFieldsWithAnnotation (global::Java.Lang.Class cls, global::Java.Lang.Class annotationCls)
		{
			if (id_getFieldsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_getFieldsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getFieldsWithAnnotation", "(Ljava/lang/Class;Ljava/lang/Class;)[Ljava/lang/reflect/Field;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (annotationCls);
				global::Java.Lang.Reflect.Field[] __ret = (global::Java.Lang.Reflect.Field[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFieldsWithAnnotation_Ljava_lang_Class_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Field));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readDeclaredField_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readDeclaredField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("readDeclaredField", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadDeclaredField (global::Java.Lang.Object target, string fieldName)
		{
			if (id_readDeclaredField_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_readDeclaredField_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readDeclaredField", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (target);
				__args [1] = new JValue (native_fieldName);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readDeclaredField_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_readDeclaredField_Ljava_lang_Object_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readDeclaredField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("readDeclaredField", "(Ljava/lang/Object;Ljava/lang/String;Z)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadDeclaredField (global::Java.Lang.Object target, string fieldName, bool forceAccess)
		{
			if (id_readDeclaredField_Ljava_lang_Object_Ljava_lang_String_Z == IntPtr.Zero)
				id_readDeclaredField_Ljava_lang_Object_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "readDeclaredField", "(Ljava/lang/Object;Ljava/lang/String;Z)Ljava/lang/Object;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (target);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (forceAccess);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readDeclaredField_Ljava_lang_Object_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_readDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readDeclaredStaticField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("readDeclaredStaticField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadDeclaredStaticField (global::Java.Lang.Class cls, string fieldName)
		{
			if (id_readDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_readDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readDeclaredStaticField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_readDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readDeclaredStaticField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("readDeclaredStaticField", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadDeclaredStaticField (global::Java.Lang.Class cls, string fieldName, bool forceAccess)
		{
			if (id_readDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Z == IntPtr.Zero)
				id_readDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "readDeclaredStaticField", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/Object;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (forceAccess);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_readField_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("readField", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadField (global::Java.Lang.Object target, string fieldName)
		{
			if (id_readField_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_readField_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readField", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (target);
				__args [1] = new JValue (native_fieldName);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readField_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_readField_Ljava_lang_Object_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("readField", "(Ljava/lang/Object;Ljava/lang/String;Z)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadField (global::Java.Lang.Object target, string fieldName, bool forceAccess)
		{
			if (id_readField_Ljava_lang_Object_Ljava_lang_String_Z == IntPtr.Zero)
				id_readField_Ljava_lang_Object_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "readField", "(Ljava/lang/Object;Ljava/lang/String;Z)Ljava/lang/Object;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (target);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (forceAccess);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readField_Ljava_lang_Object_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_readField_Ljava_lang_reflect_Field_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readField' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='java.lang.Object']]"
		[Register ("readField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadField (global::Java.Lang.Reflect.Field field, global::Java.Lang.Object target)
		{
			if (id_readField_Ljava_lang_reflect_Field_Ljava_lang_Object_ == IntPtr.Zero)
				id_readField_Ljava_lang_reflect_Field_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "readField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (field);
				__args [1] = new JValue (target);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readField_Ljava_lang_reflect_Field_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readField_Ljava_lang_reflect_Field_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readField' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean']]"
		[Register ("readField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;Z)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadField (global::Java.Lang.Reflect.Field field, global::Java.Lang.Object target, bool forceAccess)
		{
			if (id_readField_Ljava_lang_reflect_Field_Ljava_lang_Object_Z == IntPtr.Zero)
				id_readField_Ljava_lang_reflect_Field_Ljava_lang_Object_Z = JNIEnv.GetStaticMethodID (class_ref, "readField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;Z)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (field);
				__args [1] = new JValue (target);
				__args [2] = new JValue (forceAccess);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readField_Ljava_lang_reflect_Field_Ljava_lang_Object_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readStaticField_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readStaticField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("readStaticField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadStaticField (global::Java.Lang.Class cls, string fieldName)
		{
			if (id_readStaticField_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_readStaticField_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readStaticField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readStaticField_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_readStaticField_Ljava_lang_Class_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readStaticField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("readStaticField", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadStaticField (global::Java.Lang.Class cls, string fieldName, bool forceAccess)
		{
			if (id_readStaticField_Ljava_lang_Class_Ljava_lang_String_Z == IntPtr.Zero)
				id_readStaticField_Ljava_lang_Class_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "readStaticField", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/Object;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (forceAccess);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readStaticField_Ljava_lang_Class_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_readStaticField_Ljava_lang_reflect_Field_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readStaticField' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register ("readStaticField", "(Ljava/lang/reflect/Field;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadStaticField (global::Java.Lang.Reflect.Field field)
		{
			if (id_readStaticField_Ljava_lang_reflect_Field_ == IntPtr.Zero)
				id_readStaticField_Ljava_lang_reflect_Field_ = JNIEnv.GetStaticMethodID (class_ref, "readStaticField", "(Ljava/lang/reflect/Field;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (field);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readStaticField_Ljava_lang_reflect_Field_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readStaticField_Ljava_lang_reflect_Field_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='readStaticField' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='boolean']]"
		[Register ("readStaticField", "(Ljava/lang/reflect/Field;Z)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ReadStaticField (global::Java.Lang.Reflect.Field field, bool forceAccess)
		{
			if (id_readStaticField_Ljava_lang_reflect_Field_Z == IntPtr.Zero)
				id_readStaticField_Ljava_lang_reflect_Field_Z = JNIEnv.GetStaticMethodID (class_ref, "readStaticField", "(Ljava/lang/reflect/Field;Z)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (field);
				__args [1] = new JValue (forceAccess);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readStaticField_Ljava_lang_reflect_Field_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_removeFinalModifier_Ljava_lang_reflect_Field_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='removeFinalModifier' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register ("removeFinalModifier", "(Ljava/lang/reflect/Field;)V", "")]
		public static unsafe void RemoveFinalModifier (global::Java.Lang.Reflect.Field field)
		{
			if (id_removeFinalModifier_Ljava_lang_reflect_Field_ == IntPtr.Zero)
				id_removeFinalModifier_Ljava_lang_reflect_Field_ = JNIEnv.GetStaticMethodID (class_ref, "removeFinalModifier", "(Ljava/lang/reflect/Field;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (field);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeFinalModifier_Ljava_lang_reflect_Field_, __args);
			} finally {
			}
		}

		static IntPtr id_removeFinalModifier_Ljava_lang_reflect_Field_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='removeFinalModifier' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='boolean']]"
		[Register ("removeFinalModifier", "(Ljava/lang/reflect/Field;Z)V", "")]
		public static unsafe void RemoveFinalModifier (global::Java.Lang.Reflect.Field field, bool forceAccess)
		{
			if (id_removeFinalModifier_Ljava_lang_reflect_Field_Z == IntPtr.Zero)
				id_removeFinalModifier_Ljava_lang_reflect_Field_Z = JNIEnv.GetStaticMethodID (class_ref, "removeFinalModifier", "(Ljava/lang/reflect/Field;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (field);
				__args [1] = new JValue (forceAccess);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeFinalModifier_Ljava_lang_reflect_Field_Z, __args);
			} finally {
			}
		}

		static IntPtr id_writeDeclaredField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeDeclaredField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("writeDeclaredField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void WriteDeclaredField (global::Java.Lang.Object target, string fieldName, global::Java.Lang.Object value)
		{
			if (id_writeDeclaredField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_writeDeclaredField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "writeDeclaredField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (target);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeDeclaredField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_writeDeclaredField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeDeclaredField' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='boolean']]"
		[Register ("writeDeclaredField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Z)V", "")]
		public static unsafe void WriteDeclaredField (global::Java.Lang.Object target, string fieldName, global::Java.Lang.Object value, bool forceAccess)
		{
			if (id_writeDeclaredField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Z == IntPtr.Zero)
				id_writeDeclaredField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Z = JNIEnv.GetStaticMethodID (class_ref, "writeDeclaredField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Z)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (target);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);
				__args [3] = new JValue (forceAccess);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeDeclaredField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_writeDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeDeclaredStaticField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("writeDeclaredStaticField", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void WriteDeclaredStaticField (global::Java.Lang.Class cls, string fieldName, global::Java.Lang.Object value)
		{
			if (id_writeDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_writeDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "writeDeclaredStaticField", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_writeDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeDeclaredStaticField' and count(parameter)=4 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='boolean']]"
		[Register ("writeDeclaredStaticField", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;Z)V", "")]
		public static unsafe void WriteDeclaredStaticField (global::Java.Lang.Class cls, string fieldName, global::Java.Lang.Object value, bool forceAccess)
		{
			if (id_writeDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_Z == IntPtr.Zero)
				id_writeDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_Z = JNIEnv.GetStaticMethodID (class_ref, "writeDeclaredStaticField", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;Z)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);
				__args [3] = new JValue (forceAccess);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeDeclaredStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_writeField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("writeField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void WriteField (global::Java.Lang.Object target, string fieldName, global::Java.Lang.Object value)
		{
			if (id_writeField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_writeField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "writeField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (target);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_writeField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeField' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='boolean']]"
		[Register ("writeField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Z)V", "")]
		public static unsafe void WriteField (global::Java.Lang.Object target, string fieldName, global::Java.Lang.Object value, bool forceAccess)
		{
			if (id_writeField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Z == IntPtr.Zero)
				id_writeField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Z = JNIEnv.GetStaticMethodID (class_ref, "writeField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Z)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (target);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);
				__args [3] = new JValue (forceAccess);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeField_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_writeField_Ljava_lang_reflect_Field_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeField' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("writeField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void WriteField (global::Java.Lang.Reflect.Field field, global::Java.Lang.Object target, global::Java.Lang.Object value)
		{
			if (id_writeField_Ljava_lang_reflect_Field_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_writeField_Ljava_lang_reflect_Field_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "writeField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (field);
				__args [1] = new JValue (target);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeField_Ljava_lang_reflect_Field_Ljava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_writeField_Ljava_lang_reflect_Field_Ljava_lang_Object_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeField' and count(parameter)=4 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='boolean']]"
		[Register ("writeField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;Ljava/lang/Object;Z)V", "")]
		public static unsafe void WriteField (global::Java.Lang.Reflect.Field field, global::Java.Lang.Object target, global::Java.Lang.Object value, bool forceAccess)
		{
			if (id_writeField_Ljava_lang_reflect_Field_Ljava_lang_Object_Ljava_lang_Object_Z == IntPtr.Zero)
				id_writeField_Ljava_lang_reflect_Field_Ljava_lang_Object_Ljava_lang_Object_Z = JNIEnv.GetStaticMethodID (class_ref, "writeField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;Ljava/lang/Object;Z)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (field);
				__args [1] = new JValue (target);
				__args [2] = new JValue (value);
				__args [3] = new JValue (forceAccess);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeField_Ljava_lang_reflect_Field_Ljava_lang_Object_Ljava_lang_Object_Z, __args);
			} finally {
			}
		}

		static IntPtr id_writeStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeStaticField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("writeStaticField", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void WriteStaticField (global::Java.Lang.Class cls, string fieldName, global::Java.Lang.Object value)
		{
			if (id_writeStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_writeStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "writeStaticField", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_writeStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeStaticField' and count(parameter)=4 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='boolean']]"
		[Register ("writeStaticField", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;Z)V", "")]
		public static unsafe void WriteStaticField (global::Java.Lang.Class cls, string fieldName, global::Java.Lang.Object value, bool forceAccess)
		{
			if (id_writeStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_Z == IntPtr.Zero)
				id_writeStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_Z = JNIEnv.GetStaticMethodID (class_ref, "writeStaticField", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;Z)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);
				__args [3] = new JValue (forceAccess);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeStaticField_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_Object_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static IntPtr id_writeStaticField_Ljava_lang_reflect_Field_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeStaticField' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='java.lang.Object']]"
		[Register ("writeStaticField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;)V", "")]
		public static unsafe void WriteStaticField (global::Java.Lang.Reflect.Field field, global::Java.Lang.Object value)
		{
			if (id_writeStaticField_Ljava_lang_reflect_Field_Ljava_lang_Object_ == IntPtr.Zero)
				id_writeStaticField_Ljava_lang_reflect_Field_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "writeStaticField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (field);
				__args [1] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeStaticField_Ljava_lang_reflect_Field_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_writeStaticField_Ljava_lang_reflect_Field_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='FieldUtils']/method[@name='writeStaticField' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean']]"
		[Register ("writeStaticField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;Z)V", "")]
		public static unsafe void WriteStaticField (global::Java.Lang.Reflect.Field field, global::Java.Lang.Object value, bool forceAccess)
		{
			if (id_writeStaticField_Ljava_lang_reflect_Field_Ljava_lang_Object_Z == IntPtr.Zero)
				id_writeStaticField_Ljava_lang_reflect_Field_Ljava_lang_Object_Z = JNIEnv.GetStaticMethodID (class_ref, "writeStaticField", "(Ljava/lang/reflect/Field;Ljava/lang/Object;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (field);
				__args [1] = new JValue (value);
				__args [2] = new JValue (forceAccess);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeStaticField_Ljava_lang_reflect_Field_Ljava_lang_Object_Z, __args);
			} finally {
			}
		}

	}
}
