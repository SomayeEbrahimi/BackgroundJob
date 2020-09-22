using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text.Translate {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CodePointTranslator']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/translate/CodePointTranslator", DoNotGenerateAcw=true)]
	public abstract partial class CodePointTranslator : global::Org.Apache.Commons.Lang3.Text.Translate.CharSequenceTranslator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/translate/CodePointTranslator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CodePointTranslator); }
		}

		protected CodePointTranslator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CodePointTranslator']/constructor[@name='CodePointTranslator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CodePointTranslator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CodePointTranslator)) {
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

		static Delegate cb_translate_ILjava_io_Writer_;
#pragma warning disable 0169
		static Delegate GetTranslate_ILjava_io_Writer_Handler ()
		{
			if (cb_translate_ILjava_io_Writer_ == null)
				cb_translate_ILjava_io_Writer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_Z) n_Translate_ILjava_io_Writer_);
			return cb_translate_ILjava_io_Writer_;
		}

		static bool n_Translate_ILjava_io_Writer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.CodePointTranslator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Translate (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CodePointTranslator']/method[@name='translate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.io.Writer']]"
		[Register ("translate", "(ILjava/io/Writer;)Z", "GetTranslate_ILjava_io_Writer_Handler")]
		public abstract bool Translate (int p0, global::Java.IO.Writer p1);

		static IntPtr id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CodePointTranslator']/method[@name='translate' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='java.io.Writer']]"
		[Register ("translate", "(Ljava/lang/CharSequence;ILjava/io/Writer;)I", "")]
		public override sealed unsafe int Translate (global::Java.Lang.ICharSequence input, int index, global::Java.IO.Writer @out)
		{
			if (id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_ == IntPtr.Zero)
				id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_ = JNIEnv.GetMethodID (class_ref, "translate", "(Ljava/lang/CharSequence;ILjava/io/Writer;)I");
			IntPtr native_input = CharSequence.ToLocalJniHandle (input);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (index);
				__args [2] = new JValue (@out);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_translate_Ljava_lang_CharSequence_ILjava_io_Writer_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/translate/CodePointTranslator", DoNotGenerateAcw=true)]
	internal partial class CodePointTranslatorInvoker : CodePointTranslator {

		public CodePointTranslatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CodePointTranslatorInvoker); }
		}

		static IntPtr id_translate_ILjava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='CodePointTranslator']/method[@name='translate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.io.Writer']]"
		[Register ("translate", "(ILjava/io/Writer;)Z", "GetTranslate_ILjava_io_Writer_Handler")]
		public override unsafe bool Translate (int p0, global::Java.IO.Writer p1)
		{
			if (id_translate_ILjava_io_Writer_ == IntPtr.Zero)
				id_translate_ILjava_io_Writer_ = JNIEnv.GetMethodID (class_ref, "translate", "(ILjava/io/Writer;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_translate_ILjava_io_Writer_, __args);
				return __ret;
			} finally {
			}
		}

	}

}
