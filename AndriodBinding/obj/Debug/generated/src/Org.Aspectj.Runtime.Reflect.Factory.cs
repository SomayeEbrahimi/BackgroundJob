using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Runtime.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/reflect/Factory", DoNotGenerateAcw=true)]
	public sealed partial class Factory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/runtime/reflect/Factory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Factory); }
		}

		internal Factory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/constructor[@name='Factory' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Class;)V", "")]
		public unsafe Factory (string filename, global::Java.Lang.Class lexicalClass)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_filename);
				__args [1] = new JValue (lexicalClass);
				if (((object) this).GetType () != typeof (Factory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Class_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		static IntPtr id_makeAdviceSig_ILjava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeAdviceSig' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.Class[]'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.Class[]'] and parameter[7][@type='java.lang.Class']]"
		[Register ("makeAdviceSig", "(ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/AdviceSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IAdviceSignature MakeAdviceSig (int modifiers, string name, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] parameterTypes, string[] parameterNames, global::Java.Lang.Class[] exceptionTypes, global::Java.Lang.Class returnType)
		{
			if (id_makeAdviceSig_ILjava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_makeAdviceSig_ILjava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "makeAdviceSig", "(ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/AdviceSignature;");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_parameterNames = JNIEnv.NewArray (parameterNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (modifiers);
				__args [1] = new JValue (native_name);
				__args [2] = new JValue (declaringType);
				__args [3] = new JValue (native_parameterTypes);
				__args [4] = new JValue (native_parameterNames);
				__args [5] = new JValue (native_exceptionTypes);
				__args [6] = new JValue (returnType);
				global::Org.Aspectj.Lang.Reflect.IAdviceSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeAdviceSig_ILjava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (parameterNames != null) {
					JNIEnv.CopyArray (native_parameterNames, parameterNames);
					JNIEnv.DeleteLocalRef (native_parameterNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
			}
		}

		static IntPtr id_makeAdviceSig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeAdviceSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeAdviceSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IAdviceSignature MakeAdviceSig (string stringRep)
		{
			if (id_makeAdviceSig_Ljava_lang_String_ == IntPtr.Zero)
				id_makeAdviceSig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeAdviceSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceSignature;");
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_stringRep);
				global::Org.Aspectj.Lang.Reflect.IAdviceSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeAdviceSig_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		static IntPtr id_makeAdviceSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeAdviceSig' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("makeAdviceSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IAdviceSignature MakeAdviceSig (string modifiers, string name, string declaringType, string paramTypes, string paramNames, string exceptionTypes, string returnType)
		{
			if (id_makeAdviceSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_makeAdviceSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeAdviceSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceSignature;");
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_paramTypes = JNIEnv.NewString (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewString (paramNames);
			IntPtr native_exceptionTypes = JNIEnv.NewString (exceptionTypes);
			IntPtr native_returnType = JNIEnv.NewString (returnType);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_modifiers);
				__args [1] = new JValue (native_name);
				__args [2] = new JValue (native_declaringType);
				__args [3] = new JValue (native_paramTypes);
				__args [4] = new JValue (native_paramNames);
				__args [5] = new JValue (native_exceptionTypes);
				__args [6] = new JValue (native_returnType);
				global::Org.Aspectj.Lang.Reflect.IAdviceSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeAdviceSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_paramTypes);
				JNIEnv.DeleteLocalRef (native_paramNames);
				JNIEnv.DeleteLocalRef (native_exceptionTypes);
				JNIEnv.DeleteLocalRef (native_returnType);
			}
		}

		static IntPtr id_makeCatchClauseSig_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeCatchClauseSig' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='java.lang.String']]"
		[Register ("makeCatchClauseSig", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature MakeCatchClauseSig (global::Java.Lang.Class declaringType, global::Java.Lang.Class parameterType, string parameterName)
		{
			if (id_makeCatchClauseSig_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_makeCatchClauseSig_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeCatchClauseSig", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;");
			IntPtr native_parameterName = JNIEnv.NewString (parameterName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (declaringType);
				__args [1] = new JValue (parameterType);
				__args [2] = new JValue (native_parameterName);
				global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeCatchClauseSig_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_parameterName);
			}
		}

		static IntPtr id_makeCatchClauseSig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeCatchClauseSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeCatchClauseSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature MakeCatchClauseSig (string stringRep)
		{
			if (id_makeCatchClauseSig_Ljava_lang_String_ == IntPtr.Zero)
				id_makeCatchClauseSig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeCatchClauseSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;");
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_stringRep);
				global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeCatchClauseSig_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		static IntPtr id_makeCatchClauseSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeCatchClauseSig' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("makeCatchClauseSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature MakeCatchClauseSig (string declaringType, string parameterType, string parameterName)
		{
			if (id_makeCatchClauseSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_makeCatchClauseSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeCatchClauseSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;");
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_parameterType = JNIEnv.NewString (parameterType);
			IntPtr native_parameterName = JNIEnv.NewString (parameterName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_declaringType);
				__args [1] = new JValue (native_parameterType);
				__args [2] = new JValue (native_parameterName);
				global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeCatchClauseSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_parameterType);
				JNIEnv.DeleteLocalRef (native_parameterName);
			}
		}

		static IntPtr id_makeConstructorSig_ILjava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeConstructorSig' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='java.lang.Class[]'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.Class[]']]"
		[Register ("makeConstructorSig", "(ILjava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;)Lorg/aspectj/lang/reflect/ConstructorSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IConstructorSignature MakeConstructorSig (int modifiers, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] parameterTypes, string[] parameterNames, global::Java.Lang.Class[] exceptionTypes)
		{
			if (id_makeConstructorSig_ILjava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_makeConstructorSig_ILjava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "makeConstructorSig", "(ILjava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;)Lorg/aspectj/lang/reflect/ConstructorSignature;");
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_parameterNames = JNIEnv.NewArray (parameterNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (modifiers);
				__args [1] = new JValue (declaringType);
				__args [2] = new JValue (native_parameterTypes);
				__args [3] = new JValue (native_parameterNames);
				__args [4] = new JValue (native_exceptionTypes);
				global::Org.Aspectj.Lang.Reflect.IConstructorSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IConstructorSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeConstructorSig_ILjava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (parameterNames != null) {
					JNIEnv.CopyArray (native_parameterNames, parameterNames);
					JNIEnv.DeleteLocalRef (native_parameterNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
			}
		}

		static IntPtr id_makeConstructorSig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeConstructorSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeConstructorSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/ConstructorSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IConstructorSignature MakeConstructorSig (string stringRep)
		{
			if (id_makeConstructorSig_Ljava_lang_String_ == IntPtr.Zero)
				id_makeConstructorSig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeConstructorSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/ConstructorSignature;");
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_stringRep);
				global::Org.Aspectj.Lang.Reflect.IConstructorSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IConstructorSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeConstructorSig_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		static IntPtr id_makeConstructorSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeConstructorSig' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("makeConstructorSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/ConstructorSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IConstructorSignature MakeConstructorSig (string modifiers, string declaringType, string paramTypes, string paramNames, string exceptionTypes)
		{
			if (id_makeConstructorSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_makeConstructorSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeConstructorSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/ConstructorSignature;");
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_paramTypes = JNIEnv.NewString (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewString (paramNames);
			IntPtr native_exceptionTypes = JNIEnv.NewString (exceptionTypes);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_modifiers);
				__args [1] = new JValue (native_declaringType);
				__args [2] = new JValue (native_paramTypes);
				__args [3] = new JValue (native_paramNames);
				__args [4] = new JValue (native_exceptionTypes);
				global::Org.Aspectj.Lang.Reflect.IConstructorSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IConstructorSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeConstructorSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_paramTypes);
				JNIEnv.DeleteLocalRef (native_paramNames);
				JNIEnv.DeleteLocalRef (native_exceptionTypes);
			}
		}

		static IntPtr id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeESJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='int']]"
		[Register ("makeESJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeESJP (string kind, global::Org.Aspectj.Lang.ISignature sig, int l)
		{
			if (id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_I == IntPtr.Zero)
				id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_I = JNIEnv.GetMethodID (class_ref, "makeESJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;");
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_kind);
				__args [1] = new JValue (sig);
				__args [2] = new JValue (l);
				global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
			}
		}

		static IntPtr id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeESJP' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("makeESJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;II)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeESJP (string kind, global::Org.Aspectj.Lang.ISignature sig, int l, int c)
		{
			if (id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_II == IntPtr.Zero)
				id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_II = JNIEnv.GetMethodID (class_ref, "makeESJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;II)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;");
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_kind);
				__args [1] = new JValue (sig);
				__args [2] = new JValue (l);
				__args [3] = new JValue (c);
				global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
			}
		}

		static IntPtr id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_Lorg_aspectj_lang_reflect_SourceLocation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeESJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='org.aspectj.lang.reflect.SourceLocation']]"
		[Register ("makeESJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;Lorg/aspectj/lang/reflect/SourceLocation;)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeESJP (string kind, global::Org.Aspectj.Lang.ISignature sig, global::Org.Aspectj.Lang.Reflect.ISourceLocation loc)
		{
			if (id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_Lorg_aspectj_lang_reflect_SourceLocation_ == IntPtr.Zero)
				id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_Lorg_aspectj_lang_reflect_SourceLocation_ = JNIEnv.GetMethodID (class_ref, "makeESJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;Lorg/aspectj/lang/reflect/SourceLocation;)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;");
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_kind);
				__args [1] = new JValue (sig);
				__args [2] = new JValue (loc);
				global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeESJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_Lorg_aspectj_lang_reflect_SourceLocation_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
			}
		}

		static IntPtr id_makeEncSJP_Ljava_lang_reflect_Member_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeEncSJP' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Member']]"
		[Register ("makeEncSJP", "(Ljava/lang/reflect/Member;)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public static unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeEncSJP (global::Java.Lang.Reflect.IMember member)
		{
			if (id_makeEncSJP_Ljava_lang_reflect_Member_ == IntPtr.Zero)
				id_makeEncSJP_Ljava_lang_reflect_Member_ = JNIEnv.GetStaticMethodID (class_ref, "makeEncSJP", "(Ljava/lang/reflect/Member;)Lorg/aspectj/lang/JoinPoint$StaticPart;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (member);
				global::Org.Aspectj.Lang.IJoinPointStaticPart __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeEncSJP_Ljava_lang_reflect_Member_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeFieldSig_ILjava_lang_String_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeFieldSig' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.Class']]"
		[Register ("makeFieldSig", "(ILjava/lang/String;Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/FieldSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IFieldSignature MakeFieldSig (int modifiers, string name, global::Java.Lang.Class declaringType, global::Java.Lang.Class fieldType)
		{
			if (id_makeFieldSig_ILjava_lang_String_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_makeFieldSig_ILjava_lang_String_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "makeFieldSig", "(ILjava/lang/String;Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/FieldSignature;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (modifiers);
				__args [1] = new JValue (native_name);
				__args [2] = new JValue (declaringType);
				__args [3] = new JValue (fieldType);
				global::Org.Aspectj.Lang.Reflect.IFieldSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IFieldSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeFieldSig_ILjava_lang_String_Ljava_lang_Class_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_makeFieldSig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeFieldSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeFieldSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/FieldSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IFieldSignature MakeFieldSig (string stringRep)
		{
			if (id_makeFieldSig_Ljava_lang_String_ == IntPtr.Zero)
				id_makeFieldSig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeFieldSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/FieldSignature;");
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_stringRep);
				global::Org.Aspectj.Lang.Reflect.IFieldSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IFieldSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeFieldSig_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		static IntPtr id_makeFieldSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeFieldSig' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("makeFieldSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/FieldSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IFieldSignature MakeFieldSig (string modifiers, string name, string declaringType, string fieldType)
		{
			if (id_makeFieldSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_makeFieldSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeFieldSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/FieldSignature;");
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_fieldType = JNIEnv.NewString (fieldType);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_modifiers);
				__args [1] = new JValue (native_name);
				__args [2] = new JValue (native_declaringType);
				__args [3] = new JValue (native_fieldType);
				global::Org.Aspectj.Lang.Reflect.IFieldSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IFieldSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeFieldSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_fieldType);
			}
		}

		static IntPtr id_makeInitializerSig_ILjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeInitializerSig' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Class']]"
		[Register ("makeInitializerSig", "(ILjava/lang/Class;)Lorg/aspectj/lang/reflect/InitializerSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IInitializerSignature MakeInitializerSig (int modifiers, global::Java.Lang.Class declaringType)
		{
			if (id_makeInitializerSig_ILjava_lang_Class_ == IntPtr.Zero)
				id_makeInitializerSig_ILjava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "makeInitializerSig", "(ILjava/lang/Class;)Lorg/aspectj/lang/reflect/InitializerSignature;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (modifiers);
				__args [1] = new JValue (declaringType);
				global::Org.Aspectj.Lang.Reflect.IInitializerSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInitializerSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeInitializerSig_ILjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeInitializerSig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeInitializerSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeInitializerSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/InitializerSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IInitializerSignature MakeInitializerSig (string stringRep)
		{
			if (id_makeInitializerSig_Ljava_lang_String_ == IntPtr.Zero)
				id_makeInitializerSig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeInitializerSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/InitializerSignature;");
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_stringRep);
				global::Org.Aspectj.Lang.Reflect.IInitializerSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInitializerSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeInitializerSig_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		static IntPtr id_makeInitializerSig_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeInitializerSig' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("makeInitializerSig", "(Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/InitializerSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IInitializerSignature MakeInitializerSig (string modifiers, string declaringType)
		{
			if (id_makeInitializerSig_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_makeInitializerSig_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeInitializerSig", "(Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/InitializerSignature;");
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_modifiers);
				__args [1] = new JValue (native_declaringType);
				global::Org.Aspectj.Lang.Reflect.IInitializerSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInitializerSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeInitializerSig_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_declaringType);
			}
		}

		static IntPtr id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeJP' and count(parameter)=3 and parameter[1][@type='org.aspectj.lang.JoinPoint.StaticPart'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;", "")]
		public static unsafe global::Org.Aspectj.Lang.IJoinPoint MakeJP (global::Org.Aspectj.Lang.IJoinPointStaticPart staticPart, global::Java.Lang.Object _this, global::Java.Lang.Object target)
		{
			if (id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (staticPart);
				__args [1] = new JValue (_this);
				__args [2] = new JValue (target);
				global::Org.Aspectj.Lang.IJoinPoint __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeJP' and count(parameter)=4 and parameter[1][@type='org.aspectj.lang.JoinPoint.StaticPart'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register ("makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;", "")]
		public static unsafe global::Org.Aspectj.Lang.IJoinPoint MakeJP (global::Org.Aspectj.Lang.IJoinPointStaticPart staticPart, global::Java.Lang.Object _this, global::Java.Lang.Object target, global::Java.Lang.Object arg0)
		{
			if (id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (staticPart);
				__args [1] = new JValue (_this);
				__args [2] = new JValue (target);
				__args [3] = new JValue (arg0);
				global::Org.Aspectj.Lang.IJoinPoint __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeJP' and count(parameter)=5 and parameter[1][@type='org.aspectj.lang.JoinPoint.StaticPart'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Object']]"
		[Register ("makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;", "")]
		public static unsafe global::Org.Aspectj.Lang.IJoinPoint MakeJP (global::Org.Aspectj.Lang.IJoinPointStaticPart staticPart, global::Java.Lang.Object _this, global::Java.Lang.Object target, global::Java.Lang.Object arg0, global::Java.Lang.Object arg1)
		{
			if (id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (staticPart);
				__args [1] = new JValue (_this);
				__args [2] = new JValue (target);
				__args [3] = new JValue (arg0);
				__args [4] = new JValue (arg1);
				global::Org.Aspectj.Lang.IJoinPoint __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeJP' and count(parameter)=4 and parameter[1][@type='org.aspectj.lang.JoinPoint.StaticPart'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;", "")]
		public static unsafe global::Org.Aspectj.Lang.IJoinPoint MakeJP (global::Org.Aspectj.Lang.IJoinPointStaticPart staticPart, global::Java.Lang.Object _this, global::Java.Lang.Object target, global::Java.Lang.Object[] args)
		{
			if (id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (staticPart);
				__args [1] = new JValue (_this);
				__args [2] = new JValue (target);
				__args [3] = new JValue (native_args);
				global::Org.Aspectj.Lang.IJoinPoint __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeJP_Lorg_aspectj_lang_JoinPoint_StaticPart_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_makeLockSig;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeLockSig' and count(parameter)=0]"
		[Register ("makeLockSig", "()Lorg/aspectj/lang/reflect/LockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ILockSignature MakeLockSig ()
		{
			if (id_makeLockSig == IntPtr.Zero)
				id_makeLockSig = JNIEnv.GetMethodID (class_ref, "makeLockSig", "()Lorg/aspectj/lang/reflect/LockSignature;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ILockSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeLockSig), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_makeLockSig_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeLockSig' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("makeLockSig", "(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/LockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ILockSignature MakeLockSig (global::Java.Lang.Class declaringType)
		{
			if (id_makeLockSig_Ljava_lang_Class_ == IntPtr.Zero)
				id_makeLockSig_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "makeLockSig", "(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/LockSignature;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (declaringType);
				global::Org.Aspectj.Lang.Reflect.ILockSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ILockSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeLockSig_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeLockSig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeLockSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeLockSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/LockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ILockSignature MakeLockSig (string stringRep)
		{
			if (id_makeLockSig_Ljava_lang_String_ == IntPtr.Zero)
				id_makeLockSig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeLockSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/LockSignature;");
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_stringRep);
				global::Org.Aspectj.Lang.Reflect.ILockSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ILockSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeLockSig_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		static IntPtr id_makeMethodSig_ILjava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeMethodSig' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.Class[]'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.Class[]'] and parameter[7][@type='java.lang.Class']]"
		[Register ("makeMethodSig", "(ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/MethodSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IMethodSignature MakeMethodSig (int modifiers, string name, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] parameterTypes, string[] parameterNames, global::Java.Lang.Class[] exceptionTypes, global::Java.Lang.Class returnType)
		{
			if (id_makeMethodSig_ILjava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_makeMethodSig_ILjava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "makeMethodSig", "(ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/MethodSignature;");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_parameterNames = JNIEnv.NewArray (parameterNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (modifiers);
				__args [1] = new JValue (native_name);
				__args [2] = new JValue (declaringType);
				__args [3] = new JValue (native_parameterTypes);
				__args [4] = new JValue (native_parameterNames);
				__args [5] = new JValue (native_exceptionTypes);
				__args [6] = new JValue (returnType);
				global::Org.Aspectj.Lang.Reflect.IMethodSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IMethodSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeMethodSig_ILjava_lang_String_Ljava_lang_Class_arrayLjava_lang_Class_arrayLjava_lang_String_arrayLjava_lang_Class_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (parameterNames != null) {
					JNIEnv.CopyArray (native_parameterNames, parameterNames);
					JNIEnv.DeleteLocalRef (native_parameterNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
			}
		}

		static IntPtr id_makeMethodSig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeMethodSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeMethodSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/MethodSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IMethodSignature MakeMethodSig (string stringRep)
		{
			if (id_makeMethodSig_Ljava_lang_String_ == IntPtr.Zero)
				id_makeMethodSig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeMethodSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/MethodSignature;");
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_stringRep);
				global::Org.Aspectj.Lang.Reflect.IMethodSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IMethodSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeMethodSig_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		static IntPtr id_makeMethodSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeMethodSig' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("makeMethodSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/MethodSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IMethodSignature MakeMethodSig (string modifiers, string methodName, string declaringType, string paramTypes, string paramNames, string exceptionTypes, string returnType)
		{
			if (id_makeMethodSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_makeMethodSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeMethodSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/MethodSignature;");
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_paramTypes = JNIEnv.NewString (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewString (paramNames);
			IntPtr native_exceptionTypes = JNIEnv.NewString (exceptionTypes);
			IntPtr native_returnType = JNIEnv.NewString (returnType);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_modifiers);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (native_declaringType);
				__args [3] = new JValue (native_paramTypes);
				__args [4] = new JValue (native_paramNames);
				__args [5] = new JValue (native_exceptionTypes);
				__args [6] = new JValue (native_returnType);
				global::Org.Aspectj.Lang.Reflect.IMethodSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IMethodSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeMethodSig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_methodName);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_paramTypes);
				JNIEnv.DeleteLocalRef (native_paramNames);
				JNIEnv.DeleteLocalRef (native_exceptionTypes);
				JNIEnv.DeleteLocalRef (native_returnType);
			}
		}

		static IntPtr id_makeSJP_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSJP' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='int']]"
		[Register ("makeSJP", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeSJP (string kind, string modifiers, string methodName, string declaringType, string paramTypes, string paramNames, string returnType, int l)
		{
			if (id_makeSJP_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_makeSJP_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "makeSJP", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$StaticPart;");
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_paramTypes = JNIEnv.NewString (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewString (paramNames);
			IntPtr native_returnType = JNIEnv.NewString (returnType);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_kind);
				__args [1] = new JValue (native_modifiers);
				__args [2] = new JValue (native_methodName);
				__args [3] = new JValue (native_declaringType);
				__args [4] = new JValue (native_paramTypes);
				__args [5] = new JValue (native_paramNames);
				__args [6] = new JValue (native_returnType);
				__args [7] = new JValue (l);
				global::Org.Aspectj.Lang.IJoinPointStaticPart __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeSJP_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_methodName);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_paramTypes);
				JNIEnv.DeleteLocalRef (native_paramNames);
				JNIEnv.DeleteLocalRef (native_returnType);
			}
		}

		static IntPtr id_makeSJP_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSJP' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='int']]"
		[Register ("makeSJP", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeSJP (string kind, string modifiers, string methodName, string declaringType, string paramTypes, string paramNames, string exceptionTypes, string returnType, int l)
		{
			if (id_makeSJP_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_makeSJP_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "makeSJP", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$StaticPart;");
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_paramTypes = JNIEnv.NewString (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewString (paramNames);
			IntPtr native_exceptionTypes = JNIEnv.NewString (exceptionTypes);
			IntPtr native_returnType = JNIEnv.NewString (returnType);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_kind);
				__args [1] = new JValue (native_modifiers);
				__args [2] = new JValue (native_methodName);
				__args [3] = new JValue (native_declaringType);
				__args [4] = new JValue (native_paramTypes);
				__args [5] = new JValue (native_paramNames);
				__args [6] = new JValue (native_exceptionTypes);
				__args [7] = new JValue (native_returnType);
				__args [8] = new JValue (l);
				global::Org.Aspectj.Lang.IJoinPointStaticPart __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeSJP_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_methodName);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_paramTypes);
				JNIEnv.DeleteLocalRef (native_paramNames);
				JNIEnv.DeleteLocalRef (native_exceptionTypes);
				JNIEnv.DeleteLocalRef (native_returnType);
			}
		}

		static IntPtr id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='int']]"
		[Register ("makeSJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeSJP (string kind, global::Org.Aspectj.Lang.ISignature sig, int l)
		{
			if (id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_I == IntPtr.Zero)
				id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_I = JNIEnv.GetMethodID (class_ref, "makeSJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;I)Lorg/aspectj/lang/JoinPoint$StaticPart;");
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_kind);
				__args [1] = new JValue (sig);
				__args [2] = new JValue (l);
				global::Org.Aspectj.Lang.IJoinPointStaticPart __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
			}
		}

		static IntPtr id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSJP' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("makeSJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;II)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeSJP (string kind, global::Org.Aspectj.Lang.ISignature sig, int l, int c)
		{
			if (id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_II == IntPtr.Zero)
				id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_II = JNIEnv.GetMethodID (class_ref, "makeSJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;II)Lorg/aspectj/lang/JoinPoint$StaticPart;");
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_kind);
				__args [1] = new JValue (sig);
				__args [2] = new JValue (l);
				__args [3] = new JValue (c);
				global::Org.Aspectj.Lang.IJoinPointStaticPart __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
			}
		}

		static IntPtr id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_Lorg_aspectj_lang_reflect_SourceLocation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='org.aspectj.lang.reflect.SourceLocation']]"
		[Register ("makeSJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;Lorg/aspectj/lang/reflect/SourceLocation;)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeSJP (string kind, global::Org.Aspectj.Lang.ISignature sig, global::Org.Aspectj.Lang.Reflect.ISourceLocation loc)
		{
			if (id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_Lorg_aspectj_lang_reflect_SourceLocation_ == IntPtr.Zero)
				id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_Lorg_aspectj_lang_reflect_SourceLocation_ = JNIEnv.GetMethodID (class_ref, "makeSJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;Lorg/aspectj/lang/reflect/SourceLocation;)Lorg/aspectj/lang/JoinPoint$StaticPart;");
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_kind);
				__args [1] = new JValue (sig);
				__args [2] = new JValue (loc);
				global::Org.Aspectj.Lang.IJoinPointStaticPart __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeSJP_Ljava_lang_String_Lorg_aspectj_lang_Signature_Lorg_aspectj_lang_reflect_SourceLocation_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
			}
		}

		static IntPtr id_makeSourceLoc_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSourceLoc' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("makeSourceLoc", "(II)Lorg/aspectj/lang/reflect/SourceLocation;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ISourceLocation MakeSourceLoc (int line, int col)
		{
			if (id_makeSourceLoc_II == IntPtr.Zero)
				id_makeSourceLoc_II = JNIEnv.GetMethodID (class_ref, "makeSourceLoc", "(II)Lorg/aspectj/lang/reflect/SourceLocation;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (line);
				__args [1] = new JValue (col);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISourceLocation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeSourceLoc_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_makeUnlockSig;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeUnlockSig' and count(parameter)=0]"
		[Register ("makeUnlockSig", "()Lorg/aspectj/lang/reflect/UnlockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IUnlockSignature MakeUnlockSig ()
		{
			if (id_makeUnlockSig == IntPtr.Zero)
				id_makeUnlockSig = JNIEnv.GetMethodID (class_ref, "makeUnlockSig", "()Lorg/aspectj/lang/reflect/UnlockSignature;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IUnlockSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeUnlockSig), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_makeUnlockSig_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeUnlockSig' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("makeUnlockSig", "(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/UnlockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IUnlockSignature MakeUnlockSig (global::Java.Lang.Class declaringType)
		{
			if (id_makeUnlockSig_Ljava_lang_Class_ == IntPtr.Zero)
				id_makeUnlockSig_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "makeUnlockSig", "(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/UnlockSignature;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (declaringType);
				global::Org.Aspectj.Lang.Reflect.IUnlockSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IUnlockSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeUnlockSig_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeUnlockSig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeUnlockSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeUnlockSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/UnlockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IUnlockSignature MakeUnlockSig (string stringRep)
		{
			if (id_makeUnlockSig_Ljava_lang_String_ == IntPtr.Zero)
				id_makeUnlockSig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeUnlockSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/UnlockSignature;");
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_stringRep);
				global::Org.Aspectj.Lang.Reflect.IUnlockSignature __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IUnlockSignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeUnlockSig_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

	}
}
