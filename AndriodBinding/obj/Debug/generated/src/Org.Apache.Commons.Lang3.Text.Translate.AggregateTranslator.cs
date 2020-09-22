using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text.Translate {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='AggregateTranslator']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/translate/AggregateTranslator", DoNotGenerateAcw=true)]
	public partial class AggregateTranslator : global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/translate/AggregateTranslator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AggregateTranslator); }
		}

		protected AggregateTranslator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLorg_apache_commons_lang3_text_translate_CharSequenceTranslator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='AggregateTranslator']/constructor[@name='AggregateTranslator' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.translate.CharSequenceTranslator...']]"
		[Register (".ctor", "([Lorg/apache/commons/lang3/text/translate/CharSequenceTranslator;)V", "")]
		public unsafe AggregateTranslator (params global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator[] translators)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_translators = JNIEnv.NewArray (translators);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_translators);
				if (((object) this).GetType () != typeof (AggregateTranslator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lorg/apache/commons/lang3/text/translate/CharSequenceTranslator;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lorg/apache/commons/lang3/text/translate/CharSequenceTranslator;)V", __args);
					return;
				}

				if (id_ctor_arrayLorg_apache_commons_lang3_text_translate_CharSequenceTranslator_ == IntPtr.Zero)
					id_ctor_arrayLorg_apache_commons_lang3_text_translate_CharSequenceTranslator_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lorg/apache/commons/lang3/text/translate/CharSequenceTranslator;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLorg_apache_commons_lang3_text_translate_CharSequenceTranslator_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLorg_apache_commons_lang3_text_translate_CharSequenceTranslator_, __args);
			} finally {
				if (translators != null) {
					JNIEnv.CopyArray (native_translators, translators);
					JNIEnv.DeleteLocalRef (native_translators);
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.AggregateTranslator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_input, JniHandleOwnership.DoNotTransfer);
			var @out = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native__out, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Translate (input, index, @out);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='AggregateTranslator']/method[@name='translate' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='java.io.Writer']]"
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
