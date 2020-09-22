using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Objectbox.Converter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.objectbox.converter']/interface[@name='PropertyConverter']"
	[Register ("io/objectbox/converter/PropertyConverter", "", "IO.Objectbox.Converter.IPropertyConverterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"P", "D"})]
	public partial interface IPropertyConverter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.objectbox.converter']/interface[@name='PropertyConverter']/method[@name='convertToDatabaseValue' and count(parameter)=1 and parameter[1][@type='P']]"
		[Register ("convertToDatabaseValue", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetConvertToDatabaseValue_Ljava_lang_Object_Handler:IO.Objectbox.Converter.IPropertyConverterInvoker, AndriodBinding")]
		global::Java.Lang.Object ConvertToDatabaseValue (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.objectbox.converter']/interface[@name='PropertyConverter']/method[@name='convertToEntityProperty' and count(parameter)=1 and parameter[1][@type='D']]"
		[Register ("convertToEntityProperty", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetConvertToEntityProperty_Ljava_lang_Object_Handler:IO.Objectbox.Converter.IPropertyConverterInvoker, AndriodBinding")]
		global::Java.Lang.Object ConvertToEntityProperty (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("io/objectbox/converter/PropertyConverter", DoNotGenerateAcw=true)]
	internal partial class IPropertyConverterInvoker : global::Java.Lang.Object, IPropertyConverter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/objectbox/converter/PropertyConverter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPropertyConverterInvoker); }
		}

		IntPtr class_ref;

		public static IPropertyConverter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPropertyConverter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.objectbox.converter.PropertyConverter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPropertyConverterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_convertToDatabaseValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetConvertToDatabaseValue_Ljava_lang_Object_Handler ()
		{
			if (cb_convertToDatabaseValue_Ljava_lang_Object_ == null)
				cb_convertToDatabaseValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ConvertToDatabaseValue_Ljava_lang_Object_);
			return cb_convertToDatabaseValue_Ljava_lang_Object_;
		}

		static IntPtr n_ConvertToDatabaseValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Objectbox.Converter.IPropertyConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertToDatabaseValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_convertToDatabaseValue_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object ConvertToDatabaseValue (global::Java.Lang.Object p0)
		{
			if (id_convertToDatabaseValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_convertToDatabaseValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "convertToDatabaseValue", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertToDatabaseValue_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_convertToEntityProperty_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetConvertToEntityProperty_Ljava_lang_Object_Handler ()
		{
			if (cb_convertToEntityProperty_Ljava_lang_Object_ == null)
				cb_convertToEntityProperty_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ConvertToEntityProperty_Ljava_lang_Object_);
			return cb_convertToEntityProperty_Ljava_lang_Object_;
		}

		static IntPtr n_ConvertToEntityProperty_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Objectbox.Converter.IPropertyConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertToEntityProperty (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_convertToEntityProperty_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object ConvertToEntityProperty (global::Java.Lang.Object p0)
		{
			if (id_convertToEntityProperty_Ljava_lang_Object_ == IntPtr.Zero)
				id_convertToEntityProperty_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "convertToEntityProperty", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertToEntityProperty_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
