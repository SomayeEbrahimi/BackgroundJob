using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='LocaleUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/LocaleUtils", DoNotGenerateAcw=true)]
	public partial class LocaleUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/LocaleUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocaleUtils); }
		}

		protected LocaleUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='LocaleUtils']/constructor[@name='LocaleUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocaleUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LocaleUtils)) {
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

		static IntPtr id_availableLocaleList;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='LocaleUtils']/method[@name='availableLocaleList' and count(parameter)=0]"
		[Register ("availableLocaleList", "()Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Util.Locale> AvailableLocaleList ()
		{
			if (id_availableLocaleList == IntPtr.Zero)
				id_availableLocaleList = JNIEnv.GetStaticMethodID (class_ref, "availableLocaleList", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Java.Util.Locale>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_availableLocaleList), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_availableLocaleSet;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='LocaleUtils']/method[@name='availableLocaleSet' and count(parameter)=0]"
		[Register ("availableLocaleSet", "()Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Util.Locale> AvailableLocaleSet ()
		{
			if (id_availableLocaleSet == IntPtr.Zero)
				id_availableLocaleSet = JNIEnv.GetStaticMethodID (class_ref, "availableLocaleSet", "()Ljava/util/Set;");
			try {
				return global::Android.Runtime.JavaSet<global::Java.Util.Locale>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_availableLocaleSet), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_countriesByLanguage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='LocaleUtils']/method[@name='countriesByLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("countriesByLanguage", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Util.Locale> CountriesByLanguage (string languageCode)
		{
			if (id_countriesByLanguage_Ljava_lang_String_ == IntPtr.Zero)
				id_countriesByLanguage_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "countriesByLanguage", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_languageCode = JNIEnv.NewString (languageCode);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_languageCode);
				global::System.Collections.Generic.IList<global::Java.Util.Locale> __ret = global::Android.Runtime.JavaList<global::Java.Util.Locale>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_countriesByLanguage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_languageCode);
			}
		}

		static IntPtr id_isAvailableLocale_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='LocaleUtils']/method[@name='isAvailableLocale' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("isAvailableLocale", "(Ljava/util/Locale;)Z", "")]
		public static unsafe bool IsAvailableLocale (global::Java.Util.Locale locale)
		{
			if (id_isAvailableLocale_Ljava_util_Locale_ == IntPtr.Zero)
				id_isAvailableLocale_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "isAvailableLocale", "(Ljava/util/Locale;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (locale);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAvailableLocale_Ljava_util_Locale_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_languagesByCountry_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='LocaleUtils']/method[@name='languagesByCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("languagesByCountry", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Util.Locale> LanguagesByCountry (string countryCode)
		{
			if (id_languagesByCountry_Ljava_lang_String_ == IntPtr.Zero)
				id_languagesByCountry_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "languagesByCountry", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_countryCode = JNIEnv.NewString (countryCode);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_countryCode);
				global::System.Collections.Generic.IList<global::Java.Util.Locale> __ret = global::Android.Runtime.JavaList<global::Java.Util.Locale>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_languagesByCountry_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_countryCode);
			}
		}

		static IntPtr id_localeLookupList_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='LocaleUtils']/method[@name='localeLookupList' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("localeLookupList", "(Ljava/util/Locale;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Util.Locale> LocaleLookupList (global::Java.Util.Locale locale)
		{
			if (id_localeLookupList_Ljava_util_Locale_ == IntPtr.Zero)
				id_localeLookupList_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "localeLookupList", "(Ljava/util/Locale;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (locale);
				global::System.Collections.Generic.IList<global::Java.Util.Locale> __ret = global::Android.Runtime.JavaList<global::Java.Util.Locale>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_localeLookupList_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_localeLookupList_Ljava_util_Locale_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='LocaleUtils']/method[@name='localeLookupList' and count(parameter)=2 and parameter[1][@type='java.util.Locale'] and parameter[2][@type='java.util.Locale']]"
		[Register ("localeLookupList", "(Ljava/util/Locale;Ljava/util/Locale;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Util.Locale> LocaleLookupList (global::Java.Util.Locale locale, global::Java.Util.Locale defaultLocale)
		{
			if (id_localeLookupList_Ljava_util_Locale_Ljava_util_Locale_ == IntPtr.Zero)
				id_localeLookupList_Ljava_util_Locale_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "localeLookupList", "(Ljava/util/Locale;Ljava/util/Locale;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (locale);
				__args [1] = new JValue (defaultLocale);
				global::System.Collections.Generic.IList<global::Java.Util.Locale> __ret = global::Android.Runtime.JavaList<global::Java.Util.Locale>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_localeLookupList_Ljava_util_Locale_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toLocale_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='LocaleUtils']/method[@name='toLocale' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toLocale", "(Ljava/lang/String;)Ljava/util/Locale;", "")]
		public static unsafe global::Java.Util.Locale ToLocale (string str)
		{
			if (id_toLocale_Ljava_lang_String_ == IntPtr.Zero)
				id_toLocale_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toLocale", "(Ljava/lang/String;)Ljava/util/Locale;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Java.Util.Locale __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toLocale_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

	}
}
