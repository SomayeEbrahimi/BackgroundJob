using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/RandomStringUtils", DoNotGenerateAcw=true)]
	public partial class RandomStringUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/RandomStringUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RandomStringUtils); }
		}

		protected RandomStringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/constructor[@name='RandomStringUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RandomStringUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RandomStringUtils)) {
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

		static IntPtr id_random_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='random' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("random", "(I)Ljava/lang/String;", "")]
		public static unsafe string Random (int count)
		{
			if (id_random_I == IntPtr.Zero)
				id_random_I = JNIEnv.GetStaticMethodID (class_ref, "random", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_random_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_random_IZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='random' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("random", "(IZZ)Ljava/lang/String;", "")]
		public static unsafe string Random (int count, bool letters, bool numbers)
		{
			if (id_random_IZZ == IntPtr.Zero)
				id_random_IZZ = JNIEnv.GetStaticMethodID (class_ref, "random", "(IZZ)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (count);
				__args [1] = new JValue (letters);
				__args [2] = new JValue (numbers);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_random_IZZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_random_IarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='random' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='char...']]"
		[Register ("random", "(I[C)Ljava/lang/String;", "")]
		public static unsafe string Random (int count, params char[] chars)
		{
			if (id_random_IarrayC == IntPtr.Zero)
				id_random_IarrayC = JNIEnv.GetStaticMethodID (class_ref, "random", "(I[C)Ljava/lang/String;");
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (count);
				__args [1] = new JValue (native_chars);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_random_IarrayC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		static IntPtr id_random_IIIZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='random' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("random", "(IIIZZ)Ljava/lang/String;", "")]
		public static unsafe string Random (int count, int start, int end, bool letters, bool numbers)
		{
			if (id_random_IIIZZ == IntPtr.Zero)
				id_random_IIIZZ = JNIEnv.GetStaticMethodID (class_ref, "random", "(IIIZZ)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (count);
				__args [1] = new JValue (start);
				__args [2] = new JValue (end);
				__args [3] = new JValue (letters);
				__args [4] = new JValue (numbers);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_random_IIIZZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_random_IIIZZarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='random' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='char...']]"
		[Register ("random", "(IIIZZ[C)Ljava/lang/String;", "")]
		public static unsafe string Random (int count, int start, int end, bool letters, bool numbers, params char[] chars)
		{
			if (id_random_IIIZZarrayC == IntPtr.Zero)
				id_random_IIIZZarrayC = JNIEnv.GetStaticMethodID (class_ref, "random", "(IIIZZ[C)Ljava/lang/String;");
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (count);
				__args [1] = new JValue (start);
				__args [2] = new JValue (end);
				__args [3] = new JValue (letters);
				__args [4] = new JValue (numbers);
				__args [5] = new JValue (native_chars);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_random_IIIZZarrayC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		static IntPtr id_random_IIIZZarrayCLjava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='random' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='char[]'] and parameter[7][@type='java.util.Random']]"
		[Register ("random", "(IIIZZ[CLjava/util/Random;)Ljava/lang/String;", "")]
		public static unsafe string Random (int count, int start, int end, bool letters, bool numbers, char[] chars, global::Java.Util.Random random)
		{
			if (id_random_IIIZZarrayCLjava_util_Random_ == IntPtr.Zero)
				id_random_IIIZZarrayCLjava_util_Random_ = JNIEnv.GetStaticMethodID (class_ref, "random", "(IIIZZ[CLjava/util/Random;)Ljava/lang/String;");
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (count);
				__args [1] = new JValue (start);
				__args [2] = new JValue (end);
				__args [3] = new JValue (letters);
				__args [4] = new JValue (numbers);
				__args [5] = new JValue (native_chars);
				__args [6] = new JValue (random);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_random_IIIZZarrayCLjava_util_Random_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		static IntPtr id_random_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='random' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("random", "(ILjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Random (int count, string chars)
		{
			if (id_random_ILjava_lang_String_ == IntPtr.Zero)
				id_random_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "random", "(ILjava/lang/String;)Ljava/lang/String;");
			IntPtr native_chars = JNIEnv.NewString (chars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (count);
				__args [1] = new JValue (native_chars);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_random_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_chars);
			}
		}

		static IntPtr id_randomAlphabetic_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomAlphabetic' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("randomAlphabetic", "(I)Ljava/lang/String;", "")]
		public static unsafe string RandomAlphabetic (int count)
		{
			if (id_randomAlphabetic_I == IntPtr.Zero)
				id_randomAlphabetic_I = JNIEnv.GetStaticMethodID (class_ref, "randomAlphabetic", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomAlphabetic_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_randomAlphabetic_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomAlphabetic' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("randomAlphabetic", "(II)Ljava/lang/String;", "")]
		public static unsafe string RandomAlphabetic (int minLengthInclusive, int maxLengthExclusive)
		{
			if (id_randomAlphabetic_II == IntPtr.Zero)
				id_randomAlphabetic_II = JNIEnv.GetStaticMethodID (class_ref, "randomAlphabetic", "(II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (minLengthInclusive);
				__args [1] = new JValue (maxLengthExclusive);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomAlphabetic_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_randomAlphanumeric_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomAlphanumeric' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("randomAlphanumeric", "(I)Ljava/lang/String;", "")]
		public static unsafe string RandomAlphanumeric (int count)
		{
			if (id_randomAlphanumeric_I == IntPtr.Zero)
				id_randomAlphanumeric_I = JNIEnv.GetStaticMethodID (class_ref, "randomAlphanumeric", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomAlphanumeric_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_randomAlphanumeric_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomAlphanumeric' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("randomAlphanumeric", "(II)Ljava/lang/String;", "")]
		public static unsafe string RandomAlphanumeric (int minLengthInclusive, int maxLengthExclusive)
		{
			if (id_randomAlphanumeric_II == IntPtr.Zero)
				id_randomAlphanumeric_II = JNIEnv.GetStaticMethodID (class_ref, "randomAlphanumeric", "(II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (minLengthInclusive);
				__args [1] = new JValue (maxLengthExclusive);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomAlphanumeric_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_randomAscii_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomAscii' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("randomAscii", "(I)Ljava/lang/String;", "")]
		public static unsafe string RandomAscii (int count)
		{
			if (id_randomAscii_I == IntPtr.Zero)
				id_randomAscii_I = JNIEnv.GetStaticMethodID (class_ref, "randomAscii", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomAscii_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_randomAscii_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomAscii' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("randomAscii", "(II)Ljava/lang/String;", "")]
		public static unsafe string RandomAscii (int minLengthInclusive, int maxLengthExclusive)
		{
			if (id_randomAscii_II == IntPtr.Zero)
				id_randomAscii_II = JNIEnv.GetStaticMethodID (class_ref, "randomAscii", "(II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (minLengthInclusive);
				__args [1] = new JValue (maxLengthExclusive);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomAscii_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_randomGraph_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomGraph' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("randomGraph", "(I)Ljava/lang/String;", "")]
		public static unsafe string RandomGraph (int count)
		{
			if (id_randomGraph_I == IntPtr.Zero)
				id_randomGraph_I = JNIEnv.GetStaticMethodID (class_ref, "randomGraph", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomGraph_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_randomGraph_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomGraph' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("randomGraph", "(II)Ljava/lang/String;", "")]
		public static unsafe string RandomGraph (int minLengthInclusive, int maxLengthExclusive)
		{
			if (id_randomGraph_II == IntPtr.Zero)
				id_randomGraph_II = JNIEnv.GetStaticMethodID (class_ref, "randomGraph", "(II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (minLengthInclusive);
				__args [1] = new JValue (maxLengthExclusive);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomGraph_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_randomNumeric_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomNumeric' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("randomNumeric", "(I)Ljava/lang/String;", "")]
		public static unsafe string RandomNumeric (int count)
		{
			if (id_randomNumeric_I == IntPtr.Zero)
				id_randomNumeric_I = JNIEnv.GetStaticMethodID (class_ref, "randomNumeric", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomNumeric_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_randomNumeric_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomNumeric' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("randomNumeric", "(II)Ljava/lang/String;", "")]
		public static unsafe string RandomNumeric (int minLengthInclusive, int maxLengthExclusive)
		{
			if (id_randomNumeric_II == IntPtr.Zero)
				id_randomNumeric_II = JNIEnv.GetStaticMethodID (class_ref, "randomNumeric", "(II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (minLengthInclusive);
				__args [1] = new JValue (maxLengthExclusive);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomNumeric_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_randomPrint_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomPrint' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("randomPrint", "(I)Ljava/lang/String;", "")]
		public static unsafe string RandomPrint (int count)
		{
			if (id_randomPrint_I == IntPtr.Zero)
				id_randomPrint_I = JNIEnv.GetStaticMethodID (class_ref, "randomPrint", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomPrint_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_randomPrint_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomStringUtils']/method[@name='randomPrint' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("randomPrint", "(II)Ljava/lang/String;", "")]
		public static unsafe string RandomPrint (int minLengthInclusive, int maxLengthExclusive)
		{
			if (id_randomPrint_II == IntPtr.Zero)
				id_randomPrint_II = JNIEnv.GetStaticMethodID (class_ref, "randomPrint", "(II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (minLengthInclusive);
				__args [1] = new JValue (maxLengthExclusive);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomPrint_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
