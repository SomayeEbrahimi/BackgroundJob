using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/InterTypeMethodDeclarationImpl", DoNotGenerateAcw=true)]
	public partial class InterTypeMethodDeclarationImpl : global::Org.Aspectj.Internal.Lang.Reflect.InterTypeDeclarationImpl, global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/internal/lang/reflect/InterTypeMethodDeclarationImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InterTypeMethodDeclarationImpl); }
		}

		protected InterTypeMethodDeclarationImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_ILjava_lang_String_Ljava_lang_reflect_Method_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/constructor[@name='InterTypeMethodDeclarationImpl' and count(parameter)=5 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.reflect.Method']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Ljava/lang/reflect/Method;)V", "")]
		public unsafe InterTypeMethodDeclarationImpl (global::Org.Aspectj.Lang.Reflect.IAjType decType, string target, int mods, string name, global::Java.Lang.Reflect.Method itdInterMethod)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_target = JNIEnv.NewString (target);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (decType);
				__args [1] = new JValue (native_target);
				__args [2] = new JValue (mods);
				__args [3] = new JValue (native_name);
				__args [4] = new JValue (itdInterMethod);
				if (((object) this).GetType () != typeof (InterTypeMethodDeclarationImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Ljava/lang/reflect/Method;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Ljava/lang/reflect/Method;)V", __args);
					return;
				}

				if (id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_ILjava_lang_String_Ljava_lang_reflect_Method_ == IntPtr.Zero)
					id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_ILjava_lang_String_Ljava_lang_reflect_Method_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Ljava/lang/reflect/Method;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_ILjava_lang_String_Ljava_lang_reflect_Method_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_ILjava_lang_String_Ljava_lang_reflect_Method_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_ctor_Lorg_aspectj_lang_reflect_AjType_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Method_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/constructor[@name='InterTypeMethodDeclarationImpl' and count(parameter)=4 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[3][@type='java.lang.reflect.Method'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Method;I)V", "")]
		public unsafe InterTypeMethodDeclarationImpl (global::Org.Aspectj.Lang.Reflect.IAjType decType, global::Org.Aspectj.Lang.Reflect.IAjType targetType, global::Java.Lang.Reflect.Method @base, int modifiers)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (decType);
				__args [1] = new JValue (targetType);
				__args [2] = new JValue (@base);
				__args [3] = new JValue (modifiers);
				if (((object) this).GetType () != typeof (InterTypeMethodDeclarationImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Method;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Method;I)V", __args);
					return;
				}

				if (id_ctor_Lorg_aspectj_lang_reflect_AjType_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Method_I == IntPtr.Zero)
					id_ctor_Lorg_aspectj_lang_reflect_AjType_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Method_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Method;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_aspectj_lang_reflect_AjType_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Method_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_aspectj_lang_reflect_AjType_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Method_I, __args);
			} finally {
			}
		}

		static Delegate cb_getGenericReturnType;
#pragma warning disable 0169
		static Delegate GetGetGenericReturnTypeHandler ()
		{
			if (cb_getGenericReturnType == null)
				cb_getGenericReturnType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGenericReturnType);
			return cb_getGenericReturnType;
		}

		static IntPtr n_GetGenericReturnType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenericReturnType);
		}
#pragma warning restore 0169

		static IntPtr id_getGenericReturnType;
		public virtual unsafe global::Java.Lang.Reflect.IType GenericReturnType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getGenericReturnType' and count(parameter)=0]"
			[Register ("getGenericReturnType", "()Ljava/lang/reflect/Type;", "GetGetGenericReturnTypeHandler")]
			get {
				if (id_getGenericReturnType == IntPtr.Zero)
					id_getGenericReturnType = JNIEnv.GetMethodID (class_ref, "getGenericReturnType", "()Ljava/lang/reflect/Type;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGenericReturnType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGenericReturnType", "()Ljava/lang/reflect/Type;")), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getName' and count(parameter)=0]"
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

		static Delegate cb_getReturnType;
#pragma warning disable 0169
		static Delegate GetGetReturnTypeHandler ()
		{
			if (cb_getReturnType == null)
				cb_getReturnType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReturnType);
			return cb_getReturnType;
		}

		static IntPtr n_GetReturnType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReturnType);
		}
#pragma warning restore 0169

		static IntPtr id_getReturnType;
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType ReturnType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getReturnType' and count(parameter)=0]"
			[Register ("getReturnType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetReturnTypeHandler")]
			get {
				if (id_getReturnType == IntPtr.Zero)
					id_getReturnType = JNIEnv.GetMethodID (class_ref, "getReturnType", "()Lorg/aspectj/lang/reflect/AjType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReturnType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReturnType", "()Lorg/aspectj/lang/reflect/AjType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExceptionTypes;
#pragma warning disable 0169
		static Delegate GetGetExceptionTypesHandler ()
		{
			if (cb_getExceptionTypes == null)
				cb_getExceptionTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExceptionTypes);
			return cb_getExceptionTypes;
		}

		static IntPtr n_GetExceptionTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExceptionTypes ());
		}
#pragma warning restore 0169

		static IntPtr id_getExceptionTypes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getExceptionTypes' and count(parameter)=0]"
		[Register ("getExceptionTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetExceptionTypesHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetExceptionTypes ()
		{
			if (id_getExceptionTypes == IntPtr.Zero)
				id_getExceptionTypes = JNIEnv.GetMethodID (class_ref, "getExceptionTypes", "()[Lorg/aspectj/lang/reflect/AjType;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExceptionTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
				else
					return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExceptionTypes", "()[Lorg/aspectj/lang/reflect/AjType;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			} finally {
			}
		}

		static Delegate cb_getGenericParameterTypes;
#pragma warning disable 0169
		static Delegate GetGetGenericParameterTypesHandler ()
		{
			if (cb_getGenericParameterTypes == null)
				cb_getGenericParameterTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGenericParameterTypes);
			return cb_getGenericParameterTypes;
		}

		static IntPtr n_GetGenericParameterTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGenericParameterTypes ());
		}
#pragma warning restore 0169

		static IntPtr id_getGenericParameterTypes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getGenericParameterTypes' and count(parameter)=0]"
		[Register ("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", "GetGetGenericParameterTypesHandler")]
		public virtual unsafe global::Java.Lang.Reflect.IType[] GetGenericParameterTypes ()
		{
			if (id_getGenericParameterTypes == IntPtr.Zero)
				id_getGenericParameterTypes = JNIEnv.GetMethodID (class_ref, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGenericParameterTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
				else
					return (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
			} finally {
			}
		}

		static Delegate cb_getParameterTypes;
#pragma warning disable 0169
		static Delegate GetGetParameterTypesHandler ()
		{
			if (cb_getParameterTypes == null)
				cb_getParameterTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParameterTypes);
			return cb_getParameterTypes;
		}

		static IntPtr n_GetParameterTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParameterTypes ());
		}
#pragma warning restore 0169

		static IntPtr id_getParameterTypes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getParameterTypes' and count(parameter)=0]"
		[Register ("getParameterTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetParameterTypesHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetParameterTypes ()
		{
			if (id_getParameterTypes == IntPtr.Zero)
				id_getParameterTypes = JNIEnv.GetMethodID (class_ref, "getParameterTypes", "()[Lorg/aspectj/lang/reflect/AjType;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameterTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
				else
					return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParameterTypes", "()[Lorg/aspectj/lang/reflect/AjType;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			} finally {
			}
		}

		static Delegate cb_getTypeParameters;
#pragma warning disable 0169
		static Delegate GetGetTypeParametersHandler ()
		{
			if (cb_getTypeParameters == null)
				cb_getTypeParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypeParameters);
			return cb_getTypeParameters;
		}

		static IntPtr n_GetTypeParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTypeParameters ());
		}
#pragma warning restore 0169

		static IntPtr id_getTypeParameters;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getTypeParameters' and count(parameter)=0]"
		[Register ("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", "GetGetTypeParametersHandler")]
		public virtual unsafe global::Java.Lang.Reflect.ITypeVariable[] GetTypeParameters ()
		{
			if (id_getTypeParameters == IntPtr.Zero)
				id_getTypeParameters = JNIEnv.GetMethodID (class_ref, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Java.Lang.Reflect.ITypeVariable[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeParameters), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.ITypeVariable));
				else
					return (global::Java.Lang.Reflect.ITypeVariable[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.ITypeVariable));
			} finally {
			}
		}

	}
}
