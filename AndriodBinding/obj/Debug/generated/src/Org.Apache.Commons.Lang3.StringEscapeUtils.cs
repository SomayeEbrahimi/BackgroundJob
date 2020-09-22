using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/StringEscapeUtils", DoNotGenerateAcw=true)]
	public partial class StringEscapeUtils : global::Java.Lang.Object {


		static IntPtr ESCAPE_ECMASCRIPT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/field[@name='ESCAPE_ECMASCRIPT']"
		[Register ("ESCAPE_ECMASCRIPT")]
		public static global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator EscapeEcmascript {
			get {
				if (ESCAPE_ECMASCRIPT_jfieldId == IntPtr.Zero)
					ESCAPE_ECMASCRIPT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ESCAPE_ECMASCRIPT", "Lorg/apache/commons/lang3/text/translate/CharSequenceTranslator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ESCAPE_ECMASCRIPT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNESCAPE_ECMASCRIPT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/field[@name='UNESCAPE_ECMASCRIPT']"
		[Register ("UNESCAPE_ECMASCRIPT")]
		public static global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator UnescapeEcmascript {
			get {
				if (UNESCAPE_ECMASCRIPT_jfieldId == IntPtr.Zero)
					UNESCAPE_ECMASCRIPT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNESCAPE_ECMASCRIPT", "Lorg/apache/commons/lang3/text/translate/CharSequenceTranslator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNESCAPE_ECMASCRIPT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/StringEscapeUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringEscapeUtils); }
		}

		protected StringEscapeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/constructor[@name='StringEscapeUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringEscapeUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StringEscapeUtils)) {
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

		static IntPtr id_escapeCsv_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='escapeCsv' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escapeCsv", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EscapeCsv (string input)
		{
			if (id_escapeCsv_Ljava_lang_String_ == IntPtr.Zero)
				id_escapeCsv_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "escapeCsv", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_escapeCsv_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_escapeEcmaScript_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='escapeEcmaScript' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escapeEcmaScript", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EscapeEcmaScript (string input)
		{
			if (id_escapeEcmaScript_Ljava_lang_String_ == IntPtr.Zero)
				id_escapeEcmaScript_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "escapeEcmaScript", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_escapeEcmaScript_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_escapeHtml3_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='escapeHtml3' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escapeHtml3", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EscapeHtml3 (string input)
		{
			if (id_escapeHtml3_Ljava_lang_String_ == IntPtr.Zero)
				id_escapeHtml3_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "escapeHtml3", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_escapeHtml3_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_escapeHtml4_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='escapeHtml4' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escapeHtml4", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EscapeHtml4 (string input)
		{
			if (id_escapeHtml4_Ljava_lang_String_ == IntPtr.Zero)
				id_escapeHtml4_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "escapeHtml4", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_escapeHtml4_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_escapeJava_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='escapeJava' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escapeJava", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EscapeJava (string input)
		{
			if (id_escapeJava_Ljava_lang_String_ == IntPtr.Zero)
				id_escapeJava_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "escapeJava", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_escapeJava_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_escapeJson_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='escapeJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escapeJson", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EscapeJson (string input)
		{
			if (id_escapeJson_Ljava_lang_String_ == IntPtr.Zero)
				id_escapeJson_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "escapeJson", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_escapeJson_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_escapeXml_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='escapeXml' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("escapeXml", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EscapeXml (string input)
		{
			if (id_escapeXml_Ljava_lang_String_ == IntPtr.Zero)
				id_escapeXml_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "escapeXml", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_escapeXml_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_escapeXml10_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='escapeXml10' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escapeXml10", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EscapeXml10 (string input)
		{
			if (id_escapeXml10_Ljava_lang_String_ == IntPtr.Zero)
				id_escapeXml10_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "escapeXml10", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_escapeXml10_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_escapeXml11_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='escapeXml11' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escapeXml11", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EscapeXml11 (string input)
		{
			if (id_escapeXml11_Ljava_lang_String_ == IntPtr.Zero)
				id_escapeXml11_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "escapeXml11", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_escapeXml11_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_unescapeCsv_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='unescapeCsv' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unescapeCsv", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UnescapeCsv (string input)
		{
			if (id_unescapeCsv_Ljava_lang_String_ == IntPtr.Zero)
				id_unescapeCsv_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unescapeCsv", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unescapeCsv_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_unescapeEcmaScript_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='unescapeEcmaScript' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unescapeEcmaScript", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UnescapeEcmaScript (string input)
		{
			if (id_unescapeEcmaScript_Ljava_lang_String_ == IntPtr.Zero)
				id_unescapeEcmaScript_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unescapeEcmaScript", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unescapeEcmaScript_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_unescapeHtml3_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='unescapeHtml3' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unescapeHtml3", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UnescapeHtml3 (string input)
		{
			if (id_unescapeHtml3_Ljava_lang_String_ == IntPtr.Zero)
				id_unescapeHtml3_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unescapeHtml3", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unescapeHtml3_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_unescapeHtml4_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='unescapeHtml4' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unescapeHtml4", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UnescapeHtml4 (string input)
		{
			if (id_unescapeHtml4_Ljava_lang_String_ == IntPtr.Zero)
				id_unescapeHtml4_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unescapeHtml4", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unescapeHtml4_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_unescapeJava_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='unescapeJava' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unescapeJava", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UnescapeJava (string input)
		{
			if (id_unescapeJava_Ljava_lang_String_ == IntPtr.Zero)
				id_unescapeJava_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unescapeJava", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unescapeJava_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_unescapeJson_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='unescapeJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unescapeJson", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UnescapeJson (string input)
		{
			if (id_unescapeJson_Ljava_lang_String_ == IntPtr.Zero)
				id_unescapeJson_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unescapeJson", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unescapeJson_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_unescapeXml_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='StringEscapeUtils']/method[@name='unescapeXml' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unescapeXml", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UnescapeXml (string input)
		{
			if (id_unescapeXml_Ljava_lang_String_ == IntPtr.Zero)
				id_unescapeXml_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unescapeXml", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unescapeXml_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

	}
}
