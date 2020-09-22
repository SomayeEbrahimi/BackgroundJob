using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ArrayUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/ArrayUtils", DoNotGenerateAcw=true)]
	public partial class ArrayUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/utils/ArrayUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayUtils); }
		}

		protected ArrayUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ArrayUtils']/constructor[@name='ArrayUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ArrayUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ArrayUtils)) {
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

		static IntPtr id_concatAll_arrayLjava_lang_Object_arrayarrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ArrayUtils']/method[@name='concatAll' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='T[]...']]"
		[Register ("concatAll", "([Ljava/lang/Object;[[Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] ConcatAll (global::Java.Lang.Object[] first, params global::Java.Lang.Object[][] rest)
		{
			if (id_concatAll_arrayLjava_lang_Object_arrayarrayLjava_lang_Object_ == IntPtr.Zero)
				id_concatAll_arrayLjava_lang_Object_arrayarrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "concatAll", "([Ljava/lang/Object;[[Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_first = JNIEnv.NewArray (first);
			IntPtr native_rest = JNIEnv.NewArray (rest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_first);
				__args [1] = new JValue (native_rest);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatAll_arrayLjava_lang_Object_arrayarrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (first != null) {
					JNIEnv.CopyArray (native_first, first);
					JNIEnv.DeleteLocalRef (native_first);
				}
				if (rest != null) {
					JNIEnv.CopyArray (native_rest, rest);
					JNIEnv.DeleteLocalRef (native_rest);
				}
			}
		}

		static IntPtr id_contact_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ArrayUtils']/method[@name='contact' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("contact", "([B[B)[B", "")]
		public static unsafe byte[] Contact (byte[] a, byte[] b)
		{
			if (id_contact_arrayBarrayB == IntPtr.Zero)
				id_contact_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "contact", "([B[B)[B");
			IntPtr native_a = JNIEnv.NewArray (a);
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_a);
				__args [1] = new JValue (native_b);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_contact_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_contact_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ArrayUtils']/method[@name='contact' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register ("contact", "([F[F)[F", "")]
		public static unsafe float[] Contact (float[] a, float[] b)
		{
			if (id_contact_arrayFarrayF == IntPtr.Zero)
				id_contact_arrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "contact", "([F[F)[F");
			IntPtr native_a = JNIEnv.NewArray (a);
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_a);
				__args [1] = new JValue (native_b);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_contact_arrayFarrayF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_contact_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ArrayUtils']/method[@name='contact' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("contact", "([I[I)[I", "")]
		public static unsafe int[] Contact (int[] a, int[] b)
		{
			if (id_contact_arrayIarrayI == IntPtr.Zero)
				id_contact_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "contact", "([I[I)[I");
			IntPtr native_a = JNIEnv.NewArray (a);
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_a);
				__args [1] = new JValue (native_b);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_contact_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_contact_arraySarrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ArrayUtils']/method[@name='contact' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short[]']]"
		[Register ("contact", "([S[S)[S", "")]
		public static unsafe short[] Contact (short[] a, short[] b)
		{
			if (id_contact_arraySarrayS == IntPtr.Zero)
				id_contact_arraySarrayS = JNIEnv.GetStaticMethodID (class_ref, "contact", "([S[S)[S");
			IntPtr native_a = JNIEnv.NewArray (a);
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_a);
				__args [1] = new JValue (native_b);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_contact_arraySarrayS, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_contactInteger_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ArrayUtils']/method[@name='contactInteger' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("contactInteger", "([I[I)[I", "")]
		public static unsafe int[] ContactInteger (int[] a, int[] b)
		{
			if (id_contactInteger_arrayIarrayI == IntPtr.Zero)
				id_contactInteger_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "contactInteger", "([I[I)[I");
			IntPtr native_a = JNIEnv.NewArray (a);
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_a);
				__args [1] = new JValue (native_b);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_contactInteger_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

	}
}
