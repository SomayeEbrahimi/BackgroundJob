using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text.Translate {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/translate/EntityArrays", DoNotGenerateAcw=true)]
	public partial class EntityArrays : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/translate/EntityArrays", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EntityArrays); }
		}

		protected EntityArrays (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/constructor[@name='EntityArrays' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EntityArrays ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EntityArrays)) {
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

		static IntPtr id_APOS_ESCAPE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/method[@name='APOS_ESCAPE' and count(parameter)=0]"
		[Register ("APOS_ESCAPE", "()[[Ljava/lang/String;", "")]
		public static unsafe string[][] APOS_ESCAPE ()
		{
			if (id_APOS_ESCAPE == IntPtr.Zero)
				id_APOS_ESCAPE = JNIEnv.GetStaticMethodID (class_ref, "APOS_ESCAPE", "()[[Ljava/lang/String;");
			try {
				return (string[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_APOS_ESCAPE), JniHandleOwnership.TransferLocalRef, typeof (string[]));
			} finally {
			}
		}

		static IntPtr id_APOS_UNESCAPE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/method[@name='APOS_UNESCAPE' and count(parameter)=0]"
		[Register ("APOS_UNESCAPE", "()[[Ljava/lang/String;", "")]
		public static unsafe string[][] APOS_UNESCAPE ()
		{
			if (id_APOS_UNESCAPE == IntPtr.Zero)
				id_APOS_UNESCAPE = JNIEnv.GetStaticMethodID (class_ref, "APOS_UNESCAPE", "()[[Ljava/lang/String;");
			try {
				return (string[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_APOS_UNESCAPE), JniHandleOwnership.TransferLocalRef, typeof (string[]));
			} finally {
			}
		}

		static IntPtr id_BASIC_ESCAPE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/method[@name='BASIC_ESCAPE' and count(parameter)=0]"
		[Register ("BASIC_ESCAPE", "()[[Ljava/lang/String;", "")]
		public static unsafe string[][] BASIC_ESCAPE ()
		{
			if (id_BASIC_ESCAPE == IntPtr.Zero)
				id_BASIC_ESCAPE = JNIEnv.GetStaticMethodID (class_ref, "BASIC_ESCAPE", "()[[Ljava/lang/String;");
			try {
				return (string[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_BASIC_ESCAPE), JniHandleOwnership.TransferLocalRef, typeof (string[]));
			} finally {
			}
		}

		static IntPtr id_BASIC_UNESCAPE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/method[@name='BASIC_UNESCAPE' and count(parameter)=0]"
		[Register ("BASIC_UNESCAPE", "()[[Ljava/lang/String;", "")]
		public static unsafe string[][] BASIC_UNESCAPE ()
		{
			if (id_BASIC_UNESCAPE == IntPtr.Zero)
				id_BASIC_UNESCAPE = JNIEnv.GetStaticMethodID (class_ref, "BASIC_UNESCAPE", "()[[Ljava/lang/String;");
			try {
				return (string[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_BASIC_UNESCAPE), JniHandleOwnership.TransferLocalRef, typeof (string[]));
			} finally {
			}
		}

		static IntPtr id_HTML40_EXTENDED_ESCAPE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/method[@name='HTML40_EXTENDED_ESCAPE' and count(parameter)=0]"
		[Register ("HTML40_EXTENDED_ESCAPE", "()[[Ljava/lang/String;", "")]
		public static unsafe string[][] HTML40_EXTENDED_ESCAPE ()
		{
			if (id_HTML40_EXTENDED_ESCAPE == IntPtr.Zero)
				id_HTML40_EXTENDED_ESCAPE = JNIEnv.GetStaticMethodID (class_ref, "HTML40_EXTENDED_ESCAPE", "()[[Ljava/lang/String;");
			try {
				return (string[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_HTML40_EXTENDED_ESCAPE), JniHandleOwnership.TransferLocalRef, typeof (string[]));
			} finally {
			}
		}

		static IntPtr id_HTML40_EXTENDED_UNESCAPE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/method[@name='HTML40_EXTENDED_UNESCAPE' and count(parameter)=0]"
		[Register ("HTML40_EXTENDED_UNESCAPE", "()[[Ljava/lang/String;", "")]
		public static unsafe string[][] HTML40_EXTENDED_UNESCAPE ()
		{
			if (id_HTML40_EXTENDED_UNESCAPE == IntPtr.Zero)
				id_HTML40_EXTENDED_UNESCAPE = JNIEnv.GetStaticMethodID (class_ref, "HTML40_EXTENDED_UNESCAPE", "()[[Ljava/lang/String;");
			try {
				return (string[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_HTML40_EXTENDED_UNESCAPE), JniHandleOwnership.TransferLocalRef, typeof (string[]));
			} finally {
			}
		}

		static IntPtr id_ISO8859_1_ESCAPE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/method[@name='ISO8859_1_ESCAPE' and count(parameter)=0]"
		[Register ("ISO8859_1_ESCAPE", "()[[Ljava/lang/String;", "")]
		public static unsafe string[][] ISO8859_1_ESCAPE ()
		{
			if (id_ISO8859_1_ESCAPE == IntPtr.Zero)
				id_ISO8859_1_ESCAPE = JNIEnv.GetStaticMethodID (class_ref, "ISO8859_1_ESCAPE", "()[[Ljava/lang/String;");
			try {
				return (string[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_ISO8859_1_ESCAPE), JniHandleOwnership.TransferLocalRef, typeof (string[]));
			} finally {
			}
		}

		static IntPtr id_ISO8859_1_UNESCAPE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/method[@name='ISO8859_1_UNESCAPE' and count(parameter)=0]"
		[Register ("ISO8859_1_UNESCAPE", "()[[Ljava/lang/String;", "")]
		public static unsafe string[][] ISO8859_1_UNESCAPE ()
		{
			if (id_ISO8859_1_UNESCAPE == IntPtr.Zero)
				id_ISO8859_1_UNESCAPE = JNIEnv.GetStaticMethodID (class_ref, "ISO8859_1_UNESCAPE", "()[[Ljava/lang/String;");
			try {
				return (string[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_ISO8859_1_UNESCAPE), JniHandleOwnership.TransferLocalRef, typeof (string[]));
			} finally {
			}
		}

		static IntPtr id_JAVA_CTRL_CHARS_ESCAPE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/method[@name='JAVA_CTRL_CHARS_ESCAPE' and count(parameter)=0]"
		[Register ("JAVA_CTRL_CHARS_ESCAPE", "()[[Ljava/lang/String;", "")]
		public static unsafe string[][] JAVA_CTRL_CHARS_ESCAPE ()
		{
			if (id_JAVA_CTRL_CHARS_ESCAPE == IntPtr.Zero)
				id_JAVA_CTRL_CHARS_ESCAPE = JNIEnv.GetStaticMethodID (class_ref, "JAVA_CTRL_CHARS_ESCAPE", "()[[Ljava/lang/String;");
			try {
				return (string[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_JAVA_CTRL_CHARS_ESCAPE), JniHandleOwnership.TransferLocalRef, typeof (string[]));
			} finally {
			}
		}

		static IntPtr id_JAVA_CTRL_CHARS_UNESCAPE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/method[@name='JAVA_CTRL_CHARS_UNESCAPE' and count(parameter)=0]"
		[Register ("JAVA_CTRL_CHARS_UNESCAPE", "()[[Ljava/lang/String;", "")]
		public static unsafe string[][] JAVA_CTRL_CHARS_UNESCAPE ()
		{
			if (id_JAVA_CTRL_CHARS_UNESCAPE == IntPtr.Zero)
				id_JAVA_CTRL_CHARS_UNESCAPE = JNIEnv.GetStaticMethodID (class_ref, "JAVA_CTRL_CHARS_UNESCAPE", "()[[Ljava/lang/String;");
			try {
				return (string[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_JAVA_CTRL_CHARS_UNESCAPE), JniHandleOwnership.TransferLocalRef, typeof (string[]));
			} finally {
			}
		}

		static IntPtr id_invert_arrayarrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text.translate']/class[@name='EntityArrays']/method[@name='invert' and count(parameter)=1 and parameter[1][@type='java.lang.String[][]']]"
		[Register ("invert", "([[Ljava/lang/String;)[[Ljava/lang/String;", "")]
		public static unsafe string[][] Invert (string[][] array)
		{
			if (id_invert_arrayarrayLjava_lang_String_ == IntPtr.Zero)
				id_invert_arrayarrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "invert", "([[Ljava/lang/String;)[[Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				string[][] __ret = (string[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_invert_arrayarrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string[]));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

	}
}
