using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']"
	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/AdviceKind", DoNotGenerateAcw=true)]
	public sealed partial class AdviceKind : global::Java.Lang.Enum {


		static IntPtr AFTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/field[@name='AFTER']"
		[Register ("AFTER")]
		public static global::Org.Aspectj.Lang.Reflect.AdviceKind After {
			get {
				if (AFTER_jfieldId == IntPtr.Zero)
					AFTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AFTER", "Lorg/aspectj/lang/reflect/AdviceKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AFTER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AFTER_RETURNING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/field[@name='AFTER_RETURNING']"
		[Register ("AFTER_RETURNING")]
		public static global::Org.Aspectj.Lang.Reflect.AdviceKind AfterReturning {
			get {
				if (AFTER_RETURNING_jfieldId == IntPtr.Zero)
					AFTER_RETURNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AFTER_RETURNING", "Lorg/aspectj/lang/reflect/AdviceKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AFTER_RETURNING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AFTER_THROWING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/field[@name='AFTER_THROWING']"
		[Register ("AFTER_THROWING")]
		public static global::Org.Aspectj.Lang.Reflect.AdviceKind AfterThrowing {
			get {
				if (AFTER_THROWING_jfieldId == IntPtr.Zero)
					AFTER_THROWING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AFTER_THROWING", "Lorg/aspectj/lang/reflect/AdviceKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AFTER_THROWING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AROUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/field[@name='AROUND']"
		[Register ("AROUND")]
		public static global::Org.Aspectj.Lang.Reflect.AdviceKind Around {
			get {
				if (AROUND_jfieldId == IntPtr.Zero)
					AROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AROUND", "Lorg/aspectj/lang/reflect/AdviceKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AROUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BEFORE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/field[@name='BEFORE']"
		[Register ("BEFORE")]
		public static global::Org.Aspectj.Lang.Reflect.AdviceKind Before {
			get {
				if (BEFORE_jfieldId == IntPtr.Zero)
					BEFORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BEFORE", "Lorg/aspectj/lang/reflect/AdviceKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BEFORE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/lang/reflect/AdviceKind", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdviceKind); }
		}

		internal AdviceKind (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceKind;", "")]
		public static unsafe global::Org.Aspectj.Lang.Reflect.AdviceKind ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceKind;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Org.Aspectj.Lang.Reflect.AdviceKind __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/aspectj/lang/reflect/AdviceKind;", "")]
		public static unsafe global::Org.Aspectj.Lang.Reflect.AdviceKind[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/aspectj/lang/reflect/AdviceKind;");
			try {
				return (global::Org.Aspectj.Lang.Reflect.AdviceKind[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.AdviceKind));
			} finally {
			}
		}

	}
}
