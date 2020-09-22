using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/StrMatcher", DoNotGenerateAcw=true)]
	public abstract partial class StrMatcher : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/StrMatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrMatcher); }
		}

		protected StrMatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/constructor[@name='StrMatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe StrMatcher ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StrMatcher)) {
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

		static IntPtr id_charMatcher_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='charMatcher' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("charMatcher", "(C)Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher CharMatcher (char ch)
		{
			if (id_charMatcher_C == IntPtr.Zero)
				id_charMatcher_C = JNIEnv.GetStaticMethodID (class_ref, "charMatcher", "(C)Lorg/apache/commons/lang3/text/StrMatcher;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_charMatcher_C, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_charSetMatcher_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='charSetMatcher' and count(parameter)=1 and parameter[1][@type='char...']]"
		[Register ("charSetMatcher", "([C)Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher CharSetMatcher (params char[] chars)
		{
			if (id_charSetMatcher_arrayC == IntPtr.Zero)
				id_charSetMatcher_arrayC = JNIEnv.GetStaticMethodID (class_ref, "charSetMatcher", "([C)Lorg/apache/commons/lang3/text/StrMatcher;");
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_chars);
				global::Org.Apache.Commons.Lang3.Text.StrMatcher __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_charSetMatcher_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		static IntPtr id_charSetMatcher_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='charSetMatcher' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("charSetMatcher", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher CharSetMatcher (string chars)
		{
			if (id_charSetMatcher_Ljava_lang_String_ == IntPtr.Zero)
				id_charSetMatcher_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "charSetMatcher", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrMatcher;");
			IntPtr native_chars = JNIEnv.NewString (chars);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_chars);
				global::Org.Apache.Commons.Lang3.Text.StrMatcher __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_charSetMatcher_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_chars);
			}
		}

		static IntPtr id_commaMatcher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='commaMatcher' and count(parameter)=0]"
		[Register ("commaMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher CommaMatcher ()
		{
			if (id_commaMatcher == IntPtr.Zero)
				id_commaMatcher = JNIEnv.GetStaticMethodID (class_ref, "commaMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_commaMatcher), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_doubleQuoteMatcher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='doubleQuoteMatcher' and count(parameter)=0]"
		[Register ("doubleQuoteMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher DoubleQuoteMatcher ()
		{
			if (id_doubleQuoteMatcher == IntPtr.Zero)
				id_doubleQuoteMatcher = JNIEnv.GetStaticMethodID (class_ref, "doubleQuoteMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_doubleQuoteMatcher), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isMatch_arrayCI;
#pragma warning disable 0169
		static Delegate GetIsMatch_arrayCIHandler ()
		{
			if (cb_isMatch_arrayCI == null)
				cb_isMatch_arrayCI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_IsMatch_arrayCI);
			return cb_isMatch_arrayCI;
		}

		static int n_IsMatch_arrayCI (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, int pos)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = (char[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (char));
			int __ret = __this.IsMatch (buffer, pos);
			if (buffer != null)
				JNIEnv.CopyArray (buffer, native_buffer);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isMatch_arrayCI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='isMatch' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='int']]"
		[Register ("isMatch", "([CI)I", "GetIsMatch_arrayCIHandler")]
		public virtual unsafe int IsMatch (char[] buffer, int pos)
		{
			if (id_isMatch_arrayCI == IntPtr.Zero)
				id_isMatch_arrayCI = JNIEnv.GetMethodID (class_ref, "isMatch", "([CI)I");
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_buffer);
				__args [1] = new JValue (pos);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_isMatch_arrayCI, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMatch", "([CI)I"), __args);
				return __ret;
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
			}
		}

		static Delegate cb_isMatch_arrayCIII;
#pragma warning disable 0169
		static Delegate GetIsMatch_arrayCIIIHandler ()
		{
			if (cb_isMatch_arrayCIII == null)
				cb_isMatch_arrayCIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_I) n_IsMatch_arrayCIII);
			return cb_isMatch_arrayCIII;
		}

		static int n_IsMatch_arrayCIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (char[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (char));
			int __ret = __this.IsMatch (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='isMatch' and count(parameter)=4 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("isMatch", "([CIII)I", "GetIsMatch_arrayCIIIHandler")]
		public abstract int IsMatch (char[] p0, int p1, int p2, int p3);

		static IntPtr id_noneMatcher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='noneMatcher' and count(parameter)=0]"
		[Register ("noneMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher NoneMatcher ()
		{
			if (id_noneMatcher == IntPtr.Zero)
				id_noneMatcher = JNIEnv.GetStaticMethodID (class_ref, "noneMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_noneMatcher), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_quoteMatcher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='quoteMatcher' and count(parameter)=0]"
		[Register ("quoteMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher QuoteMatcher ()
		{
			if (id_quoteMatcher == IntPtr.Zero)
				id_quoteMatcher = JNIEnv.GetStaticMethodID (class_ref, "quoteMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_quoteMatcher), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_singleQuoteMatcher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='singleQuoteMatcher' and count(parameter)=0]"
		[Register ("singleQuoteMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher SingleQuoteMatcher ()
		{
			if (id_singleQuoteMatcher == IntPtr.Zero)
				id_singleQuoteMatcher = JNIEnv.GetStaticMethodID (class_ref, "singleQuoteMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_singleQuoteMatcher), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_spaceMatcher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='spaceMatcher' and count(parameter)=0]"
		[Register ("spaceMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher SpaceMatcher ()
		{
			if (id_spaceMatcher == IntPtr.Zero)
				id_spaceMatcher = JNIEnv.GetStaticMethodID (class_ref, "spaceMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_spaceMatcher), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_splitMatcher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='splitMatcher' and count(parameter)=0]"
		[Register ("splitMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher SplitMatcher ()
		{
			if (id_splitMatcher == IntPtr.Zero)
				id_splitMatcher = JNIEnv.GetStaticMethodID (class_ref, "splitMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_splitMatcher), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_stringMatcher_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='stringMatcher' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringMatcher", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher StringMatcher (string str)
		{
			if (id_stringMatcher_Ljava_lang_String_ == IntPtr.Zero)
				id_stringMatcher_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stringMatcher", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrMatcher;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::Org.Apache.Commons.Lang3.Text.StrMatcher __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_stringMatcher_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_tabMatcher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='tabMatcher' and count(parameter)=0]"
		[Register ("tabMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher TabMatcher ()
		{
			if (id_tabMatcher == IntPtr.Zero)
				id_tabMatcher = JNIEnv.GetStaticMethodID (class_ref, "tabMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_tabMatcher), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_trimMatcher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='trimMatcher' and count(parameter)=0]"
		[Register ("trimMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrMatcher TrimMatcher ()
		{
			if (id_trimMatcher == IntPtr.Zero)
				id_trimMatcher = JNIEnv.GetStaticMethodID (class_ref, "trimMatcher", "()Lorg/apache/commons/lang3/text/StrMatcher;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_trimMatcher), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/StrMatcher", DoNotGenerateAcw=true)]
	internal partial class StrMatcherInvoker : StrMatcher {

		public StrMatcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrMatcherInvoker); }
		}

		static IntPtr id_isMatch_arrayCIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrMatcher']/method[@name='isMatch' and count(parameter)=4 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("isMatch", "([CIII)I", "GetIsMatch_arrayCIIIHandler")]
		public override unsafe int IsMatch (char[] p0, int p1, int p2, int p3)
		{
			if (id_isMatch_arrayCIII == IntPtr.Zero)
				id_isMatch_arrayCIII = JNIEnv.GetMethodID (class_ref, "isMatch", "([CIII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_isMatch_arrayCIII, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

}
