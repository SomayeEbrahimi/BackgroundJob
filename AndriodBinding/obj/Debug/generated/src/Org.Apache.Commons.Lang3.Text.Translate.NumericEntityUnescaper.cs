using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text.Translate {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='NumericEntityUnescaper']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/translate/NumericEntityUnescaper", DoNotGenerateAcw=true)]
	public partial class NumericEntityUnescaper : global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='NumericEntityUnescaper.OPTION']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION", DoNotGenerateAcw=true)]
		public sealed partial class OPTION : global::Java.Lang.Enum {


			static IntPtr errorIfNoSemiColon_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='NumericEntityUnescaper.OPTION']/field[@name='errorIfNoSemiColon']"
			[Register ("errorIfNoSemiColon")]
			public static global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION ErrorIfNoSemiColon {
				get {
					if (errorIfNoSemiColon_jfieldId == IntPtr.Zero)
						errorIfNoSemiColon_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "errorIfNoSemiColon", "Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, errorIfNoSemiColon_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr semiColonOptional_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='NumericEntityUnescaper.OPTION']/field[@name='semiColonOptional']"
			[Register ("semiColonOptional")]
			public static global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION SemiColonOptional {
				get {
					if (semiColonOptional_jfieldId == IntPtr.Zero)
						semiColonOptional_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "semiColonOptional", "Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, semiColonOptional_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr semiColonRequired_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='NumericEntityUnescaper.OPTION']/field[@name='semiColonRequired']"
			[Register ("semiColonRequired")]
			public static global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION SemiColonRequired {
				get {
					if (semiColonRequired_jfieldId == IntPtr.Zero)
						semiColonRequired_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "semiColonRequired", "Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, semiColonRequired_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OPTION); }
			}

			internal OPTION (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='NumericEntityUnescaper.OPTION']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;", "")]
			public static unsafe global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='NumericEntityUnescaper.OPTION']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;", "")]
			public static unsafe global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;");
				try {
					return (global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/translate/NumericEntityUnescaper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NumericEntityUnescaper); }
		}

		protected NumericEntityUnescaper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='NumericEntityUnescaper']/constructor[@name='NumericEntityUnescaper' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.translate.NumericEntityUnescaper.OPTION...']]"
		[Register (".ctor", "([Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;)V", "")]
		public unsafe NumericEntityUnescaper (params global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION[] options)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_options = JNIEnv.NewArray (options);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_options);
				if (((object) this).GetType () != typeof (NumericEntityUnescaper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;)V", __args);
					return;
				}

				if (id_ctor_arrayLorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_ == IntPtr.Zero)
					id_ctor_arrayLorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_, __args);
			} finally {
				if (options != null) {
					JNIEnv.CopyArray (native_options, options);
					JNIEnv.DeleteLocalRef (native_options);
				}
			}
		}

		static Delegate cb_isSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_;
#pragma warning disable 0169
		static Delegate GetIsSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_Handler ()
		{
			if (cb_isSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_ == null)
				cb_isSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_);
			return cb_isSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_;
		}

		static bool n_IsSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_ (IntPtr jnienv, IntPtr native__this, IntPtr native_option)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var option = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION> (native_option, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSet (option);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='NumericEntityUnescaper']/method[@name='isSet' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.translate.NumericEntityUnescaper.OPTION']]"
		[Register ("isSet", "(Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;)Z", "GetIsSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_Handler")]
		public virtual unsafe bool IsSet (global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper.OPTION option)
		{
			if (id_isSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_ == IntPtr.Zero)
				id_isSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_ = JNIEnv.GetMethodID (class_ref, "isSet", "(Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (option);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSet_Lorg_apache_commons_lang3_text_translate_NumericEntityUnescaper_OPTION_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSet", "(Lorg/apache/commons/lang3/text/translate/NumericEntityUnescaper$OPTION;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_translate_Ljava_lang_CharSequence_ILjava_io_Writer_;
#pragma warning disable 0169
		static Delegate GetTranslate_Ljava_lang_CharSequence_ILjava_io_Writer_Handler ()
		{
			if (cb_translate_Ljava_lang_CharSequence_ILjava_io_Writer_ == null)
				cb_translate_Ljava_lang_CharSequence_ILjava_io_Writer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_I) n_Translate_Ljava_lang_CharSequence_ILjava_io_Writer_);
			return cb_translate_Ljava_lang_CharSequence_ILjava_io_Writer_;
		}

		static int n_Translate_Ljava_lang_CharSequence_ILjava_io_Writer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input, int index, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.NumericEntityUnescaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_input, JniHandleOwnership.DoNotTransfer);
			var @out = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native__out, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Translate (input, index, @out);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='NumericEntityUnescaper']/method[@name='translate' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='java.io.Writer']]"
		[Register ("translate", "(Ljava/lang/CharSequence;ILjava/io/Writer;)I", "GetTranslate_Ljava_lang_CharSequence_ILjava_io_Writer_Handler")]
		public override unsafe int Translate (global::Java.Lang.ICharSequence input, int index, global::Java.IO.Writer @out)
		{
			if (id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_ == IntPtr.Zero)
				id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_ = JNIEnv.GetMethodID (class_ref, "translate", "(Ljava/lang/CharSequence;ILjava/io/Writer;)I");
			IntPtr native_input = CharSequence.ToLocalJniHandle (input);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (index);
				__args [2] = new JValue (@out);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "translate", "(Ljava/lang/CharSequence;ILjava/io/Writer;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

	}
}
