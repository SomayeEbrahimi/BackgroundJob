using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/ClassUtils", DoNotGenerateAcw=true)]
	public partial class ClassUtils : global::Java.Lang.Object {


		static IntPtr INNER_CLASS_SEPARATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/field[@name='INNER_CLASS_SEPARATOR']"
		[Register ("INNER_CLASS_SEPARATOR")]
		public static string InnerClassSeparator {
			get {
				if (INNER_CLASS_SEPARATOR_jfieldId == IntPtr.Zero)
					INNER_CLASS_SEPARATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INNER_CLASS_SEPARATOR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INNER_CLASS_SEPARATOR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/field[@name='INNER_CLASS_SEPARATOR_CHAR']"
		[Register ("INNER_CLASS_SEPARATOR_CHAR")]
		public const char InnerClassSeparatorChar = (char) (char)36;

		static IntPtr PACKAGE_SEPARATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/field[@name='PACKAGE_SEPARATOR']"
		[Register ("PACKAGE_SEPARATOR")]
		public static string PackageSeparator {
			get {
				if (PACKAGE_SEPARATOR_jfieldId == IntPtr.Zero)
					PACKAGE_SEPARATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PACKAGE_SEPARATOR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PACKAGE_SEPARATOR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/field[@name='PACKAGE_SEPARATOR_CHAR']"
		[Register ("PACKAGE_SEPARATOR_CHAR")]
		public const char PackageSeparatorChar = (char) (char)46;
		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils.Interfaces']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/ClassUtils$Interfaces", DoNotGenerateAcw=true)]
		public sealed partial class Interfaces : global::Java.Lang.Enum {


			static IntPtr EXCLUDE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils.Interfaces']/field[@name='EXCLUDE']"
			[Register ("EXCLUDE")]
			public static global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces Exclude {
				get {
					if (EXCLUDE_jfieldId == IntPtr.Zero)
						EXCLUDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXCLUDE", "Lorg/apache/commons/lang3/ClassUtils$Interfaces;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXCLUDE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INCLUDE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils.Interfaces']/field[@name='INCLUDE']"
			[Register ("INCLUDE")]
			public static global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces Include {
				get {
					if (INCLUDE_jfieldId == IntPtr.Zero)
						INCLUDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INCLUDE", "Lorg/apache/commons/lang3/ClassUtils$Interfaces;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INCLUDE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/ClassUtils$Interfaces", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Interfaces); }
			}

			internal Interfaces (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils.Interfaces']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/apache/commons/lang3/ClassUtils$Interfaces;", "")]
			public static unsafe global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/apache/commons/lang3/ClassUtils$Interfaces;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils.Interfaces']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/apache/commons/lang3/ClassUtils$Interfaces;", "")]
			public static unsafe global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/apache/commons/lang3/ClassUtils$Interfaces;");
				try {
					return (global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/ClassUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClassUtils); }
		}

		protected ClassUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/constructor[@name='ClassUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClassUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ClassUtils)) {
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

		static IntPtr id_convertClassNamesToClasses_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='convertClassNamesToClasses' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("convertClassNamesToClasses", "(Ljava/util/List;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Class> ConvertClassNamesToClasses (global::System.Collections.Generic.IList<string> classNames)
		{
			if (id_convertClassNamesToClasses_Ljava_util_List_ == IntPtr.Zero)
				id_convertClassNamesToClasses_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "convertClassNamesToClasses", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_classNames = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (classNames);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_classNames);
				global::System.Collections.Generic.IList<global::Java.Lang.Class> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Class>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertClassNamesToClasses_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_classNames);
			}
		}

		static IntPtr id_convertClassesToClassNames_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='convertClassesToClassNames' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Class&lt;?&gt;&gt;']]"
		[Register ("convertClassesToClassNames", "(Ljava/util/List;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> ConvertClassesToClassNames (global::System.Collections.Generic.IList<global::Java.Lang.Class> classes)
		{
			if (id_convertClassesToClassNames_Ljava_util_List_ == IntPtr.Zero)
				id_convertClassesToClassNames_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "convertClassesToClassNames", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_classes = global::Android.Runtime.JavaList<global::Java.Lang.Class>.ToLocalJniHandle (classes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_classes);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertClassesToClassNames_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_classes);
			}
		}

		static IntPtr id_getAbbreviatedName_Ljava_lang_Class_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getAbbreviatedName' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='int']]"
		[Register ("getAbbreviatedName", "(Ljava/lang/Class;I)Ljava/lang/String;", "")]
		public static unsafe string GetAbbreviatedName (global::Java.Lang.Class cls, int len)
		{
			if (id_getAbbreviatedName_Ljava_lang_Class_I == IntPtr.Zero)
				id_getAbbreviatedName_Ljava_lang_Class_I = JNIEnv.GetStaticMethodID (class_ref, "getAbbreviatedName", "(Ljava/lang/Class;I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (len);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAbbreviatedName_Ljava_lang_Class_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAbbreviatedName_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getAbbreviatedName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getAbbreviatedName", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string GetAbbreviatedName (string className, int len)
		{
			if (id_getAbbreviatedName_Ljava_lang_String_I == IntPtr.Zero)
				id_getAbbreviatedName_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getAbbreviatedName", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_className);
				__args [1] = new JValue (len);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAbbreviatedName_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		static IntPtr id_getAllInterfaces_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getAllInterfaces' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getAllInterfaces", "(Ljava/lang/Class;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Class> GetAllInterfaces (global::Java.Lang.Class cls)
		{
			if (id_getAllInterfaces_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAllInterfaces_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getAllInterfaces", "(Ljava/lang/Class;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				global::System.Collections.Generic.IList<global::Java.Lang.Class> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Class>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllInterfaces_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAllSuperclasses_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getAllSuperclasses' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getAllSuperclasses", "(Ljava/lang/Class;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Class> GetAllSuperclasses (global::Java.Lang.Class cls)
		{
			if (id_getAllSuperclasses_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAllSuperclasses_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getAllSuperclasses", "(Ljava/lang/Class;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				global::System.Collections.Generic.IList<global::Java.Lang.Class> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Class>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllSuperclasses_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCanonicalName_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getCanonicalName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getCanonicalName", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
		public static unsafe string GetCanonicalName (global::Java.Lang.Class cls)
		{
			if (id_getCanonicalName_Ljava_lang_Class_ == IntPtr.Zero)
				id_getCanonicalName_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getCanonicalName", "(Ljava/lang/Class;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCanonicalName_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCanonicalName_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getCanonicalName' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getCanonicalName", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetCanonicalName (global::Java.Lang.Class cls, string valueIfNull)
		{
			if (id_getCanonicalName_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_getCanonicalName_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCanonicalName", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_valueIfNull = JNIEnv.NewString (valueIfNull);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_valueIfNull);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCanonicalName_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueIfNull);
			}
		}

		static IntPtr id_getCanonicalName_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getCanonicalName' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getCanonicalName", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string GetCanonicalName (global::Java.Lang.Object @object)
		{
			if (id_getCanonicalName_Ljava_lang_Object_ == IntPtr.Zero)
				id_getCanonicalName_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getCanonicalName", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCanonicalName_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCanonicalName_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getCanonicalName' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getCanonicalName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetCanonicalName (global::Java.Lang.Object @object, string valueIfNull)
		{
			if (id_getCanonicalName_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_getCanonicalName_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCanonicalName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_valueIfNull = JNIEnv.NewString (valueIfNull);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_valueIfNull);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCanonicalName_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueIfNull);
			}
		}

		static IntPtr id_getClass_Ljava_lang_ClassLoader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getClass' and count(parameter)=2 and parameter[1][@type='java.lang.ClassLoader'] and parameter[2][@type='java.lang.String']]"
		[Register ("getClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class GetClass (global::Java.Lang.ClassLoader classLoader, string className)
		{
			if (id_getClass_Ljava_lang_ClassLoader_Ljava_lang_String_ == IntPtr.Zero)
				id_getClass_Ljava_lang_ClassLoader_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;");
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (classLoader);
				__args [1] = new JValue (native_className);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClass_Ljava_lang_ClassLoader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		static IntPtr id_getClass_Ljava_lang_ClassLoader_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getClass' and count(parameter)=3 and parameter[1][@type='java.lang.ClassLoader'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;Z)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class GetClass (global::Java.Lang.ClassLoader classLoader, string className, bool initialize)
		{
			if (id_getClass_Ljava_lang_ClassLoader_Ljava_lang_String_Z == IntPtr.Zero)
				id_getClass_Ljava_lang_ClassLoader_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;Z)Ljava/lang/Class;");
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (classLoader);
				__args [1] = new JValue (native_className);
				__args [2] = new JValue (initialize);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClass_Ljava_lang_ClassLoader_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		static IntPtr id_getClass_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClass", "(Ljava/lang/String;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class GetClass (string className)
		{
			if (id_getClass_Ljava_lang_String_ == IntPtr.Zero)
				id_getClass_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_className);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClass_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		static IntPtr id_getClass_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getClass' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getClass", "(Ljava/lang/String;Z)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class GetClass (string className, bool initialize)
		{
			if (id_getClass_Ljava_lang_String_Z == IntPtr.Zero)
				id_getClass_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getClass", "(Ljava/lang/String;Z)Ljava/lang/Class;");
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_className);
				__args [1] = new JValue (initialize);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClass_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		static IntPtr id_getName_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getName", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
		public static unsafe string GetName (global::Java.Lang.Class cls)
		{
			if (id_getName_Ljava_lang_Class_ == IntPtr.Zero)
				id_getName_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getName", "(Ljava/lang/Class;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getName_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getName_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getName' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getName", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetName (global::Java.Lang.Class cls, string valueIfNull)
		{
			if (id_getName_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_getName_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getName", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_valueIfNull = JNIEnv.NewString (valueIfNull);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_valueIfNull);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getName_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueIfNull);
			}
		}

		static IntPtr id_getName_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getName' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getName", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string GetName (global::Java.Lang.Object @object)
		{
			if (id_getName_Ljava_lang_Object_ == IntPtr.Zero)
				id_getName_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getName", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getName_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getName_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getName' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetName (global::Java.Lang.Object @object, string valueIfNull)
		{
			if (id_getName_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_getName_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_valueIfNull = JNIEnv.NewString (valueIfNull);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_valueIfNull);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getName_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueIfNull);
			}
		}

		static IntPtr id_getPackageCanonicalName_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getPackageCanonicalName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getPackageCanonicalName", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
		public static unsafe string GetPackageCanonicalName (global::Java.Lang.Class cls)
		{
			if (id_getPackageCanonicalName_Ljava_lang_Class_ == IntPtr.Zero)
				id_getPackageCanonicalName_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getPackageCanonicalName", "(Ljava/lang/Class;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageCanonicalName_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPackageCanonicalName_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getPackageCanonicalName' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getPackageCanonicalName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetPackageCanonicalName (global::Java.Lang.Object @object, string valueIfNull)
		{
			if (id_getPackageCanonicalName_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_getPackageCanonicalName_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPackageCanonicalName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_valueIfNull = JNIEnv.NewString (valueIfNull);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_valueIfNull);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageCanonicalName_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueIfNull);
			}
		}

		static IntPtr id_getPackageCanonicalName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getPackageCanonicalName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPackageCanonicalName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetPackageCanonicalName (string canonicalName)
		{
			if (id_getPackageCanonicalName_Ljava_lang_String_ == IntPtr.Zero)
				id_getPackageCanonicalName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPackageCanonicalName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_canonicalName = JNIEnv.NewString (canonicalName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_canonicalName);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageCanonicalName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_canonicalName);
			}
		}

		static IntPtr id_getPackageName_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getPackageName", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
		public static unsafe string GetPackageName (global::Java.Lang.Class cls)
		{
			if (id_getPackageName_Ljava_lang_Class_ == IntPtr.Zero)
				id_getPackageName_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getPackageName", "(Ljava/lang/Class;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageName_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPackageName_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getPackageName' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getPackageName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetPackageName (global::Java.Lang.Object @object, string valueIfNull)
		{
			if (id_getPackageName_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_getPackageName_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPackageName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_valueIfNull = JNIEnv.NewString (valueIfNull);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_valueIfNull);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageName_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueIfNull);
			}
		}

		static IntPtr id_getPackageName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPackageName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetPackageName (string className)
		{
			if (id_getPackageName_Ljava_lang_String_ == IntPtr.Zero)
				id_getPackageName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPackageName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_className);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		static IntPtr id_getPublicMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getPublicMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("getPublicMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method GetPublicMethod (global::Java.Lang.Class cls, string methodName, params global::Java.Lang.Class[] parameterTypes)
		{
			if (id_getPublicMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_getPublicMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getPublicMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_parameterTypes);
				global::Java.Lang.Reflect.Method __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPublicMethod_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
			}
		}

		static IntPtr id_getShortCanonicalName_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getShortCanonicalName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getShortCanonicalName", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
		public static unsafe string GetShortCanonicalName (global::Java.Lang.Class cls)
		{
			if (id_getShortCanonicalName_Ljava_lang_Class_ == IntPtr.Zero)
				id_getShortCanonicalName_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getShortCanonicalName", "(Ljava/lang/Class;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getShortCanonicalName_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getShortCanonicalName_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getShortCanonicalName' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getShortCanonicalName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetShortCanonicalName (global::Java.Lang.Object @object, string valueIfNull)
		{
			if (id_getShortCanonicalName_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_getShortCanonicalName_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getShortCanonicalName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_valueIfNull = JNIEnv.NewString (valueIfNull);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_valueIfNull);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getShortCanonicalName_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueIfNull);
			}
		}

		static IntPtr id_getShortCanonicalName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getShortCanonicalName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getShortCanonicalName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetShortCanonicalName (string canonicalName)
		{
			if (id_getShortCanonicalName_Ljava_lang_String_ == IntPtr.Zero)
				id_getShortCanonicalName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getShortCanonicalName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_canonicalName = JNIEnv.NewString (canonicalName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_canonicalName);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getShortCanonicalName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_canonicalName);
			}
		}

		static IntPtr id_getShortClassName_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getShortClassName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getShortClassName", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
		public static unsafe string GetShortClassName (global::Java.Lang.Class cls)
		{
			if (id_getShortClassName_Ljava_lang_Class_ == IntPtr.Zero)
				id_getShortClassName_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getShortClassName", "(Ljava/lang/Class;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getShortClassName_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getShortClassName_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getShortClassName' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getShortClassName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetShortClassName (global::Java.Lang.Object @object, string valueIfNull)
		{
			if (id_getShortClassName_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_getShortClassName_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getShortClassName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_valueIfNull = JNIEnv.NewString (valueIfNull);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_valueIfNull);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getShortClassName_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueIfNull);
			}
		}

		static IntPtr id_getShortClassName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getShortClassName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getShortClassName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetShortClassName (string className)
		{
			if (id_getShortClassName_Ljava_lang_String_ == IntPtr.Zero)
				id_getShortClassName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getShortClassName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_className);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getShortClassName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		static IntPtr id_getSimpleName_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getSimpleName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getSimpleName", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
		public static unsafe string GetSimpleName (global::Java.Lang.Class cls)
		{
			if (id_getSimpleName_Ljava_lang_Class_ == IntPtr.Zero)
				id_getSimpleName_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getSimpleName", "(Ljava/lang/Class;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSimpleName_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSimpleName_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getSimpleName' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSimpleName", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetSimpleName (global::Java.Lang.Class cls, string valueIfNull)
		{
			if (id_getSimpleName_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_getSimpleName_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getSimpleName", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_valueIfNull = JNIEnv.NewString (valueIfNull);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (native_valueIfNull);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSimpleName_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueIfNull);
			}
		}

		static IntPtr id_getSimpleName_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getSimpleName' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getSimpleName", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string GetSimpleName (global::Java.Lang.Object @object)
		{
			if (id_getSimpleName_Ljava_lang_Object_ == IntPtr.Zero)
				id_getSimpleName_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getSimpleName", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSimpleName_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSimpleName_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='getSimpleName' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSimpleName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetSimpleName (global::Java.Lang.Object @object, string valueIfNull)
		{
			if (id_getSimpleName_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_getSimpleName_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getSimpleName", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_valueIfNull = JNIEnv.NewString (valueIfNull);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_valueIfNull);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSimpleName_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueIfNull);
			}
		}

		static IntPtr id_hierarchy_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='hierarchy' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("hierarchy", "(Ljava/lang/Class;)Ljava/lang/Iterable;", "")]
		public static unsafe global::Java.Lang.IIterable Hierarchy (global::Java.Lang.Class type)
		{
			if (id_hierarchy_Ljava_lang_Class_ == IntPtr.Zero)
				id_hierarchy_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "hierarchy", "(Ljava/lang/Class;)Ljava/lang/Iterable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				global::Java.Lang.IIterable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_hierarchy_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hierarchy_Ljava_lang_Class_Lorg_apache_commons_lang3_ClassUtils_Interfaces_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='hierarchy' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='org.apache.commons.lang3.ClassUtils.Interfaces']]"
		[Register ("hierarchy", "(Ljava/lang/Class;Lorg/apache/commons/lang3/ClassUtils$Interfaces;)Ljava/lang/Iterable;", "")]
		public static unsafe global::Java.Lang.IIterable Hierarchy (global::Java.Lang.Class type, global::Org.Apache.Commons.Lang3.ClassUtils.Interfaces interfacesBehavior)
		{
			if (id_hierarchy_Ljava_lang_Class_Lorg_apache_commons_lang3_ClassUtils_Interfaces_ == IntPtr.Zero)
				id_hierarchy_Ljava_lang_Class_Lorg_apache_commons_lang3_ClassUtils_Interfaces_ = JNIEnv.GetStaticMethodID (class_ref, "hierarchy", "(Ljava/lang/Class;Lorg/apache/commons/lang3/ClassUtils$Interfaces;)Ljava/lang/Iterable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (type);
				__args [1] = new JValue (interfacesBehavior);
				global::Java.Lang.IIterable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_hierarchy_Ljava_lang_Class_Lorg_apache_commons_lang3_ClassUtils_Interfaces_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isAssignable_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='isAssignable' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("isAssignable", "(Ljava/lang/Class;Ljava/lang/Class;)Z", "")]
		public static unsafe bool IsAssignable (global::Java.Lang.Class cls, global::Java.Lang.Class toClass)
		{
			if (id_isAssignable_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_isAssignable_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "isAssignable", "(Ljava/lang/Class;Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (toClass);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAssignable_Ljava_lang_Class_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isAssignable_Ljava_lang_Class_Ljava_lang_Class_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='isAssignable' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='boolean']]"
		[Register ("isAssignable", "(Ljava/lang/Class;Ljava/lang/Class;Z)Z", "")]
		public static unsafe bool IsAssignable (global::Java.Lang.Class cls, global::Java.Lang.Class toClass, bool autoboxing)
		{
			if (id_isAssignable_Ljava_lang_Class_Ljava_lang_Class_Z == IntPtr.Zero)
				id_isAssignable_Ljava_lang_Class_Ljava_lang_Class_Z = JNIEnv.GetStaticMethodID (class_ref, "isAssignable", "(Ljava/lang/Class;Ljava/lang/Class;Z)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (toClass);
				__args [2] = new JValue (autoboxing);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAssignable_Ljava_lang_Class_Ljava_lang_Class_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isAssignable_arrayLjava_lang_Class_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='isAssignable' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;[]'] and parameter[2][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("isAssignable", "([Ljava/lang/Class;[Ljava/lang/Class;)Z", "")]
		public static unsafe bool IsAssignable (global::Java.Lang.Class[] classArray, params global::Java.Lang.Class[] toClassArray)
		{
			if (id_isAssignable_arrayLjava_lang_Class_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_isAssignable_arrayLjava_lang_Class_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "isAssignable", "([Ljava/lang/Class;[Ljava/lang/Class;)Z");
			IntPtr native_classArray = JNIEnv.NewArray (classArray);
			IntPtr native_toClassArray = JNIEnv.NewArray (toClassArray);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_classArray);
				__args [1] = new JValue (native_toClassArray);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAssignable_arrayLjava_lang_Class_arrayLjava_lang_Class_, __args);
				return __ret;
			} finally {
				if (classArray != null) {
					JNIEnv.CopyArray (native_classArray, classArray);
					JNIEnv.DeleteLocalRef (native_classArray);
				}
				if (toClassArray != null) {
					JNIEnv.CopyArray (native_toClassArray, toClassArray);
					JNIEnv.DeleteLocalRef (native_toClassArray);
				}
			}
		}

		static IntPtr id_isAssignable_arrayLjava_lang_Class_arrayLjava_lang_Class_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='isAssignable' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;[]'] and parameter[2][@type='java.lang.Class&lt;?&gt;[]'] and parameter[3][@type='boolean']]"
		[Register ("isAssignable", "([Ljava/lang/Class;[Ljava/lang/Class;Z)Z", "")]
		public static unsafe bool IsAssignable (global::Java.Lang.Class[] classArray, global::Java.Lang.Class[] toClassArray, bool autoboxing)
		{
			if (id_isAssignable_arrayLjava_lang_Class_arrayLjava_lang_Class_Z == IntPtr.Zero)
				id_isAssignable_arrayLjava_lang_Class_arrayLjava_lang_Class_Z = JNIEnv.GetStaticMethodID (class_ref, "isAssignable", "([Ljava/lang/Class;[Ljava/lang/Class;Z)Z");
			IntPtr native_classArray = JNIEnv.NewArray (classArray);
			IntPtr native_toClassArray = JNIEnv.NewArray (toClassArray);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_classArray);
				__args [1] = new JValue (native_toClassArray);
				__args [2] = new JValue (autoboxing);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAssignable_arrayLjava_lang_Class_arrayLjava_lang_Class_Z, __args);
				return __ret;
			} finally {
				if (classArray != null) {
					JNIEnv.CopyArray (native_classArray, classArray);
					JNIEnv.DeleteLocalRef (native_classArray);
				}
				if (toClassArray != null) {
					JNIEnv.CopyArray (native_toClassArray, toClassArray);
					JNIEnv.DeleteLocalRef (native_toClassArray);
				}
			}
		}

		static IntPtr id_isInnerClass_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='isInnerClass' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("isInnerClass", "(Ljava/lang/Class;)Z", "")]
		public static unsafe bool IsInnerClass (global::Java.Lang.Class cls)
		{
			if (id_isInnerClass_Ljava_lang_Class_ == IntPtr.Zero)
				id_isInnerClass_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "isInnerClass", "(Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isInnerClass_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isPrimitiveOrWrapper_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='isPrimitiveOrWrapper' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("isPrimitiveOrWrapper", "(Ljava/lang/Class;)Z", "")]
		public static unsafe bool IsPrimitiveOrWrapper (global::Java.Lang.Class type)
		{
			if (id_isPrimitiveOrWrapper_Ljava_lang_Class_ == IntPtr.Zero)
				id_isPrimitiveOrWrapper_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "isPrimitiveOrWrapper", "(Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPrimitiveOrWrapper_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isPrimitiveWrapper_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='isPrimitiveWrapper' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("isPrimitiveWrapper", "(Ljava/lang/Class;)Z", "")]
		public static unsafe bool IsPrimitiveWrapper (global::Java.Lang.Class type)
		{
			if (id_isPrimitiveWrapper_Ljava_lang_Class_ == IntPtr.Zero)
				id_isPrimitiveWrapper_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "isPrimitiveWrapper", "(Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPrimitiveWrapper_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_primitiveToWrapper_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='primitiveToWrapper' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("primitiveToWrapper", "(Ljava/lang/Class;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class PrimitiveToWrapper (global::Java.Lang.Class cls)
		{
			if (id_primitiveToWrapper_Ljava_lang_Class_ == IntPtr.Zero)
				id_primitiveToWrapper_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "primitiveToWrapper", "(Ljava/lang/Class;)Ljava/lang/Class;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_primitiveToWrapper_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_primitivesToWrappers_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='primitivesToWrappers' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("primitivesToWrappers", "([Ljava/lang/Class;)[Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class[] PrimitivesToWrappers (params global::Java.Lang.Class[] classes)
		{
			if (id_primitivesToWrappers_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_primitivesToWrappers_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "primitivesToWrappers", "([Ljava/lang/Class;)[Ljava/lang/Class;");
			IntPtr native_classes = JNIEnv.NewArray (classes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_classes);
				global::Java.Lang.Class[] __ret = (global::Java.Lang.Class[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_primitivesToWrappers_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Class));
				return __ret;
			} finally {
				if (classes != null) {
					JNIEnv.CopyArray (native_classes, classes);
					JNIEnv.DeleteLocalRef (native_classes);
				}
			}
		}

		static IntPtr id_toClass_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='toClass' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("toClass", "([Ljava/lang/Object;)[Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class[] ToClass (params global::Java.Lang.Object[] array)
		{
			if (id_toClass_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_toClass_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "toClass", "([Ljava/lang/Object;)[Ljava/lang/Class;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Class[] __ret = (global::Java.Lang.Class[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toClass_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Class));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_wrapperToPrimitive_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='wrapperToPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("wrapperToPrimitive", "(Ljava/lang/Class;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class WrapperToPrimitive (global::Java.Lang.Class cls)
		{
			if (id_wrapperToPrimitive_Ljava_lang_Class_ == IntPtr.Zero)
				id_wrapperToPrimitive_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "wrapperToPrimitive", "(Ljava/lang/Class;)Ljava/lang/Class;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrapperToPrimitive_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_wrappersToPrimitives_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassUtils']/method[@name='wrappersToPrimitives' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("wrappersToPrimitives", "([Ljava/lang/Class;)[Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class[] WrappersToPrimitives (params global::Java.Lang.Class[] classes)
		{
			if (id_wrappersToPrimitives_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_wrappersToPrimitives_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "wrappersToPrimitives", "([Ljava/lang/Class;)[Ljava/lang/Class;");
			IntPtr native_classes = JNIEnv.NewArray (classes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_classes);
				global::Java.Lang.Class[] __ret = (global::Java.Lang.Class[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrappersToPrimitives_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Class));
				return __ret;
			} finally {
				if (classes != null) {
					JNIEnv.CopyArray (native_classes, classes);
					JNIEnv.DeleteLocalRef (native_classes);
				}
			}
		}

	}
}
