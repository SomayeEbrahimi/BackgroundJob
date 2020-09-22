using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/RandomUtils", DoNotGenerateAcw=true)]
	public partial class RandomUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/RandomUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RandomUtils); }
		}

		protected RandomUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']/constructor[@name='RandomUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RandomUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RandomUtils)) {
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

		static IntPtr id_nextBoolean;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']/method[@name='nextBoolean' and count(parameter)=0]"
		[Register ("nextBoolean", "()Z", "")]
		public static unsafe bool NextBoolean ()
		{
			if (id_nextBoolean == IntPtr.Zero)
				id_nextBoolean = JNIEnv.GetStaticMethodID (class_ref, "nextBoolean", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_nextBoolean);
			} finally {
			}
		}

		static IntPtr id_nextBytes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']/method[@name='nextBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("nextBytes", "(I)[B", "")]
		public static unsafe byte[] NextBytes (int count)
		{
			if (id_nextBytes_I == IntPtr.Zero)
				id_nextBytes_I = JNIEnv.GetStaticMethodID (class_ref, "nextBytes", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nextBytes_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_nextDouble;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']/method[@name='nextDouble' and count(parameter)=0]"
		[Register ("nextDouble", "()D", "")]
		public static unsafe double NextDouble ()
		{
			if (id_nextDouble == IntPtr.Zero)
				id_nextDouble = JNIEnv.GetStaticMethodID (class_ref, "nextDouble", "()D");
			try {
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_nextDouble);
			} finally {
			}
		}

		static IntPtr id_nextDouble_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']/method[@name='nextDouble' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("nextDouble", "(DD)D", "")]
		public static unsafe double NextDouble (double startInclusive, double endInclusive)
		{
			if (id_nextDouble_DD == IntPtr.Zero)
				id_nextDouble_DD = JNIEnv.GetStaticMethodID (class_ref, "nextDouble", "(DD)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (startInclusive);
				__args [1] = new JValue (endInclusive);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_nextDouble_DD, __args);
			} finally {
			}
		}

		static IntPtr id_nextFloat;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']/method[@name='nextFloat' and count(parameter)=0]"
		[Register ("nextFloat", "()F", "")]
		public static unsafe float NextFloat ()
		{
			if (id_nextFloat == IntPtr.Zero)
				id_nextFloat = JNIEnv.GetStaticMethodID (class_ref, "nextFloat", "()F");
			try {
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_nextFloat);
			} finally {
			}
		}

		static IntPtr id_nextFloat_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']/method[@name='nextFloat' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("nextFloat", "(FF)F", "")]
		public static unsafe float NextFloat (float startInclusive, float endInclusive)
		{
			if (id_nextFloat_FF == IntPtr.Zero)
				id_nextFloat_FF = JNIEnv.GetStaticMethodID (class_ref, "nextFloat", "(FF)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (startInclusive);
				__args [1] = new JValue (endInclusive);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_nextFloat_FF, __args);
			} finally {
			}
		}

		static IntPtr id_nextInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']/method[@name='nextInt' and count(parameter)=0]"
		[Register ("nextInt", "()I", "")]
		public static unsafe int NextInt ()
		{
			if (id_nextInt == IntPtr.Zero)
				id_nextInt = JNIEnv.GetStaticMethodID (class_ref, "nextInt", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_nextInt);
			} finally {
			}
		}

		static IntPtr id_nextInt_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']/method[@name='nextInt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("nextInt", "(II)I", "")]
		public static unsafe int NextInt (int startInclusive, int endExclusive)
		{
			if (id_nextInt_II == IntPtr.Zero)
				id_nextInt_II = JNIEnv.GetStaticMethodID (class_ref, "nextInt", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (startInclusive);
				__args [1] = new JValue (endExclusive);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_nextInt_II, __args);
			} finally {
			}
		}

		static IntPtr id_nextLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']/method[@name='nextLong' and count(parameter)=0]"
		[Register ("nextLong", "()J", "")]
		public static unsafe long NextLong ()
		{
			if (id_nextLong == IntPtr.Zero)
				id_nextLong = JNIEnv.GetStaticMethodID (class_ref, "nextLong", "()J");
			try {
				return JNIEnv.CallStaticLongMethod  (class_ref, id_nextLong);
			} finally {
			}
		}

		static IntPtr id_nextLong_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='RandomUtils']/method[@name='nextLong' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("nextLong", "(JJ)J", "")]
		public static unsafe long NextLong (long startInclusive, long endExclusive)
		{
			if (id_nextLong_JJ == IntPtr.Zero)
				id_nextLong_JJ = JNIEnv.GetStaticMethodID (class_ref, "nextLong", "(JJ)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (startInclusive);
				__args [1] = new JValue (endExclusive);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_nextLong_JJ, __args);
			} finally {
			}
		}

	}
}
