using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text.Translate {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='JavaUnicodeEscaper']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/translate/JavaUnicodeEscaper", DoNotGenerateAcw=true)]
	public partial class JavaUnicodeEscaper : global::Org.Apache.Commons.Lang3.Text.Translate.UnicodeEscaper {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/translate/JavaUnicodeEscaper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JavaUnicodeEscaper); }
		}

		protected JavaUnicodeEscaper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='JavaUnicodeEscaper']/constructor[@name='JavaUnicodeEscaper' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(IIZ)V", "")]
		public unsafe JavaUnicodeEscaper (int below, int above, bool between)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (below);
				__args [1] = new JValue (above);
				__args [2] = new JValue (between);
				if (((object) this).GetType () != typeof (JavaUnicodeEscaper)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='JavaUnicodeEscaper']/method[@name='above' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("above", "(I)Lorg/apache/commons/lang3/text/translate/JavaUnicodeEscaper;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.Translate.JavaUnicodeEscaper Above (int codepoint)
		{
			if (id_above_I == IntPtr.Zero)
				id_above_I = JNIEnv.GetStaticMethodID (class_ref, "above", "(I)Lorg/apache/commons/lang3/text/translate/JavaUnicodeEscaper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (codepoint);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.JavaUnicodeEscaper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_above_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_below_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='JavaUnicodeEscaper']/method[@name='below' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("below", "(I)Lorg/apache/commons/lang3/text/translate/JavaUnicodeEscaper;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.Translate.JavaUnicodeEscaper Below (int codepoint)
		{
			if (id_below_I == IntPtr.Zero)
				id_below_I = JNIEnv.GetStaticMethodID (class_ref, "below", "(I)Lorg/apache/commons/lang3/text/translate/JavaUnicodeEscaper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (codepoint);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.JavaUnicodeEscaper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_below_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_between_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='JavaUnicodeEscaper']/method[@name='between' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("between", "(II)Lorg/apache/commons/lang3/text/translate/JavaUnicodeEscaper;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.Translate.JavaUnicodeEscaper Between (int codepointLow, int codepointHigh)
		{
			if (id_between_II == IntPtr.Zero)
				id_between_II = JNIEnv.GetStaticMethodID (class_ref, "between", "(II)Lorg/apache/commons/lang3/text/translate/JavaUnicodeEscaper;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (codepointLow);
				__args [1] = new JValue (codepointHigh);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.JavaUnicodeEscaper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_between_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_outsideOf_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='JavaUnicodeEscaper']/method[@name='outsideOf' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("outsideOf", "(II)Lorg/apache/commons/lang3/text/translate/JavaUnicodeEscaper;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.Translate.JavaUnicodeEscaper OutsideOf (int codepointLow, int codepointHigh)
		{
			if (id_outsideOf_II == IntPtr.Zero)
				id_outsideOf_II = JNIEnv.GetStaticMethodID (class_ref, "outsideOf", "(II)Lorg/apache/commons/lang3/text/translate/JavaUnicodeEscaper;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (codepointLow);
				__args [1] = new JValue (codepointHigh);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.Translate.JavaUnicodeEscaper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_outsideOf_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
