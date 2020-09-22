using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/DeclareAnnotationImpl", DoNotGenerateAcw=true)]
	public partial class DeclareAnnotationImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/internal/lang/reflect/DeclareAnnotationImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeclareAnnotationImpl); }
		}

		protected DeclareAnnotationImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_annotation_Annotation_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/constructor[@name='DeclareAnnotationImpl' and count(parameter)=5 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.annotation.Annotation'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/annotation/Annotation;Ljava/lang/String;)V", "")]
		public unsafe DeclareAnnotationImpl (global::Org.Aspectj.Lang.Reflect.IAjType declaring, string kindString, string pattern, global::Java.Lang.Annotation.IAnnotation ann, string annText)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_kindString = JNIEnv.NewString (kindString);
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			IntPtr native_annText = JNIEnv.NewString (annText);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (declaring);
				__args [1] = new JValue (native_kindString);
				__args [2] = new JValue (native_pattern);
				__args [3] = new JValue (ann);
				__args [4] = new JValue (native_annText);
				if (((object) this).GetType () != typeof (DeclareAnnotationImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/annotation/Annotation;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/annotation/Annotation;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_annotation_Annotation_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_annotation_Annotation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/annotation/Annotation;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_annotation_Annotation_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_annotation_Annotation_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_kindString);
				JNIEnv.DeleteLocalRef (native_pattern);
				JNIEnv.DeleteLocalRef (native_annText);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Annotation);
		}
#pragma warning restore 0169

		static IntPtr id_getAnnotation;
		public virtual unsafe global::Java.Lang.Annotation.IAnnotation Annotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getAnnotation' and count(parameter)=0]"
			[Register ("getAnnotation", "()Ljava/lang/annotation/Annotation;", "GetGetAnnotationHandler")]
			get {
				if (id_getAnnotation == IntPtr.Zero)
					id_getAnnotation = JNIEnv.GetMethodID (class_ref, "getAnnotation", "()Ljava/lang/annotation/Annotation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Annotation.IAnnotation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnnotation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Annotation.IAnnotation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnnotation", "()Ljava/lang/annotation/Annotation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AnnotationAsText);
		}
#pragma warning restore 0169

		static IntPtr id_getAnnotationAsText;
		public virtual unsafe string AnnotationAsText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getAnnotationAsText' and count(parameter)=0]"
			[Register ("getAnnotationAsText", "()Ljava/lang/String;", "GetGetAnnotationAsTextHandler")]
			get {
				if (id_getAnnotationAsText == IntPtr.Zero)
					id_getAnnotationAsText = JNIEnv.GetMethodID (class_ref, "getAnnotationAsText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnnotationAsText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnnotationAsText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		static IntPtr id_getDeclaringType;
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
			[Register ("getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetDeclaringTypeHandler")]
			get {
				if (id_getDeclaringType == IntPtr.Zero)
					id_getDeclaringType = JNIEnv.GetMethodID (class_ref, "getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaringType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Kind);
		}
#pragma warning restore 0169

		static IntPtr id_getKind;
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind Kind {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getKind' and count(parameter)=0]"
			[Register ("getKind", "()Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;", "GetGetKindHandler")]
			get {
				if (id_getKind == IntPtr.Zero)
					id_getKind = JNIEnv.GetMethodID (class_ref, "getKind", "()Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKind), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKind", "()Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SignaturePattern);
		}
#pragma warning restore 0169

		static IntPtr id_getSignaturePattern;
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.ISignaturePattern SignaturePattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getSignaturePattern' and count(parameter)=0]"
			[Register ("getSignaturePattern", "()Lorg/aspectj/lang/reflect/SignaturePattern;", "GetGetSignaturePatternHandler")]
			get {
				if (id_getSignaturePattern == IntPtr.Zero)
					id_getSignaturePattern = JNIEnv.GetMethodID (class_ref, "getSignaturePattern", "()Lorg/aspectj/lang/reflect/SignaturePattern;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISignaturePattern> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignaturePattern), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISignaturePattern> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSignaturePattern", "()Lorg/aspectj/lang/reflect/SignaturePattern;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TypePattern);
		}
#pragma warning restore 0169

		static IntPtr id_getTypePattern;
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern TypePattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getTypePattern' and count(parameter)=0]"
			[Register ("getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;", "GetGetTypePatternHandler")]
			get {
				if (id_getTypePattern == IntPtr.Zero)
					id_getTypePattern = JNIEnv.GetMethodID (class_ref, "getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypePattern), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
