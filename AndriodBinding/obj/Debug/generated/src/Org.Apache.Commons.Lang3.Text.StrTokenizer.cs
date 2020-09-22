using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/StrTokenizer", DoNotGenerateAcw=true)]
	public partial class StrTokenizer : global::Java.Lang.Object, global::Java.Lang.ICloneable, global::Java.Util.IListIterator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/StrTokenizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrTokenizer); }
		}

		protected StrTokenizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StrTokenizer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StrTokenizer)) {
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

		static IntPtr id_ctor_arrayC;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register (".ctor", "([C)V", "")]
		public unsafe StrTokenizer (char[] input)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([C)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([C)V", __args);
					return;
				}

				if (id_ctor_arrayC == IntPtr.Zero)
					id_ctor_arrayC = JNIEnv.GetMethodID (class_ref, "<init>", "([C)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayC, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayC, __args);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		static IntPtr id_ctor_arrayCC;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char']]"
		[Register (".ctor", "([CC)V", "")]
		public unsafe StrTokenizer (char[] input, char delim)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (delim);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([CC)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([CC)V", __args);
					return;
				}

				if (id_ctor_arrayCC == IntPtr.Zero)
					id_ctor_arrayCC = JNIEnv.GetMethodID (class_ref, "<init>", "([CC)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayCC, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayCC, __args);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		static IntPtr id_ctor_arrayCCC;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='char'] and parameter[3][@type='char']]"
		[Register (".ctor", "([CCC)V", "")]
		public unsafe StrTokenizer (char[] input, char delim, char quote)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (delim);
				__args [2] = new JValue (quote);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([CCC)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([CCC)V", __args);
					return;
				}

				if (id_ctor_arrayCCC == IntPtr.Zero)
					id_ctor_arrayCCC = JNIEnv.GetMethodID (class_ref, "<init>", "([CCC)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayCCC, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayCCC, __args);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		static IntPtr id_ctor_arrayCLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "([CLjava/lang/String;)V", "")]
		public unsafe StrTokenizer (char[] input, string delim)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewArray (input);
			IntPtr native_delim = JNIEnv.NewString (delim);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (native_delim);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([CLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([CLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_arrayCLjava_lang_String_ == IntPtr.Zero)
					id_ctor_arrayCLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "([CLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayCLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayCLjava_lang_String_, __args);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
				JNIEnv.DeleteLocalRef (native_delim);
			}
		}

		static IntPtr id_ctor_arrayCLorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register (".ctor", "([CLorg/apache/commons/lang3/text/StrMatcher;)V", "")]
		public unsafe StrTokenizer (char[] input, global::Org.Apache.Commons.Lang3.Text.StrMatcher delim)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (delim);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([CLorg/apache/commons/lang3/text/StrMatcher;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([CLorg/apache/commons/lang3/text/StrMatcher;)V", __args);
					return;
				}

				if (id_ctor_arrayCLorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
					id_ctor_arrayCLorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "<init>", "([CLorg/apache/commons/lang3/text/StrMatcher;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayCLorg_apache_commons_lang3_text_StrMatcher_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayCLorg_apache_commons_lang3_text_StrMatcher_, __args);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		static IntPtr id_ctor_arrayCLorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='org.apache.commons.lang3.text.StrMatcher'] and parameter[3][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register (".ctor", "([CLorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;)V", "")]
		public unsafe StrTokenizer (char[] input, global::Org.Apache.Commons.Lang3.Text.StrMatcher delim, global::Org.Apache.Commons.Lang3.Text.StrMatcher quote)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (delim);
				__args [2] = new JValue (quote);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([CLorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([CLorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;)V", __args);
					return;
				}

				if (id_ctor_arrayCLorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
					id_ctor_arrayCLorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "<init>", "([CLorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayCLorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayCLorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_, __args);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe StrTokenizer (string input)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_C;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register (".ctor", "(Ljava/lang/String;C)V", "")]
		public unsafe StrTokenizer (string input, char delim)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (delim);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;C)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;C)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_C == IntPtr.Zero)
					id_ctor_Ljava_lang_String_C = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;C)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_C, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_C, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_CC;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char'] and parameter[3][@type='char']]"
		[Register (".ctor", "(Ljava/lang/String;CC)V", "")]
		public unsafe StrTokenizer (string input, char delim, char quote)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (delim);
				__args [2] = new JValue (quote);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;CC)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;CC)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_CC == IntPtr.Zero)
					id_ctor_Ljava_lang_String_CC = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;CC)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_CC, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_CC, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe StrTokenizer (string input, string delim)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewString (input);
			IntPtr native_delim = JNIEnv.NewString (delim);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (native_delim);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_delim);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/apache/commons/lang3/text/StrMatcher;)V", "")]
		public unsafe StrTokenizer (string input, global::Org.Apache.Commons.Lang3.Text.StrMatcher delim)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (delim);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lorg/apache/commons/lang3/text/StrMatcher;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lorg/apache/commons/lang3/text/StrMatcher;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/apache/commons/lang3/text/StrMatcher;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrMatcher_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrMatcher_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/constructor[@name='StrTokenizer' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.commons.lang3.text.StrMatcher'] and parameter[3][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;)V", "")]
		public unsafe StrTokenizer (string input, global::Org.Apache.Commons.Lang3.Text.StrMatcher delim, global::Org.Apache.Commons.Lang3.Text.StrMatcher quote)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (delim);
				__args [2] = new JValue (quote);
				if (((object) this).GetType () != typeof (StrTokenizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/apache/commons/lang3/text/StrMatcher;Lorg/apache/commons/lang3/text/StrMatcher;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_apache_commons_lang3_text_StrMatcher_Lorg_apache_commons_lang3_text_StrMatcher_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_getCSVInstance;
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer CSVInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getCSVInstance' and count(parameter)=0]"
			[Register ("getCSVInstance", "()Lorg/apache/commons/lang3/text/StrTokenizer;", "")]
			get {
				if (id_getCSVInstance == IntPtr.Zero)
					id_getCSVInstance = JNIEnv.GetStaticMethodID (class_ref, "getCSVInstance", "()Lorg/apache/commons/lang3/text/StrTokenizer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCSVInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Content);
		}
#pragma warning restore 0169

		static IntPtr id_getContent;
		public virtual unsafe string Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/lang/String;", "GetGetContentHandler")]
			get {
				if (id_getContent == IntPtr.Zero)
					id_getContent = JNIEnv.GetMethodID (class_ref, "getContent", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContent), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContent", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDelimiterMatcher;
#pragma warning disable 0169
		static Delegate GetGetDelimiterMatcherHandler ()
		{
			if (cb_getDelimiterMatcher == null)
				cb_getDelimiterMatcher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDelimiterMatcher);
			return cb_getDelimiterMatcher;
		}

		static IntPtr n_GetDelimiterMatcher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DelimiterMatcher);
		}
#pragma warning restore 0169

		static IntPtr id_getDelimiterMatcher;
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher DelimiterMatcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getDelimiterMatcher' and count(parameter)=0]"
			[Register ("getDelimiterMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "GetGetDelimiterMatcherHandler")]
			get {
				if (id_getDelimiterMatcher == IntPtr.Zero)
					id_getDelimiterMatcher = JNIEnv.GetMethodID (class_ref, "getDelimiterMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDelimiterMatcher), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelimiterMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		static IntPtr id_hasNext;
		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNext);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasNext", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasPrevious;
#pragma warning disable 0169
		static Delegate GetHasPreviousHandler ()
		{
			if (cb_hasPrevious == null)
				cb_hasPrevious = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasPrevious);
			return cb_hasPrevious;
		}

		static bool n_HasPrevious (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPrevious;
		}
#pragma warning restore 0169

		static IntPtr id_hasPrevious;
		public virtual unsafe bool HasPrevious {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='hasPrevious' and count(parameter)=0]"
			[Register ("hasPrevious", "()Z", "GetHasPreviousHandler")]
			get {
				if (id_hasPrevious == IntPtr.Zero)
					id_hasPrevious = JNIEnv.GetMethodID (class_ref, "hasPrevious", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasPrevious);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasPrevious", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getIgnoredMatcher;
#pragma warning disable 0169
		static Delegate GetGetIgnoredMatcherHandler ()
		{
			if (cb_getIgnoredMatcher == null)
				cb_getIgnoredMatcher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIgnoredMatcher);
			return cb_getIgnoredMatcher;
		}

		static IntPtr n_GetIgnoredMatcher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IgnoredMatcher);
		}
#pragma warning restore 0169

		static IntPtr id_getIgnoredMatcher;
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher IgnoredMatcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getIgnoredMatcher' and count(parameter)=0]"
			[Register ("getIgnoredMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "GetGetIgnoredMatcherHandler")]
			get {
				if (id_getIgnoredMatcher == IntPtr.Zero)
					id_getIgnoredMatcher = JNIEnv.GetMethodID (class_ref, "getIgnoredMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIgnoredMatcher), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIgnoredMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEmptyTokenAsNull;
#pragma warning disable 0169
		static Delegate GetIsEmptyTokenAsNullHandler ()
		{
			if (cb_isEmptyTokenAsNull == null)
				cb_isEmptyTokenAsNull = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEmptyTokenAsNull);
			return cb_isEmptyTokenAsNull;
		}

		static bool n_IsEmptyTokenAsNull (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmptyTokenAsNull;
		}
#pragma warning restore 0169

		static IntPtr id_isEmptyTokenAsNull;
		public virtual unsafe bool IsEmptyTokenAsNull {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='isEmptyTokenAsNull' and count(parameter)=0]"
			[Register ("isEmptyTokenAsNull", "()Z", "GetIsEmptyTokenAsNullHandler")]
			get {
				if (id_isEmptyTokenAsNull == IntPtr.Zero)
					id_isEmptyTokenAsNull = JNIEnv.GetMethodID (class_ref, "isEmptyTokenAsNull", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmptyTokenAsNull);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmptyTokenAsNull", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isIgnoreEmptyTokens;
#pragma warning disable 0169
		static Delegate GetIsIgnoreEmptyTokensHandler ()
		{
			if (cb_isIgnoreEmptyTokens == null)
				cb_isIgnoreEmptyTokens = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsIgnoreEmptyTokens);
			return cb_isIgnoreEmptyTokens;
		}

		static bool n_IsIgnoreEmptyTokens (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIgnoreEmptyTokens;
		}
#pragma warning restore 0169

		static IntPtr id_isIgnoreEmptyTokens;
		public virtual unsafe bool IsIgnoreEmptyTokens {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='isIgnoreEmptyTokens' and count(parameter)=0]"
			[Register ("isIgnoreEmptyTokens", "()Z", "GetIsIgnoreEmptyTokensHandler")]
			get {
				if (id_isIgnoreEmptyTokens == IntPtr.Zero)
					id_isIgnoreEmptyTokens = JNIEnv.GetMethodID (class_ref, "isIgnoreEmptyTokens", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isIgnoreEmptyTokens);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isIgnoreEmptyTokens", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getQuoteMatcher;
#pragma warning disable 0169
		static Delegate GetGetQuoteMatcherHandler ()
		{
			if (cb_getQuoteMatcher == null)
				cb_getQuoteMatcher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetQuoteMatcher);
			return cb_getQuoteMatcher;
		}

		static IntPtr n_GetQuoteMatcher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.QuoteMatcher);
		}
#pragma warning restore 0169

		static IntPtr id_getQuoteMatcher;
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher QuoteMatcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getQuoteMatcher' and count(parameter)=0]"
			[Register ("getQuoteMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "GetGetQuoteMatcherHandler")]
			get {
				if (id_getQuoteMatcher == IntPtr.Zero)
					id_getQuoteMatcher = JNIEnv.GetMethodID (class_ref, "getQuoteMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getQuoteMatcher), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuoteMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTSVInstance;
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer TSVInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getTSVInstance' and count(parameter)=0]"
			[Register ("getTSVInstance", "()Lorg/apache/commons/lang3/text/StrTokenizer;", "")]
			get {
				if (id_getTSVInstance == IntPtr.Zero)
					id_getTSVInstance = JNIEnv.GetStaticMethodID (class_ref, "getTSVInstance", "()Lorg/apache/commons/lang3/text/StrTokenizer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTSVInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenList;
#pragma warning disable 0169
		static Delegate GetGetTokenListHandler ()
		{
			if (cb_getTokenList == null)
				cb_getTokenList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTokenList);
			return cb_getTokenList;
		}

		static IntPtr n_GetTokenList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.TokenList);
		}
#pragma warning restore 0169

		static IntPtr id_getTokenList;
		public virtual unsafe global::System.Collections.Generic.IList<string> TokenList {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getTokenList' and count(parameter)=0]"
			[Register ("getTokenList", "()Ljava/util/List;", "GetGetTokenListHandler")]
			get {
				if (id_getTokenList == IntPtr.Zero)
					id_getTokenList = JNIEnv.GetMethodID (class_ref, "getTokenList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrimmerMatcher;
#pragma warning disable 0169
		static Delegate GetGetTrimmerMatcherHandler ()
		{
			if (cb_getTrimmerMatcher == null)
				cb_getTrimmerMatcher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTrimmerMatcher);
			return cb_getTrimmerMatcher;
		}

		static IntPtr n_GetTrimmerMatcher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrimmerMatcher);
		}
#pragma warning restore 0169

		static IntPtr id_getTrimmerMatcher;
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher TrimmerMatcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getTrimmerMatcher' and count(parameter)=0]"
			[Register ("getTrimmerMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "GetGetTrimmerMatcherHandler")]
			get {
				if (id_getTrimmerMatcher == IntPtr.Zero)
					id_getTrimmerMatcher = JNIEnv.GetMethodID (class_ref, "getTrimmerMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrimmerMatcher), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrimmerMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Handler ()
		{
			if (cb_add_Ljava_lang_String_ == null)
				cb_add_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Ljava_lang_String_);
			return cb_add_Ljava_lang_String_;
		}

		static void n_Add_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = JNIEnv.GetString (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.Add (obj);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;)V", "GetAdd_Ljava_lang_String_Handler")]
		public virtual unsafe void Add (string obj)
		{
			if (id_add_Ljava_lang_String_ == IntPtr.Zero)
				id_add_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;)V");
			IntPtr native_obj = JNIEnv.NewString (obj);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_obj);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Ljava/lang/Object;", "GetCloneHandler")]
		public virtual unsafe global::Java.Lang.Object Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getCSVInstance_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getCSVInstance' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("getCSVInstance", "([C)Lorg/apache/commons/lang3/text/StrTokenizer;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer GetCSVInstance (char[] input)
		{
			if (id_getCSVInstance_arrayC == IntPtr.Zero)
				id_getCSVInstance_arrayC = JNIEnv.GetStaticMethodID (class_ref, "getCSVInstance", "([C)Lorg/apache/commons/lang3/text/StrTokenizer;");
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				global::Org.Apache.Commons.Lang3.Text.StrTokenizer __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCSVInstance_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		static IntPtr id_getCSVInstance_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getCSVInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCSVInstance", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrTokenizer;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer GetCSVInstance (string input)
		{
			if (id_getCSVInstance_Ljava_lang_String_ == IntPtr.Zero)
				id_getCSVInstance_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCSVInstance", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrTokenizer;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				global::Org.Apache.Commons.Lang3.Text.StrTokenizer __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCSVInstance_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_getTSVInstance_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getTSVInstance' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("getTSVInstance", "([C)Lorg/apache/commons/lang3/text/StrTokenizer;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer GetTSVInstance (char[] input)
		{
			if (id_getTSVInstance_arrayC == IntPtr.Zero)
				id_getTSVInstance_arrayC = JNIEnv.GetStaticMethodID (class_ref, "getTSVInstance", "([C)Lorg/apache/commons/lang3/text/StrTokenizer;");
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				global::Org.Apache.Commons.Lang3.Text.StrTokenizer __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTSVInstance_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		static IntPtr id_getTSVInstance_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getTSVInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTSVInstance", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrTokenizer;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer GetTSVInstance (string input)
		{
			if (id_getTSVInstance_Ljava_lang_String_ == IntPtr.Zero)
				id_getTSVInstance_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getTSVInstance", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrTokenizer;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				global::Org.Apache.Commons.Lang3.Text.StrTokenizer __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTSVInstance_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static Delegate cb_getTokenArray;
#pragma warning disable 0169
		static Delegate GetGetTokenArrayHandler ()
		{
			if (cb_getTokenArray == null)
				cb_getTokenArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTokenArray);
			return cb_getTokenArray;
		}

		static IntPtr n_GetTokenArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTokenArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getTokenArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='getTokenArray' and count(parameter)=0]"
		[Register ("getTokenArray", "()[Ljava/lang/String;", "GetGetTokenArrayHandler")]
		public virtual unsafe string[] GetTokenArray ()
		{
			if (id_getTokenArray == IntPtr.Zero)
				id_getTokenArray = JNIEnv.GetMethodID (class_ref, "getTokenArray", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenArray), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenArray", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Next ());
		}
#pragma warning restore 0169

		static IntPtr id_next;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/String;", "GetNextHandler")]
		public virtual unsafe string Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_next), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "next", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nextIndex;
#pragma warning disable 0169
		static Delegate GetNextIndexHandler ()
		{
			if (cb_nextIndex == null)
				cb_nextIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_NextIndex);
			return cb_nextIndex;
		}

		static int n_NextIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextIndex ();
		}
#pragma warning restore 0169

		static IntPtr id_nextIndex;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='nextIndex' and count(parameter)=0]"
		[Register ("nextIndex", "()I", "GetNextIndexHandler")]
		public virtual unsafe int NextIndex ()
		{
			if (id_nextIndex == IntPtr.Zero)
				id_nextIndex = JNIEnv.GetMethodID (class_ref, "nextIndex", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_nextIndex);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextIndex", "()I"));
			} finally {
			}
		}

		static Delegate cb_nextToken;
#pragma warning disable 0169
		static Delegate GetNextTokenHandler ()
		{
			if (cb_nextToken == null)
				cb_nextToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NextToken);
			return cb_nextToken;
		}

		static IntPtr n_NextToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextToken ());
		}
#pragma warning restore 0169

		static IntPtr id_nextToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='nextToken' and count(parameter)=0]"
		[Register ("nextToken", "()Ljava/lang/String;", "GetNextTokenHandler")]
		public virtual unsafe string NextToken ()
		{
			if (id_nextToken == IntPtr.Zero)
				id_nextToken = JNIEnv.GetMethodID (class_ref, "nextToken", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextToken), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_previous;
#pragma warning disable 0169
		static Delegate GetPreviousHandler ()
		{
			if (cb_previous == null)
				cb_previous = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Previous);
			return cb_previous;
		}

		static IntPtr n_Previous (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Previous ());
		}
#pragma warning restore 0169

		static IntPtr id_previous;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='previous' and count(parameter)=0]"
		[Register ("previous", "()Ljava/lang/String;", "GetPreviousHandler")]
		public virtual unsafe string Previous ()
		{
			if (id_previous == IntPtr.Zero)
				id_previous = JNIEnv.GetMethodID (class_ref, "previous", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_previous), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "previous", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_previousIndex;
#pragma warning disable 0169
		static Delegate GetPreviousIndexHandler ()
		{
			if (cb_previousIndex == null)
				cb_previousIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_PreviousIndex);
			return cb_previousIndex;
		}

		static int n_PreviousIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreviousIndex ();
		}
#pragma warning restore 0169

		static IntPtr id_previousIndex;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='previousIndex' and count(parameter)=0]"
		[Register ("previousIndex", "()I", "GetPreviousIndexHandler")]
		public virtual unsafe int PreviousIndex ()
		{
			if (id_previousIndex == IntPtr.Zero)
				id_previousIndex = JNIEnv.GetMethodID (class_ref, "previousIndex", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_previousIndex);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "previousIndex", "()I"));
			} finally {
			}
		}

		static Delegate cb_previousToken;
#pragma warning disable 0169
		static Delegate GetPreviousTokenHandler ()
		{
			if (cb_previousToken == null)
				cb_previousToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PreviousToken);
			return cb_previousToken;
		}

		static IntPtr n_PreviousToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PreviousToken ());
		}
#pragma warning restore 0169

		static IntPtr id_previousToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='previousToken' and count(parameter)=0]"
		[Register ("previousToken", "()Ljava/lang/String;", "GetPreviousTokenHandler")]
		public virtual unsafe string PreviousToken ()
		{
			if (id_previousToken == IntPtr.Zero)
				id_previousToken = JNIEnv.GetMethodID (class_ref, "previousToken", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_previousToken), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "previousToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler")]
		public virtual unsafe void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "()V"));
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Reset);
			return cb_reset;
		}

		static IntPtr n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reset ());
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()Lorg/apache/commons/lang3/text/StrTokenizer;", "GetResetHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()Lorg/apache/commons/lang3/text/StrTokenizer;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reset), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()Lorg/apache/commons/lang3/text/StrTokenizer;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reset_arrayC;
#pragma warning disable 0169
		static Delegate GetReset_arrayCHandler ()
		{
			if (cb_reset_arrayC == null)
				cb_reset_arrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Reset_arrayC);
			return cb_reset_arrayC;
		}

		static IntPtr n_Reset_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_input)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = (char[]) JNIEnv.GetArray (native_input, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Reset (input));
			if (input != null)
				JNIEnv.CopyArray (input, native_input);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_reset_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("reset", "([C)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetReset_arrayCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer Reset (char[] input)
		{
			if (id_reset_arrayC == IntPtr.Zero)
				id_reset_arrayC = JNIEnv.GetMethodID (class_ref, "reset", "([C)Lorg/apache/commons/lang3/text/StrTokenizer;");
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);

				global::Org.Apache.Commons.Lang3.Text.StrTokenizer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reset_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "([C)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		static Delegate cb_reset_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReset_Ljava_lang_String_Handler ()
		{
			if (cb_reset_Ljava_lang_String_ == null)
				cb_reset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Reset_Ljava_lang_String_);
			return cb_reset_Ljava_lang_String_;
		}

		static IntPtr n_Reset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = JNIEnv.GetString (native_input, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Reset (input));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_reset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("reset", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetReset_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer Reset (string input)
		{
			if (id_reset_Ljava_lang_String_ == IntPtr.Zero)
				id_reset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "reset", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrTokenizer;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);

				global::Org.Apache.Commons.Lang3.Text.StrTokenizer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reset_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static Delegate cb_set_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Handler ()
		{
			if (cb_set_Ljava_lang_String_ == null)
				cb_set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Set_Ljava_lang_String_);
			return cb_set_Ljava_lang_String_;
		}

		static void n_Set_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = JNIEnv.GetString (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.Set (obj);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='set' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("set", "(Ljava/lang/String;)V", "GetSet_Ljava_lang_String_Handler")]
		public virtual unsafe void Set (string obj)
		{
			if (id_set_Ljava_lang_String_ == IntPtr.Zero)
				id_set_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;)V");
			IntPtr native_obj = JNIEnv.NewString (obj);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_obj);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		static Delegate cb_setDelimiterChar_C;
#pragma warning disable 0169
		static Delegate GetSetDelimiterChar_CHandler ()
		{
			if (cb_setDelimiterChar_C == null)
				cb_setDelimiterChar_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_SetDelimiterChar_C);
			return cb_setDelimiterChar_C;
		}

		static IntPtr n_SetDelimiterChar_C (IntPtr jnienv, IntPtr native__this, char delim)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDelimiterChar (delim));
		}
#pragma warning restore 0169

		static IntPtr id_setDelimiterChar_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='setDelimiterChar' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("setDelimiterChar", "(C)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetSetDelimiterChar_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer SetDelimiterChar (char delim)
		{
			if (id_setDelimiterChar_C == IntPtr.Zero)
				id_setDelimiterChar_C = JNIEnv.GetMethodID (class_ref, "setDelimiterChar", "(C)Lorg/apache/commons/lang3/text/StrTokenizer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (delim);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDelimiterChar_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDelimiterChar", "(C)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetSetDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_setDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_setDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_setDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static IntPtr n_SetDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_delim)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var delim = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_delim, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDelimiterMatcher (delim));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='setDelimiterMatcher' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("setDelimiterMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetSetDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer SetDelimiterMatcher (global::Org.Apache.Commons.Lang3.Text.StrMatcher delim)
		{
			if (id_setDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_setDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "setDelimiterMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (delim);

				global::Org.Apache.Commons.Lang3.Text.StrTokenizer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDelimiterMatcher_Lorg_apache_commons_lang3_text_StrMatcher_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDelimiterMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDelimiterString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDelimiterString_Ljava_lang_String_Handler ()
		{
			if (cb_setDelimiterString_Ljava_lang_String_ == null)
				cb_setDelimiterString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDelimiterString_Ljava_lang_String_);
			return cb_setDelimiterString_Ljava_lang_String_;
		}

		static IntPtr n_SetDelimiterString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_delim)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var delim = JNIEnv.GetString (native_delim, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDelimiterString (delim));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDelimiterString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='setDelimiterString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDelimiterString", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetSetDelimiterString_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer SetDelimiterString (string delim)
		{
			if (id_setDelimiterString_Ljava_lang_String_ == IntPtr.Zero)
				id_setDelimiterString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDelimiterString", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrTokenizer;");
			IntPtr native_delim = JNIEnv.NewString (delim);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_delim);

				global::Org.Apache.Commons.Lang3.Text.StrTokenizer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDelimiterString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDelimiterString", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_delim);
			}
		}

		static Delegate cb_setEmptyTokenAsNull_Z;
#pragma warning disable 0169
		static Delegate GetSetEmptyTokenAsNull_ZHandler ()
		{
			if (cb_setEmptyTokenAsNull_Z == null)
				cb_setEmptyTokenAsNull_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetEmptyTokenAsNull_Z);
			return cb_setEmptyTokenAsNull_Z;
		}

		static IntPtr n_SetEmptyTokenAsNull_Z (IntPtr jnienv, IntPtr native__this, bool emptyAsNull)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEmptyTokenAsNull (emptyAsNull));
		}
#pragma warning restore 0169

		static IntPtr id_setEmptyTokenAsNull_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='setEmptyTokenAsNull' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEmptyTokenAsNull", "(Z)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetSetEmptyTokenAsNull_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer SetEmptyTokenAsNull (bool emptyAsNull)
		{
			if (id_setEmptyTokenAsNull_Z == IntPtr.Zero)
				id_setEmptyTokenAsNull_Z = JNIEnv.GetMethodID (class_ref, "setEmptyTokenAsNull", "(Z)Lorg/apache/commons/lang3/text/StrTokenizer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (emptyAsNull);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEmptyTokenAsNull_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmptyTokenAsNull", "(Z)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIgnoreEmptyTokens_Z;
#pragma warning disable 0169
		static Delegate GetSetIgnoreEmptyTokens_ZHandler ()
		{
			if (cb_setIgnoreEmptyTokens_Z == null)
				cb_setIgnoreEmptyTokens_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetIgnoreEmptyTokens_Z);
			return cb_setIgnoreEmptyTokens_Z;
		}

		static IntPtr n_SetIgnoreEmptyTokens_Z (IntPtr jnienv, IntPtr native__this, bool ignoreEmptyTokens)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIgnoreEmptyTokens (ignoreEmptyTokens));
		}
#pragma warning restore 0169

		static IntPtr id_setIgnoreEmptyTokens_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='setIgnoreEmptyTokens' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIgnoreEmptyTokens", "(Z)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetSetIgnoreEmptyTokens_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer SetIgnoreEmptyTokens (bool ignoreEmptyTokens)
		{
			if (id_setIgnoreEmptyTokens_Z == IntPtr.Zero)
				id_setIgnoreEmptyTokens_Z = JNIEnv.GetMethodID (class_ref, "setIgnoreEmptyTokens", "(Z)Lorg/apache/commons/lang3/text/StrTokenizer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ignoreEmptyTokens);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setIgnoreEmptyTokens_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIgnoreEmptyTokens", "(Z)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIgnoredChar_C;
#pragma warning disable 0169
		static Delegate GetSetIgnoredChar_CHandler ()
		{
			if (cb_setIgnoredChar_C == null)
				cb_setIgnoredChar_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_SetIgnoredChar_C);
			return cb_setIgnoredChar_C;
		}

		static IntPtr n_SetIgnoredChar_C (IntPtr jnienv, IntPtr native__this, char ignored)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIgnoredChar (ignored));
		}
#pragma warning restore 0169

		static IntPtr id_setIgnoredChar_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='setIgnoredChar' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("setIgnoredChar", "(C)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetSetIgnoredChar_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer SetIgnoredChar (char ignored)
		{
			if (id_setIgnoredChar_C == IntPtr.Zero)
				id_setIgnoredChar_C = JNIEnv.GetMethodID (class_ref, "setIgnoredChar", "(C)Lorg/apache/commons/lang3/text/StrTokenizer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ignored);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setIgnoredChar_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIgnoredChar", "(C)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetSetIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_setIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_setIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_setIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static IntPtr n_SetIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ignored)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ignored = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_ignored, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIgnoredMatcher (ignored));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='setIgnoredMatcher' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("setIgnoredMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetSetIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer SetIgnoredMatcher (global::Org.Apache.Commons.Lang3.Text.StrMatcher ignored)
		{
			if (id_setIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_setIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "setIgnoredMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ignored);

				global::Org.Apache.Commons.Lang3.Text.StrTokenizer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setIgnoredMatcher_Lorg_apache_commons_lang3_text_StrMatcher_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIgnoredMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setQuoteChar_C;
#pragma warning disable 0169
		static Delegate GetSetQuoteChar_CHandler ()
		{
			if (cb_setQuoteChar_C == null)
				cb_setQuoteChar_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_SetQuoteChar_C);
			return cb_setQuoteChar_C;
		}

		static IntPtr n_SetQuoteChar_C (IntPtr jnienv, IntPtr native__this, char quote)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetQuoteChar (quote));
		}
#pragma warning restore 0169

		static IntPtr id_setQuoteChar_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='setQuoteChar' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("setQuoteChar", "(C)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetSetQuoteChar_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer SetQuoteChar (char quote)
		{
			if (id_setQuoteChar_C == IntPtr.Zero)
				id_setQuoteChar_C = JNIEnv.GetMethodID (class_ref, "setQuoteChar", "(C)Lorg/apache/commons/lang3/text/StrTokenizer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (quote);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setQuoteChar_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuoteChar", "(C)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetSetQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_setQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_setQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_setQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static IntPtr n_SetQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_quote)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var quote = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_quote, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetQuoteMatcher (quote));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='setQuoteMatcher' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("setQuoteMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetSetQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer SetQuoteMatcher (global::Org.Apache.Commons.Lang3.Text.StrMatcher quote)
		{
			if (id_setQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_setQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "setQuoteMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (quote);

				global::Org.Apache.Commons.Lang3.Text.StrTokenizer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setQuoteMatcher_Lorg_apache_commons_lang3_text_StrMatcher_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuoteMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetSetTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_setTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_setTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_setTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static IntPtr n_SetTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trimmer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var trimmer = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_trimmer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTrimmerMatcher (trimmer));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='setTrimmerMatcher' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("setTrimmerMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;", "GetSetTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer SetTrimmerMatcher (global::Org.Apache.Commons.Lang3.Text.StrMatcher trimmer)
		{
			if (id_setTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_setTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "setTrimmerMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (trimmer);

				global::Org.Apache.Commons.Lang3.Text.StrTokenizer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTrimmerMatcher_Lorg_apache_commons_lang3_text_StrMatcher_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrimmerMatcher", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrTokenizer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

		static Delegate cb_tokenize_arrayCII;
#pragma warning disable 0169
		static Delegate GetTokenize_arrayCIIHandler ()
		{
			if (cb_tokenize_arrayCII == null)
				cb_tokenize_arrayCII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Tokenize_arrayCII);
			return cb_tokenize_arrayCII;
		}

		static IntPtr n_Tokenize_arrayCII (IntPtr jnienv, IntPtr native__this, IntPtr native_srcChars, int offset, int count)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var srcChars = (char[]) JNIEnv.GetArray (native_srcChars, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Tokenize (srcChars, offset, count));
			if (srcChars != null)
				JNIEnv.CopyArray (srcChars, native_srcChars);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_tokenize_arrayCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrTokenizer']/method[@name='tokenize' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("tokenize", "([CII)Ljava/util/List;", "GetTokenize_arrayCIIHandler")]
		protected virtual unsafe global::System.Collections.Generic.IList<string> Tokenize (char[] srcChars, int offset, int count)
		{
			if (id_tokenize_arrayCII == IntPtr.Zero)
				id_tokenize_arrayCII = JNIEnv.GetMethodID (class_ref, "tokenize", "([CII)Ljava/util/List;");
			IntPtr native_srcChars = JNIEnv.NewArray (srcChars);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_srcChars);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (count);

				global::System.Collections.Generic.IList<string> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tokenize_arrayCII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tokenize", "([CII)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (srcChars != null) {
					JNIEnv.CopyArray (native_srcChars, srcChars);
					JNIEnv.DeleteLocalRef (native_srcChars);
				}
			}
		}

	}
}
