using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Runtime.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/reflect/FieldSignatureImpl", DoNotGenerateAcw=true)]
	public partial class FieldSignatureImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IFieldSignature {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/runtime/reflect/FieldSignatureImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FieldSignatureImpl); }
		}

		protected FieldSignatureImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDeclaringType;
#pragma warning disable 0169
		static Delegate GetGetDeclaringTypeHandler ()
		{
			if (cb_getDeclaringType == null)
				cb_getDeclaringType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaringType);
			return cb_getDeclaringType;
		}

		static IntPtr n_GetDeclaringType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		static IntPtr id_getDeclaringType;
		public virtual unsafe global::Java.Lang.Class DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
			[Register ("getDeclaringType", "()Ljava/lang/Class;", "GetGetDeclaringTypeHandler")]
			get {
				if (id_getDeclaringType == IntPtr.Zero)
					id_getDeclaringType = JNIEnv.GetMethodID (class_ref, "getDeclaringType", "()Ljava/lang/Class;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaringType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeclaringType", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeclaringTypeName;
#pragma warning disable 0169
		static Delegate GetGetDeclaringTypeNameHandler ()
		{
			if (cb_getDeclaringTypeName == null)
				cb_getDeclaringTypeName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaringTypeName);
			return cb_getDeclaringTypeName;
		}

		static IntPtr n_GetDeclaringTypeName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeclaringTypeName);
		}
#pragma warning restore 0169

		static IntPtr id_getDeclaringTypeName;
		public virtual unsafe string DeclaringTypeName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getDeclaringTypeName' and count(parameter)=0]"
			[Register ("getDeclaringTypeName", "()Ljava/lang/String;", "GetGetDeclaringTypeNameHandler")]
			get {
				if (id_getDeclaringTypeName == IntPtr.Zero)
					id_getDeclaringTypeName = JNIEnv.GetMethodID (class_ref, "getDeclaringTypeName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaringTypeName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeclaringTypeName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getField;
#pragma warning disable 0169
		static Delegate GetGetFieldHandler ()
		{
			if (cb_getField == null)
				cb_getField = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetField);
			return cb_getField;
		}

		static IntPtr n_GetField (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Field);
		}
#pragma warning restore 0169

		static IntPtr id_getField;
		public virtual unsafe global::Java.Lang.Reflect.Field Field {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getField' and count(parameter)=0]"
			[Register ("getField", "()Ljava/lang/reflect/Field;", "GetGetFieldHandler")]
			get {
				if (id_getField == IntPtr.Zero)
					id_getField = JNIEnv.GetMethodID (class_ref, "getField", "()Ljava/lang/reflect/Field;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getField), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getField", "()Ljava/lang/reflect/Field;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFieldType;
#pragma warning disable 0169
		static Delegate GetGetFieldTypeHandler ()
		{
			if (cb_getFieldType == null)
				cb_getFieldType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFieldType);
			return cb_getFieldType;
		}

		static IntPtr n_GetFieldType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FieldType);
		}
#pragma warning restore 0169

		static IntPtr id_getFieldType;
		public virtual unsafe global::Java.Lang.Class FieldType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getFieldType' and count(parameter)=0]"
			[Register ("getFieldType", "()Ljava/lang/Class;", "GetGetFieldTypeHandler")]
			get {
				if (id_getFieldType == IntPtr.Zero)
					id_getFieldType = JNIEnv.GetMethodID (class_ref, "getFieldType", "()Ljava/lang/Class;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFieldType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFieldType", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModifiers;
#pragma warning disable 0169
		static Delegate GetGetModifiersHandler ()
		{
			if (cb_getModifiers == null)
				cb_getModifiers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetModifiers);
			return cb_getModifiers;
		}

		static int n_GetModifiers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Modifiers;
		}
#pragma warning restore 0169

		static IntPtr id_getModifiers;
		public virtual unsafe int Modifiers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getModifiers' and count(parameter)=0]"
			[Register ("getModifiers", "()I", "GetGetModifiersHandler")]
			get {
				if (id_getModifiers == IntPtr.Zero)
					id_getModifiers = JNIEnv.GetMethodID (class_ref, "getModifiers", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getModifiers);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModifiers", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setLookupClassLoader_Ljava_lang_ClassLoader_;
#pragma warning disable 0169
		static Delegate GetSetLookupClassLoader_Ljava_lang_ClassLoader_Handler ()
		{
			if (cb_setLookupClassLoader_Ljava_lang_ClassLoader_ == null)
				cb_setLookupClassLoader_Ljava_lang_ClassLoader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLookupClassLoader_Ljava_lang_ClassLoader_);
			return cb_setLookupClassLoader_Ljava_lang_ClassLoader_;
		}

		static void n_SetLookupClassLoader_Ljava_lang_ClassLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_loader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var loader = global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (native_loader, JniHandleOwnership.DoNotTransfer);
			__this.SetLookupClassLoader (loader);
		}
#pragma warning restore 0169

		static IntPtr id_setLookupClassLoader_Ljava_lang_ClassLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='SignatureImpl']/method[@name='setLookupClassLoader' and count(parameter)=1 and parameter[1][@type='java.lang.ClassLoader']]"
		[Register ("setLookupClassLoader", "(Ljava/lang/ClassLoader;)V", "GetSetLookupClassLoader_Ljava_lang_ClassLoader_Handler")]
		public virtual unsafe void SetLookupClassLoader (global::Java.Lang.ClassLoader loader)
		{
			if (id_setLookupClassLoader_Ljava_lang_ClassLoader_ == IntPtr.Zero)
				id_setLookupClassLoader_Ljava_lang_ClassLoader_ = JNIEnv.GetMethodID (class_ref, "setLookupClassLoader", "(Ljava/lang/ClassLoader;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (loader);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLookupClassLoader_Ljava_lang_ClassLoader_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLookupClassLoader", "(Ljava/lang/ClassLoader;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_toLongString;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='SignatureImpl']/method[@name='toLongString' and count(parameter)=0]"
		[Register ("toLongString", "()Ljava/lang/String;", "")]
		public unsafe string ToLongString ()
		{
			if (id_toLongString == IntPtr.Zero)
				id_toLongString = JNIEnv.GetMethodID (class_ref, "toLongString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toLongString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toShortString;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='SignatureImpl']/method[@name='toShortString' and count(parameter)=0]"
		[Register ("toShortString", "()Ljava/lang/String;", "")]
		public unsafe string ToShortString ()
		{
			if (id_toShortString == IntPtr.Zero)
				id_toShortString = JNIEnv.GetMethodID (class_ref, "toShortString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toShortString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='SignatureImpl']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
