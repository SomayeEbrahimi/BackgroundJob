using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text.Translate {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeUnescaper']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/translate/UnicodeUnescaper", DoNotGenerateAcw=true)]
	public partial class UnicodeUnescaper : global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/translate/UnicodeUnescaper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnicodeUnescaper); }
		}

		protected UnicodeUnescaper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeUnescaper']/constructor[@name='UnicodeUnescaper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnicodeUnescaper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UnicodeUnescaper)) {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeUnescaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_input, JniHandleOwnership.DoNotTransfer);
			var @out = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native__out, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Translate (input, index, @out);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeUnescaper']/method[@name='translate' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='java.io.Writer']]"
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
