using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/DeclareParentsImpl", DoNotGenerateAcw=true)]
	public partial class DeclareParentsImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IDeclareParents {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/internal/lang/reflect/DeclareParentsImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeclareParentsImpl); }
		}

		protected DeclareParentsImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_ZLorg_aspectj_lang_reflect_AjType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/constructor[@name='DeclareParentsImpl' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ZLorg/aspectj/lang/reflect/AjType;)V", "")]
		public unsafe DeclareParentsImpl (string targets, string parentsAsString, bool isExtends, global::Org.Aspectj.Lang.Reflect.IAjType declaring)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_targets = JNIEnv.NewString (targets);
			IntPtr native_parentsAsString = JNIEnv.NewString (parentsAsString);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_targets);
				__args [1] = new JValue (native_parentsAsString);
				__args [2] = new JValue (isExtends);
				__args [3] = new JValue (declaring);
				if (((object) this).GetType () != typeof (DeclareParentsImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;ZLorg/aspectj/lang/reflect/AjType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;ZLorg/aspectj/lang/reflect/AjType;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ZLorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ZLorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;ZLorg/aspectj/lang/reflect/AjType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_ZLorg_aspectj_lang_reflect_AjType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_ZLorg_aspectj_lang_reflect_AjType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_targets);
				JNIEnv.DeleteLocalRef (native_parentsAsString);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareParentsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		static IntPtr id_getDeclaringType;
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
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

		static Delegate cb_isExtends;
#pragma warning disable 0169
		static Delegate GetIsExtendsHandler ()
		{
			if (cb_isExtends == null)
				cb_isExtends = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExtends);
			return cb_isExtends;
		}

		static bool n_IsExtends (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareParentsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExtends;
		}
#pragma warning restore 0169

		static IntPtr id_isExtends;
		public virtual unsafe bool IsExtends {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/method[@name='isExtends' and count(parameter)=0]"
			[Register ("isExtends", "()Z", "GetIsExtendsHandler")]
			get {
				if (id_isExtends == IntPtr.Zero)
					id_isExtends = JNIEnv.GetMethodID (class_ref, "isExtends", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExtends);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExtends", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isImplements;
#pragma warning disable 0169
		static Delegate GetIsImplementsHandler ()
		{
			if (cb_isImplements == null)
				cb_isImplements = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsImplements);
			return cb_isImplements;
		}

		static bool n_IsImplements (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareParentsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsImplements;
		}
#pragma warning restore 0169

		static IntPtr id_isImplements;
		public virtual unsafe bool IsImplements {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/method[@name='isImplements' and count(parameter)=0]"
			[Register ("isImplements", "()Z", "GetIsImplementsHandler")]
			get {
				if (id_isImplements == IntPtr.Zero)
					id_isImplements = JNIEnv.GetMethodID (class_ref, "isImplements", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isImplements);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isImplements", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getTargetTypesPattern;
#pragma warning disable 0169
		static Delegate GetGetTargetTypesPatternHandler ()
		{
			if (cb_getTargetTypesPattern == null)
				cb_getTargetTypesPattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTargetTypesPattern);
			return cb_getTargetTypesPattern;
		}

		static IntPtr n_GetTargetTypesPattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareParentsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TargetTypesPattern);
		}
#pragma warning restore 0169

		static IntPtr id_getTargetTypesPattern;
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern TargetTypesPattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/method[@name='getTargetTypesPattern' and count(parameter)=0]"
			[Register ("getTargetTypesPattern", "()Lorg/aspectj/lang/reflect/TypePattern;", "GetGetTargetTypesPatternHandler")]
			get {
				if (id_getTargetTypesPattern == IntPtr.Zero)
					id_getTargetTypesPattern = JNIEnv.GetMethodID (class_ref, "getTargetTypesPattern", "()Lorg/aspectj/lang/reflect/TypePattern;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTargetTypesPattern), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTargetTypesPattern", "()Lorg/aspectj/lang/reflect/TypePattern;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getParentTypes;
#pragma warning disable 0169
		static Delegate GetGetParentTypesHandler ()
		{
			if (cb_getParentTypes == null)
				cb_getParentTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParentTypes);
			return cb_getParentTypes;
		}

		static IntPtr n_GetParentTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareParentsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParentTypes ());
		}
#pragma warning restore 0169

		static IntPtr id_getParentTypes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/method[@name='getParentTypes' and count(parameter)=0]"
		[Register ("getParentTypes", "()[Ljava/lang/reflect/Type;", "GetGetParentTypesHandler")]
		public virtual unsafe global::Java.Lang.Reflect.IType[] GetParentTypes ()
		{
			if (id_getParentTypes == IntPtr.Zero)
				id_getParentTypes = JNIEnv.GetMethodID (class_ref, "getParentTypes", "()[Ljava/lang/reflect/Type;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParentTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
				else
					return (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParentTypes", "()[Ljava/lang/reflect/Type;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
			} finally {
			}
		}

	}
}
