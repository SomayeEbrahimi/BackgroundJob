using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Lang {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']"
	[global::Android.Runtime.Register ("org/aspectj/lang/Aspects14", DoNotGenerateAcw=true)]
	public partial class Aspects14 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/lang/Aspects14", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Aspects14); }
		}

		protected Aspects14 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/constructor[@name='Aspects14' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Aspects14 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Aspects14)) {
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

		static IntPtr id_aspectOf_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='aspectOf' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("aspectOf", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object AspectOf (global::Java.Lang.Class aspectClass)
		{
			if (id_aspectOf_Ljava_lang_Class_ == IntPtr.Zero)
				id_aspectOf_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "aspectOf", "(Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aspectClass);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_aspectOf_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_aspectOf_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='aspectOf' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Class']]"
		[Register ("aspectOf", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object AspectOf (global::Java.Lang.Class aspectClass, global::Java.Lang.Class perTypeWithin)
		{
			if (id_aspectOf_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_aspectOf_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "aspectOf", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aspectClass);
				__args [1] = new JValue (perTypeWithin);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_aspectOf_Ljava_lang_Class_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_aspectOf_Ljava_lang_Class_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='aspectOf' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Object']]"
		[Register ("aspectOf", "(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object AspectOf (global::Java.Lang.Class aspectClass, global::Java.Lang.Object perObject)
		{
			if (id_aspectOf_Ljava_lang_Class_Ljava_lang_Object_ == IntPtr.Zero)
				id_aspectOf_Ljava_lang_Class_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "aspectOf", "(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aspectClass);
				__args [1] = new JValue (perObject);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_aspectOf_Ljava_lang_Class_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hasAspect_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='hasAspect' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("hasAspect", "(Ljava/lang/Class;)Z", "")]
		public static unsafe bool HasAspect (global::Java.Lang.Class aspectClass)
		{
			if (id_hasAspect_Ljava_lang_Class_ == IntPtr.Zero)
				id_hasAspect_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "hasAspect", "(Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aspectClass);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasAspect_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hasAspect_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='hasAspect' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Class']]"
		[Register ("hasAspect", "(Ljava/lang/Class;Ljava/lang/Class;)Z", "")]
		public static unsafe bool HasAspect (global::Java.Lang.Class aspectClass, global::Java.Lang.Class perTypeWithin)
		{
			if (id_hasAspect_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_hasAspect_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "hasAspect", "(Ljava/lang/Class;Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aspectClass);
				__args [1] = new JValue (perTypeWithin);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasAspect_Ljava_lang_Class_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hasAspect_Ljava_lang_Class_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='hasAspect' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Object']]"
		[Register ("hasAspect", "(Ljava/lang/Class;Ljava/lang/Object;)Z", "")]
		public static unsafe bool HasAspect (global::Java.Lang.Class aspectClass, global::Java.Lang.Object perObject)
		{
			if (id_hasAspect_Ljava_lang_Class_Ljava_lang_Object_ == IntPtr.Zero)
				id_hasAspect_Ljava_lang_Class_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "hasAspect", "(Ljava/lang/Class;Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aspectClass);
				__args [1] = new JValue (perObject);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasAspect_Ljava_lang_Class_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
