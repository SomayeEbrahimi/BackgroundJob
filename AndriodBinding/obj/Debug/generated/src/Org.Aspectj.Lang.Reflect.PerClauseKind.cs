using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']"
	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/PerClauseKind", DoNotGenerateAcw=true)]
	public sealed partial class PerClauseKind : global::Java.Lang.Enum {


		static IntPtr PERCFLOW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='PERCFLOW']"
		[Register ("PERCFLOW")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Percflow {
			get {
				if (PERCFLOW_jfieldId == IntPtr.Zero)
					PERCFLOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERCFLOW", "Lorg/aspectj/lang/reflect/PerClauseKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERCFLOW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PERCFLOWBELOW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='PERCFLOWBELOW']"
		[Register ("PERCFLOWBELOW")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Percflowbelow {
			get {
				if (PERCFLOWBELOW_jfieldId == IntPtr.Zero)
					PERCFLOWBELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERCFLOWBELOW", "Lorg/aspectj/lang/reflect/PerClauseKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERCFLOWBELOW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PERTARGET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='PERTARGET']"
		[Register ("PERTARGET")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Pertarget {
			get {
				if (PERTARGET_jfieldId == IntPtr.Zero)
					PERTARGET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERTARGET", "Lorg/aspectj/lang/reflect/PerClauseKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERTARGET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PERTHIS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='PERTHIS']"
		[Register ("PERTHIS")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Perthis {
			get {
				if (PERTHIS_jfieldId == IntPtr.Zero)
					PERTHIS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERTHIS", "Lorg/aspectj/lang/reflect/PerClauseKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERTHIS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PERTYPEWITHIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='PERTYPEWITHIN']"
		[Register ("PERTYPEWITHIN")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Pertypewithin {
			get {
				if (PERTYPEWITHIN_jfieldId == IntPtr.Zero)
					PERTYPEWITHIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERTYPEWITHIN", "Lorg/aspectj/lang/reflect/PerClauseKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERTYPEWITHIN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SINGLETON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='SINGLETON']"
		[Register ("SINGLETON")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Singleton {
			get {
				if (SINGLETON_jfieldId == IntPtr.Zero)
					SINGLETON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINGLETON", "Lorg/aspectj/lang/reflect/PerClauseKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINGLETON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/lang/reflect/PerClauseKind", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PerClauseKind); }
		}

		internal PerClauseKind (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/PerClauseKind;", "")]
		public static unsafe global::Org.Aspectj.Lang.Reflect.PerClauseKind ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/PerClauseKind;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Org.Aspectj.Lang.Reflect.PerClauseKind __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/aspectj/lang/reflect/PerClauseKind;", "")]
		public static unsafe global::Org.Aspectj.Lang.Reflect.PerClauseKind[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/aspectj/lang/reflect/PerClauseKind;");
			try {
				return (global::Org.Aspectj.Lang.Reflect.PerClauseKind[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.PerClauseKind));
			} finally {
			}
		}

	}
}
