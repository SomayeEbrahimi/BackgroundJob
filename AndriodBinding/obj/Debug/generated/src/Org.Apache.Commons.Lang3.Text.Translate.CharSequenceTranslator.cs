using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text.Translate {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CharSequenceTranslator']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/translate/CharSequenceTranslator", DoNotGenerateAcw=true)]
	public abstract partial class CharSequenceTranslator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/translate/CharSequenceTranslator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharSequenceTranslator); }
		}

		protected CharSequenceTranslator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CharSequenceTranslator']/constructor[@name='CharSequenceTranslator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CharSequenceTranslator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CharSequenceTranslator)) {
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

		static IntPtr id_hex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CharSequenceTranslator']/method[@name='hex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hex", "(I)Ljava/lang/String;", "")]
		public static unsafe string Hex (int codepoint)
		{
			if (id_hex_I == IntPtr.Zero)
				id_hex_I = JNIEnv.GetStaticMethodID (class_ref, "hex", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (codepoint);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hex_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_translate_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CharSequenceTranslator']/method[@name='translate' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("translate", "(Ljava/lang/CharSequence;)Ljava/lang/String;", "")]
		public unsafe string Translate (global::Java.Lang.ICharSequence input)
		{
			if (id_translate_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_translate_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "translate", "(Ljava/lang/CharSequence;)Ljava/lang/String;");
			IntPtr native_input = CharSequence.ToLocalJniHandle (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_translate_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		public string Translate (string input)
		{
			var jls_input = input == null ? null : new global::Java.Lang.String (input);
			string __result = Translate (jls_input);
			var __rsval = __result;
			jls_input?.Dispose ();
			return __rsval;
		}

		static Delegate cb_translate_Ljava_lang_CharSequence_ILjava_io_Writer_;
#pragma warning disable 0169
		static Delegate GetTranslate_Ljava_lang_CharSequence_ILjava_io_Writer_Handler ()
		{
			if (cb_translate_Ljava_lang_CharSequence_ILjava_io_Writer_ == null)
				cb_translate_Ljava_lang_CharSequence_ILjava_io_Writer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_I) n_Translate_Ljava_lang_CharSequence_ILjava_io_Writer_);
			return cb_translate_Ljava_lang_CharSequence_ILjava_io_Writer_;
		}

		static int n_Translate_Ljava_lang_CharSequence_ILjava_io_Writer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Translate (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CharSequenceTranslator']/method[@name='translate' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='java.io.Writer']]"
		[Register ("translate", "(Ljava/lang/CharSequence;ILjava/io/Writer;)I", "GetTranslate_Ljava_lang_CharSequence_ILjava_io_Writer_Handler")]
		public abstract int Translate (global::Java.Lang.ICharSequence p0, int p1, global::Java.IO.Writer p2);

		public int Translate (string p0, int p1, global::Java.IO.Writer p2)
		{
			var jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			int __result = Translate (jls_p0, p1, p2);
			var __rsval = __result;
			jls_p0?.Dispose ();
			return __rsval;
		}

		static IntPtr id_translate_Ljava_lang_CharSequence_Ljava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CharSequenceTranslator']/method[@name='translate' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.io.Writer']]"
		[Register ("translate", "(Ljava/lang/CharSequence;Ljava/io/Writer;)V", "")]
		public unsafe void Translate (global::Java.Lang.ICharSequence input, global::Java.IO.Writer @out)
		{
			if (id_translate_Ljava_lang_CharSequence_Ljava_io_Writer_ == IntPtr.Zero)
				id_translate_Ljava_lang_CharSequence_Ljava_io_Writer_ = JNIEnv.GetMethodID (class_ref, "translate", "(Ljava/lang/CharSequence;Ljava/io/Writer;)V");
			IntPtr native_input = CharSequence.ToLocalJniHandle (input);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (@out);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_translate_Ljava_lang_CharSequence_Ljava_io_Writer_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		public void Translate (string input, global::Java.IO.Writer @out)
		{
			var jls_input = input == null ? null : new global::Java.Lang.String (input);
			Translate (jls_input, @out);
			jls_input?.Dispose ();
		}

		static IntPtr id_with_arrayLorg_apache_commons_lang3_text_translate_CharSequenceTranslator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CharSequenceTranslator']/method[@name='with' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.translate.CharSequenceTranslator...']]"
		[Register ("with", "([Lorg/apache/commons/lang3/text/translate/CharSequenceTranslator;)Lorg/apache/commons/lang3/text/translate/CharSequenceTranslator;", "")]
		public unsafe global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator With (params global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator[] translators)
		{
			if (id_with_arrayLorg_apache_commons_lang3_text_translate_CharSequenceTranslator_ == IntPtr.Zero)
				id_with_arrayLorg_apache_commons_lang3_text_translate_CharSequenceTranslator_ = JNIEnv.GetMethodID (class_ref, "with", "([Lorg/apache/commons/lang3/text/translate/CharSequenceTranslator;)Lorg/apache/commons/lang3/text/translate/CharSequenceTranslator;");
			IntPtr native_translators = JNIEnv.NewArray (translators);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_translators);
				global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_with_arrayLorg_apache_commons_lang3_text_translate_CharSequenceTranslator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (translators != null) {
					JNIEnv.CopyArray (native_translators, translators);
					JNIEnv.DeleteLocalRef (native_translators);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/translate/CharSequenceTranslator", DoNotGenerateAcw=true)]
	internal partial class CharSequenceTranslatorInvoker : CharSequenceTranslator {

		public CharSequenceTranslatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharSequenceTranslatorInvoker); }
		}

		static IntPtr id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CharSequenceTranslator']/method[@name='translate' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='java.io.Writer']]"
		[Register ("translate", "(Ljava/lang/CharSequence;ILjava/io/Writer;)I", "GetTranslate_Ljava_lang_CharSequence_ILjava_io_Writer_Handler")]
		public override unsafe int Translate (global::Java.Lang.ICharSequence p0, int p1, global::Java.IO.Writer p2)
		{
			if (id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_ == IntPtr.Zero)
				id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_ = JNIEnv.GetMethodID (class_ref, "translate", "(Ljava/lang/CharSequence;ILjava/io/Writer;)I");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
