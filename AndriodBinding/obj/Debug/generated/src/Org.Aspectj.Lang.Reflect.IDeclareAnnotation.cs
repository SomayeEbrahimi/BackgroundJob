using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='DeclareAnnotation.Kind']"
	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/DeclareAnnotation$Kind", DoNotGenerateAcw=true)]
	public sealed partial class DeclareAnnotationKind : global::Java.Lang.Enum {


		static IntPtr Constructor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='DeclareAnnotation.Kind']/field[@name='Constructor']"
		[Register ("Constructor")]
		public static global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind Constructor {
			get {
				if (Constructor_jfieldId == IntPtr.Zero)
					Constructor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Constructor", "Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Constructor_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Field_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='DeclareAnnotation.Kind']/field[@name='Field']"
		[Register ("Field")]
		public static global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind Field {
			get {
				if (Field_jfieldId == IntPtr.Zero)
					Field_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Field", "Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Field_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Method_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='DeclareAnnotation.Kind']/field[@name='Method']"
		[Register ("Method")]
		public static global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind Method {
			get {
				if (Method_jfieldId == IntPtr.Zero)
					Method_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Method", "Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Method_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='DeclareAnnotation.Kind']/field[@name='Type']"
		[Register ("Type")]
		public static global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind Type {
			get {
				if (Type_jfieldId == IntPtr.Zero)
					Type_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Type", "Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/lang/reflect/DeclareAnnotation$Kind", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeclareAnnotationKind); }
		}

		internal DeclareAnnotationKind (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='DeclareAnnotation.Kind']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;", "")]
		public static unsafe global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='DeclareAnnotation.Kind']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;", "")]
		public static unsafe global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;");
			try {
				return (global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareAnnotation']"
	[Register ("org/aspectj/lang/reflect/DeclareAnnotation", "", "Org.Aspectj.Lang.Reflect.IDeclareAnnotationInvoker")]
	public partial interface IDeclareAnnotation : IJavaObject {

		global::Java.Lang.Annotation.IAnnotation Annotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareAnnotation']/method[@name='getAnnotation' and count(parameter)=0]"
			[Register ("getAnnotation", "()Ljava/lang/annotation/Annotation;", "GetGetAnnotationHandler:Org.Aspectj.Lang.Reflect.IDeclareAnnotationInvoker, AndriodBinding")] get;
		}

		string AnnotationAsText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareAnnotation']/method[@name='getAnnotationAsText' and count(parameter)=0]"
			[Register ("getAnnotationAsText", "()Ljava/lang/String;", "GetGetAnnotationAsTextHandler:Org.Aspectj.Lang.Reflect.IDeclareAnnotationInvoker, AndriodBinding")] get;
		}

		global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareAnnotation']/method[@name='getDeclaringType' and count(parameter)=0]"
			[Register ("getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetDeclaringTypeHandler:Org.Aspectj.Lang.Reflect.IDeclareAnnotationInvoker, AndriodBinding")] get;
		}

		global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind Kind {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareAnnotation']/method[@name='getKind' and count(parameter)=0]"
			[Register ("getKind", "()Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;", "GetGetKindHandler:Org.Aspectj.Lang.Reflect.IDeclareAnnotationInvoker, AndriodBinding")] get;
		}

		global::Org.Aspectj.Lang.Reflect.ISignaturePattern SignaturePattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareAnnotation']/method[@name='getSignaturePattern' and count(parameter)=0]"
			[Register ("getSignaturePattern", "()Lorg/aspectj/lang/reflect/SignaturePattern;", "GetGetSignaturePatternHandler:Org.Aspectj.Lang.Reflect.IDeclareAnnotationInvoker, AndriodBinding")] get;
		}

		global::Org.Aspectj.Lang.Reflect.ITypePattern TypePattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareAnnotation']/method[@name='getTypePattern' and count(parameter)=0]"
			[Register ("getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;", "GetGetTypePatternHandler:Org.Aspectj.Lang.Reflect.IDeclareAnnotationInvoker, AndriodBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/DeclareAnnotation", DoNotGenerateAcw=true)]
	internal partial class IDeclareAnnotationInvoker : global::Java.Lang.Object, IDeclareAnnotation {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/aspectj/lang/reflect/DeclareAnnotation");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDeclareAnnotationInvoker); }
		}

		IntPtr class_ref;

		public static IDeclareAnnotation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeclareAnnotation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.DeclareAnnotation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeclareAnnotationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAnnotation;
#pragma warning disable 0169
		static Delegate GetGetAnnotationHandler ()
		{
			if (cb_getAnnotation == null)
				cb_getAnnotation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAnnotation);
			return cb_getAnnotation;
		}

		static IntPtr n_GetAnnotation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Annotation);
		}
#pragma warning restore 0169

		IntPtr id_getAnnotation;
		public unsafe global::Java.Lang.Annotation.IAnnotation Annotation {
			get {
				if (id_getAnnotation == IntPtr.Zero)
					id_getAnnotation = JNIEnv.GetMethodID (class_ref, "getAnnotation", "()Ljava/lang/annotation/Annotation;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Annotation.IAnnotation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnnotation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAnnotationAsText;
#pragma warning disable 0169
		static Delegate GetGetAnnotationAsTextHandler ()
		{
			if (cb_getAnnotationAsText == null)
				cb_getAnnotationAsText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAnnotationAsText);
			return cb_getAnnotationAsText;
		}

		static IntPtr n_GetAnnotationAsText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AnnotationAsText);
		}
#pragma warning restore 0169

		IntPtr id_getAnnotationAsText;
		public unsafe string AnnotationAsText {
			get {
				if (id_getAnnotationAsText == IntPtr.Zero)
					id_getAnnotationAsText = JNIEnv.GetMethodID (class_ref, "getAnnotationAsText", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnnotationAsText), JniHandleOwnership.TransferLocalRef);
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		IntPtr id_getDeclaringType;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			get {
				if (id_getDeclaringType == IntPtr.Zero)
					id_getDeclaringType = JNIEnv.GetMethodID (class_ref, "getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaringType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getKind;
#pragma warning disable 0169
		static Delegate GetGetKindHandler ()
		{
			if (cb_getKind == null)
				cb_getKind = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetKind);
			return cb_getKind;
		}

		static IntPtr n_GetKind (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Kind);
		}
#pragma warning restore 0169

		IntPtr id_getKind;
		public unsafe global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind Kind {
			get {
				if (id_getKind == IntPtr.Zero)
					id_getKind = JNIEnv.GetMethodID (class_ref, "getKind", "()Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKind), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSignaturePattern;
#pragma warning disable 0169
		static Delegate GetGetSignaturePatternHandler ()
		{
			if (cb_getSignaturePattern == null)
				cb_getSignaturePattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSignaturePattern);
			return cb_getSignaturePattern;
		}

		static IntPtr n_GetSignaturePattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SignaturePattern);
		}
#pragma warning restore 0169

		IntPtr id_getSignaturePattern;
		public unsafe global::Org.Aspectj.Lang.Reflect.ISignaturePattern SignaturePattern {
			get {
				if (id_getSignaturePattern == IntPtr.Zero)
					id_getSignaturePattern = JNIEnv.GetMethodID (class_ref, "getSignaturePattern", "()Lorg/aspectj/lang/reflect/SignaturePattern;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISignaturePattern> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignaturePattern), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTypePattern;
#pragma warning disable 0169
		static Delegate GetGetTypePatternHandler ()
		{
			if (cb_getTypePattern == null)
				cb_getTypePattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypePattern);
			return cb_getTypePattern;
		}

		static IntPtr n_GetTypePattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TypePattern);
		}
#pragma warning restore 0169

		IntPtr id_getTypePattern;
		public unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern TypePattern {
			get {
				if (id_getTypePattern == IntPtr.Zero)
					id_getTypePattern = JNIEnv.GetMethodID (class_ref, "getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypePattern), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
