using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/StrSubstitutor", DoNotGenerateAcw=true)]
	public partial class StrSubstitutor : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/field[@name='DEFAULT_ESCAPE']"
		[Register ("DEFAULT_ESCAPE")]
		public const char DefaultEscape = (char) (char)36;

		static IntPtr DEFAULT_PREFIX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/field[@name='DEFAULT_PREFIX']"
		[Register ("DEFAULT_PREFIX")]
		public static global::Org.Apache.Commons.Lang3.Text.StrMatcher DefaultPrefix {
			get {
				if (DEFAULT_PREFIX_jfieldId == IntPtr.Zero)
					DEFAULT_PREFIX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_PREFIX", "Lorg/apache/commons/lang3/text/StrMatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_PREFIX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEFAULT_SUFFIX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/field[@name='DEFAULT_SUFFIX']"
		[Register ("DEFAULT_SUFFIX")]
		public static global::Org.Apache.Commons.Lang3.Text.StrMatcher DefaultSuffix {
			get {
				if (DEFAULT_SUFFIX_jfieldId == IntPtr.Zero)
					DEFAULT_SUFFIX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_SUFFIX", "Lorg/apache/commons/lang3/text/StrMatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_SUFFIX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEFAULT_VALUE_DELIMITER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/field[@name='DEFAULT_VALUE_DELIMITER']"
		[Register ("DEFAULT_VALUE_DELIMITER")]
		public static global::Org.Apache.Commons.Lang3.Text.StrMatcher DefaultValueDelimiter {
			get {
				if (DEFAULT_VALUE_DELIMITER_jfieldId == IntPtr.Zero)
					DEFAULT_VALUE_DELIMITER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_VALUE_DELIMITER", "Lorg/apache/commons/lang3/text/StrMatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_VALUE_DELIMITER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/StrSubstitutor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrSubstitutor); }
		}

		protected StrSubstitutor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/constructor[@name='StrSubstitutor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StrSubstitutor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StrSubstitutor)) {
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

		static IntPtr id_ctor_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/constructor[@name='StrSubstitutor' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, V&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe StrSubstitutor (global::System.Collections.IDictionary valueMap)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_valueMap = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (valueMap);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_valueMap);
				if (((object) this).GetType () != typeof (StrSubstitutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_valueMap);
			}
		}

		static IntPtr id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/constructor[@name='StrSubstitutor' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, V&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe StrSubstitutor (global::System.Collections.IDictionary valueMap, string prefix, string suffix)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_valueMap = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (valueMap);
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_suffix = JNIEnv.NewString (suffix);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_valueMap);
				__args [1] = new JValue (native_prefix);
				__args [2] = new JValue (native_suffix);
				if (((object) this).GetType () != typeof (StrSubstitutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_valueMap);
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
			}
		}

		static IntPtr id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_C;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/constructor[@name='StrSubstitutor' and count(parameter)=4 and parameter[1][@type='java.util.Map&lt;java.lang.String, V&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='char']]"
		[Register (".ctor", "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;C)V", "")]
		public unsafe StrSubstitutor (global::System.Collections.IDictionary valueMap, string prefix, string suffix, char escape)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_valueMap = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (valueMap);
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_suffix = JNIEnv.NewString (suffix);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_valueMap);
				__args [1] = new JValue (native_prefix);
				__args [2] = new JValue (native_suffix);
				__args [3] = new JValue (escape);
				if (((object) this).GetType () != typeof (StrSubstitutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;C)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;C)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_C == IntPtr.Zero)
					id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_C = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;C)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_C, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_C, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_valueMap);
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
			}
		}

		static IntPtr id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_CLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/constructor[@name='StrSubstitutor' and count(parameter)=5 and parameter[1][@type='java.util.Map&lt;java.lang.String, V&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='char'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;CLjava/lang/String;)V", "")]
		public unsafe StrSubstitutor (global::System.Collections.IDictionary valueMap, string prefix, string suffix, char escape, string valueDelimiter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_valueMap = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (valueMap);
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_suffix = JNIEnv.NewString (suffix);
			IntPtr native_valueDelimiter = JNIEnv.NewString (valueDelimiter);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_valueMap);
				__args [1] = new JValue (native_prefix);
				__args [2] = new JValue (native_suffix);
				__args [3] = new JValue (escape);
				__args [4] = new JValue (native_valueDelimiter);
				if (((object) this).GetType () != typeof (StrSubstitutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;CLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;CLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_CLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_CLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;CLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_CLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_CLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_valueMap);
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
				JNIEnv.DeleteLocalRef (native_valueDelimiter);
			}
		}

		static IntPtr id_ctor_Lorg_apache_commons_lang3_text_StrLookup_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/constructor[@name='StrSubstitutor' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrLookup&lt;?&gt;']]"
		[Register (".ctor", "(Lorg/apache/commons/lang3/text/StrLookup;)V", "")]
		public unsafe StrSubstitutor (global::Org.Apache.Commons.Lang3.Text.StrLookup variableResolver)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (variableResolver);
				if (((object) this).GetType () != typeof (StrSubstitutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/lang3/text/StrLookup;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/lang3/text/StrLookup;)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_commons_lang3_text_StrLookup_ == IntPtr.Zero)
					id_ctor_Lorg_apache_commons_lang3_text_StrLookup_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/lang3/text/StrLookup;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_lang3_text_StrLookup_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_lang3_text_StrLookup_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Ljava_lang_String_Ljava_lang_String_C;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/constructor[@name='StrSubstitutor' and count(parameter)=4 and parameter[1][@type='org.apache.commons.lang3.text.StrLookup&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='char']]"
		[Register (".ctor", "(Lorg/apache/commons/lang3/text/StrLookup;Ljava/lang/String;Ljava/lang/String;C)V", "")]
		public unsafe StrSubstitutor (global::Org.Apache.Commons.Lang3.Text.StrLookup variableResolver, string prefix, string suffix, char escape)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_suffix = JNIEnv.NewString (suffix);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (variableResolver);
				__args [1] = new JValue (native_prefix);
				__args [2] = new JValue (native_suffix);
				__args [3] = new JValue (escape);
				if (((object) this).GetType () != typeof (StrSubstitutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/lang3/text/StrLookup;Ljava/lang/String;Ljava/lang/String;C)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/lang3/text/StrLookup;Ljava/lang/String;Ljava/lang/String;C)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Ljava_lang_String_Ljava_lang_String_C == IntPtr.Zero)
					id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Ljava_lang_String_Ljava_lang_String_C = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/lang3/text/StrLookup;Ljava/lang/String;Ljava/lang/String;C)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Ljava_lang_String_Ljava_lang_String_C, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Ljava_lang_String_Ljava_lang_String_C, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
			}
		}

		static IntPtr id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Ljava_lang_String_Ljava_lang_String_CLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/constructor[@name='StrSubstitutor' and count(parameter)=5 and parameter[1][@type='org.apache.commons.lang3.text.StrLookup&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='char'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/apache/commons/lang3/text/StrLookup;Ljava/lang/String;Ljava/lang/String;CLjava/lang/String;)V", "")]
		public unsafe StrSubstitutor (global::Org.Apache.Commons.Lang3.Text.StrLookup variableResolver, string prefix, string suffix, char escape, string valueDelimiter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_suffix = JNIEnv.NewString (suffix);
			IntPtr native_valueDelimiter = JNIEnv.NewString (valueDelimiter);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (variableResolver);
				__args [1] = new JValue (native_prefix);
				__args [2] = new JValue (native_suffix);
				__args [3] = new JValue (escape);
				__args [4] = new JValue (native_valueDelimiter);
				if (((object) this).GetType () != typeof (StrSubstitutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/lang3/text/StrLookup;Ljava/lang/String;Ljava/lang/String;CLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/lang3/text/StrLookup;Ljava/lang/String;Ljava/lang/String;CLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Ljava_lang_String_Ljava_lang_String_CLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Ljava_lang_String_Ljava_lang_String_CLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/lang3/text/StrLookup;Ljava/lang/String;Ljava/lang/String;CLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Ljava_lang_String_Ljava_lang_String_CLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Ljava_lang_String_Ljava_lang_String_CLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
				JNIEnv.DeleteLocalRef (native_valueDelimiter);
			}
		}

		static IntPtr id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_C;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/constructor[@name='StrSubstitutor' and count(parameter)=4 and parameter[1][@type='org.apache.commons.lang3.text.StrLookup&lt;?&gt;'] and parameter[2][@type='org.apache.commons.lang3.text.StrMatcher'] and parameter[3][@type='org.apache.commons.lang3.text.StrMatcher'] and parameter[4][@type='char']]"
		[Register (".ctor", "(Lorg/apache/commons/lang3/text/StrLookup;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;C)V", "")]
		public unsafe StrSubstitutor (global::Org.Apache.Commons.Lang3.Text.StrLookup variableResolver, global::Org.Apache.Commons.Lang3.Text.StrMatcher prefixMatcher, global::Org.Apache.Commons.Lang3.Text.StrMatcher suffixMatcher, char escape)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (variableResolver);
				__args [1] = new JValue (prefixMatcher);
				__args [2] = new JValue (suffixMatcher);
				__args [3] = new JValue (escape);
				if (((object) this).GetType () != typeof (StrSubstitutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/lang3/text/StrLookup;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;C)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/lang3/text/StrLookup;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;C)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_C == IntPtr.Zero)
					id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_C = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/lang3/text/StrLookup;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;C)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_C, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_C, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_CLorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/constructor[@name='StrSubstitutor' and count(parameter)=5 and parameter[1][@type='org.apache.commons.lang3.text.StrLookup&lt;?&gt;'] and parameter[2][@type='org.apache.commons.lang3.text.StrMatcher'] and parameter[3][@type='org.apache.commons.lang3.text.StrMatcher'] and parameter[4][@type='char'] and parameter[5][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register (".ctor", "(Lorg/apache/commons/lang3/text/StrLookup;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;CLorg/apache/commons/lang3/text/StrMatcher;)V", "")]
		public unsafe StrSubstitutor (global::Org.Apache.Commons.Lang3.Text.StrLookup variableResolver, global::Org.Apache.Commons.Lang3.Text.StrMatcher prefixMatcher, global::Org.Apache.Commons.Lang3.Text.StrMatcher suffixMatcher, char escape, global::Org.Apache.Commons.Lang3.Text.StrMatcher valueDelimiterMatcher)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (variableResolver);
				__args [1] = new JValue (prefixMatcher);
				__args [2] = new JValue (suffixMatcher);
				__args [3] = new JValue (escape);
				__args [4] = new JValue (valueDelimiterMatcher);
				if (((object) this).GetType () != typeof (StrSubstitutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/lang3/text/StrLookup;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;CLorg/apache/commons/lang3/text/StrMatcher;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/lang3/text/StrLookup;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;CLorg/apache/commons/lang3/text/StrMatcher;)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_CLorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
					id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_CLorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/lang3/text/StrLookup;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;CLorg/apache/commons/lang3/text/StrMatcher;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_CLorg_apache_commons_lang3_text_StrMatcher_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_lang3_text_StrLookup_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_CLorg_apache_commons_lang3_text_StrMatcher_, __args);
			} finally {
			}
		}

		static Delegate cb_isEnableSubstitutionInVariables;
#pragma warning disable 0169
		static Delegate GetIsEnableSubstitutionInVariablesHandler ()
		{
			if (cb_isEnableSubstitutionInVariables == null)
				cb_isEnableSubstitutionInVariables = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEnableSubstitutionInVariables);
			return cb_isEnableSubstitutionInVariables;
		}

		static bool n_IsEnableSubstitutionInVariables (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableSubstitutionInVariables;
		}
#pragma warning restore 0169

		static Delegate cb_setEnableSubstitutionInVariables_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableSubstitutionInVariables_ZHandler ()
		{
			if (cb_setEnableSubstitutionInVariables_Z == null)
				cb_setEnableSubstitutionInVariables_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEnableSubstitutionInVariables_Z);
			return cb_setEnableSubstitutionInVariables_Z;
		}

		static void n_SetEnableSubstitutionInVariables_Z (IntPtr jnienv, IntPtr native__this, bool enableSubstitutionInVariables)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableSubstitutionInVariables = enableSubstitutionInVariables;
		}
#pragma warning restore 0169

		static IntPtr id_isEnableSubstitutionInVariables;
		static IntPtr id_setEnableSubstitutionInVariables_Z;
		public virtual unsafe bool EnableSubstitutionInVariables {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='isEnableSubstitutionInVariables' and count(parameter)=0]"
			[Register ("isEnableSubstitutionInVariables", "()Z", "GetIsEnableSubstitutionInVariablesHandler")]
			get {
				if (id_isEnableSubstitutionInVariables == IntPtr.Zero)
					id_isEnableSubstitutionInVariables = JNIEnv.GetMethodID (class_ref, "isEnableSubstitutionInVariables", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnableSubstitutionInVariables);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnableSubstitutionInVariables", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setEnableSubstitutionInVariables' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableSubstitutionInVariables", "(Z)V", "GetSetEnableSubstitutionInVariables_ZHandler")]
			set {
				if (id_setEnableSubstitutionInVariables_Z == IntPtr.Zero)
					id_setEnableSubstitutionInVariables_Z = JNIEnv.GetMethodID (class_ref, "setEnableSubstitutionInVariables", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnableSubstitutionInVariables_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnableSubstitutionInVariables", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEscapeChar;
#pragma warning disable 0169
		static Delegate GetGetEscapeCharHandler ()
		{
			if (cb_getEscapeChar == null)
				cb_getEscapeChar = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_C) n_GetEscapeChar);
			return cb_getEscapeChar;
		}

		static char n_GetEscapeChar (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EscapeChar;
		}
#pragma warning restore 0169

		static Delegate cb_setEscapeChar_C;
#pragma warning disable 0169
		static Delegate GetSetEscapeChar_CHandler ()
		{
			if (cb_setEscapeChar_C == null)
				cb_setEscapeChar_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_V) n_SetEscapeChar_C);
			return cb_setEscapeChar_C;
		}

		static void n_SetEscapeChar_C (IntPtr jnienv, IntPtr native__this, char escapeCharacter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EscapeChar = escapeCharacter;
		}
#pragma warning restore 0169

		static IntPtr id_getEscapeChar;
		static IntPtr id_setEscapeChar_C;
		public virtual unsafe char EscapeChar {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='getEscapeChar' and count(parameter)=0]"
			[Register ("getEscapeChar", "()C", "GetGetEscapeCharHandler")]
			get {
				if (id_getEscapeChar == IntPtr.Zero)
					id_getEscapeChar = JNIEnv.GetMethodID (class_ref, "getEscapeChar", "()C");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallCharMethod (((global::Java.Lang.Object) this).Handle, id_getEscapeChar);
					else
						return JNIEnv.CallNonvirtualCharMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEscapeChar", "()C"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setEscapeChar' and count(parameter)=1 and parameter[1][@type='char']]"
			[Register ("setEscapeChar", "(C)V", "GetSetEscapeChar_CHandler")]
			set {
				if (id_setEscapeChar_C == IntPtr.Zero)
					id_setEscapeChar_C = JNIEnv.GetMethodID (class_ref, "setEscapeChar", "(C)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEscapeChar_C, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEscapeChar", "(C)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isPreserveEscapes;
#pragma warning disable 0169
		static Delegate GetIsPreserveEscapesHandler ()
		{
			if (cb_isPreserveEscapes == null)
				cb_isPreserveEscapes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPreserveEscapes);
			return cb_isPreserveEscapes;
		}

		static bool n_IsPreserveEscapes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreserveEscapes;
		}
#pragma warning restore 0169

		static Delegate cb_setPreserveEscapes_Z;
#pragma warning disable 0169
		static Delegate GetSetPreserveEscapes_ZHandler ()
		{
			if (cb_setPreserveEscapes_Z == null)
				cb_setPreserveEscapes_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPreserveEscapes_Z);
			return cb_setPreserveEscapes_Z;
		}

		static void n_SetPreserveEscapes_Z (IntPtr jnienv, IntPtr native__this, bool preserveEscapes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreserveEscapes = preserveEscapes;
		}
#pragma warning restore 0169

		static IntPtr id_isPreserveEscapes;
		static IntPtr id_setPreserveEscapes_Z;
		public virtual unsafe bool PreserveEscapes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='isPreserveEscapes' and count(parameter)=0]"
			[Register ("isPreserveEscapes", "()Z", "GetIsPreserveEscapesHandler")]
			get {
				if (id_isPreserveEscapes == IntPtr.Zero)
					id_isPreserveEscapes = JNIEnv.GetMethodID (class_ref, "isPreserveEscapes", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPreserveEscapes);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPreserveEscapes", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setPreserveEscapes' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPreserveEscapes", "(Z)V", "GetSetPreserveEscapes_ZHandler")]
			set {
				if (id_setPreserveEscapes_Z == IntPtr.Zero)
					id_setPreserveEscapes_Z = JNIEnv.GetMethodID (class_ref, "setPreserveEscapes", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreserveEscapes_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreserveEscapes", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValueDelimiterMatcher;
#pragma warning disable 0169
		static Delegate GetGetValueDelimiterMatcherHandler ()
		{
			if (cb_getValueDelimiterMatcher == null)
				cb_getValueDelimiterMatcher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetValueDelimiterMatcher);
			return cb_getValueDelimiterMatcher;
		}

		static IntPtr n_GetValueDelimiterMatcher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueDelimiterMatcher);
		}
#pragma warning restore 0169

		static IntPtr id_getValueDelimiterMatcher;
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher ValueDelimiterMatcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='getValueDelimiterMatcher' and count(parameter)=0]"
			[Register ("getValueDelimiterMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "GetGetValueDelimiterMatcherHandler")]
			get {
				if (id_getValueDelimiterMatcher == IntPtr.Zero)
					id_getValueDelimiterMatcher = JNIEnv.GetMethodID (class_ref, "getValueDelimiterMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValueDelimiterMatcher), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValueDelimiterMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVariablePrefixMatcher;
#pragma warning disable 0169
		static Delegate GetGetVariablePrefixMatcherHandler ()
		{
			if (cb_getVariablePrefixMatcher == null)
				cb_getVariablePrefixMatcher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVariablePrefixMatcher);
			return cb_getVariablePrefixMatcher;
		}

		static IntPtr n_GetVariablePrefixMatcher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VariablePrefixMatcher);
		}
#pragma warning restore 0169

		static IntPtr id_getVariablePrefixMatcher;
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher VariablePrefixMatcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='getVariablePrefixMatcher' and count(parameter)=0]"
			[Register ("getVariablePrefixMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "GetGetVariablePrefixMatcherHandler")]
			get {
				if (id_getVariablePrefixMatcher == IntPtr.Zero)
					id_getVariablePrefixMatcher = JNIEnv.GetMethodID (class_ref, "getVariablePrefixMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVariablePrefixMatcher), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVariablePrefixMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVariableResolver;
#pragma warning disable 0169
		static Delegate GetGetVariableResolverHandler ()
		{
			if (cb_getVariableResolver == null)
				cb_getVariableResolver = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVariableResolver);
			return cb_getVariableResolver;
		}

		static IntPtr n_GetVariableResolver (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VariableResolver);
		}
#pragma warning restore 0169

		static Delegate cb_setVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_;
#pragma warning disable 0169
		static Delegate GetSetVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_Handler ()
		{
			if (cb_setVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_ == null)
				cb_setVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_);
			return cb_setVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_;
		}

		static void n_SetVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_variableResolver)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var variableResolver = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrLookup> (native_variableResolver, JniHandleOwnership.DoNotTransfer);
			__this.VariableResolver = variableResolver;
		}
#pragma warning restore 0169

		static IntPtr id_getVariableResolver;
		static IntPtr id_setVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_;
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrLookup VariableResolver {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='getVariableResolver' and count(parameter)=0]"
			[Register ("getVariableResolver", "()Lorg/apache/commons/lang3/text/StrLookup;", "GetGetVariableResolverHandler")]
			get {
				if (id_getVariableResolver == IntPtr.Zero)
					id_getVariableResolver = JNIEnv.GetMethodID (class_ref, "getVariableResolver", "()Lorg/apache/commons/lang3/text/StrLookup;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrLookup> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVariableResolver), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrLookup> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVariableResolver", "()Lorg/apache/commons/lang3/text/StrLookup;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setVariableResolver' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrLookup&lt;?&gt;']]"
			[Register ("setVariableResolver", "(Lorg/apache/commons/lang3/text/StrLookup;)V", "GetSetVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_Handler")]
			set {
				if (id_setVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_ == IntPtr.Zero)
					id_setVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_ = JNIEnv.GetMethodID (class_ref, "setVariableResolver", "(Lorg/apache/commons/lang3/text/StrLookup;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVariableResolver_Lorg_apache_commons_lang3_text_StrLookup_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVariableResolver", "(Lorg/apache/commons/lang3/text/StrLookup;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVariableSuffixMatcher;
#pragma warning disable 0169
		static Delegate GetGetVariableSuffixMatcherHandler ()
		{
			if (cb_getVariableSuffixMatcher == null)
				cb_getVariableSuffixMatcher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVariableSuffixMatcher);
			return cb_getVariableSuffixMatcher;
		}

		static IntPtr n_GetVariableSuffixMatcher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VariableSuffixMatcher);
		}
#pragma warning restore 0169

		static IntPtr id_getVariableSuffixMatcher;
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher VariableSuffixMatcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='getVariableSuffixMatcher' and count(parameter)=0]"
			[Register ("getVariableSuffixMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "GetGetVariableSuffixMatcherHandler")]
			get {
				if (id_getVariableSuffixMatcher == IntPtr.Zero)
					id_getVariableSuffixMatcher = JNIEnv.GetMethodID (class_ref, "getVariableSuffixMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVariableSuffixMatcher), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVariableSuffixMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_replace_arrayC;
#pragma warning disable 0169
		static Delegate GetReplace_arrayCHandler ()
		{
			if (cb_replace_arrayC == null)
				cb_replace_arrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Replace_arrayC);
			return cb_replace_arrayC;
		}

		static IntPtr n_Replace_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = (char[]) JNIEnv.GetArray (native_source, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.NewString (__this.Replace (source));
			if (source != null)
				JNIEnv.CopyArray (source, native_source);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("replace", "([C)Ljava/lang/String;", "GetReplace_arrayCHandler")]
		public virtual unsafe string Replace (char[] source)
		{
			if (id_replace_arrayC == IntPtr.Zero)
				id_replace_arrayC = JNIEnv.GetMethodID (class_ref, "replace", "([C)Ljava/lang/String;");
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_source);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "([C)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
			}
		}

		static Delegate cb_replace_arrayCII;
#pragma warning disable 0169
		static Delegate GetReplace_arrayCIIHandler ()
		{
			if (cb_replace_arrayCII == null)
				cb_replace_arrayCII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Replace_arrayCII);
			return cb_replace_arrayCII;
		}

		static IntPtr n_Replace_arrayCII (IntPtr jnienv, IntPtr native__this, IntPtr native_source, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = (char[]) JNIEnv.GetArray (native_source, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.NewString (__this.Replace (source, offset, length));
			if (source != null)
				JNIEnv.CopyArray (source, native_source);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_arrayCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("replace", "([CII)Ljava/lang/String;", "GetReplace_arrayCIIHandler")]
		public virtual unsafe string Replace (char[] source, int offset, int length)
		{
			if (id_replace_arrayCII == IntPtr.Zero)
				id_replace_arrayCII = JNIEnv.GetMethodID (class_ref, "replace", "([CII)Ljava/lang/String;");
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_source);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_arrayCII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "([CII)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
			}
		}

		static Delegate cb_replace_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetReplace_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_replace_Ljava_lang_CharSequence_ == null)
				cb_replace_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Replace_Ljava_lang_CharSequence_);
			return cb_replace_Ljava_lang_CharSequence_;
		}

		static IntPtr n_Replace_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Replace (source));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("replace", "(Ljava/lang/CharSequence;)Ljava/lang/String;", "GetReplace_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe string Replace (global::Java.Lang.ICharSequence source)
		{
			if (id_replace_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_replace_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "replace", "(Ljava/lang/CharSequence;)Ljava/lang/String;");
			IntPtr native_source = CharSequence.ToLocalJniHandle (source);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_source);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(Ljava/lang/CharSequence;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

		static Delegate cb_replace_Ljava_lang_CharSequence_II;
#pragma warning disable 0169
		static Delegate GetReplace_Ljava_lang_CharSequence_IIHandler ()
		{
			if (cb_replace_Ljava_lang_CharSequence_II == null)
				cb_replace_Ljava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Replace_Ljava_lang_CharSequence_II);
			return cb_replace_Ljava_lang_CharSequence_II;
		}

		static IntPtr n_Replace_Ljava_lang_CharSequence_II (IntPtr jnienv, IntPtr native__this, IntPtr native_source, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Replace (source, offset, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_Ljava_lang_CharSequence_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("replace", "(Ljava/lang/CharSequence;II)Ljava/lang/String;", "GetReplace_Ljava_lang_CharSequence_IIHandler")]
		public virtual unsafe string Replace (global::Java.Lang.ICharSequence source, int offset, int length)
		{
			if (id_replace_Ljava_lang_CharSequence_II == IntPtr.Zero)
				id_replace_Ljava_lang_CharSequence_II = JNIEnv.GetMethodID (class_ref, "replace", "(Ljava/lang/CharSequence;II)Ljava/lang/String;");
			IntPtr native_source = CharSequence.ToLocalJniHandle (source);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_source);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_Ljava_lang_CharSequence_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(Ljava/lang/CharSequence;II)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

		static Delegate cb_replace_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetReplace_Ljava_lang_Object_Handler ()
		{
			if (cb_replace_Ljava_lang_Object_ == null)
				cb_replace_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Replace_Ljava_lang_Object_);
			return cb_replace_Ljava_lang_Object_;
		}

		static IntPtr n_Replace_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Replace (source));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("replace", "(Ljava/lang/Object;)Ljava/lang/String;", "GetReplace_Ljava_lang_Object_Handler")]
		public virtual unsafe string Replace (global::Java.Lang.Object source)
		{
			if (id_replace_Ljava_lang_Object_ == IntPtr.Zero)
				id_replace_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "replace", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(Ljava/lang/Object;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replace_Ljava_lang_Object_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.util.Map&lt;java.lang.String, V&gt;']]"
		[Register ("replace", "(Ljava/lang/Object;Ljava/util/Map;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public static unsafe string Replace (global::Java.Lang.Object source, global::System.Collections.IDictionary valueMap)
		{
			if (id_replace_Ljava_lang_Object_Ljava_util_Map_ == IntPtr.Zero)
				id_replace_Ljava_lang_Object_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "replace", "(Ljava/lang/Object;Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_valueMap = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (valueMap);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (native_valueMap);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replace_Ljava_lang_Object_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueMap);
			}
		}

		static IntPtr id_replace_Ljava_lang_Object_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.util.Map&lt;java.lang.String, V&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("replace", "(Ljava/lang/Object;Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public static unsafe string Replace (global::Java.Lang.Object source, global::System.Collections.IDictionary valueMap, string prefix, string suffix)
		{
			if (id_replace_Ljava_lang_Object_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replace_Ljava_lang_Object_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "replace", "(Ljava/lang/Object;Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_valueMap = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (valueMap);
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_suffix = JNIEnv.NewString (suffix);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source);
				__args [1] = new JValue (native_valueMap);
				__args [2] = new JValue (native_prefix);
				__args [3] = new JValue (native_suffix);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replace_Ljava_lang_Object_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueMap);
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
			}
		}

		static IntPtr id_replace_Ljava_lang_Object_Ljava_util_Properties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.util.Properties']]"
		[Register ("replace", "(Ljava/lang/Object;Ljava/util/Properties;)Ljava/lang/String;", "")]
		public static unsafe string Replace (global::Java.Lang.Object source, global::Java.Util.Properties valueProperties)
		{
			if (id_replace_Ljava_lang_Object_Ljava_util_Properties_ == IntPtr.Zero)
				id_replace_Ljava_lang_Object_Ljava_util_Properties_ = JNIEnv.GetStaticMethodID (class_ref, "replace", "(Ljava/lang/Object;Ljava/util/Properties;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (valueProperties);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replace_Ljava_lang_Object_Ljava_util_Properties_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_replace_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReplace_Ljava_lang_String_Handler ()
		{
			if (cb_replace_Ljava_lang_String_ == null)
				cb_replace_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Replace_Ljava_lang_String_);
			return cb_replace_Ljava_lang_String_;
		}

		static IntPtr n_Replace_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Replace (source));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("replace", "(Ljava/lang/String;)Ljava/lang/String;", "GetReplace_Ljava_lang_String_Handler")]
		public virtual unsafe string Replace (string source)
		{
			if (id_replace_Ljava_lang_String_ == IntPtr.Zero)
				id_replace_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "replace", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_source = JNIEnv.NewString (source);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_source);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

		static Delegate cb_replace_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetReplace_Ljava_lang_String_IIHandler ()
		{
			if (cb_replace_Ljava_lang_String_II == null)
				cb_replace_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Replace_Ljava_lang_String_II);
			return cb_replace_Ljava_lang_String_II;
		}

		static IntPtr n_Replace_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_source, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Replace (source, offset, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("replace", "(Ljava/lang/String;II)Ljava/lang/String;", "GetReplace_Ljava_lang_String_IIHandler")]
		public virtual unsafe string Replace (string source, int offset, int length)
		{
			if (id_replace_Ljava_lang_String_II == IntPtr.Zero)
				id_replace_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "replace", "(Ljava/lang/String;II)Ljava/lang/String;");
			IntPtr native_source = JNIEnv.NewString (source);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_source);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(Ljava/lang/String;II)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

		static Delegate cb_replace_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		static Delegate GetReplace_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_replace_Ljava_lang_StringBuffer_ == null)
				cb_replace_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Replace_Ljava_lang_StringBuffer_);
			return cb_replace_Ljava_lang_StringBuffer_;
		}

		static IntPtr n_Replace_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Replace (source));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuffer']]"
		[Register ("replace", "(Ljava/lang/StringBuffer;)Ljava/lang/String;", "GetReplace_Ljava_lang_StringBuffer_Handler")]
		public virtual unsafe string Replace (global::Java.Lang.StringBuffer source)
		{
			if (id_replace_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_replace_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "replace", "(Ljava/lang/StringBuffer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_Ljava_lang_StringBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(Ljava/lang/StringBuffer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_replace_Ljava_lang_StringBuffer_II;
#pragma warning disable 0169
		static Delegate GetReplace_Ljava_lang_StringBuffer_IIHandler ()
		{
			if (cb_replace_Ljava_lang_StringBuffer_II == null)
				cb_replace_Ljava_lang_StringBuffer_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Replace_Ljava_lang_StringBuffer_II);
			return cb_replace_Ljava_lang_StringBuffer_II;
		}

		static IntPtr n_Replace_Ljava_lang_StringBuffer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_source, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Replace (source, offset, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_Ljava_lang_StringBuffer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("replace", "(Ljava/lang/StringBuffer;II)Ljava/lang/String;", "GetReplace_Ljava_lang_StringBuffer_IIHandler")]
		public virtual unsafe string Replace (global::Java.Lang.StringBuffer source, int offset, int length)
		{
			if (id_replace_Ljava_lang_StringBuffer_II == IntPtr.Zero)
				id_replace_Ljava_lang_StringBuffer_II = JNIEnv.GetMethodID (class_ref, "replace", "(Ljava/lang/StringBuffer;II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_Ljava_lang_StringBuffer_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(Ljava/lang/StringBuffer;II)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_replace_Lorg_apache_commons_lang3_text_StrBuilder_;
#pragma warning disable 0169
		static Delegate GetReplace_Lorg_apache_commons_lang3_text_StrBuilder_Handler ()
		{
			if (cb_replace_Lorg_apache_commons_lang3_text_StrBuilder_ == null)
				cb_replace_Lorg_apache_commons_lang3_text_StrBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Replace_Lorg_apache_commons_lang3_text_StrBuilder_);
			return cb_replace_Lorg_apache_commons_lang3_text_StrBuilder_;
		}

		static IntPtr n_Replace_Lorg_apache_commons_lang3_text_StrBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Replace (source));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_Lorg_apache_commons_lang3_text_StrBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder']]"
		[Register ("replace", "(Lorg/apache/commons/lang3/text/StrBuilder;)Ljava/lang/String;", "GetReplace_Lorg_apache_commons_lang3_text_StrBuilder_Handler")]
		public virtual unsafe string Replace (global::Org.Apache.Commons.Lang3.Text.StrBuilder source)
		{
			if (id_replace_Lorg_apache_commons_lang3_text_StrBuilder_ == IntPtr.Zero)
				id_replace_Lorg_apache_commons_lang3_text_StrBuilder_ = JNIEnv.GetMethodID (class_ref, "replace", "(Lorg/apache/commons/lang3/text/StrBuilder;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_Lorg_apache_commons_lang3_text_StrBuilder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(Lorg/apache/commons/lang3/text/StrBuilder;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_replace_Lorg_apache_commons_lang3_text_StrBuilder_II;
#pragma warning disable 0169
		static Delegate GetReplace_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler ()
		{
			if (cb_replace_Lorg_apache_commons_lang3_text_StrBuilder_II == null)
				cb_replace_Lorg_apache_commons_lang3_text_StrBuilder_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Replace_Lorg_apache_commons_lang3_text_StrBuilder_II);
			return cb_replace_Lorg_apache_commons_lang3_text_StrBuilder_II;
		}

		static IntPtr n_Replace_Lorg_apache_commons_lang3_text_StrBuilder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_source, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Replace (source, offset, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_Lorg_apache_commons_lang3_text_StrBuilder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replace' and count(parameter)=3 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("replace", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Ljava/lang/String;", "GetReplace_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler")]
		public virtual unsafe string Replace (global::Org.Apache.Commons.Lang3.Text.StrBuilder source, int offset, int length)
		{
			if (id_replace_Lorg_apache_commons_lang3_text_StrBuilder_II == IntPtr.Zero)
				id_replace_Lorg_apache_commons_lang3_text_StrBuilder_II = JNIEnv.GetMethodID (class_ref, "replace", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_Lorg_apache_commons_lang3_text_StrBuilder_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_replaceIn_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		static Delegate GetReplaceIn_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_replaceIn_Ljava_lang_StringBuffer_ == null)
				cb_replaceIn_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ReplaceIn_Ljava_lang_StringBuffer_);
			return cb_replaceIn_Ljava_lang_StringBuffer_;
		}

		static bool n_ReplaceIn_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_source, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReplaceIn (source);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replaceIn_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replaceIn' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuffer']]"
		[Register ("replaceIn", "(Ljava/lang/StringBuffer;)Z", "GetReplaceIn_Ljava_lang_StringBuffer_Handler")]
		public virtual unsafe bool ReplaceIn (global::Java.Lang.StringBuffer source)
		{
			if (id_replaceIn_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_replaceIn_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "replaceIn", "(Ljava/lang/StringBuffer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_replaceIn_Ljava_lang_StringBuffer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceIn", "(Ljava/lang/StringBuffer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_replaceIn_Ljava_lang_StringBuffer_II;
#pragma warning disable 0169
		static Delegate GetReplaceIn_Ljava_lang_StringBuffer_IIHandler ()
		{
			if (cb_replaceIn_Ljava_lang_StringBuffer_II == null)
				cb_replaceIn_Ljava_lang_StringBuffer_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_Z) n_ReplaceIn_Ljava_lang_StringBuffer_II);
			return cb_replaceIn_Ljava_lang_StringBuffer_II;
		}

		static bool n_ReplaceIn_Ljava_lang_StringBuffer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_source, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_source, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReplaceIn (source, offset, length);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replaceIn_Ljava_lang_StringBuffer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replaceIn' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("replaceIn", "(Ljava/lang/StringBuffer;II)Z", "GetReplaceIn_Ljava_lang_StringBuffer_IIHandler")]
		public virtual unsafe bool ReplaceIn (global::Java.Lang.StringBuffer source, int offset, int length)
		{
			if (id_replaceIn_Ljava_lang_StringBuffer_II == IntPtr.Zero)
				id_replaceIn_Ljava_lang_StringBuffer_II = JNIEnv.GetMethodID (class_ref, "replaceIn", "(Ljava/lang/StringBuffer;II)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_replaceIn_Ljava_lang_StringBuffer_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceIn", "(Ljava/lang/StringBuffer;II)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_replaceIn_Ljava_lang_StringBuilder_;
#pragma warning disable 0169
		static Delegate GetReplaceIn_Ljava_lang_StringBuilder_Handler ()
		{
			if (cb_replaceIn_Ljava_lang_StringBuilder_ == null)
				cb_replaceIn_Ljava_lang_StringBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ReplaceIn_Ljava_lang_StringBuilder_);
			return cb_replaceIn_Ljava_lang_StringBuilder_;
		}

		static bool n_ReplaceIn_Ljava_lang_StringBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_source, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReplaceIn (source);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replaceIn_Ljava_lang_StringBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replaceIn' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuilder']]"
		[Register ("replaceIn", "(Ljava/lang/StringBuilder;)Z", "GetReplaceIn_Ljava_lang_StringBuilder_Handler")]
		public virtual unsafe bool ReplaceIn (global::Java.Lang.StringBuilder source)
		{
			if (id_replaceIn_Ljava_lang_StringBuilder_ == IntPtr.Zero)
				id_replaceIn_Ljava_lang_StringBuilder_ = JNIEnv.GetMethodID (class_ref, "replaceIn", "(Ljava/lang/StringBuilder;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_replaceIn_Ljava_lang_StringBuilder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceIn", "(Ljava/lang/StringBuilder;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_replaceIn_Ljava_lang_StringBuilder_II;
#pragma warning disable 0169
		static Delegate GetReplaceIn_Ljava_lang_StringBuilder_IIHandler ()
		{
			if (cb_replaceIn_Ljava_lang_StringBuilder_II == null)
				cb_replaceIn_Ljava_lang_StringBuilder_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_Z) n_ReplaceIn_Ljava_lang_StringBuilder_II);
			return cb_replaceIn_Ljava_lang_StringBuilder_II;
		}

		static bool n_ReplaceIn_Ljava_lang_StringBuilder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_source, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_source, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReplaceIn (source, offset, length);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replaceIn_Ljava_lang_StringBuilder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replaceIn' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("replaceIn", "(Ljava/lang/StringBuilder;II)Z", "GetReplaceIn_Ljava_lang_StringBuilder_IIHandler")]
		public virtual unsafe bool ReplaceIn (global::Java.Lang.StringBuilder source, int offset, int length)
		{
			if (id_replaceIn_Ljava_lang_StringBuilder_II == IntPtr.Zero)
				id_replaceIn_Ljava_lang_StringBuilder_II = JNIEnv.GetMethodID (class_ref, "replaceIn", "(Ljava/lang/StringBuilder;II)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_replaceIn_Ljava_lang_StringBuilder_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceIn", "(Ljava/lang/StringBuilder;II)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_;
#pragma warning disable 0169
		static Delegate GetReplaceIn_Lorg_apache_commons_lang3_text_StrBuilder_Handler ()
		{
			if (cb_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_ == null)
				cb_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ReplaceIn_Lorg_apache_commons_lang3_text_StrBuilder_);
			return cb_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_;
		}

		static bool n_ReplaceIn_Lorg_apache_commons_lang3_text_StrBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_source, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReplaceIn (source);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replaceIn' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder']]"
		[Register ("replaceIn", "(Lorg/apache/commons/lang3/text/StrBuilder;)Z", "GetReplaceIn_Lorg_apache_commons_lang3_text_StrBuilder_Handler")]
		public virtual unsafe bool ReplaceIn (global::Org.Apache.Commons.Lang3.Text.StrBuilder source)
		{
			if (id_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_ == IntPtr.Zero)
				id_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_ = JNIEnv.GetMethodID (class_ref, "replaceIn", "(Lorg/apache/commons/lang3/text/StrBuilder;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceIn", "(Lorg/apache/commons/lang3/text/StrBuilder;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_II;
#pragma warning disable 0169
		static Delegate GetReplaceIn_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler ()
		{
			if (cb_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_II == null)
				cb_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_Z) n_ReplaceIn_Lorg_apache_commons_lang3_text_StrBuilder_II);
			return cb_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_II;
		}

		static bool n_ReplaceIn_Lorg_apache_commons_lang3_text_StrBuilder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_source, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_source, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReplaceIn (source, offset, length);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replaceIn' and count(parameter)=3 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("replaceIn", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Z", "GetReplaceIn_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler")]
		public virtual unsafe bool ReplaceIn (global::Org.Apache.Commons.Lang3.Text.StrBuilder source, int offset, int length)
		{
			if (id_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_II == IntPtr.Zero)
				id_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_II = JNIEnv.GetMethodID (class_ref, "replaceIn", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_replaceIn_Lorg_apache_commons_lang3_text_StrBuilder_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceIn", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_replaceSystemProperties_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='replaceSystemProperties' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("replaceSystemProperties", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceSystemProperties (global::Java.Lang.Object source)
		{
			if (id_replaceSystemProperties_Ljava_lang_Object_ == IntPtr.Zero)
				id_replaceSystemProperties_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "replaceSystemProperties", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceSystemProperties_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_resolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_II;
#pragma warning disable 0169
		static Delegate GetResolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler ()
		{
			if (cb_resolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_II == null)
				cb_resolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_L) n_ResolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_II);
			return cb_resolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_II;
		}

		static IntPtr n_ResolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_variableName, IntPtr native_buf, int startPos, int endPos)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var variableName = JNIEnv.GetString (native_variableName, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ResolveVariable (variableName, buf, startPos, endPos));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_resolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='resolveVariable' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.commons.lang3.text.StrBuilder'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("resolveVariable", "(Ljava/lang/String;Lorg/apache/commons/lang3/text/StrBuilder;II)Ljava/lang/String;", "GetResolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler")]
		protected virtual unsafe string ResolveVariable (string variableName, global::Org.Apache.Commons.Lang3.Text.StrBuilder buf, int startPos, int endPos)
		{
			if (id_resolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_II == IntPtr.Zero)
				id_resolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_II = JNIEnv.GetMethodID (class_ref, "resolveVariable", "(Ljava/lang/String;Lorg/apache/commons/lang3/text/StrBuilder;II)Ljava/lang/String;");
			IntPtr native_variableName = JNIEnv.NewString (variableName);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_variableName);
				__args [1] = new JValue (buf);
				__args [2] = new JValue (startPos);
				__args [3] = new JValue (endPos);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_resolveVariable_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrBuilder_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resolveVariable", "(Ljava/lang/String;Lorg/apache/commons/lang3/text/StrBuilder;II)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_variableName);
			}
		}

		static Delegate cb_setValueDelimiter_C;
#pragma warning disable 0169
		static Delegate GetSetValueDelimiter_CHandler ()
		{
			if (cb_setValueDelimiter_C == null)
				cb_setValueDelimiter_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_SetValueDelimiter_C);
			return cb_setValueDelimiter_C;
		}

		static IntPtr n_SetValueDelimiter_C (IntPtr jnienv, IntPtr native__this, char valueDelimiter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetValueDelimiter (valueDelimiter));
		}
#pragma warning restore 0169

		static IntPtr id_setValueDelimiter_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setValueDelimiter' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("setValueDelimiter", "(C)Lorg/apache/commons/lang3/text/StrSubstitutor;", "GetSetValueDelimiter_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrSubstitutor SetValueDelimiter (char valueDelimiter)
		{
			if (id_setValueDelimiter_C == IntPtr.Zero)
				id_setValueDelimiter_C = JNIEnv.GetMethodID (class_ref, "setValueDelimiter", "(C)Lorg/apache/commons/lang3/text/StrSubstitutor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (valueDelimiter);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setValueDelimiter_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValueDelimiter", "(C)Lorg/apache/commons/lang3/text/StrSubstitutor;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setValueDelimiter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValueDelimiter_Ljava_lang_String_Handler ()
		{
			if (cb_setValueDelimiter_Ljava_lang_String_ == null)
				cb_setValueDelimiter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetValueDelimiter_Ljava_lang_String_);
			return cb_setValueDelimiter_Ljava_lang_String_;
		}

		static IntPtr n_SetValueDelimiter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_valueDelimiter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var valueDelimiter = JNIEnv.GetString (native_valueDelimiter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetValueDelimiter (valueDelimiter));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setValueDelimiter_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setValueDelimiter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setValueDelimiter", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrSubstitutor;", "GetSetValueDelimiter_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrSubstitutor SetValueDelimiter (string valueDelimiter)
		{
			if (id_setValueDelimiter_Ljava_lang_String_ == IntPtr.Zero)
				id_setValueDelimiter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValueDelimiter", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrSubstitutor;");
			IntPtr native_valueDelimiter = JNIEnv.NewString (valueDelimiter);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_valueDelimiter);

				global::Org.Apache.Commons.Lang3.Text.StrSubstitutor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setValueDelimiter_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValueDelimiter", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrSubstitutor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueDelimiter);
			}
		}

		static Delegate cb_setValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetSetValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_setValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_setValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_setValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static IntPtr n_SetValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_valueDelimiterMatcher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var valueDelimiterMatcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_valueDelimiterMatcher, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetValueDelimiterMatcher (valueDelimiterMatcher));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setValueDelimiterMatcher' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("setValueDelimiterMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrSubstitutor;", "GetSetValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrSubstitutor SetValueDelimiterMatcher (global::Org.Apache.Commons.Lang3.Text.StrMatcher valueDelimiterMatcher)
		{
			if (id_setValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_setValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "setValueDelimiterMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrSubstitutor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (valueDelimiterMatcher);

				global::Org.Apache.Commons.Lang3.Text.StrSubstitutor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setValueDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValueDelimiterMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrSubstitutor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setVariablePrefix_C;
#pragma warning disable 0169
		static Delegate GetSetVariablePrefix_CHandler ()
		{
			if (cb_setVariablePrefix_C == null)
				cb_setVariablePrefix_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_SetVariablePrefix_C);
			return cb_setVariablePrefix_C;
		}

		static IntPtr n_SetVariablePrefix_C (IntPtr jnienv, IntPtr native__this, char prefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetVariablePrefix (prefix));
		}
#pragma warning restore 0169

		static IntPtr id_setVariablePrefix_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setVariablePrefix' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("setVariablePrefix", "(C)Lorg/apache/commons/lang3/text/StrSubstitutor;", "GetSetVariablePrefix_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrSubstitutor SetVariablePrefix (char prefix)
		{
			if (id_setVariablePrefix_C == IntPtr.Zero)
				id_setVariablePrefix_C = JNIEnv.GetMethodID (class_ref, "setVariablePrefix", "(C)Lorg/apache/commons/lang3/text/StrSubstitutor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (prefix);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setVariablePrefix_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVariablePrefix", "(C)Lorg/apache/commons/lang3/text/StrSubstitutor;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setVariablePrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVariablePrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setVariablePrefix_Ljava_lang_String_ == null)
				cb_setVariablePrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetVariablePrefix_Ljava_lang_String_);
			return cb_setVariablePrefix_Ljava_lang_String_;
		}

		static IntPtr n_SetVariablePrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVariablePrefix (prefix));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setVariablePrefix_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setVariablePrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVariablePrefix", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrSubstitutor;", "GetSetVariablePrefix_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrSubstitutor SetVariablePrefix (string prefix)
		{
			if (id_setVariablePrefix_Ljava_lang_String_ == IntPtr.Zero)
				id_setVariablePrefix_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVariablePrefix", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrSubstitutor;");
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_prefix);

				global::Org.Apache.Commons.Lang3.Text.StrSubstitutor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setVariablePrefix_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVariablePrefix", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrSubstitutor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		static Delegate cb_setVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetSetVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_setVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_setVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_setVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static IntPtr n_SetVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefixMatcher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var prefixMatcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_prefixMatcher, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVariablePrefixMatcher (prefixMatcher));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setVariablePrefixMatcher' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("setVariablePrefixMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrSubstitutor;", "GetSetVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrSubstitutor SetVariablePrefixMatcher (global::Org.Apache.Commons.Lang3.Text.StrMatcher prefixMatcher)
		{
			if (id_setVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_setVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "setVariablePrefixMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrSubstitutor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (prefixMatcher);

				global::Org.Apache.Commons.Lang3.Text.StrSubstitutor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setVariablePrefixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVariablePrefixMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrSubstitutor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setVariableSuffix_C;
#pragma warning disable 0169
		static Delegate GetSetVariableSuffix_CHandler ()
		{
			if (cb_setVariableSuffix_C == null)
				cb_setVariableSuffix_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_SetVariableSuffix_C);
			return cb_setVariableSuffix_C;
		}

		static IntPtr n_SetVariableSuffix_C (IntPtr jnienv, IntPtr native__this, char suffix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetVariableSuffix (suffix));
		}
#pragma warning restore 0169

		static IntPtr id_setVariableSuffix_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setVariableSuffix' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("setVariableSuffix", "(C)Lorg/apache/commons/lang3/text/StrSubstitutor;", "GetSetVariableSuffix_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrSubstitutor SetVariableSuffix (char suffix)
		{
			if (id_setVariableSuffix_C == IntPtr.Zero)
				id_setVariableSuffix_C = JNIEnv.GetMethodID (class_ref, "setVariableSuffix", "(C)Lorg/apache/commons/lang3/text/StrSubstitutor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (suffix);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setVariableSuffix_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVariableSuffix", "(C)Lorg/apache/commons/lang3/text/StrSubstitutor;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setVariableSuffix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVariableSuffix_Ljava_lang_String_Handler ()
		{
			if (cb_setVariableSuffix_Ljava_lang_String_ == null)
				cb_setVariableSuffix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetVariableSuffix_Ljava_lang_String_);
			return cb_setVariableSuffix_Ljava_lang_String_;
		}

		static IntPtr n_SetVariableSuffix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_suffix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var suffix = JNIEnv.GetString (native_suffix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVariableSuffix (suffix));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setVariableSuffix_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setVariableSuffix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVariableSuffix", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrSubstitutor;", "GetSetVariableSuffix_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrSubstitutor SetVariableSuffix (string suffix)
		{
			if (id_setVariableSuffix_Ljava_lang_String_ == IntPtr.Zero)
				id_setVariableSuffix_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVariableSuffix", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrSubstitutor;");
			IntPtr native_suffix = JNIEnv.NewString (suffix);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_suffix);

				global::Org.Apache.Commons.Lang3.Text.StrSubstitutor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setVariableSuffix_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVariableSuffix", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrSubstitutor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_suffix);
			}
		}

		static Delegate cb_setVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetSetVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_setVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_setVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_setVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static IntPtr n_SetVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_suffixMatcher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var suffixMatcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_suffixMatcher, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVariableSuffixMatcher (suffixMatcher));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='setVariableSuffixMatcher' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("setVariableSuffixMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrSubstitutor;", "GetSetVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrSubstitutor SetVariableSuffixMatcher (global::Org.Apache.Commons.Lang3.Text.StrMatcher suffixMatcher)
		{
			if (id_setVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_setVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "setVariableSuffixMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrSubstitutor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (suffixMatcher);

				global::Org.Apache.Commons.Lang3.Text.StrSubstitutor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setVariableSuffixMatcher_Lorg_apache_commons_lang3_text_StrMatcher_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVariableSuffixMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrSubstitutor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_substitute_Lorg_apache_commons_lang3_text_StrBuilder_II;
#pragma warning disable 0169
		static Delegate GetSubstitute_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler ()
		{
			if (cb_substitute_Lorg_apache_commons_lang3_text_StrBuilder_II == null)
				cb_substitute_Lorg_apache_commons_lang3_text_StrBuilder_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_Z) n_Substitute_Lorg_apache_commons_lang3_text_StrBuilder_II);
			return cb_substitute_Lorg_apache_commons_lang3_text_StrBuilder_II;
		}

		static bool n_Substitute_Lorg_apache_commons_lang3_text_StrBuilder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrSubstitutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_buf, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Substitute (buf, offset, length);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_substitute_Lorg_apache_commons_lang3_text_StrBuilder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrSubstitutor']/method[@name='substitute' and count(parameter)=3 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("substitute", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Z", "GetSubstitute_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler")]
		protected virtual unsafe bool Substitute (global::Org.Apache.Commons.Lang3.Text.StrBuilder buf, int offset, int length)
		{
			if (id_substitute_Lorg_apache_commons_lang3_text_StrBuilder_II == IntPtr.Zero)
				id_substitute_Lorg_apache_commons_lang3_text_StrBuilder_II = JNIEnv.GetMethodID (class_ref, "substitute", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buf);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_substitute_Lorg_apache_commons_lang3_text_StrBuilder_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "substitute", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
