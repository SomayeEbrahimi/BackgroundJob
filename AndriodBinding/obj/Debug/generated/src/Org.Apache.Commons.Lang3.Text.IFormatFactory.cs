using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3.text']/interface[@name='FormatFactory']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("org/apache/commons/lang3/text/FormatFactory", "", "Org.Apache.Commons.Lang3.Text.IFormatFactoryInvoker")]
	public partial interface IFormatFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/interface[@name='FormatFactory']/method[@name='getFormat' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Locale']]"
		[Register ("getFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)Ljava/text/Format;", "GetGetFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_Handler:Org.Apache.Commons.Lang3.Text.IFormatFactoryInvoker, AndriodBinding")]
		global::Java.Text._Format GetFormat (string p0, string p1, global::Java.Util.Locale p2);

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/FormatFactory", DoNotGenerateAcw=true)]
	internal partial class IFormatFactoryInvoker : global::Java.Lang.Object, IFormatFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/text/FormatFactory");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFormatFactoryInvoker); }
		}

		IntPtr class_ref;

		public static IFormatFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFormatFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.text.FormatFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFormatFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_;
#pragma warning disable 0169
		static Delegate GetGetFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_Handler ()
		{
			if (cb_getFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_ == null)
				cb_getFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_);
			return cb_getFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_;
		}

		static IntPtr n_GetFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.IFormatFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFormat (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_;
		public unsafe global::Java.Text._Format GetFormat (string p0, string p1, global::Java.Util.Locale p2)
		{
			if (id_getFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_ == IntPtr.Zero)
				id_getFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_ = JNIEnv.GetMethodID (class_ref, "getFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)Ljava/text/Format;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Text._Format> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
