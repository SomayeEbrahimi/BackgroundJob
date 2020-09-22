using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/InterTypeFieldDeclarationImpl", DoNotGenerateAcw=true)]
	public partial class InterTypeFieldDeclarationImpl : global::Org.Aspectj.Internal.Lang.Reflect.InterTypeDeclarationImpl, global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/internal/lang/reflect/InterTypeFieldDeclarationImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InterTypeFieldDeclarationImpl); }
		}

		protected InterTypeFieldDeclarationImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_ILjava_lang_String_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']/constructor[@name='InterTypeFieldDeclarationImpl' and count(parameter)=6 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[6][@type='java.lang.reflect.Type']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Type;)V", "")]
		public unsafe InterTypeFieldDeclarationImpl (global::Org.Aspectj.Lang.Reflect.IAjType decType, string target, int mods, string name, global::Org.Aspectj.Lang.Reflect.IAjType type, global::Java.Lang.Reflect.IType genericType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_target = JNIEnv.NewString (target);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (decType);
				__args [1] = new JValue (native_target);
				__args [2] = new JValue (mods);
				__args [3] = new JValue (native_name);
				__args [4] = new JValue (type);
				__args [5] = new JValue (genericType);
				if (((object) this).GetType () != typeof (InterTypeFieldDeclarationImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Type;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Type;)V", __args);
					return;
				}

				if (id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_ILjava_lang_String_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Type_ == IntPtr.Zero)
					id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_ILjava_lang_String_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Type;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_ILjava_lang_String_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Type_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_String_ILjava_lang_String_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Type_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_ctor_Lorg_aspectj_lang_reflect_AjType_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Field_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']/constructor[@name='InterTypeFieldDeclarationImpl' and count(parameter)=3 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[3][@type='java.lang.reflect.Field']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Field;)V", "")]
		public unsafe InterTypeFieldDeclarationImpl (global::Org.Aspectj.Lang.Reflect.IAjType decType, global::Org.Aspectj.Lang.Reflect.IAjType targetType, global::Java.Lang.Reflect.Field @base)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (decType);
				__args [1] = new JValue (targetType);
				__args [2] = new JValue (@base);
				if (((object) this).GetType () != typeof (InterTypeFieldDeclarationImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Field;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Field;)V", __args);
					return;
				}

				if (id_ctor_Lorg_aspectj_lang_reflect_AjType_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Field_ == IntPtr.Zero)
					id_ctor_Lorg_aspectj_lang_reflect_AjType_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Field_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Field;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_aspectj_lang_reflect_AjType_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Field_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_aspectj_lang_reflect_AjType_Lorg_aspectj_lang_reflect_AjType_Ljava_lang_reflect_Field_, __args);
			} finally {
			}
		}

		static Delegate cb_getGenericType;
#pragma warning disable 0169
		static Delegate GetGetGenericTypeHandler ()
		{
			if (cb_getGenericType == null)
				cb_getGenericType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGenericType);
			return cb_getGenericType;
		}

		static IntPtr n_GetGenericType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeFieldDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenericType);
		}
#pragma warning restore 0169

		static IntPtr id_getGenericType;
		public virtual unsafe global::Java.Lang.Reflect.IType GenericType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']/method[@name='getGenericType' and count(parameter)=0]"
			[Register ("getGenericType", "()Ljava/lang/reflect/Type;", "GetGetGenericTypeHandler")]
			get {
				if (id_getGenericType == IntPtr.Zero)
					id_getGenericType = JNIEnv.GetMethodID (class_ref, "getGenericType", "()Ljava/lang/reflect/Type;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGenericType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGenericType", "()Ljava/lang/reflect/Type;")), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeFieldDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']/method[@name='getName' and count(parameter)=0]"
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeFieldDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lorg/aspectj/lang/reflect/AjType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lorg/aspectj/lang/reflect/AjType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
