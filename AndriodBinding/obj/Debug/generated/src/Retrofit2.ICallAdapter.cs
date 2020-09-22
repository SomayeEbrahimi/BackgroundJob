using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Retrofit2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='retrofit2']/class[@name='CallAdapter.Factory']"
	[global::Android.Runtime.Register ("retrofit2/CallAdapter$Factory", DoNotGenerateAcw=true)]
	public abstract partial class CallAdapterFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("retrofit2/CallAdapter$Factory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CallAdapterFactory); }
		}

		protected CallAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='retrofit2']/class[@name='CallAdapter.Factory']/constructor[@name='CallAdapter.Factory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CallAdapterFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CallAdapterFactory)) {
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

		static Delegate cb_get_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_Handler ()
		{
			if (cb_get_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ == null)
				cb_get_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Get_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_);
			return cb_get_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
		}

		static IntPtr n_Get_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.CallAdapterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Annotation.IAnnotation[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Annotation.IAnnotation));
			var p2 = global::Java.Lang.Object.GetObject<global::Retrofit2.Retrofit> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='CallAdapter.Factory']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.annotation.Annotation[]'] and parameter[3][@type='retrofit2.Retrofit']]"
		[Register ("get", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/CallAdapter;", "GetGet_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_Handler")]
		public abstract global::Retrofit2.ICallAdapter Get (global::Java.Lang.Reflect.IType p0, global::Java.Lang.Annotation.IAnnotation[] p1, global::Retrofit2.Retrofit p2);

		static IntPtr id_getParameterUpperBound_ILjava_lang_reflect_ParameterizedType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='CallAdapter.Factory']/method[@name='getParameterUpperBound' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.reflect.ParameterizedType']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='CallAdapter.Factory']/method[@name='getRawType' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
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

	}

	[global::Android.Runtime.Register ("retrofit2/CallAdapter$Factory", DoNotGenerateAcw=true)]
	internal partial class CallAdapterFactoryInvoker : CallAdapterFactory {

		public CallAdapterFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CallAdapterFactoryInvoker); }
		}

		static IntPtr id_get_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='CallAdapter.Factory']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.annotation.Annotation[]'] and parameter[3][@type='retrofit2.Retrofit']]"
		[Register ("get", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/CallAdapter;", "GetGet_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_Handler")]
		public override unsafe global::Retrofit2.ICallAdapter Get (global::Java.Lang.Reflect.IType p0, global::Java.Lang.Annotation.IAnnotation[] p1, global::Retrofit2.Retrofit p2)
		{
			if (id_get_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ == IntPtr.Zero)
				id_get_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/reflect/Type;[Ljava/lang/annotation/Annotation;Lretrofit2/Retrofit;)Lretrofit2/CallAdapter;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Retrofit2.ICallAdapter __ret = global::Java.Lang.Object.GetObject<global::Retrofit2.ICallAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_reflect_Type_arrayLjava_lang_annotation_Annotation_Lretrofit2_Retrofit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='retrofit2']/interface[@name='CallAdapter']"
	[Register ("retrofit2/CallAdapter", "", "Retrofit2.ICallAdapterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R", "T"})]
	public partial interface ICallAdapter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='CallAdapter']/method[@name='adapt' and count(parameter)=1 and parameter[1][@type='retrofit2.Call&lt;R&gt;']]"
		[Register ("adapt", "(Lretrofit2/Call;)Ljava/lang/Object;", "GetAdapt_Lretrofit2_Call_Handler:Retrofit2.ICallAdapterInvoker, AndriodBinding")]
		global::Java.Lang.Object Adapt (global::Retrofit2.ICall p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='CallAdapter']/method[@name='responseType' and count(parameter)=0]"
		[Register ("responseType", "()Ljava/lang/reflect/Type;", "GetResponseTypeHandler:Retrofit2.ICallAdapterInvoker, AndriodBinding")]
		global::Java.Lang.Reflect.IType ResponseType ();

	}

	[global::Android.Runtime.Register ("retrofit2/CallAdapter", DoNotGenerateAcw=true)]
	internal partial class ICallAdapterInvoker : global::Java.Lang.Object, ICallAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("retrofit2/CallAdapter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICallAdapterInvoker); }
		}

		IntPtr class_ref;

		public static ICallAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICallAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "retrofit2.CallAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_adapt_Lretrofit2_Call_;
#pragma warning disable 0169
		static Delegate GetAdapt_Lretrofit2_Call_Handler ()
		{
			if (cb_adapt_Lretrofit2_Call_ == null)
				cb_adapt_Lretrofit2_Call_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Adapt_Lretrofit2_Call_);
			return cb_adapt_Lretrofit2_Call_;
		}

		static IntPtr n_Adapt_Lretrofit2_Call_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ICallAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Retrofit2.ICall)global::Java.Lang.Object.GetObject<global::Retrofit2.ICall> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Adapt (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_adapt_Lretrofit2_Call_;
		public unsafe global::Java.Lang.Object Adapt (global::Retrofit2.ICall p0)
		{
			if (id_adapt_Lretrofit2_Call_ == IntPtr.Zero)
				id_adapt_Lretrofit2_Call_ = JNIEnv.GetMethodID (class_ref, "adapt", "(Lretrofit2/Call;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_adapt_Lretrofit2_Call_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_responseType;
#pragma warning disable 0169
		static Delegate GetResponseTypeHandler ()
		{
			if (cb_responseType == null)
				cb_responseType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ResponseType);
			return cb_responseType;
		}

		static IntPtr n_ResponseType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ICallAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseType ());
		}
#pragma warning restore 0169

		IntPtr id_responseType;
		public unsafe global::Java.Lang.Reflect.IType ResponseType ()
		{
			if (id_responseType == IntPtr.Zero)
				id_responseType = JNIEnv.GetMethodID (class_ref, "responseType", "()Ljava/lang/reflect/Type;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_responseType), JniHandleOwnership.TransferLocalRef);
		}

	}

}
