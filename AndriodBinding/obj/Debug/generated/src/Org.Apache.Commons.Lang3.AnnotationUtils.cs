using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='AnnotationUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/AnnotationUtils", DoNotGenerateAcw=true)]
	public partial class AnnotationUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/AnnotationUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnnotationUtils); }
		}

		protected AnnotationUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='AnnotationUtils']/constructor[@name='AnnotationUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnnotationUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AnnotationUtils)) {
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

		static IntPtr id_equals_Ljava_lang_annotation_Annotation_Ljava_lang_annotation_Annotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='AnnotationUtils']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='java.lang.annotation.Annotation'] and parameter[2][@type='java.lang.annotation.Annotation']]"
		[Register ("equals", "(Ljava/lang/annotation/Annotation;Ljava/lang/annotation/Annotation;)Z", "")]
		public static unsafe bool Equals (global::Java.Lang.Annotation.IAnnotation a1, global::Java.Lang.Annotation.IAnnotation a2)
		{
			if (id_equals_Ljava_lang_annotation_Annotation_Ljava_lang_annotation_Annotation_ == IntPtr.Zero)
				id_equals_Ljava_lang_annotation_Annotation_Ljava_lang_annotation_Annotation_ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(Ljava/lang/annotation/Annotation;Ljava/lang/annotation/Annotation;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (a1);
				__args [1] = new JValue (a2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_Ljava_lang_annotation_Annotation_Ljava_lang_annotation_Annotation_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hashCode_Ljava_lang_annotation_Annotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='AnnotationUtils']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='java.lang.annotation.Annotation']]"
		[Register ("hashCode", "(Ljava/lang/annotation/Annotation;)I", "")]
		public static unsafe int HashCode (global::Java.Lang.Annotation.IAnnotation a)
		{
			if (id_hashCode_Ljava_lang_annotation_Annotation_ == IntPtr.Zero)
				id_hashCode_Ljava_lang_annotation_Annotation_ = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(Ljava/lang/annotation/Annotation;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (a);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_Ljava_lang_annotation_Annotation_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isValidAnnotationMemberType_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='AnnotationUtils']/method[@name='isValidAnnotationMemberType' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("isValidAnnotationMemberType", "(Ljava/lang/Class;)Z", "")]
		public static unsafe bool IsValidAnnotationMemberType (global::Java.Lang.Class type)
		{
			if (id_isValidAnnotationMemberType_Ljava_lang_Class_ == IntPtr.Zero)
				id_isValidAnnotationMemberType_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "isValidAnnotationMemberType", "(Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isValidAnnotationMemberType_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_Ljava_lang_annotation_Annotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='AnnotationUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.lang.annotation.Annotation']]"
		[Register ("toString", "(Ljava/lang/annotation/Annotation;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Annotation.IAnnotation a)
		{
			if (id_toString_Ljava_lang_annotation_Annotation_ == IntPtr.Zero)
				id_toString_Ljava_lang_annotation_Annotation_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/annotation/Annotation;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (a);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_annotation_Annotation_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
