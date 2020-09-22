using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text.Translate {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeEscaper']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/translate/UnicodeEscaper", DoNotGenerateAcw=true)]
	public partial class UnicodeEscaper : global::Org.Apache.Commons.Lang3.Text.Translate.CodePointTranslator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/translate/UnicodeEscaper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnicodeEscaper); }
		}

		protected UnicodeEscaper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeEscaper']/constructor[@name='UnicodeEscaper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnicodeEscaper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UnicodeEscaper)) {
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

		static IntPtr id_ctor_IIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeEscaper']/constructor[@name='UnicodeEscaper' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(IIZ)V", "")]
		protected unsafe UnicodeEscaper (int below, int above, bool between)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (below);
				__args [1] = new JValue (above);
				__args [2] = new JValue (between);
				if (((object) this).GetType () != typeof (UnicodeEscaper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IIZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIZ)V", __args);
					return;
				}

				if (id_ctor_IIZ == IntPtr.Zero)
					id_ctor_IIZ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIZ, __args);
			} finally {
			}
		}

		static IntPtr id_above_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeEscaper']/method[@name='above' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("above", "(I)Lorg/apache/commons/lang3/text/translate/UnicodeEscaper;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeEscaper Above (int codepoint)
		{
			if (id_above_I == IntPtr.Zero)
				id_above_I = JNIEnv.GetStaticMethodID (class_ref, "above", "(I)Lorg/apache/commons/lang3/text/translate/UnicodeEscaper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (codepoint);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeEscaper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_above_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_below_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeEscaper']/method[@name='below' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("below", "(I)Lorg/apache/commons/lang3/text/translate/UnicodeEscaper;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeEscaper Below (int codepoint)
		{
			if (id_below_I == IntPtr.Zero)
				id_below_I = JNIEnv.GetStaticMethodID (class_ref, "below", "(I)Lorg/apache/commons/lang3/text/translate/UnicodeEscaper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (codepoint);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeEscaper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_below_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_between_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeEscaper']/method[@name='between' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("between", "(II)Lorg/apache/commons/lang3/text/translate/UnicodeEscaper;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeEscaper Between (int codepointLow, int codepointHigh)
		{
			if (id_between_II == IntPtr.Zero)
				id_between_II = JNIEnv.GetStaticMethodID (class_ref, "between", "(II)Lorg/apache/commons/lang3/text/translate/UnicodeEscaper;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (codepointLow);
				__args [1] = new JValue (codepointHigh);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeEscaper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_between_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_outsideOf_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeEscaper']/method[@name='outsideOf' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("outsideOf", "(II)Lorg/apache/commons/lang3/text/translate/UnicodeEscaper;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeEscaper OutsideOf (int codepointLow, int codepointHigh)
		{
			if (id_outsideOf_II == IntPtr.Zero)
				id_outsideOf_II = JNIEnv.GetStaticMethodID (class_ref, "outsideOf", "(II)Lorg/apache/commons/lang3/text/translate/UnicodeEscaper;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (codepointLow);
				__args [1] = new JValue (codepointHigh);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeEscaper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_outsideOf_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toUtf16Escape_I;
#pragma warning disable 0169
		static Delegate GetToUtf16Escape_IHandler ()
		{
			if (cb_toUtf16Escape_I == null)
				cb_toUtf16Escape_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_ToUtf16Escape_I);
			return cb_toUtf16Escape_I;
		}

		static IntPtr n_ToUtf16Escape_I (IntPtr jnienv, IntPtr native__this, int codepoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeEscaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToUtf16Escape (codepoint));
		}
#pragma warning restore 0169

		static IntPtr id_toUtf16Escape_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeEscaper']/method[@name='toUtf16Escape' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toUtf16Escape", "(I)Ljava/lang/String;", "GetToUtf16Escape_IHandler")]
		protected virtual unsafe string ToUtf16Escape (int codepoint)
		{
			if (id_toUtf16Escape_I == IntPtr.Zero)
				id_toUtf16Escape_I = JNIEnv.GetMethodID (class_ref, "toUtf16Escape", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (codepoint);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toUtf16Escape_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toUtf16Escape", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static bool n_Translate_ILjava_io_Writer_ (IntPtr jnienv, IntPtr native__this, int codepoint, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeEscaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native__out, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Translate (codepoint, @out);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_translate_ILjava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='UnicodeEscaper']/method[@name='translate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.io.Writer']]"
		[Register ("translate", "(ILjava/io/Writer;)Z", "GetTranslate_ILjava_io_Writer_Handler")]
		public override unsafe bool Translate (int codepoint, global::Java.IO.Writer @out)
		{
			if (id_translate_ILjava_io_Writer_ == IntPtr.Zero)
				id_translate_ILjava_io_Writer_ = JNIEnv.GetMethodID (class_ref, "translate", "(ILjava/io/Writer;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (codepoint);
				__args [1] = new JValue (@out);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_translate_ILjava_io_Writer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "translate", "(ILjava/io/Writer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
