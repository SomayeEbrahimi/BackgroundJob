using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='StringToType']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/StringToType", DoNotGenerateAcw=true)]
	public partial class StringToType : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/internal/lang/reflect/StringToType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringToType); }
		}

		protected StringToType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='StringToType']/constructor[@name='StringToType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringToType ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StringToType)) {
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

		static IntPtr id_commaSeparatedListToTypeArray_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='StringToType']/method[@name='commaSeparatedListToTypeArray' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class']]"
		[Register ("commaSeparatedListToTypeArray", "(Ljava/lang/String;Ljava/lang/Class;)[Ljava/lang/reflect/Type;", "")]
		public static unsafe global::Java.Lang.Reflect.IType[] CommaSeparatedListToTypeArray (string typeNames, global::Java.Lang.Class classScope)
		{
			if (id_commaSeparatedListToTypeArray_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_commaSeparatedListToTypeArray_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "commaSeparatedListToTypeArray", "(Ljava/lang/String;Ljava/lang/Class;)[Ljava/lang/reflect/Type;");
			IntPtr native_typeNames = JNIEnv.NewString (typeNames);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_typeNames);
				__args [1] = new JValue (classScope);
				global::Java.Lang.Reflect.IType[] __ret = (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_commaSeparatedListToTypeArray_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_typeNames);
			}
		}

		static IntPtr id_stringToType_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='StringToType']/method[@name='stringToType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class']]"
		[Register ("stringToType", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/reflect/Type;", "")]
		public static unsafe global::Java.Lang.Reflect.IType InvokeStringToType (string typeName, global::Java.Lang.Class classScope)
		{
			if (id_stringToType_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_stringToType_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "stringToType", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/reflect/Type;");
			IntPtr native_typeName = JNIEnv.NewString (typeName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_typeName);
				__args [1] = new JValue (classScope);
				global::Java.Lang.Reflect.IType __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_stringToType_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_typeName);
			}
		}

	}
}
