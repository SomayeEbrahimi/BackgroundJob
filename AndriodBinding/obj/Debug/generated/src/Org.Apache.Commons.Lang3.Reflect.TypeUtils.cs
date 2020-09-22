using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/reflect/TypeUtils", DoNotGenerateAcw=true)]
	public partial class TypeUtils : global::Java.Lang.Object {


		static IntPtr WILDCARD_ALL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/field[@name='WILDCARD_ALL']"
		[Register ("WILDCARD_ALL")]
		public static global::Java.Lang.Reflect.IWildcardType WildcardAll {
			get {
				if (WILDCARD_ALL_jfieldId == IntPtr.Zero)
					WILDCARD_ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WILDCARD_ALL", "Ljava/lang/reflect/WildcardType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WILDCARD_ALL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IWildcardType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils.WildcardTypeBuilder']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/reflect/TypeUtils$WildcardTypeBuilder", DoNotGenerateAcw=true)]
		public partial class WildcardTypeBuilder : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Builder.IBuilder {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/reflect/TypeUtils$WildcardTypeBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WildcardTypeBuilder); }
			}

			protected WildcardTypeBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils.WildcardTypeBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Ljava/lang/reflect/WildcardType;", "GetBuildHandler")]
			public virtual unsafe global::Java.Lang.Reflect.IWildcardType Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Ljava/lang/reflect/WildcardType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IWildcardType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IWildcardType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Ljava/lang/reflect/WildcardType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withLowerBounds_arrayLjava_lang_reflect_Type_;
#pragma warning disable 0169
			static Delegate GetWithLowerBounds_arrayLjava_lang_reflect_Type_Handler ()
			{
				if (cb_withLowerBounds_arrayLjava_lang_reflect_Type_ == null)
					cb_withLowerBounds_arrayLjava_lang_reflect_Type_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithLowerBounds_arrayLjava_lang_reflect_Type_);
				return cb_withLowerBounds_arrayLjava_lang_reflect_Type_;
			}

			static IntPtr n_WithLowerBounds_arrayLjava_lang_reflect_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bounds)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var bounds = (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (native_bounds, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Reflect.IType));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLowerBounds (bounds));
				if (bounds != null)
					JNIEnv.CopyArray (bounds, native_bounds);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withLowerBounds_arrayLjava_lang_reflect_Type_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils.WildcardTypeBuilder']/method[@name='withLowerBounds' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type...']]"
			[Register ("withLowerBounds", "([Ljava/lang/reflect/Type;)Lorg/apache/commons/lang3/reflect/TypeUtils$WildcardTypeBuilder;", "GetWithLowerBounds_arrayLjava_lang_reflect_Type_Handler")]
			public virtual unsafe global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder WithLowerBounds (params global::Java.Lang.Reflect.IType[] bounds)
			{
				if (id_withLowerBounds_arrayLjava_lang_reflect_Type_ == IntPtr.Zero)
					id_withLowerBounds_arrayLjava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "withLowerBounds", "([Ljava/lang/reflect/Type;)Lorg/apache/commons/lang3/reflect/TypeUtils$WildcardTypeBuilder;");
				IntPtr native_bounds = JNIEnv.NewArray (bounds);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_bounds);

					global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withLowerBounds_arrayLjava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withLowerBounds", "([Ljava/lang/reflect/Type;)Lorg/apache/commons/lang3/reflect/TypeUtils$WildcardTypeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (bounds != null) {
						JNIEnv.CopyArray (native_bounds, bounds);
						JNIEnv.DeleteLocalRef (native_bounds);
					}
				}
			}

			static Delegate cb_withUpperBounds_arrayLjava_lang_reflect_Type_;
#pragma warning disable 0169
			static Delegate GetWithUpperBounds_arrayLjava_lang_reflect_Type_Handler ()
			{
				if (cb_withUpperBounds_arrayLjava_lang_reflect_Type_ == null)
					cb_withUpperBounds_arrayLjava_lang_reflect_Type_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithUpperBounds_arrayLjava_lang_reflect_Type_);
				return cb_withUpperBounds_arrayLjava_lang_reflect_Type_;
			}

			static IntPtr n_WithUpperBounds_arrayLjava_lang_reflect_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bounds)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var bounds = (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (native_bounds, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Reflect.IType));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithUpperBounds (bounds));
				if (bounds != null)
					JNIEnv.CopyArray (bounds, native_bounds);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withUpperBounds_arrayLjava_lang_reflect_Type_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils.WildcardTypeBuilder']/method[@name='withUpperBounds' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type...']]"
			[Register ("withUpperBounds", "([Ljava/lang/reflect/Type;)Lorg/apache/commons/lang3/reflect/TypeUtils$WildcardTypeBuilder;", "GetWithUpperBounds_arrayLjava_lang_reflect_Type_Handler")]
			public virtual unsafe global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder WithUpperBounds (params global::Java.Lang.Reflect.IType[] bounds)
			{
				if (id_withUpperBounds_arrayLjava_lang_reflect_Type_ == IntPtr.Zero)
					id_withUpperBounds_arrayLjava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "withUpperBounds", "([Ljava/lang/reflect/Type;)Lorg/apache/commons/lang3/reflect/TypeUtils$WildcardTypeBuilder;");
				IntPtr native_bounds = JNIEnv.NewArray (bounds);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_bounds);

					global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withUpperBounds_arrayLjava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withUpperBounds", "([Ljava/lang/reflect/Type;)Lorg/apache/commons/lang3/reflect/TypeUtils$WildcardTypeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (bounds != null) {
						JNIEnv.CopyArray (native_bounds, bounds);
						JNIEnv.DeleteLocalRef (native_bounds);
					}
				}
			}

			// This method is explicitly implemented as a member of an instantiated Org.Apache.Commons.Lang3.Builder.IBuilder
			global::Java.Lang.Object global::Org.Apache.Commons.Lang3.Builder.IBuilder.Build ()
			{
				return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Build ());
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/reflect/TypeUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TypeUtils); }
		}

		protected TypeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/constructor[@name='TypeUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TypeUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TypeUtils)) {
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

		static IntPtr id_containsTypeVariables_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='containsTypeVariables' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("containsTypeVariables", "(Ljava/lang/reflect/Type;)Z", "")]
		public static unsafe bool ContainsTypeVariables (global::Java.Lang.Reflect.IType type)
		{
			if (id_containsTypeVariables_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_containsTypeVariables_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "containsTypeVariables", "(Ljava/lang/reflect/Type;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsTypeVariables_Ljava_lang_reflect_Type_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_determineTypeArguments_Ljava_lang_Class_Ljava_lang_reflect_ParameterizedType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='determineTypeArguments' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.reflect.ParameterizedType']]"
		[Register ("determineTypeArguments", "(Ljava/lang/Class;Ljava/lang/reflect/ParameterizedType;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType> DetermineTypeArguments (global::Java.Lang.Class cls, global::Java.Lang.Reflect.IParameterizedType superType)
		{
			if (id_determineTypeArguments_Ljava_lang_Class_Ljava_lang_reflect_ParameterizedType_ == IntPtr.Zero)
				id_determineTypeArguments_Ljava_lang_Class_Ljava_lang_reflect_ParameterizedType_ = JNIEnv.GetStaticMethodID (class_ref, "determineTypeArguments", "(Ljava/lang/Class;Ljava/lang/reflect/ParameterizedType;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cls);
				__args [1] = new JValue (superType);
				global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType> __ret = global::Android.Runtime.JavaDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_determineTypeArguments_Ljava_lang_Class_Ljava_lang_reflect_ParameterizedType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_equals_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("equals", "(Ljava/lang/reflect/Type;Ljava/lang/reflect/Type;)Z", "")]
		public static unsafe bool Equals (global::Java.Lang.Reflect.IType t1, global::Java.Lang.Reflect.IType t2)
		{
			if (id_equals_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_equals_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(Ljava/lang/reflect/Type;Ljava/lang/reflect/Type;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (t1);
				__args [1] = new JValue (t2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_genericArrayType_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='genericArrayType' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("genericArrayType", "(Ljava/lang/reflect/Type;)Ljava/lang/reflect/GenericArrayType;", "")]
		public static unsafe global::Java.Lang.Reflect.IGenericArrayType GenericArrayType (global::Java.Lang.Reflect.IType componentType)
		{
			if (id_genericArrayType_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_genericArrayType_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "genericArrayType", "(Ljava/lang/reflect/Type;)Ljava/lang/reflect/GenericArrayType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (componentType);
				global::Java.Lang.Reflect.IGenericArrayType __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IGenericArrayType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_genericArrayType_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getArrayComponentType_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='getArrayComponentType' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("getArrayComponentType", "(Ljava/lang/reflect/Type;)Ljava/lang/reflect/Type;", "")]
		public static unsafe global::Java.Lang.Reflect.IType GetArrayComponentType (global::Java.Lang.Reflect.IType type)
		{
			if (id_getArrayComponentType_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_getArrayComponentType_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getArrayComponentType", "(Ljava/lang/reflect/Type;)Ljava/lang/reflect/Type;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				global::Java.Lang.Reflect.IType __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getArrayComponentType_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getImplicitBounds_Ljava_lang_reflect_TypeVariable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='getImplicitBounds' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.TypeVariable&lt;?&gt;']]"
		[Register ("getImplicitBounds", "(Ljava/lang/reflect/TypeVariable;)[Ljava/lang/reflect/Type;", "")]
		public static unsafe global::Java.Lang.Reflect.IType[] GetImplicitBounds (global::Java.Lang.Reflect.ITypeVariable typeVariable)
		{
			if (id_getImplicitBounds_Ljava_lang_reflect_TypeVariable_ == IntPtr.Zero)
				id_getImplicitBounds_Ljava_lang_reflect_TypeVariable_ = JNIEnv.GetStaticMethodID (class_ref, "getImplicitBounds", "(Ljava/lang/reflect/TypeVariable;)[Ljava/lang/reflect/Type;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (typeVariable);
				global::Java.Lang.Reflect.IType[] __ret = (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImplicitBounds_Ljava_lang_reflect_TypeVariable_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getImplicitLowerBounds_Ljava_lang_reflect_WildcardType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='getImplicitLowerBounds' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.WildcardType']]"
		[Register ("getImplicitLowerBounds", "(Ljava/lang/reflect/WildcardType;)[Ljava/lang/reflect/Type;", "")]
		public static unsafe global::Java.Lang.Reflect.IType[] GetImplicitLowerBounds (global::Java.Lang.Reflect.IWildcardType wildcardType)
		{
			if (id_getImplicitLowerBounds_Ljava_lang_reflect_WildcardType_ == IntPtr.Zero)
				id_getImplicitLowerBounds_Ljava_lang_reflect_WildcardType_ = JNIEnv.GetStaticMethodID (class_ref, "getImplicitLowerBounds", "(Ljava/lang/reflect/WildcardType;)[Ljava/lang/reflect/Type;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (wildcardType);
				global::Java.Lang.Reflect.IType[] __ret = (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImplicitLowerBounds_Ljava_lang_reflect_WildcardType_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getImplicitUpperBounds_Ljava_lang_reflect_WildcardType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='getImplicitUpperBounds' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.WildcardType']]"
		[Register ("getImplicitUpperBounds", "(Ljava/lang/reflect/WildcardType;)[Ljava/lang/reflect/Type;", "")]
		public static unsafe global::Java.Lang.Reflect.IType[] GetImplicitUpperBounds (global::Java.Lang.Reflect.IWildcardType wildcardType)
		{
			if (id_getImplicitUpperBounds_Ljava_lang_reflect_WildcardType_ == IntPtr.Zero)
				id_getImplicitUpperBounds_Ljava_lang_reflect_WildcardType_ = JNIEnv.GetStaticMethodID (class_ref, "getImplicitUpperBounds", "(Ljava/lang/reflect/WildcardType;)[Ljava/lang/reflect/Type;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (wildcardType);
				global::Java.Lang.Reflect.IType[] __ret = (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImplicitUpperBounds_Ljava_lang_reflect_WildcardType_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRawType_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='getRawType' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("getRawType", "(Ljava/lang/reflect/Type;Ljava/lang/reflect/Type;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class GetRawType (global::Java.Lang.Reflect.IType type, global::Java.Lang.Reflect.IType assigningType)
		{
			if (id_getRawType_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_getRawType_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getRawType", "(Ljava/lang/reflect/Type;Ljava/lang/reflect/Type;)Ljava/lang/Class;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (type);
				__args [1] = new JValue (assigningType);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRawType_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTypeArguments_Ljava_lang_reflect_ParameterizedType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='getTypeArguments' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.ParameterizedType']]"
		[Register ("getTypeArguments", "(Ljava/lang/reflect/ParameterizedType;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType> GetTypeArguments (global::Java.Lang.Reflect.IParameterizedType type)
		{
			if (id_getTypeArguments_Ljava_lang_reflect_ParameterizedType_ == IntPtr.Zero)
				id_getTypeArguments_Ljava_lang_reflect_ParameterizedType_ = JNIEnv.GetStaticMethodID (class_ref, "getTypeArguments", "(Ljava/lang/reflect/ParameterizedType;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType> __ret = global::Android.Runtime.JavaDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTypeArguments_Ljava_lang_reflect_ParameterizedType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTypeArguments_Ljava_lang_reflect_Type_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='getTypeArguments' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getTypeArguments", "(Ljava/lang/reflect/Type;Ljava/lang/Class;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType> GetTypeArguments (global::Java.Lang.Reflect.IType type, global::Java.Lang.Class toClass)
		{
			if (id_getTypeArguments_Ljava_lang_reflect_Type_Ljava_lang_Class_ == IntPtr.Zero)
				id_getTypeArguments_Ljava_lang_reflect_Type_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getTypeArguments", "(Ljava/lang/reflect/Type;Ljava/lang/Class;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (type);
				__args [1] = new JValue (toClass);
				global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType> __ret = global::Android.Runtime.JavaDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTypeArguments_Ljava_lang_reflect_Type_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isArrayType_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='isArrayType' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("isArrayType", "(Ljava/lang/reflect/Type;)Z", "")]
		public static unsafe bool IsArrayType (global::Java.Lang.Reflect.IType type)
		{
			if (id_isArrayType_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_isArrayType_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "isArrayType", "(Ljava/lang/reflect/Type;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isArrayType_Ljava_lang_reflect_Type_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isAssignable_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='isAssignable' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("isAssignable", "(Ljava/lang/reflect/Type;Ljava/lang/reflect/Type;)Z", "")]
		public static unsafe bool IsAssignable (global::Java.Lang.Reflect.IType type, global::Java.Lang.Reflect.IType toType)
		{
			if (id_isAssignable_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_isAssignable_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "isAssignable", "(Ljava/lang/reflect/Type;Ljava/lang/reflect/Type;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (type);
				__args [1] = new JValue (toType);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAssignable_Ljava_lang_reflect_Type_Ljava_lang_reflect_Type_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isInstance_Ljava_lang_Object_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='isInstance' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("isInstance", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Z", "")]
		public static unsafe bool IsInstance (global::Java.Lang.Object value, global::Java.Lang.Reflect.IType type)
		{
			if (id_isInstance_Ljava_lang_Object_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_isInstance_Ljava_lang_Object_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "isInstance", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (value);
				__args [1] = new JValue (type);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isInstance_Ljava_lang_Object_Ljava_lang_reflect_Type_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_normalizeUpperBounds_arrayLjava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='normalizeUpperBounds' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type[]']]"
		[Register ("normalizeUpperBounds", "([Ljava/lang/reflect/Type;)[Ljava/lang/reflect/Type;", "")]
		public static unsafe global::Java.Lang.Reflect.IType[] NormalizeUpperBounds (global::Java.Lang.Reflect.IType[] bounds)
		{
			if (id_normalizeUpperBounds_arrayLjava_lang_reflect_Type_ == IntPtr.Zero)
				id_normalizeUpperBounds_arrayLjava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "normalizeUpperBounds", "([Ljava/lang/reflect/Type;)[Ljava/lang/reflect/Type;");
			IntPtr native_bounds = JNIEnv.NewArray (bounds);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bounds);
				global::Java.Lang.Reflect.IType[] __ret = (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_normalizeUpperBounds_arrayLjava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
				return __ret;
			} finally {
				if (bounds != null) {
					JNIEnv.CopyArray (native_bounds, bounds);
					JNIEnv.DeleteLocalRef (native_bounds);
				}
			}
		}

		static IntPtr id_parameterize_Ljava_lang_Class_arrayLjava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='parameterize' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.reflect.Type...']]"
		[Register ("parameterize", "(Ljava/lang/Class;[Ljava/lang/reflect/Type;)Ljava/lang/reflect/ParameterizedType;", "")]
		public static unsafe global::Java.Lang.Reflect.IParameterizedType Parameterize (global::Java.Lang.Class raw, params global::Java.Lang.Reflect.IType[] typeArguments)
		{
			if (id_parameterize_Ljava_lang_Class_arrayLjava_lang_reflect_Type_ == IntPtr.Zero)
				id_parameterize_Ljava_lang_Class_arrayLjava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "parameterize", "(Ljava/lang/Class;[Ljava/lang/reflect/Type;)Ljava/lang/reflect/ParameterizedType;");
			IntPtr native_typeArguments = JNIEnv.NewArray (typeArguments);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (raw);
				__args [1] = new JValue (native_typeArguments);
				global::Java.Lang.Reflect.IParameterizedType __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IParameterizedType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parameterize_Ljava_lang_Class_arrayLjava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (typeArguments != null) {
					JNIEnv.CopyArray (native_typeArguments, typeArguments);
					JNIEnv.DeleteLocalRef (native_typeArguments);
				}
			}
		}

		static IntPtr id_parameterize_Ljava_lang_Class_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='parameterize' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.util.Map&lt;java.lang.reflect.TypeVariable&lt;?&gt;, java.lang.reflect.Type&gt;']]"
		[Register ("parameterize", "(Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/reflect/ParameterizedType;", "")]
		public static unsafe global::Java.Lang.Reflect.IParameterizedType Parameterize (global::Java.Lang.Class raw, global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType> typeArgMappings)
		{
			if (id_parameterize_Ljava_lang_Class_Ljava_util_Map_ == IntPtr.Zero)
				id_parameterize_Ljava_lang_Class_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "parameterize", "(Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/reflect/ParameterizedType;");
			IntPtr native_typeArgMappings = global::Android.Runtime.JavaDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType>.ToLocalJniHandle (typeArgMappings);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (raw);
				__args [1] = new JValue (native_typeArgMappings);
				global::Java.Lang.Reflect.IParameterizedType __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IParameterizedType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parameterize_Ljava_lang_Class_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_typeArgMappings);
			}
		}

		static IntPtr id_parameterizeWithOwner_Ljava_lang_reflect_Type_Ljava_lang_Class_arrayLjava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='parameterizeWithOwner' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.reflect.Type...']]"
		[Register ("parameterizeWithOwner", "(Ljava/lang/reflect/Type;Ljava/lang/Class;[Ljava/lang/reflect/Type;)Ljava/lang/reflect/ParameterizedType;", "")]
		public static unsafe global::Java.Lang.Reflect.IParameterizedType ParameterizeWithOwner (global::Java.Lang.Reflect.IType owner, global::Java.Lang.Class raw, params global::Java.Lang.Reflect.IType[] typeArguments)
		{
			if (id_parameterizeWithOwner_Ljava_lang_reflect_Type_Ljava_lang_Class_arrayLjava_lang_reflect_Type_ == IntPtr.Zero)
				id_parameterizeWithOwner_Ljava_lang_reflect_Type_Ljava_lang_Class_arrayLjava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "parameterizeWithOwner", "(Ljava/lang/reflect/Type;Ljava/lang/Class;[Ljava/lang/reflect/Type;)Ljava/lang/reflect/ParameterizedType;");
			IntPtr native_typeArguments = JNIEnv.NewArray (typeArguments);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (owner);
				__args [1] = new JValue (raw);
				__args [2] = new JValue (native_typeArguments);
				global::Java.Lang.Reflect.IParameterizedType __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IParameterizedType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parameterizeWithOwner_Ljava_lang_reflect_Type_Ljava_lang_Class_arrayLjava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (typeArguments != null) {
					JNIEnv.CopyArray (native_typeArguments, typeArguments);
					JNIEnv.DeleteLocalRef (native_typeArguments);
				}
			}
		}

		static IntPtr id_parameterizeWithOwner_Ljava_lang_reflect_Type_Ljava_lang_Class_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='parameterizeWithOwner' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.util.Map&lt;java.lang.reflect.TypeVariable&lt;?&gt;, java.lang.reflect.Type&gt;']]"
		[Register ("parameterizeWithOwner", "(Ljava/lang/reflect/Type;Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/reflect/ParameterizedType;", "")]
		public static unsafe global::Java.Lang.Reflect.IParameterizedType ParameterizeWithOwner (global::Java.Lang.Reflect.IType owner, global::Java.Lang.Class raw, global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType> typeArgMappings)
		{
			if (id_parameterizeWithOwner_Ljava_lang_reflect_Type_Ljava_lang_Class_Ljava_util_Map_ == IntPtr.Zero)
				id_parameterizeWithOwner_Ljava_lang_reflect_Type_Ljava_lang_Class_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "parameterizeWithOwner", "(Ljava/lang/reflect/Type;Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/reflect/ParameterizedType;");
			IntPtr native_typeArgMappings = global::Android.Runtime.JavaDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType>.ToLocalJniHandle (typeArgMappings);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (owner);
				__args [1] = new JValue (raw);
				__args [2] = new JValue (native_typeArgMappings);
				global::Java.Lang.Reflect.IParameterizedType __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IParameterizedType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parameterizeWithOwner_Ljava_lang_reflect_Type_Ljava_lang_Class_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_typeArgMappings);
			}
		}

		static IntPtr id_toLongString_Ljava_lang_reflect_TypeVariable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='toLongString' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.TypeVariable&lt;?&gt;']]"
		[Register ("toLongString", "(Ljava/lang/reflect/TypeVariable;)Ljava/lang/String;", "")]
		public static unsafe string ToLongString (global::Java.Lang.Reflect.ITypeVariable var)
		{
			if (id_toLongString_Ljava_lang_reflect_TypeVariable_ == IntPtr.Zero)
				id_toLongString_Ljava_lang_reflect_TypeVariable_ = JNIEnv.GetStaticMethodID (class_ref, "toLongString", "(Ljava/lang/reflect/TypeVariable;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (var);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toLongString_Ljava_lang_reflect_TypeVariable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("toString", "(Ljava/lang/reflect/Type;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Reflect.IType type)
		{
			if (id_toString_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_toString_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/reflect/Type;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_typesSatisfyVariables_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='typesSatisfyVariables' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.reflect.TypeVariable&lt;?&gt;, java.lang.reflect.Type&gt;']]"
		[Register ("typesSatisfyVariables", "(Ljava/util/Map;)Z", "")]
		public static unsafe bool TypesSatisfyVariables (global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType> typeVarAssigns)
		{
			if (id_typesSatisfyVariables_Ljava_util_Map_ == IntPtr.Zero)
				id_typesSatisfyVariables_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "typesSatisfyVariables", "(Ljava/util/Map;)Z");
			IntPtr native_typeVarAssigns = global::Android.Runtime.JavaDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType>.ToLocalJniHandle (typeVarAssigns);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_typeVarAssigns);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_typesSatisfyVariables_Ljava_util_Map_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_typeVarAssigns);
			}
		}

		static IntPtr id_unrollVariables_Ljava_util_Map_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='unrollVariables' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.reflect.TypeVariable&lt;?&gt;, java.lang.reflect.Type&gt;'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("unrollVariables", "(Ljava/util/Map;Ljava/lang/reflect/Type;)Ljava/lang/reflect/Type;", "")]
		public static unsafe global::Java.Lang.Reflect.IType UnrollVariables (global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType> typeArguments, global::Java.Lang.Reflect.IType type)
		{
			if (id_unrollVariables_Ljava_util_Map_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_unrollVariables_Ljava_util_Map_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "unrollVariables", "(Ljava/util/Map;Ljava/lang/reflect/Type;)Ljava/lang/reflect/Type;");
			IntPtr native_typeArguments = global::Android.Runtime.JavaDictionary<global::Java.Lang.Reflect.ITypeVariable, global::Java.Lang.Reflect.IType>.ToLocalJniHandle (typeArguments);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_typeArguments);
				__args [1] = new JValue (type);
				global::Java.Lang.Reflect.IType __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_unrollVariables_Ljava_util_Map_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_typeArguments);
			}
		}

		static IntPtr id_wildcardType;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='wildcardType' and count(parameter)=0]"
		[Register ("wildcardType", "()Lorg/apache/commons/lang3/reflect/TypeUtils$WildcardTypeBuilder;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder WildcardType ()
		{
			if (id_wildcardType == IntPtr.Zero)
				id_wildcardType = JNIEnv.GetStaticMethodID (class_ref, "wildcardType", "()Lorg/apache/commons/lang3/reflect/TypeUtils$WildcardTypeBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Reflect.TypeUtils.WildcardTypeBuilder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wildcardType), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_wrap_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("wrap", "(Ljava/lang/Class;)Lorg/apache/commons/lang3/reflect/Typed;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Reflect.ITyped Wrap (global::Java.Lang.Class type)
		{
			if (id_wrap_Ljava_lang_Class_ == IntPtr.Zero)
				id_wrap_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Ljava/lang/Class;)Lorg/apache/commons/lang3/reflect/Typed;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				global::Org.Apache.Commons.Lang3.Reflect.ITyped __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Reflect.ITyped> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_wrap_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='TypeUtils']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("wrap", "(Ljava/lang/reflect/Type;)Lorg/apache/commons/lang3/reflect/Typed;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Reflect.ITyped Wrap (global::Java.Lang.Reflect.IType type)
		{
			if (id_wrap_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_wrap_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Ljava/lang/reflect/Type;)Lorg/apache/commons/lang3/reflect/Typed;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				global::Org.Apache.Commons.Lang3.Reflect.ITyped __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Reflect.ITyped> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
