using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='ExtendedMessageFormat']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/ExtendedMessageFormat", DoNotGenerateAcw=true)]
	public partial class ExtendedMessageFormat : global::Java.Text.MessageFormat {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/ExtendedMessageFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExtendedMessageFormat); }
		}

		protected ExtendedMessageFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='ExtendedMessageFormat']/constructor[@name='ExtendedMessageFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ExtendedMessageFormat (string pattern)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_pattern);
				if (((object) this).GetType () != typeof (ExtendedMessageFormat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Locale_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='ExtendedMessageFormat']/constructor[@name='ExtendedMessageFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Locale']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Locale;)V", "")]
		public unsafe ExtendedMessageFormat (string pattern, global::Java.Util.Locale locale)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_pattern);
				__args [1] = new JValue (locale);
				if (((object) this).GetType () != typeof (ExtendedMessageFormat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/Locale;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/Locale;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_Locale_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_Locale_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Locale;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Locale_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Locale_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Locale_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='ExtendedMessageFormat']/constructor[@name='ExtendedMessageFormat' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Locale'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends org.apache.commons.lang3.text.FormatFactory&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Locale;Ljava/util/Map;)V", "")]
		public unsafe ExtendedMessageFormat (string pattern, global::Java.Util.Locale locale, global::System.Collections.Generic.IDictionary<string, global::Org.Apache.Commons.Lang3.Text.IFormatFactory> registry)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString (pattern);
			IntPtr native_registry = global::Android.Runtime.JavaDictionary<string, global::Org.Apache.Commons.Lang3.Text.IFormatFactory>.ToLocalJniHandle (registry);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_pattern);
				__args [1] = new JValue (locale);
				__args [2] = new JValue (native_registry);
				if (((object) this).GetType () != typeof (ExtendedMessageFormat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/Locale;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/Locale;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_Locale_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_Locale_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Locale;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Locale_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Locale_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
				JNIEnv.DeleteLocalRef (native_registry);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='ExtendedMessageFormat']/constructor[@name='ExtendedMessageFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, ? extends org.apache.commons.lang3.text.FormatFactory&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe ExtendedMessageFormat (string pattern, global::System.Collections.Generic.IDictionary<string, global::Org.Apache.Commons.Lang3.Text.IFormatFactory> registry)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString (pattern);
			IntPtr native_registry = global::Android.Runtime.JavaDictionary<string, global::Org.Apache.Commons.Lang3.Text.IFormatFactory>.ToLocalJniHandle (registry);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_pattern);
				__args [1] = new JValue (native_registry);
				if (((object) this).GetType () != typeof (ExtendedMessageFormat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
				JNIEnv.DeleteLocalRef (native_registry);
			}
		}

		static IntPtr id_applyPattern_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='ExtendedMessageFormat']/method[@name='applyPattern' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("applyPattern", "(Ljava/lang/String;)V", "")]
		public override sealed unsafe void ApplyPattern (string pattern)
		{
			if (id_applyPattern_Ljava_lang_String_ == IntPtr.Zero)
				id_applyPattern_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "applyPattern", "(Ljava/lang/String;)V");
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_pattern);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyPattern_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

	}
}
