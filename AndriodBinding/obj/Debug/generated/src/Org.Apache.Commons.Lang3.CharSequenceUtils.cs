using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSequenceUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/CharSequenceUtils", DoNotGenerateAcw=true)]
	public partial class CharSequenceUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/CharSequenceUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharSequenceUtils); }
		}

		protected CharSequenceUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSequenceUtils']/constructor[@name='CharSequenceUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CharSequenceUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CharSequenceUtils)) {
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

		static IntPtr id_subSequence_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSequenceUtils']/method[@name='subSequence' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int']]"
		[Register ("subSequence", "(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence SubSequenceFormatted (global::Java.Lang.ICharSequence cs, int start)
		{
			if (id_subSequence_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_subSequence_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "subSequence", "(Ljava/lang/CharSequence;I)Ljava/lang/CharSequence;");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (start);
				global::Java.Lang.ICharSequence __ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallStaticObjectMethod  (class_ref, id_subSequence_Ljava_lang_CharSequence_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static string SubSequence (string cs, int start)
		{
			var jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			global::Java.Lang.ICharSequence __result = SubSequenceFormatted (jls_cs, start);
			var __rsval = __result?.ToString ();
			jls_cs?.Dispose ();
			return __rsval;
		}

	}
}
