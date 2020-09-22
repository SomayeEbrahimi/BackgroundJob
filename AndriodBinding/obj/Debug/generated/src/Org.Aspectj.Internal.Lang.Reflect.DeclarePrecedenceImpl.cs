using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclarePrecedenceImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/DeclarePrecedenceImpl", DoNotGenerateAcw=true)]
	public partial class DeclarePrecedenceImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IDeclarePrecedence {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/internal/lang/reflect/DeclarePrecedenceImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeclarePrecedenceImpl); }
		}

		protected DeclarePrecedenceImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclarePrecedenceImpl']/constructor[@name='DeclarePrecedenceImpl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)V", "")]
		public unsafe DeclarePrecedenceImpl (string precedenceList, global::Org.Aspectj.Lang.Reflect.IAjType declaring)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_precedenceList = JNIEnv.NewString (precedenceList);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_precedenceList);
				__args [1] = new JValue (declaring);
				if (((object) this).GetType () != typeof (DeclarePrecedenceImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_precedenceList);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclarePrecedenceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		static IntPtr id_getDeclaringType;
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclarePrecedenceImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
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

		static Delegate cb_getPrecedenceOrder;
#pragma warning disable 0169
		static Delegate GetGetPrecedenceOrderHandler ()
		{
			if (cb_getPrecedenceOrder == null)
				cb_getPrecedenceOrder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrecedenceOrder);
			return cb_getPrecedenceOrder;
		}

		static IntPtr n_GetPrecedenceOrder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclarePrecedenceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPrecedenceOrder ());
		}
#pragma warning restore 0169

		static IntPtr id_getPrecedenceOrder;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclarePrecedenceImpl']/method[@name='getPrecedenceOrder' and count(parameter)=0]"
		[Register ("getPrecedenceOrder", "()[Lorg/aspectj/lang/reflect/TypePattern;", "GetGetPrecedenceOrderHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern[] GetPrecedenceOrder ()
		{
			if (id_getPrecedenceOrder == IntPtr.Zero)
				id_getPrecedenceOrder = JNIEnv.GetMethodID (class_ref, "getPrecedenceOrder", "()[Lorg/aspectj/lang/reflect/TypePattern;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Aspectj.Lang.Reflect.ITypePattern[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrecedenceOrder), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.ITypePattern));
				else
					return (global::Org.Aspectj.Lang.Reflect.ITypePattern[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrecedenceOrder", "()[Lorg/aspectj/lang/reflect/TypePattern;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.ITypePattern));
			} finally {
			}
		}

	}
}
