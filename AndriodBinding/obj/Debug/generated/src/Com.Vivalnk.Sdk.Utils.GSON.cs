using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='GSON']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/GSON", DoNotGenerateAcw=true)]
	public partial class GSON : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/utils/GSON", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GSON); }
		}

		protected GSON (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='GSON']/constructor[@name='GSON' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GSON ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GSON)) {
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

		static IntPtr id_fromJson_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='GSON']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromJson", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object FromJson (string json, global::Java.Lang.Class classOfT)
		{
			if (id_fromJson_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_fromJson_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "fromJson", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_json);
				__args [1] = new JValue (classOfT);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromJson_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		static IntPtr id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='GSON']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object FromJson (string json, global::Java.Lang.Reflect.IType typeOfT)
		{
			if (id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "fromJson", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_json);
				__args [1] = new JValue (typeOfT);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='GSON']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toJson", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string ToJson (global::Java.Lang.Object src)
		{
			if (id_toJson_Ljava_lang_Object_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "toJson", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (src);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toJson_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='GSON']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;", "")]
		public static unsafe string ToJson (global::Java.Lang.Object src, global::Java.Lang.Reflect.IType typeOfSrc)
		{
			if (id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (src);
				__args [1] = new JValue (typeOfSrc);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
