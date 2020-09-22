using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassPathUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/ClassPathUtils", DoNotGenerateAcw=true)]
	public partial class ClassPathUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/ClassPathUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClassPathUtils); }
		}

		protected ClassPathUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassPathUtils']/constructor[@name='ClassPathUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClassPathUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ClassPathUtils)) {
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

		static IntPtr id_toFullyQualifiedName_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassPathUtils']/method[@name='toFullyQualifiedName' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("toFullyQualifiedName", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToFullyQualifiedName (global::Java.Lang.Class context, string resourceName)
		{
			if (id_toFullyQualifiedName_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_toFullyQualifiedName_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toFullyQualifiedName", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_resourceName = JNIEnv.NewString (resourceName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_resourceName);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFullyQualifiedName_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_resourceName);
			}
		}

		static IntPtr id_toFullyQualifiedName_Ljava_lang_Package_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassPathUtils']/method[@name='toFullyQualifiedName' and count(parameter)=2 and parameter[1][@type='java.lang.Package'] and parameter[2][@type='java.lang.String']]"
		[Register ("toFullyQualifiedName", "(Ljava/lang/Package;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToFullyQualifiedName (global::Java.Lang.Package context, string resourceName)
		{
			if (id_toFullyQualifiedName_Ljava_lang_Package_Ljava_lang_String_ == IntPtr.Zero)
				id_toFullyQualifiedName_Ljava_lang_Package_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toFullyQualifiedName", "(Ljava/lang/Package;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_resourceName = JNIEnv.NewString (resourceName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_resourceName);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFullyQualifiedName_Ljava_lang_Package_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_resourceName);
			}
		}

		static IntPtr id_toFullyQualifiedPath_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassPathUtils']/method[@name='toFullyQualifiedPath' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("toFullyQualifiedPath", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToFullyQualifiedPath (global::Java.Lang.Class context, string resourceName)
		{
			if (id_toFullyQualifiedPath_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_toFullyQualifiedPath_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toFullyQualifiedPath", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_resourceName = JNIEnv.NewString (resourceName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_resourceName);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFullyQualifiedPath_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_resourceName);
			}
		}

		static IntPtr id_toFullyQualifiedPath_Ljava_lang_Package_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ClassPathUtils']/method[@name='toFullyQualifiedPath' and count(parameter)=2 and parameter[1][@type='java.lang.Package'] and parameter[2][@type='java.lang.String']]"
		[Register ("toFullyQualifiedPath", "(Ljava/lang/Package;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToFullyQualifiedPath (global::Java.Lang.Package context, string resourceName)
		{
			if (id_toFullyQualifiedPath_Ljava_lang_Package_Ljava_lang_String_ == IntPtr.Zero)
				id_toFullyQualifiedPath_Ljava_lang_Package_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toFullyQualifiedPath", "(Ljava/lang/Package;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_resourceName = JNIEnv.NewString (resourceName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_resourceName);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFullyQualifiedPath_Ljava_lang_Package_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_resourceName);
			}
		}

	}
}
