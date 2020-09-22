using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Retrofit2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='retrofit2']/class[@name='Converter.Factory']"
	[global::Android.Runtime.Register ("retrofit2/Converter$Factory", DoNotGenerateAcw=true)]
	public abstract partial class ConverterFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("retrofit2/Converter$Factory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConverterFactory); }
		}

		protected ConverterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='retrofit2']/class[@name='Converter.Factory']/constructor[@name='Converter.Factory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConverterFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConverterFactory)) {
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

		static IntPtr id_getParameterUpperBound_ILjava_lang_reflect_ParameterizedType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Converter.Factory']/method[@name='getParameterUpperBound' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.reflect.ParameterizedType']]"
		[Register ("getParameterUpperBound", "(ILjava/lang/reflect/ParameterizedType;)Ljava/lang/reflect/Type;", "")]
		protected static unsafe global::Java.Lang.Reflect.IType GetParameterUpperBound (int index, global::Java.Lang.Reflect.IParameterizedType type)
		{
			if (id_getParameterUpperBound_ILjava_lang_reflect_ParameterizedType_ == IntPtr.Zero)
				id_getParameterUpperBound_ILjava_lang_reflect_ParameterizedType_ = JNIEnv.GetStaticMethodID (class_ref, "getParameterUpperBound", "(ILjava/lang/reflect/ParameterizedType;)Ljava/lang/reflect/Type;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (type);
				global::Java.Lang.Reflect.IType __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getParameterUpperBound_ILjava_lang_reflect_ParameterizedType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRawType_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Converter.Factory']/method[@name='getRawType' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("getRawType", "(Ljava/lang/reflect/Type;)Ljava/lang/Class;", "")]
		protected static unsafe global::Java.Lang.Class GetRawType (global::Java.Lang.Reflect.IType type)
		{
			if (id_getRawType_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_getRawType_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getRawType", "(Ljava/lang/reflect/Type;)Ljava/lang/Class;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRawType_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
#pragma warning disable 0169
		static Delegate GetRequestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_Handler ()
		{
			if (cb_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ == null)
				cb_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_RequestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_);
			return cb_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
		}

		static IntPtr n_RequestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_parameterAnnotations, IntPtr native_methodAnnotations, IntPtr native_retrofit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ConverterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_type, JniHandleOwnership.DoNotTransfer);
			var parameterAnnotations = (global::Java.Lang.Annotation.IAnnotation[]) JNIEnv.GetArray (native_parameterAnnotations, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Annotation.IAnnotation));
			var methodAnnotations = (global::Java.Lang.Annotation.IAnnotation[]) JNIEnv.GetArray (native_methodAnnotations, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Annotation.IAnnotation));
			var retrofit = global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit> (native_retrofit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestBodyConverter (type, parameterAnnotations, methodAnnotations, retrofit));
			if (parameterAnnotations != null)
				JNIEnv.CopyArray (parameterAnnotations, native_parameterAnnotations);
			if (methodAnnotations != null)
				JNIEnv.CopyArray (methodAnnotations, native_methodAnnotations);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Converter.Factory']/method[@name='requestBodyConverter' and count(parameter)=4 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.annotation.Annotation[]'] and parameter[3][@type='java.lang.annotation.Annotation[]'] and parameter[4][@type='retrofit2.Retrofit']]"
		[Register ("requestBodyConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/Converter;", "GetRequestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_Handler")]
		public virtual unsafe global::Retrofit2.IConverter RequestBodyConverter (global::Java.Lang.Reflect.IType type, global::Java.Lang.Annotation.IAnnotation[] parameterAnnotations, global::Java.Lang.Annotation.IAnnotation[] methodAnnotations, global::Retrofit2.Retrofit retrofit)
		{
			if (id_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ == IntPtr.Zero)
				id_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ = JNIEnv.GetMethodID (class_ref, "requestBodyConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/Converter;");
			IntPtr native_parameterAnnotations = JNIEnv.NewArray (parameterAnnotations);
			IntPtr native_methodAnnotations = JNIEnv.NewArray (methodAnnotations);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (type);
				__args [1] = new JValue (native_parameterAnnotations);
				__args [2] = new JValue (native_methodAnnotations);
				__args [3] = new JValue (retrofit);

				global::Retrofit2.IConverter __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestBodyConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/Converter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (parameterAnnotations != null) {
					JNIEnv.CopyArray (native_parameterAnnotations, parameterAnnotations);
					JNIEnv.DeleteLocalRef (native_parameterAnnotations);
				}
				if (methodAnnotations != null) {
					JNIEnv.CopyArray (native_methodAnnotations, methodAnnotations);
					JNIEnv.DeleteLocalRef (native_methodAnnotations);
				}
			}
		}

		static Delegate cb_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
#pragma warning disable 0169
		static Delegate GetResponseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_Handler ()
		{
			if (cb_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ == null)
				cb_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_ResponseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_);
			return cb_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
		}

		static IntPtr n_ResponseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_annotations, IntPtr native_retrofit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ConverterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_type, JniHandleOwnership.DoNotTransfer);
			var annotations = (global::Java.Lang.Annotation.IAnnotation[]) JNIEnv.GetArray (native_annotations, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Annotation.IAnnotation));
			var retrofit = global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit> (native_retrofit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResponseBodyConverter (type, annotations, retrofit));
			if (annotations != null)
				JNIEnv.CopyArray (annotations, native_annotations);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Converter.Factory']/method[@name='responseBodyConverter' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.annotation.Annotation[]'] and parameter[3][@type='retrofit2.Retrofit']]"
		[Register ("responseBodyConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/Converter;", "GetResponseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_Handler")]
		public virtual unsafe global::Retrofit2.IConverter ResponseBodyConverter (global::Java.Lang.Reflect.IType type, global::Java.Lang.Annotation.IAnnotation[] annotations, global::Retrofit2.Retrofit retrofit)
		{
			if (id_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ == IntPtr.Zero)
				id_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ = JNIEnv.GetMethodID (class_ref, "responseBodyConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/Converter;");
			IntPtr native_annotations = JNIEnv.NewArray (annotations);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (type);
				__args [1] = new JValue (native_annotations);
				__args [2] = new JValue (retrofit);

				global::Retrofit2.IConverter __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_responseBodyConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "responseBodyConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/Converter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (annotations != null) {
					JNIEnv.CopyArray (native_annotations, annotations);
					JNIEnv.DeleteLocalRef (native_annotations);
				}
			}
		}

		static Delegate cb_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
#pragma warning disable 0169
		static Delegate GetStringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_Handler ()
		{
			if (cb_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ == null)
				cb_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_StringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_);
			return cb_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
		}

		static IntPtr n_StringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_annotations, IntPtr native_retrofit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ConverterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_type, JniHandleOwnership.DoNotTransfer);
			var annotations = (global::Java.Lang.Annotation.IAnnotation[]) JNIEnv.GetArray (native_annotations, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Annotation.IAnnotation));
			var retrofit = global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit> (native_retrofit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StringConverter (type, annotations, retrofit));
			if (annotations != null)
				JNIEnv.CopyArray (annotations, native_annotations);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='Converter.Factory']/method[@name='stringConverter' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.annotation.Annotation[]'] and parameter[3][@type='retrofit2.Retrofit']]"
		[Register ("stringConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/Converter;", "GetStringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_Handler")]
		public virtual unsafe global::Retrofit2.IConverter StringConverter (global::Java.Lang.Reflect.IType type, global::Java.Lang.Annotation.IAnnotation[] annotations, global::Retrofit2.Retrofit retrofit)
		{
			if (id_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ == IntPtr.Zero)
				id_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ = JNIEnv.GetMethodID (class_ref, "stringConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/Converter;");
			IntPtr native_annotations = JNIEnv.NewArray (annotations);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (type);
				__args [1] = new JValue (native_annotations);
				__args [2] = new JValue (retrofit);

				global::Retrofit2.IConverter __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_stringConverter_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stringConverter", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/Converter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (annotations != null) {
					JNIEnv.CopyArray (native_annotations, annotations);
					JNIEnv.DeleteLocalRef (native_annotations);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("retrofit2/Converter$Factory", DoNotGenerateAcw=true)]
	internal partial class ConverterFactoryInvoker : ConverterFactory {

		public ConverterFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConverterFactoryInvoker); }
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='retrofit2']/interface[@name='Converter']"
	[Register ("retrofit2/Converter", "", "Retrofit2.IConverterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"F", "T"})]
	public partial interface IConverter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='Converter']/method[@name='convert' and count(parameter)=1 and parameter[1][@type='F']]"
		[Register ("convert", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetConvert_Ljava_lang_Object_Handler:Retrofit2.IConverterInvoker, AndriodBinding")]
		global::Java.Lang.Object Convert (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("retrofit2/Converter", DoNotGenerateAcw=true)]
	internal partial class IConverterInvoker : global::Java.Lang.Object, IConverter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("retrofit2/Converter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConverterInvoker); }
		}

		IntPtr class_ref;

		public static IConverter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConverter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "retrofit2.Converter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConverterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_convert_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetConvert_Ljava_lang_Object_Handler ()
		{
			if (cb_convert_Ljava_lang_Object_ == null)
				cb_convert_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Convert_Ljava_lang_Object_);
			return cb_convert_Ljava_lang_Object_;
		}

		static IntPtr n_Convert_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.IConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Convert (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_convert_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Convert (global::Java.Lang.Object p0)
		{
			if (id_convert_Ljava_lang_Object_ == IntPtr.Zero)
				id_convert_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "convert", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convert_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
