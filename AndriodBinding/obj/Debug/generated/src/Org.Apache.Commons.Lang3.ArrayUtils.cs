using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/ArrayUtils", DoNotGenerateAcw=true)]
	public partial class ArrayUtils : global::Java.Lang.Object {


		static IntPtr EMPTY_BOOLEAN_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_BOOLEAN_ARRAY']"
		[Register ("EMPTY_BOOLEAN_ARRAY")]
		public static IList<bool> EmptyBooleanArray {
			get {
				if (EMPTY_BOOLEAN_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_BOOLEAN_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_BOOLEAN_ARRAY", "[Z");
				return global::Android.Runtime.JavaArray<bool>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_BOOLEAN_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_BOOLEAN_OBJECT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_BOOLEAN_OBJECT_ARRAY']"
		[Register ("EMPTY_BOOLEAN_OBJECT_ARRAY")]
		public static IList<Java.Lang.Boolean> EmptyBooleanObjectArray {
			get {
				if (EMPTY_BOOLEAN_OBJECT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_BOOLEAN_OBJECT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_BOOLEAN_OBJECT_ARRAY", "[Ljava/lang/Boolean;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_BOOLEAN_OBJECT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_BYTE_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_BYTE_ARRAY']"
		[Register ("EMPTY_BYTE_ARRAY")]
		public static IList<byte> EmptyByteArray {
			get {
				if (EMPTY_BYTE_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_BYTE_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_BYTE_ARRAY", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_BYTE_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_BYTE_OBJECT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_BYTE_OBJECT_ARRAY']"
		[Register ("EMPTY_BYTE_OBJECT_ARRAY")]
		public static IList<Java.Lang.Byte> EmptyByteObjectArray {
			get {
				if (EMPTY_BYTE_OBJECT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_BYTE_OBJECT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_BYTE_OBJECT_ARRAY", "[Ljava/lang/Byte;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Byte>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_BYTE_OBJECT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_CHARACTER_OBJECT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_CHARACTER_OBJECT_ARRAY']"
		[Register ("EMPTY_CHARACTER_OBJECT_ARRAY")]
		public static IList<Java.Lang.Character> EmptyCharacterObjectArray {
			get {
				if (EMPTY_CHARACTER_OBJECT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_CHARACTER_OBJECT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_CHARACTER_OBJECT_ARRAY", "[Ljava/lang/Character;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Character>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_CHARACTER_OBJECT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_CHAR_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_CHAR_ARRAY']"
		[Register ("EMPTY_CHAR_ARRAY")]
		public static IList<char> EmptyCharArray {
			get {
				if (EMPTY_CHAR_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_CHAR_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_CHAR_ARRAY", "[C");
				return global::Android.Runtime.JavaArray<char>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_CHAR_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_CLASS_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_CLASS_ARRAY']"
		[Register ("EMPTY_CLASS_ARRAY")]
		public static IList<Java.Lang.Class> EmptyClassArray {
			get {
				if (EMPTY_CLASS_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_CLASS_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_CLASS_ARRAY", "[Ljava/lang/Class;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Class>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_CLASS_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_DOUBLE_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_DOUBLE_ARRAY']"
		[Register ("EMPTY_DOUBLE_ARRAY")]
		public static IList<double> EmptyDoubleArray {
			get {
				if (EMPTY_DOUBLE_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_DOUBLE_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_DOUBLE_ARRAY", "[D");
				return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_DOUBLE_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_DOUBLE_OBJECT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_DOUBLE_OBJECT_ARRAY']"
		[Register ("EMPTY_DOUBLE_OBJECT_ARRAY")]
		public static IList<Java.Lang.Double> EmptyDoubleObjectArray {
			get {
				if (EMPTY_DOUBLE_OBJECT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_DOUBLE_OBJECT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_DOUBLE_OBJECT_ARRAY", "[Ljava/lang/Double;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Double>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_DOUBLE_OBJECT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_FLOAT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_FLOAT_ARRAY']"
		[Register ("EMPTY_FLOAT_ARRAY")]
		public static IList<float> EmptyFloatArray {
			get {
				if (EMPTY_FLOAT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_FLOAT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_FLOAT_ARRAY", "[F");
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_FLOAT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_FLOAT_OBJECT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_FLOAT_OBJECT_ARRAY']"
		[Register ("EMPTY_FLOAT_OBJECT_ARRAY")]
		public static IList<Java.Lang.Float> EmptyFloatObjectArray {
			get {
				if (EMPTY_FLOAT_OBJECT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_FLOAT_OBJECT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_FLOAT_OBJECT_ARRAY", "[Ljava/lang/Float;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Float>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_FLOAT_OBJECT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_INTEGER_OBJECT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_INTEGER_OBJECT_ARRAY']"
		[Register ("EMPTY_INTEGER_OBJECT_ARRAY")]
		public static IList<Java.Lang.Integer> EmptyIntegerObjectArray {
			get {
				if (EMPTY_INTEGER_OBJECT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_INTEGER_OBJECT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_INTEGER_OBJECT_ARRAY", "[Ljava/lang/Integer;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_INTEGER_OBJECT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_INT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_INT_ARRAY']"
		[Register ("EMPTY_INT_ARRAY")]
		public static IList<int> EmptyIntArray {
			get {
				if (EMPTY_INT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_INT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_INT_ARRAY", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_INT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_LONG_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_LONG_ARRAY']"
		[Register ("EMPTY_LONG_ARRAY")]
		public static IList<long> EmptyLongArray {
			get {
				if (EMPTY_LONG_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_LONG_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_LONG_ARRAY", "[J");
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_LONG_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_LONG_OBJECT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_LONG_OBJECT_ARRAY']"
		[Register ("EMPTY_LONG_OBJECT_ARRAY")]
		public static IList<Java.Lang.Long> EmptyLongObjectArray {
			get {
				if (EMPTY_LONG_OBJECT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_LONG_OBJECT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_LONG_OBJECT_ARRAY", "[Ljava/lang/Long;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Long>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_LONG_OBJECT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_OBJECT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_OBJECT_ARRAY']"
		[Register ("EMPTY_OBJECT_ARRAY")]
		public static IList<Java.Lang.Object> EmptyObjectArray {
			get {
				if (EMPTY_OBJECT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_OBJECT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_OBJECT_ARRAY", "[Ljava/lang/Object;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Object>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_OBJECT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_SHORT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_SHORT_ARRAY']"
		[Register ("EMPTY_SHORT_ARRAY")]
		public static IList<short> EmptyShortArray {
			get {
				if (EMPTY_SHORT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_SHORT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_SHORT_ARRAY", "[S");
				return global::Android.Runtime.JavaArray<short>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_SHORT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_SHORT_OBJECT_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_SHORT_OBJECT_ARRAY']"
		[Register ("EMPTY_SHORT_OBJECT_ARRAY")]
		public static IList<Java.Lang.Short> EmptyShortObjectArray {
			get {
				if (EMPTY_SHORT_OBJECT_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_SHORT_OBJECT_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_SHORT_OBJECT_ARRAY", "[Ljava/lang/Short;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Short>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_SHORT_OBJECT_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_STRING_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='EMPTY_STRING_ARRAY']"
		[Register ("EMPTY_STRING_ARRAY")]
		public static IList<string> EmptyStringArray {
			get {
				if (EMPTY_STRING_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_STRING_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_STRING_ARRAY", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_STRING_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/field[@name='INDEX_NOT_FOUND']"
		[Register ("INDEX_NOT_FOUND")]
		public const int IndexNotFound = (int) -1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/ArrayUtils", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/constructor[@name='ArrayUtils' and count(parameter)=0]"
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

		static IntPtr id_add_arrayZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean']]"
		[Register ("add", "([ZZ)[Z", "")]
		public static unsafe bool[] Add (bool[] array, bool element)
		{
			if (id_add_arrayZZ == IntPtr.Zero)
				id_add_arrayZZ = JNIEnv.GetStaticMethodID (class_ref, "add", "([ZZ)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayZZ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayZIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=3 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "([ZIZ)[Z", "")]
		public static unsafe bool[] Add (bool[] array, int index, bool element)
		{
			if (id_add_arrayZIZ == IntPtr.Zero)
				id_add_arrayZIZ = JNIEnv.GetStaticMethodID (class_ref, "add", "([ZIZ)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				__args [2] = new JValue (element);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayZIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register ("add", "([BB)[B", "")]
		public static unsafe byte[] Add (byte[] array, sbyte element)
		{
			if (id_add_arrayBB == IntPtr.Zero)
				id_add_arrayBB = JNIEnv.GetStaticMethodID (class_ref, "add", "([BB)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayBB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayBIB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "([BIB)[B", "")]
		public static unsafe byte[] Add (byte[] array, int index, sbyte element)
		{
			if (id_add_arrayBIB == IntPtr.Zero)
				id_add_arrayBIB = JNIEnv.GetStaticMethodID (class_ref, "add", "([BIB)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				__args [2] = new JValue (element);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayBIB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayCC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char']]"
		[Register ("add", "([CC)[C", "")]
		public static unsafe char[] Add (char[] array, char element)
		{
			if (id_add_arrayCC == IntPtr.Zero)
				id_add_arrayCC = JNIEnv.GetStaticMethodID (class_ref, "add", "([CC)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayCC, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayCIC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "([CIC)[C", "")]
		public static unsafe char[] Add (char[] array, int index, char element)
		{
			if (id_add_arrayCIC == IntPtr.Zero)
				id_add_arrayCIC = JNIEnv.GetStaticMethodID (class_ref, "add", "([CIC)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				__args [2] = new JValue (element);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayCIC, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double']]"
		[Register ("add", "([DD)[D", "")]
		public static unsafe double[] Add (double[] array, double element)
		{
			if (id_add_arrayDD == IntPtr.Zero)
				id_add_arrayDD = JNIEnv.GetStaticMethodID (class_ref, "add", "([DD)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayDD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayDID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='int'] and parameter[3][@type='double']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "([DID)[D", "")]
		public static unsafe double[] Add (double[] array, int index, double element)
		{
			if (id_add_arrayDID == IntPtr.Zero)
				id_add_arrayDID = JNIEnv.GetStaticMethodID (class_ref, "add", "([DID)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				__args [2] = new JValue (element);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayDID, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float']]"
		[Register ("add", "([FF)[F", "")]
		public static unsafe float[] Add (float[] array, float element)
		{
			if (id_add_arrayFF == IntPtr.Zero)
				id_add_arrayFF = JNIEnv.GetStaticMethodID (class_ref, "add", "([FF)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayFF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayFIF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=3 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "([FIF)[F", "")]
		public static unsafe float[] Add (float[] array, int index, float element)
		{
			if (id_add_arrayFIF == IntPtr.Zero)
				id_add_arrayFIF = JNIEnv.GetStaticMethodID (class_ref, "add", "([FIF)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				__args [2] = new JValue (element);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayFIF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("add", "([II)[I", "")]
		public static unsafe int[] Add (int[] array, int element)
		{
			if (id_add_arrayII == IntPtr.Zero)
				id_add_arrayII = JNIEnv.GetStaticMethodID (class_ref, "add", "([II)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "([III)[I", "")]
		public static unsafe int[] Add (int[] array, int index, int element)
		{
			if (id_add_arrayIII == IntPtr.Zero)
				id_add_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "add", "([III)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				__args [2] = new JValue (element);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayIII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayJIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=3 and parameter[1][@type='long[]'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "([JIJ)[J", "")]
		public static unsafe long[] Add (long[] array, int index, long element)
		{
			if (id_add_arrayJIJ == IntPtr.Zero)
				id_add_arrayJIJ = JNIEnv.GetStaticMethodID (class_ref, "add", "([JIJ)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				__args [2] = new JValue (element);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayJIJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long']]"
		[Register ("add", "([JJ)[J", "")]
		public static unsafe long[] Add (long[] array, long element)
		{
			if (id_add_arrayJJ == IntPtr.Zero)
				id_add_arrayJJ = JNIEnv.GetStaticMethodID (class_ref, "add", "([JJ)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arraySIS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=3 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='short']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "([SIS)[S", "")]
		public static unsafe short[] Add (short[] array, int index, short element)
		{
			if (id_add_arraySIS == IntPtr.Zero)
				id_add_arraySIS = JNIEnv.GetStaticMethodID (class_ref, "add", "([SIS)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				__args [2] = new JValue (element);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arraySIS, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arraySS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short']]"
		[Register ("add", "([SS)[S", "")]
		public static unsafe short[] Add (short[] array, short element)
		{
			if (id_add_arraySS == IntPtr.Zero)
				id_add_arraySS = JNIEnv.GetStaticMethodID (class_ref, "add", "([SS)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arraySS, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_add_arrayLjava_lang_Object_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=3 and parameter[1][@type='T[]'] and parameter[2][@type='int'] and parameter[3][@type='T']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "([Ljava/lang/Object;ILjava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] Add (global::Java.Lang.Object[] array, int index, global::Java.Lang.Object element)
		{
			if (id_add_arrayLjava_lang_Object_ILjava_lang_Object_ == IntPtr.Zero)
				id_add_arrayLjava_lang_Object_ILjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "add", "([Ljava/lang/Object;ILjava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				__args [2] = new JValue (native_element);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayLjava_lang_Object_ILjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_add_arrayLjava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='add' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='T']]"
		[Register ("add", "([Ljava/lang/Object;Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] Add (global::Java.Lang.Object[] array, global::Java.Lang.Object element)
		{
			if (id_add_arrayLjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_add_arrayLjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "add", "([Ljava/lang/Object;Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_element);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_add_arrayLjava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_addAll_arrayZarrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean...']]"
		[Register ("addAll", "([Z[Z)[Z", "")]
		public static unsafe bool[] AddAll (bool[] array1, params bool[] array2)
		{
			if (id_addAll_arrayZarrayZ == IntPtr.Zero)
				id_addAll_arrayZarrayZ = JNIEnv.GetStaticMethodID (class_ref, "addAll", "([Z[Z)[Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_addAll_arrayZarrayZ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_addAll_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte...']]"
		[Register ("addAll", "([B[B)[B", "")]
		public static unsafe byte[] AddAll (byte[] array1, params byte[] array2)
		{
			if (id_addAll_arrayBarrayB == IntPtr.Zero)
				id_addAll_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "addAll", "([B[B)[B");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_addAll_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_addAll_arrayCarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char...']]"
		[Register ("addAll", "([C[C)[C", "")]
		public static unsafe char[] AddAll (char[] array1, params char[] array2)
		{
			if (id_addAll_arrayCarrayC == IntPtr.Zero)
				id_addAll_arrayCarrayC = JNIEnv.GetStaticMethodID (class_ref, "addAll", "([C[C)[C");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_addAll_arrayCarrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_addAll_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double...']]"
		[Register ("addAll", "([D[D)[D", "")]
		public static unsafe double[] AddAll (double[] array1, params double[] array2)
		{
			if (id_addAll_arrayDarrayD == IntPtr.Zero)
				id_addAll_arrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "addAll", "([D[D)[D");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_addAll_arrayDarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_addAll_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float...']]"
		[Register ("addAll", "([F[F)[F", "")]
		public static unsafe float[] AddAll (float[] array1, params float[] array2)
		{
			if (id_addAll_arrayFarrayF == IntPtr.Zero)
				id_addAll_arrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "addAll", "([F[F)[F");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_addAll_arrayFarrayF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_addAll_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int...']]"
		[Register ("addAll", "([I[I)[I", "")]
		public static unsafe int[] AddAll (int[] array1, params int[] array2)
		{
			if (id_addAll_arrayIarrayI == IntPtr.Zero)
				id_addAll_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "addAll", "([I[I)[I");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_addAll_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_addAll_arrayJarrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long...']]"
		[Register ("addAll", "([J[J)[J", "")]
		public static unsafe long[] AddAll (long[] array1, params long[] array2)
		{
			if (id_addAll_arrayJarrayJ == IntPtr.Zero)
				id_addAll_arrayJarrayJ = JNIEnv.GetStaticMethodID (class_ref, "addAll", "([J[J)[J");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_addAll_arrayJarrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_addAll_arraySarrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short...']]"
		[Register ("addAll", "([S[S)[S", "")]
		public static unsafe short[] AddAll (short[] array1, params short[] array2)
		{
			if (id_addAll_arraySarrayS == IntPtr.Zero)
				id_addAll_arraySarrayS = JNIEnv.GetStaticMethodID (class_ref, "addAll", "([S[S)[S");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_addAll_arraySarrayS, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_addAll_arrayLjava_lang_Object_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='T...']]"
		[Register ("addAll", "([Ljava/lang/Object;[Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] AddAll (global::Java.Lang.Object[] array1, params global::Java.Lang.Object[] array2)
		{
			if (id_addAll_arrayLjava_lang_Object_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_addAll_arrayLjava_lang_Object_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "addAll", "([Ljava/lang/Object;[Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_addAll_arrayLjava_lang_Object_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_clone_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("clone", "([Z)[Z", "")]
		public static unsafe bool[] Clone (bool[] array)
		{
			if (id_clone_arrayZ == IntPtr.Zero)
				id_clone_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "clone", "([Z)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_clone_arrayZ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_clone_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("clone", "([B)[B", "")]
		public static unsafe byte[] Clone (byte[] array)
		{
			if (id_clone_arrayB == IntPtr.Zero)
				id_clone_arrayB = JNIEnv.GetStaticMethodID (class_ref, "clone", "([B)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_clone_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_clone_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("clone", "([C)[C", "")]
		public static unsafe char[] Clone (char[] array)
		{
			if (id_clone_arrayC == IntPtr.Zero)
				id_clone_arrayC = JNIEnv.GetStaticMethodID (class_ref, "clone", "([C)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_clone_arrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_clone_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("clone", "([D)[D", "")]
		public static unsafe double[] Clone (double[] array)
		{
			if (id_clone_arrayD == IntPtr.Zero)
				id_clone_arrayD = JNIEnv.GetStaticMethodID (class_ref, "clone", "([D)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_clone_arrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_clone_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("clone", "([F)[F", "")]
		public static unsafe float[] Clone (float[] array)
		{
			if (id_clone_arrayF == IntPtr.Zero)
				id_clone_arrayF = JNIEnv.GetStaticMethodID (class_ref, "clone", "([F)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_clone_arrayF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_clone_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("clone", "([I)[I", "")]
		public static unsafe int[] Clone (int[] array)
		{
			if (id_clone_arrayI == IntPtr.Zero)
				id_clone_arrayI = JNIEnv.GetStaticMethodID (class_ref, "clone", "([I)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_clone_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_clone_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("clone", "([J)[J", "")]
		public static unsafe long[] Clone (long[] array)
		{
			if (id_clone_arrayJ == IntPtr.Zero)
				id_clone_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "clone", "([J)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_clone_arrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_clone_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("clone", "([S)[S", "")]
		public static unsafe short[] Clone (short[] array)
		{
			if (id_clone_arrayS == IntPtr.Zero)
				id_clone_arrayS = JNIEnv.GetStaticMethodID (class_ref, "clone", "([S)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_clone_arrayS, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_clone_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Register ("clone", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] Clone (global::Java.Lang.Object[] array)
		{
			if (id_clone_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_clone_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "clone", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_clone_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_contains_arrayZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean']]"
		[Register ("contains", "([ZZ)Z", "")]
		public static unsafe bool Contains (bool[] array, bool valueToFind)
		{
			if (id_contains_arrayZZ == IntPtr.Zero)
				id_contains_arrayZZ = JNIEnv.GetStaticMethodID (class_ref, "contains", "([ZZ)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_arrayZZ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_contains_arrayBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register ("contains", "([BB)Z", "")]
		public static unsafe bool Contains (byte[] array, sbyte valueToFind)
		{
			if (id_contains_arrayBB == IntPtr.Zero)
				id_contains_arrayBB = JNIEnv.GetStaticMethodID (class_ref, "contains", "([BB)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_arrayBB, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_contains_arrayCC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char']]"
		[Register ("contains", "([CC)Z", "")]
		public static unsafe bool Contains (char[] array, char valueToFind)
		{
			if (id_contains_arrayCC == IntPtr.Zero)
				id_contains_arrayCC = JNIEnv.GetStaticMethodID (class_ref, "contains", "([CC)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_arrayCC, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_contains_arrayDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double']]"
		[Register ("contains", "([DD)Z", "")]
		public static unsafe bool Contains (double[] array, double valueToFind)
		{
			if (id_contains_arrayDD == IntPtr.Zero)
				id_contains_arrayDD = JNIEnv.GetStaticMethodID (class_ref, "contains", "([DD)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_arrayDD, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_contains_arrayDDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='contains' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("contains", "([DDD)Z", "")]
		public static unsafe bool Contains (double[] array, double valueToFind, double tolerance)
		{
			if (id_contains_arrayDDD == IntPtr.Zero)
				id_contains_arrayDDD = JNIEnv.GetStaticMethodID (class_ref, "contains", "([DDD)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (tolerance);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_arrayDDD, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_contains_arrayFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float']]"
		[Register ("contains", "([FF)Z", "")]
		public static unsafe bool Contains (float[] array, float valueToFind)
		{
			if (id_contains_arrayFF == IntPtr.Zero)
				id_contains_arrayFF = JNIEnv.GetStaticMethodID (class_ref, "contains", "([FF)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_arrayFF, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_contains_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("contains", "([II)Z", "")]
		public static unsafe bool Contains (int[] array, int valueToFind)
		{
			if (id_contains_arrayII == IntPtr.Zero)
				id_contains_arrayII = JNIEnv.GetStaticMethodID (class_ref, "contains", "([II)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_arrayII, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_contains_arrayLjava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object']]"
		[Register ("contains", "([Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool Contains (global::Java.Lang.Object[] array, global::Java.Lang.Object objectToFind)
		{
			if (id_contains_arrayLjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_contains_arrayLjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "contains", "([Ljava/lang/Object;Ljava/lang/Object;)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (objectToFind);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_arrayLjava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_contains_arrayJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long']]"
		[Register ("contains", "([JJ)Z", "")]
		public static unsafe bool Contains (long[] array, long valueToFind)
		{
			if (id_contains_arrayJJ == IntPtr.Zero)
				id_contains_arrayJJ = JNIEnv.GetStaticMethodID (class_ref, "contains", "([JJ)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_arrayJJ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_contains_arraySS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short']]"
		[Register ("contains", "([SS)Z", "")]
		public static unsafe bool Contains (short[] array, short valueToFind)
		{
			if (id_contains_arraySS == IntPtr.Zero)
				id_contains_arraySS = JNIEnv.GetStaticMethodID (class_ref, "contains", "([SS)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_arraySS, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_getLength_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='getLength' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getLength", "(Ljava/lang/Object;)I", "")]
		public static unsafe int GetLength (global::Java.Lang.Object array)
		{
			if (id_getLength_Ljava_lang_Object_ == IntPtr.Zero)
				id_getLength_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getLength", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (array);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getLength_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hashCode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("hashCode", "(Ljava/lang/Object;)I", "")]
		public static unsafe int HashCode (global::Java.Lang.Object array)
		{
			if (id_hashCode_Ljava_lang_Object_ == IntPtr.Zero)
				id_hashCode_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (array);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_indexOf_arrayZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean']]"
		[Register ("indexOf", "([ZZ)I", "")]
		public static unsafe int IndexOf (bool[] array, bool valueToFind)
		{
			if (id_indexOf_arrayZZ == IntPtr.Zero)
				id_indexOf_arrayZZ = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([ZZ)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayZZ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayZZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("indexOf", "([ZZI)I", "")]
		public static unsafe int IndexOf (bool[] array, bool valueToFind, int startIndex)
		{
			if (id_indexOf_arrayZZI == IntPtr.Zero)
				id_indexOf_arrayZZI = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([ZZI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayZZI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register ("indexOf", "([BB)I", "")]
		public static unsafe int IndexOf (byte[] array, sbyte valueToFind)
		{
			if (id_indexOf_arrayBB == IntPtr.Zero)
				id_indexOf_arrayBB = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([BB)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayBB, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayBBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte'] and parameter[3][@type='int']]"
		[Register ("indexOf", "([BBI)I", "")]
		public static unsafe int IndexOf (byte[] array, sbyte valueToFind, int startIndex)
		{
			if (id_indexOf_arrayBBI == IntPtr.Zero)
				id_indexOf_arrayBBI = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([BBI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayBBI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayCC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char']]"
		[Register ("indexOf", "([CC)I", "")]
		public static unsafe int IndexOf (char[] array, char valueToFind)
		{
			if (id_indexOf_arrayCC == IntPtr.Zero)
				id_indexOf_arrayCC = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([CC)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayCC, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayCCI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='char'] and parameter[3][@type='int']]"
		[Register ("indexOf", "([CCI)I", "")]
		public static unsafe int IndexOf (char[] array, char valueToFind, int startIndex)
		{
			if (id_indexOf_arrayCCI == IntPtr.Zero)
				id_indexOf_arrayCCI = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([CCI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayCCI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double']]"
		[Register ("indexOf", "([DD)I", "")]
		public static unsafe int IndexOf (double[] array, double valueToFind)
		{
			if (id_indexOf_arrayDD == IntPtr.Zero)
				id_indexOf_arrayDD = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([DD)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayDD, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayDDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("indexOf", "([DDD)I", "")]
		public static unsafe int IndexOf (double[] array, double valueToFind, double tolerance)
		{
			if (id_indexOf_arrayDDD == IntPtr.Zero)
				id_indexOf_arrayDDD = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([DDD)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (tolerance);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayDDD, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayDDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("indexOf", "([DDI)I", "")]
		public static unsafe int IndexOf (double[] array, double valueToFind, int startIndex)
		{
			if (id_indexOf_arrayDDI == IntPtr.Zero)
				id_indexOf_arrayDDI = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([DDI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayDDI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayDDID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=4 and parameter[1][@type='double[]'] and parameter[2][@type='double'] and parameter[3][@type='int'] and parameter[4][@type='double']]"
		[Register ("indexOf", "([DDID)I", "")]
		public static unsafe int IndexOf (double[] array, double valueToFind, int startIndex, double tolerance)
		{
			if (id_indexOf_arrayDDID == IntPtr.Zero)
				id_indexOf_arrayDDID = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([DDID)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (tolerance);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayDDID, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float']]"
		[Register ("indexOf", "([FF)I", "")]
		public static unsafe int IndexOf (float[] array, float valueToFind)
		{
			if (id_indexOf_arrayFF == IntPtr.Zero)
				id_indexOf_arrayFF = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([FF)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayFF, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayFFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='float[]'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register ("indexOf", "([FFI)I", "")]
		public static unsafe int IndexOf (float[] array, float valueToFind, int startIndex)
		{
			if (id_indexOf_arrayFFI == IntPtr.Zero)
				id_indexOf_arrayFFI = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([FFI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayFFI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("indexOf", "([II)I", "")]
		public static unsafe int IndexOf (int[] array, int valueToFind)
		{
			if (id_indexOf_arrayII == IntPtr.Zero)
				id_indexOf_arrayII = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([II)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayII, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("indexOf", "([III)I", "")]
		public static unsafe int IndexOf (int[] array, int valueToFind, int startIndex)
		{
			if (id_indexOf_arrayIII == IntPtr.Zero)
				id_indexOf_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([III)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayIII, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object']]"
		[Register ("indexOf", "([Ljava/lang/Object;Ljava/lang/Object;)I", "")]
		public static unsafe int IndexOf (global::Java.Lang.Object[] array, global::Java.Lang.Object objectToFind)
		{
			if (id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([Ljava/lang/Object;Ljava/lang/Object;)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (objectToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int']]"
		[Register ("indexOf", "([Ljava/lang/Object;Ljava/lang/Object;I)I", "")]
		public static unsafe int IndexOf (global::Java.Lang.Object[] array, global::Java.Lang.Object objectToFind, int startIndex)
		{
			if (id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_I == IntPtr.Zero)
				id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([Ljava/lang/Object;Ljava/lang/Object;I)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (objectToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayLjava_lang_Object_Ljava_lang_Object_I, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long']]"
		[Register ("indexOf", "([JJ)I", "")]
		public static unsafe int IndexOf (long[] array, long valueToFind)
		{
			if (id_indexOf_arrayJJ == IntPtr.Zero)
				id_indexOf_arrayJJ = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([JJ)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayJJ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arrayJJI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='long[]'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("indexOf", "([JJI)I", "")]
		public static unsafe int IndexOf (long[] array, long valueToFind, int startIndex)
		{
			if (id_indexOf_arrayJJI == IntPtr.Zero)
				id_indexOf_arrayJJI = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([JJI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arrayJJI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arraySS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short']]"
		[Register ("indexOf", "([SS)I", "")]
		public static unsafe int IndexOf (short[] array, short valueToFind)
		{
			if (id_indexOf_arraySS == IntPtr.Zero)
				id_indexOf_arraySS = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([SS)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arraySS, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_indexOf_arraySSI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='short[]'] and parameter[2][@type='short'] and parameter[3][@type='int']]"
		[Register ("indexOf", "([SSI)I", "")]
		public static unsafe int IndexOf (short[] array, short valueToFind, int startIndex)
		{
			if (id_indexOf_arraySSI == IntPtr.Zero)
				id_indexOf_arraySSI = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "([SSI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOf_arraySSI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_insert_IarrayZarrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean[]'] and parameter[3][@type='boolean...']]"
		[Register ("insert", "(I[Z[Z)[Z", "")]
		public static unsafe bool[] Insert (int index, bool[] array, params bool[] values)
		{
			if (id_insert_IarrayZarrayZ == IntPtr.Zero)
				id_insert_IarrayZarrayZ = JNIEnv.GetStaticMethodID (class_ref, "insert", "(I[Z[Z)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (native_values);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_insert_IarrayZarrayZ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_insert_IarrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte...']]"
		[Register ("insert", "(I[B[B)[B", "")]
		public static unsafe byte[] Insert (int index, byte[] array, params byte[] values)
		{
			if (id_insert_IarrayBarrayB == IntPtr.Zero)
				id_insert_IarrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "insert", "(I[B[B)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (native_values);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_insert_IarrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_insert_IarrayCarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='char[]'] and parameter[3][@type='char...']]"
		[Register ("insert", "(I[C[C)[C", "")]
		public static unsafe char[] Insert (int index, char[] array, params char[] values)
		{
			if (id_insert_IarrayCarrayC == IntPtr.Zero)
				id_insert_IarrayCarrayC = JNIEnv.GetStaticMethodID (class_ref, "insert", "(I[C[C)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (native_values);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_insert_IarrayCarrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_insert_IarrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double[]'] and parameter[3][@type='double...']]"
		[Register ("insert", "(I[D[D)[D", "")]
		public static unsafe double[] Insert (int index, double[] array, params double[] values)
		{
			if (id_insert_IarrayDarrayD == IntPtr.Zero)
				id_insert_IarrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "insert", "(I[D[D)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (native_values);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_insert_IarrayDarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_insert_IarrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float[]'] and parameter[3][@type='float...']]"
		[Register ("insert", "(I[F[F)[F", "")]
		public static unsafe float[] Insert (int index, float[] array, params float[] values)
		{
			if (id_insert_IarrayFarrayF == IntPtr.Zero)
				id_insert_IarrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "insert", "(I[F[F)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (native_values);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_insert_IarrayFarrayF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_insert_IarrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='int...']]"
		[Register ("insert", "(I[I[I)[I", "")]
		public static unsafe int[] Insert (int index, int[] array, params int[] values)
		{
			if (id_insert_IarrayIarrayI == IntPtr.Zero)
				id_insert_IarrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "insert", "(I[I[I)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (native_values);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_insert_IarrayIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_insert_IarrayJarrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long[]'] and parameter[3][@type='long...']]"
		[Register ("insert", "(I[J[J)[J", "")]
		public static unsafe long[] Insert (int index, long[] array, params long[] values)
		{
			if (id_insert_IarrayJarrayJ == IntPtr.Zero)
				id_insert_IarrayJarrayJ = JNIEnv.GetStaticMethodID (class_ref, "insert", "(I[J[J)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (native_values);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_insert_IarrayJarrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_insert_IarraySarrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='short[]'] and parameter[3][@type='short...']]"
		[Register ("insert", "(I[S[S)[S", "")]
		public static unsafe short[] Insert (int index, short[] array, params short[] values)
		{
			if (id_insert_IarraySarrayS == IntPtr.Zero)
				id_insert_IarraySarrayS = JNIEnv.GetStaticMethodID (class_ref, "insert", "(I[S[S)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (native_values);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_insert_IarraySarrayS, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_insert_IarrayLjava_lang_Object_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='T[]'] and parameter[3][@type='T...']]"
		[Register ("insert", "(I[Ljava/lang/Object;[Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] Insert (int index, global::Java.Lang.Object[] array, params global::Java.Lang.Object[] values)
		{
			if (id_insert_IarrayLjava_lang_Object_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_insert_IarrayLjava_lang_Object_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "insert", "(I[Ljava/lang/Object;[Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (native_values);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_insert_IarrayLjava_lang_Object_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_isArrayIndexValid_arrayLjava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isArrayIndexValid' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='int']]"
		[Register ("isArrayIndexValid", "([Ljava/lang/Object;I)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe bool IsArrayIndexValid (global::Java.Lang.Object[] array, int index)
		{
			if (id_isArrayIndexValid_arrayLjava_lang_Object_I == IntPtr.Zero)
				id_isArrayIndexValid_arrayLjava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "isArrayIndexValid", "([Ljava/lang/Object;I)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isArrayIndexValid_arrayLjava_lang_Object_I, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isEmpty_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("isEmpty", "([Z)Z", "")]
		public static unsafe bool IsEmpty (bool[] array)
		{
			if (id_isEmpty_arrayZ == IntPtr.Zero)
				id_isEmpty_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "([Z)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_arrayZ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isEmpty_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isEmpty", "([B)Z", "")]
		public static unsafe bool IsEmpty (byte[] array)
		{
			if (id_isEmpty_arrayB == IntPtr.Zero)
				id_isEmpty_arrayB = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "([B)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_arrayB, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isEmpty_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("isEmpty", "([C)Z", "")]
		public static unsafe bool IsEmpty (char[] array)
		{
			if (id_isEmpty_arrayC == IntPtr.Zero)
				id_isEmpty_arrayC = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "([C)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_arrayC, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isEmpty_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("isEmpty", "([D)Z", "")]
		public static unsafe bool IsEmpty (double[] array)
		{
			if (id_isEmpty_arrayD == IntPtr.Zero)
				id_isEmpty_arrayD = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "([D)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_arrayD, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isEmpty_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("isEmpty", "([F)Z", "")]
		public static unsafe bool IsEmpty (float[] array)
		{
			if (id_isEmpty_arrayF == IntPtr.Zero)
				id_isEmpty_arrayF = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "([F)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_arrayF, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isEmpty_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("isEmpty", "([I)Z", "")]
		public static unsafe bool IsEmpty (int[] array)
		{
			if (id_isEmpty_arrayI == IntPtr.Zero)
				id_isEmpty_arrayI = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "([I)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_arrayI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isEmpty_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("isEmpty", "([Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsEmpty (global::Java.Lang.Object[] array)
		{
			if (id_isEmpty_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_isEmpty_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "([Ljava/lang/Object;)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_arrayLjava_lang_Object_, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isEmpty_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("isEmpty", "([J)Z", "")]
		public static unsafe bool IsEmpty (long[] array)
		{
			if (id_isEmpty_arrayJ == IntPtr.Zero)
				id_isEmpty_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "([J)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_arrayJ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isEmpty_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("isEmpty", "([S)Z", "")]
		public static unsafe bool IsEmpty (short[] array)
		{
			if (id_isEmpty_arrayS == IntPtr.Zero)
				id_isEmpty_arrayS = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "([S)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_arrayS, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isEquals_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isEquals' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("isEquals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsEquals (global::Java.Lang.Object array1, global::Java.Lang.Object array2)
		{
			if (id_isEquals_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_isEquals_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isEquals", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (array1);
				__args [1] = new JValue (array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEquals_Ljava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNotEmpty_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isNotEmpty' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("isNotEmpty", "([Z)Z", "")]
		public static unsafe bool IsNotEmpty (bool[] array)
		{
			if (id_isNotEmpty_arrayZ == IntPtr.Zero)
				id_isNotEmpty_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "isNotEmpty", "([Z)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotEmpty_arrayZ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isNotEmpty_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isNotEmpty' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isNotEmpty", "([B)Z", "")]
		public static unsafe bool IsNotEmpty (byte[] array)
		{
			if (id_isNotEmpty_arrayB == IntPtr.Zero)
				id_isNotEmpty_arrayB = JNIEnv.GetStaticMethodID (class_ref, "isNotEmpty", "([B)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotEmpty_arrayB, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isNotEmpty_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isNotEmpty' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("isNotEmpty", "([C)Z", "")]
		public static unsafe bool IsNotEmpty (char[] array)
		{
			if (id_isNotEmpty_arrayC == IntPtr.Zero)
				id_isNotEmpty_arrayC = JNIEnv.GetStaticMethodID (class_ref, "isNotEmpty", "([C)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotEmpty_arrayC, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isNotEmpty_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isNotEmpty' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("isNotEmpty", "([D)Z", "")]
		public static unsafe bool IsNotEmpty (double[] array)
		{
			if (id_isNotEmpty_arrayD == IntPtr.Zero)
				id_isNotEmpty_arrayD = JNIEnv.GetStaticMethodID (class_ref, "isNotEmpty", "([D)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotEmpty_arrayD, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isNotEmpty_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isNotEmpty' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("isNotEmpty", "([F)Z", "")]
		public static unsafe bool IsNotEmpty (float[] array)
		{
			if (id_isNotEmpty_arrayF == IntPtr.Zero)
				id_isNotEmpty_arrayF = JNIEnv.GetStaticMethodID (class_ref, "isNotEmpty", "([F)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotEmpty_arrayF, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isNotEmpty_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isNotEmpty' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("isNotEmpty", "([I)Z", "")]
		public static unsafe bool IsNotEmpty (int[] array)
		{
			if (id_isNotEmpty_arrayI == IntPtr.Zero)
				id_isNotEmpty_arrayI = JNIEnv.GetStaticMethodID (class_ref, "isNotEmpty", "([I)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotEmpty_arrayI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isNotEmpty_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isNotEmpty' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("isNotEmpty", "([J)Z", "")]
		public static unsafe bool IsNotEmpty (long[] array)
		{
			if (id_isNotEmpty_arrayJ == IntPtr.Zero)
				id_isNotEmpty_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "isNotEmpty", "([J)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotEmpty_arrayJ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isNotEmpty_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isNotEmpty' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("isNotEmpty", "([S)Z", "")]
		public static unsafe bool IsNotEmpty (short[] array)
		{
			if (id_isNotEmpty_arrayS == IntPtr.Zero)
				id_isNotEmpty_arrayS = JNIEnv.GetStaticMethodID (class_ref, "isNotEmpty", "([S)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotEmpty_arrayS, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isNotEmpty_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isNotEmpty' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Register ("isNotEmpty", "([Ljava/lang/Object;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe bool IsNotEmpty (global::Java.Lang.Object[] array)
		{
			if (id_isNotEmpty_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_isNotEmpty_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isNotEmpty", "([Ljava/lang/Object;)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotEmpty_arrayLjava_lang_Object_, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isSameLength_arrayZarrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSameLength' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean[]']]"
		[Register ("isSameLength", "([Z[Z)Z", "")]
		public static unsafe bool IsSameLength (bool[] array1, bool[] array2)
		{
			if (id_isSameLength_arrayZarrayZ == IntPtr.Zero)
				id_isSameLength_arrayZarrayZ = JNIEnv.GetStaticMethodID (class_ref, "isSameLength", "([Z[Z)Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameLength_arrayZarrayZ, __args);
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_isSameLength_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSameLength' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("isSameLength", "([B[B)Z", "")]
		public static unsafe bool IsSameLength (byte[] array1, byte[] array2)
		{
			if (id_isSameLength_arrayBarrayB == IntPtr.Zero)
				id_isSameLength_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "isSameLength", "([B[B)Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameLength_arrayBarrayB, __args);
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_isSameLength_arrayCarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSameLength' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char[]']]"
		[Register ("isSameLength", "([C[C)Z", "")]
		public static unsafe bool IsSameLength (char[] array1, char[] array2)
		{
			if (id_isSameLength_arrayCarrayC == IntPtr.Zero)
				id_isSameLength_arrayCarrayC = JNIEnv.GetStaticMethodID (class_ref, "isSameLength", "([C[C)Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameLength_arrayCarrayC, __args);
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_isSameLength_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSameLength' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("isSameLength", "([D[D)Z", "")]
		public static unsafe bool IsSameLength (double[] array1, double[] array2)
		{
			if (id_isSameLength_arrayDarrayD == IntPtr.Zero)
				id_isSameLength_arrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "isSameLength", "([D[D)Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameLength_arrayDarrayD, __args);
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_isSameLength_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSameLength' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register ("isSameLength", "([F[F)Z", "")]
		public static unsafe bool IsSameLength (float[] array1, float[] array2)
		{
			if (id_isSameLength_arrayFarrayF == IntPtr.Zero)
				id_isSameLength_arrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "isSameLength", "([F[F)Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameLength_arrayFarrayF, __args);
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_isSameLength_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSameLength' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("isSameLength", "([I[I)Z", "")]
		public static unsafe bool IsSameLength (int[] array1, int[] array2)
		{
			if (id_isSameLength_arrayIarrayI == IntPtr.Zero)
				id_isSameLength_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "isSameLength", "([I[I)Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameLength_arrayIarrayI, __args);
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_isSameLength_arrayLjava_lang_Object_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSameLength' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("isSameLength", "([Ljava/lang/Object;[Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsSameLength (global::Java.Lang.Object[] array1, global::Java.Lang.Object[] array2)
		{
			if (id_isSameLength_arrayLjava_lang_Object_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_isSameLength_arrayLjava_lang_Object_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isSameLength", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameLength_arrayLjava_lang_Object_arrayLjava_lang_Object_, __args);
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_isSameLength_arrayJarrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSameLength' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long[]']]"
		[Register ("isSameLength", "([J[J)Z", "")]
		public static unsafe bool IsSameLength (long[] array1, long[] array2)
		{
			if (id_isSameLength_arrayJarrayJ == IntPtr.Zero)
				id_isSameLength_arrayJarrayJ = JNIEnv.GetStaticMethodID (class_ref, "isSameLength", "([J[J)Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameLength_arrayJarrayJ, __args);
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_isSameLength_arraySarrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSameLength' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short[]']]"
		[Register ("isSameLength", "([S[S)Z", "")]
		public static unsafe bool IsSameLength (short[] array1, short[] array2)
		{
			if (id_isSameLength_arraySarrayS == IntPtr.Zero)
				id_isSameLength_arraySarrayS = JNIEnv.GetStaticMethodID (class_ref, "isSameLength", "([S[S)Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameLength_arraySarrayS, __args);
				return __ret;
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
			}
		}

		static IntPtr id_isSameType_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSameType' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("isSameType", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsSameType (global::Java.Lang.Object array1, global::Java.Lang.Object array2)
		{
			if (id_isSameType_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_isSameType_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isSameType", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (array1);
				__args [1] = new JValue (array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameType_Ljava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isSorted_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSorted' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("isSorted", "([Z)Z", "")]
		public static unsafe bool IsSorted (bool[] array)
		{
			if (id_isSorted_arrayZ == IntPtr.Zero)
				id_isSorted_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "isSorted", "([Z)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSorted_arrayZ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isSorted_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSorted' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isSorted", "([B)Z", "")]
		public static unsafe bool IsSorted (byte[] array)
		{
			if (id_isSorted_arrayB == IntPtr.Zero)
				id_isSorted_arrayB = JNIEnv.GetStaticMethodID (class_ref, "isSorted", "([B)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSorted_arrayB, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isSorted_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSorted' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("isSorted", "([C)Z", "")]
		public static unsafe bool IsSorted (char[] array)
		{
			if (id_isSorted_arrayC == IntPtr.Zero)
				id_isSorted_arrayC = JNIEnv.GetStaticMethodID (class_ref, "isSorted", "([C)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSorted_arrayC, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isSorted_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSorted' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("isSorted", "([D)Z", "")]
		public static unsafe bool IsSorted (double[] array)
		{
			if (id_isSorted_arrayD == IntPtr.Zero)
				id_isSorted_arrayD = JNIEnv.GetStaticMethodID (class_ref, "isSorted", "([D)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSorted_arrayD, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isSorted_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSorted' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("isSorted", "([F)Z", "")]
		public static unsafe bool IsSorted (float[] array)
		{
			if (id_isSorted_arrayF == IntPtr.Zero)
				id_isSorted_arrayF = JNIEnv.GetStaticMethodID (class_ref, "isSorted", "([F)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSorted_arrayF, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isSorted_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSorted' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("isSorted", "([I)Z", "")]
		public static unsafe bool IsSorted (int[] array)
		{
			if (id_isSorted_arrayI == IntPtr.Zero)
				id_isSorted_arrayI = JNIEnv.GetStaticMethodID (class_ref, "isSorted", "([I)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSorted_arrayI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isSorted_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSorted' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("isSorted", "([J)Z", "")]
		public static unsafe bool IsSorted (long[] array)
		{
			if (id_isSorted_arrayJ == IntPtr.Zero)
				id_isSorted_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "isSorted", "([J)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSorted_arrayJ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isSorted_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSorted' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("isSorted", "([S)Z", "")]
		public static unsafe bool IsSorted (short[] array)
		{
			if (id_isSorted_arrayS == IntPtr.Zero)
				id_isSorted_arrayS = JNIEnv.GetStaticMethodID (class_ref, "isSorted", "([S)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSorted_arrayS, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isSorted_arrayLjava_lang_Comparable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSorted' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Register ("isSorted", "([Ljava/lang/Comparable;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<? super T>"})]
		public static unsafe bool IsSorted (global::Java.Lang.Object[] array)
		{
			if (id_isSorted_arrayLjava_lang_Comparable_ == IntPtr.Zero)
				id_isSorted_arrayLjava_lang_Comparable_ = JNIEnv.GetStaticMethodID (class_ref, "isSorted", "([Ljava/lang/Comparable;)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSorted_arrayLjava_lang_Comparable_, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_isSorted_arrayLjava_lang_Object_Ljava_util_Comparator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='isSorted' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='java.util.Comparator&lt;T&gt;']]"
		[Register ("isSorted", "([Ljava/lang/Object;Ljava/util/Comparator;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe bool IsSorted (global::Java.Lang.Object[] array, global::Java.Util.IComparator comparator)
		{
			if (id_isSorted_arrayLjava_lang_Object_Ljava_util_Comparator_ == IntPtr.Zero)
				id_isSorted_arrayLjava_lang_Object_Ljava_util_Comparator_ = JNIEnv.GetStaticMethodID (class_ref, "isSorted", "([Ljava/lang/Object;Ljava/util/Comparator;)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (comparator);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSorted_arrayLjava_lang_Object_Ljava_util_Comparator_, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean']]"
		[Register ("lastIndexOf", "([ZZ)I", "")]
		public static unsafe int LastIndexOf (bool[] array, bool valueToFind)
		{
			if (id_lastIndexOf_arrayZZ == IntPtr.Zero)
				id_lastIndexOf_arrayZZ = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([ZZ)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayZZ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayZZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("lastIndexOf", "([ZZI)I", "")]
		public static unsafe int LastIndexOf (bool[] array, bool valueToFind, int startIndex)
		{
			if (id_lastIndexOf_arrayZZI == IntPtr.Zero)
				id_lastIndexOf_arrayZZI = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([ZZI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayZZI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register ("lastIndexOf", "([BB)I", "")]
		public static unsafe int LastIndexOf (byte[] array, sbyte valueToFind)
		{
			if (id_lastIndexOf_arrayBB == IntPtr.Zero)
				id_lastIndexOf_arrayBB = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([BB)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayBB, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayBBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte'] and parameter[3][@type='int']]"
		[Register ("lastIndexOf", "([BBI)I", "")]
		public static unsafe int LastIndexOf (byte[] array, sbyte valueToFind, int startIndex)
		{
			if (id_lastIndexOf_arrayBBI == IntPtr.Zero)
				id_lastIndexOf_arrayBBI = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([BBI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayBBI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayCC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char']]"
		[Register ("lastIndexOf", "([CC)I", "")]
		public static unsafe int LastIndexOf (char[] array, char valueToFind)
		{
			if (id_lastIndexOf_arrayCC == IntPtr.Zero)
				id_lastIndexOf_arrayCC = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([CC)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayCC, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayCCI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='char'] and parameter[3][@type='int']]"
		[Register ("lastIndexOf", "([CCI)I", "")]
		public static unsafe int LastIndexOf (char[] array, char valueToFind, int startIndex)
		{
			if (id_lastIndexOf_arrayCCI == IntPtr.Zero)
				id_lastIndexOf_arrayCCI = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([CCI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayCCI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double']]"
		[Register ("lastIndexOf", "([DD)I", "")]
		public static unsafe int LastIndexOf (double[] array, double valueToFind)
		{
			if (id_lastIndexOf_arrayDD == IntPtr.Zero)
				id_lastIndexOf_arrayDD = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([DD)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayDD, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayDDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("lastIndexOf", "([DDD)I", "")]
		public static unsafe int LastIndexOf (double[] array, double valueToFind, double tolerance)
		{
			if (id_lastIndexOf_arrayDDD == IntPtr.Zero)
				id_lastIndexOf_arrayDDD = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([DDD)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (tolerance);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayDDD, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayDDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("lastIndexOf", "([DDI)I", "")]
		public static unsafe int LastIndexOf (double[] array, double valueToFind, int startIndex)
		{
			if (id_lastIndexOf_arrayDDI == IntPtr.Zero)
				id_lastIndexOf_arrayDDI = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([DDI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayDDI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayDDID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=4 and parameter[1][@type='double[]'] and parameter[2][@type='double'] and parameter[3][@type='int'] and parameter[4][@type='double']]"
		[Register ("lastIndexOf", "([DDID)I", "")]
		public static unsafe int LastIndexOf (double[] array, double valueToFind, int startIndex, double tolerance)
		{
			if (id_lastIndexOf_arrayDDID == IntPtr.Zero)
				id_lastIndexOf_arrayDDID = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([DDID)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (tolerance);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayDDID, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float']]"
		[Register ("lastIndexOf", "([FF)I", "")]
		public static unsafe int LastIndexOf (float[] array, float valueToFind)
		{
			if (id_lastIndexOf_arrayFF == IntPtr.Zero)
				id_lastIndexOf_arrayFF = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([FF)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayFF, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayFFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='float[]'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register ("lastIndexOf", "([FFI)I", "")]
		public static unsafe int LastIndexOf (float[] array, float valueToFind, int startIndex)
		{
			if (id_lastIndexOf_arrayFFI == IntPtr.Zero)
				id_lastIndexOf_arrayFFI = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([FFI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayFFI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("lastIndexOf", "([II)I", "")]
		public static unsafe int LastIndexOf (int[] array, int valueToFind)
		{
			if (id_lastIndexOf_arrayII == IntPtr.Zero)
				id_lastIndexOf_arrayII = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([II)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayII, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("lastIndexOf", "([III)I", "")]
		public static unsafe int LastIndexOf (int[] array, int valueToFind, int startIndex)
		{
			if (id_lastIndexOf_arrayIII == IntPtr.Zero)
				id_lastIndexOf_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([III)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayIII, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayLjava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object']]"
		[Register ("lastIndexOf", "([Ljava/lang/Object;Ljava/lang/Object;)I", "")]
		public static unsafe int LastIndexOf (global::Java.Lang.Object[] array, global::Java.Lang.Object objectToFind)
		{
			if (id_lastIndexOf_arrayLjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_lastIndexOf_arrayLjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([Ljava/lang/Object;Ljava/lang/Object;)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (objectToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayLjava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayLjava_lang_Object_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int']]"
		[Register ("lastIndexOf", "([Ljava/lang/Object;Ljava/lang/Object;I)I", "")]
		public static unsafe int LastIndexOf (global::Java.Lang.Object[] array, global::Java.Lang.Object objectToFind, int startIndex)
		{
			if (id_lastIndexOf_arrayLjava_lang_Object_Ljava_lang_Object_I == IntPtr.Zero)
				id_lastIndexOf_arrayLjava_lang_Object_Ljava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([Ljava/lang/Object;Ljava/lang/Object;I)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (objectToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayLjava_lang_Object_Ljava_lang_Object_I, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long']]"
		[Register ("lastIndexOf", "([JJ)I", "")]
		public static unsafe int LastIndexOf (long[] array, long valueToFind)
		{
			if (id_lastIndexOf_arrayJJ == IntPtr.Zero)
				id_lastIndexOf_arrayJJ = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([JJ)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayJJ, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arrayJJI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='long[]'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("lastIndexOf", "([JJI)I", "")]
		public static unsafe int LastIndexOf (long[] array, long valueToFind, int startIndex)
		{
			if (id_lastIndexOf_arrayJJI == IntPtr.Zero)
				id_lastIndexOf_arrayJJI = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([JJI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arrayJJI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arraySS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short']]"
		[Register ("lastIndexOf", "([SS)I", "")]
		public static unsafe int LastIndexOf (short[] array, short valueToFind)
		{
			if (id_lastIndexOf_arraySS == IntPtr.Zero)
				id_lastIndexOf_arraySS = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([SS)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arraySS, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_lastIndexOf_arraySSI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='lastIndexOf' and count(parameter)=3 and parameter[1][@type='short[]'] and parameter[2][@type='short'] and parameter[3][@type='int']]"
		[Register ("lastIndexOf", "([SSI)I", "")]
		public static unsafe int LastIndexOf (short[] array, short valueToFind, int startIndex)
		{
			if (id_lastIndexOf_arraySSI == IntPtr.Zero)
				id_lastIndexOf_arraySSI = JNIEnv.GetStaticMethodID (class_ref, "lastIndexOf", "([SSI)I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueToFind);
				__args [2] = new JValue (startIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lastIndexOf_arraySSI, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("nullToEmpty", "([Z)[Z", "")]
		public static unsafe bool[] NullToEmpty (bool[] array)
		{
			if (id_nullToEmpty_arrayZ == IntPtr.Zero)
				id_nullToEmpty_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Z)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayZ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("nullToEmpty", "([B)[B", "")]
		public static unsafe byte[] NullToEmpty (byte[] array)
		{
			if (id_nullToEmpty_arrayB == IntPtr.Zero)
				id_nullToEmpty_arrayB = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([B)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("nullToEmpty", "([C)[C", "")]
		public static unsafe char[] NullToEmpty (char[] array)
		{
			if (id_nullToEmpty_arrayC == IntPtr.Zero)
				id_nullToEmpty_arrayC = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([C)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("nullToEmpty", "([D)[D", "")]
		public static unsafe double[] NullToEmpty (double[] array)
		{
			if (id_nullToEmpty_arrayD == IntPtr.Zero)
				id_nullToEmpty_arrayD = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([D)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("nullToEmpty", "([F)[F", "")]
		public static unsafe float[] NullToEmpty (float[] array)
		{
			if (id_nullToEmpty_arrayF == IntPtr.Zero)
				id_nullToEmpty_arrayF = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([F)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("nullToEmpty", "([I)[I", "")]
		public static unsafe int[] NullToEmpty (int[] array)
		{
			if (id_nullToEmpty_arrayI == IntPtr.Zero)
				id_nullToEmpty_arrayI = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([I)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean[]']]"
		[Register ("nullToEmpty", "([Ljava/lang/Boolean;)[Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean[] NullToEmpty (global::Java.Lang.Boolean[] array)
		{
			if (id_nullToEmpty_arrayLjava_lang_Boolean_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/Boolean;)[Ljava/lang/Boolean;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Boolean[] __ret = (global::Java.Lang.Boolean[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Boolean));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_Byte_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Byte[]']]"
		[Register ("nullToEmpty", "([Ljava/lang/Byte;)[Ljava/lang/Byte;", "")]
		public static unsafe global::Java.Lang.Byte[] NullToEmpty (global::Java.Lang.Byte[] array)
		{
			if (id_nullToEmpty_arrayLjava_lang_Byte_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_Byte_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/Byte;)[Ljava/lang/Byte;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Byte[] __ret = (global::Java.Lang.Byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_Byte_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_Character_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Character[]']]"
		[Register ("nullToEmpty", "([Ljava/lang/Character;)[Ljava/lang/Character;", "")]
		public static unsafe global::Java.Lang.Character[] NullToEmpty (global::Java.Lang.Character[] array)
		{
			if (id_nullToEmpty_arrayLjava_lang_Character_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_Character_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/Character;)[Ljava/lang/Character;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Character[] __ret = (global::Java.Lang.Character[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_Character_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Character));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;[]']]"
		[Register ("nullToEmpty", "([Ljava/lang/Class;)[Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class[] NullToEmpty (global::Java.Lang.Class[] array)
		{
			if (id_nullToEmpty_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/Class;)[Ljava/lang/Class;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Class[] __ret = (global::Java.Lang.Class[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Class));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Double[]']]"
		[Register ("nullToEmpty", "([Ljava/lang/Double;)[Ljava/lang/Double;", "")]
		public static unsafe global::Java.Lang.Double[] NullToEmpty (global::Java.Lang.Double[] array)
		{
			if (id_nullToEmpty_arrayLjava_lang_Double_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_Double_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/Double;)[Ljava/lang/Double;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Double[] __ret = (global::Java.Lang.Double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_Float_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("nullToEmpty", "([Ljava/lang/Float;)[Ljava/lang/Float;", "")]
		public static unsafe global::Java.Lang.Float[] NullToEmpty (global::Java.Lang.Float[] array)
		{
			if (id_nullToEmpty_arrayLjava_lang_Float_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_Float_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/Float;)[Ljava/lang/Float;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Float[] __ret = (global::Java.Lang.Float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_Float_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Integer[]']]"
		[Register ("nullToEmpty", "([Ljava/lang/Integer;)[Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer[] NullToEmpty (global::Java.Lang.Integer[] array)
		{
			if (id_nullToEmpty_arrayLjava_lang_Integer_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/Integer;)[Ljava/lang/Integer;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Integer[] __ret = (global::Java.Lang.Integer[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Integer));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Long[]']]"
		[Register ("nullToEmpty", "([Ljava/lang/Long;)[Ljava/lang/Long;", "")]
		public static unsafe global::Java.Lang.Long[] NullToEmpty (global::Java.Lang.Long[] array)
		{
			if (id_nullToEmpty_arrayLjava_lang_Long_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/Long;)[Ljava/lang/Long;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Long[] __ret = (global::Java.Lang.Long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("nullToEmpty", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object[] NullToEmpty (global::Java.Lang.Object[] array)
		{
			if (id_nullToEmpty_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_Short_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Short[]']]"
		[Register ("nullToEmpty", "([Ljava/lang/Short;)[Ljava/lang/Short;", "")]
		public static unsafe global::Java.Lang.Short[] NullToEmpty (global::Java.Lang.Short[] array)
		{
			if (id_nullToEmpty_arrayLjava_lang_Short_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_Short_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/Short;)[Ljava/lang/Short;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Short[] __ret = (global::Java.Lang.Short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_Short_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("nullToEmpty", "([Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] NullToEmpty (string[] array)
		{
			if (id_nullToEmpty_arrayLjava_lang_String_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("nullToEmpty", "([J)[J", "")]
		public static unsafe long[] NullToEmpty (long[] array)
		{
			if (id_nullToEmpty_arrayJ == IntPtr.Zero)
				id_nullToEmpty_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([J)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("nullToEmpty", "([S)[S", "")]
		public static unsafe short[] NullToEmpty (short[] array)
		{
			if (id_nullToEmpty_arrayS == IntPtr.Zero)
				id_nullToEmpty_arrayS = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([S)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayS, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_nullToEmpty_arrayLjava_lang_Object_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='nullToEmpty' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='java.lang.Class&lt;T[]&gt;']]"
		[Register ("nullToEmpty", "([Ljava/lang/Object;Ljava/lang/Class;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] NullToEmpty (global::Java.Lang.Object[] array, global::Java.Lang.Class type)
		{
			if (id_nullToEmpty_arrayLjava_lang_Object_Ljava_lang_Class_ == IntPtr.Zero)
				id_nullToEmpty_arrayLjava_lang_Object_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "nullToEmpty", "([Ljava/lang/Object;Ljava/lang/Class;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (type);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullToEmpty_arrayLjava_lang_Object_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_remove_arrayZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='int']]"
		[Register ("remove", "([ZI)[Z", "")]
		public static unsafe bool[] Remove (bool[] array, int index)
		{
			if (id_remove_arrayZI == IntPtr.Zero)
				id_remove_arrayZI = JNIEnv.GetStaticMethodID (class_ref, "remove", "([ZI)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_remove_arrayZI, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_remove_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("remove", "([BI)[B", "")]
		public static unsafe byte[] Remove (byte[] array, int index)
		{
			if (id_remove_arrayBI == IntPtr.Zero)
				id_remove_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "remove", "([BI)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_remove_arrayBI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_remove_arrayCI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='int']]"
		[Register ("remove", "([CI)[C", "")]
		public static unsafe char[] Remove (char[] array, int index)
		{
			if (id_remove_arrayCI == IntPtr.Zero)
				id_remove_arrayCI = JNIEnv.GetStaticMethodID (class_ref, "remove", "([CI)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_remove_arrayCI, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_remove_arrayDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='int']]"
		[Register ("remove", "([DI)[D", "")]
		public static unsafe double[] Remove (double[] array, int index)
		{
			if (id_remove_arrayDI == IntPtr.Zero)
				id_remove_arrayDI = JNIEnv.GetStaticMethodID (class_ref, "remove", "([DI)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_remove_arrayDI, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_remove_arrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("remove", "([FI)[F", "")]
		public static unsafe float[] Remove (float[] array, int index)
		{
			if (id_remove_arrayFI == IntPtr.Zero)
				id_remove_arrayFI = JNIEnv.GetStaticMethodID (class_ref, "remove", "([FI)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_remove_arrayFI, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_remove_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("remove", "([II)[I", "")]
		public static unsafe int[] Remove (int[] array, int index)
		{
			if (id_remove_arrayII == IntPtr.Zero)
				id_remove_arrayII = JNIEnv.GetStaticMethodID (class_ref, "remove", "([II)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_remove_arrayII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_remove_arrayJI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='int']]"
		[Register ("remove", "([JI)[J", "")]
		public static unsafe long[] Remove (long[] array, int index)
		{
			if (id_remove_arrayJI == IntPtr.Zero)
				id_remove_arrayJI = JNIEnv.GetStaticMethodID (class_ref, "remove", "([JI)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_remove_arrayJI, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_remove_arraySI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='int']]"
		[Register ("remove", "([SI)[S", "")]
		public static unsafe short[] Remove (short[] array, int index)
		{
			if (id_remove_arraySI == IntPtr.Zero)
				id_remove_arraySI = JNIEnv.GetStaticMethodID (class_ref, "remove", "([SI)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_remove_arraySI, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_remove_arrayLjava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='int']]"
		[Register ("remove", "([Ljava/lang/Object;I)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] Remove (global::Java.Lang.Object[] array, int index)
		{
			if (id_remove_arrayLjava_lang_Object_I == IntPtr.Zero)
				id_remove_arrayLjava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "remove", "([Ljava/lang/Object;I)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (index);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_remove_arrayLjava_lang_Object_I, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeAll_arrayZarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='int...']]"
		[Register ("removeAll", "([Z[I)[Z", "")]
		public static unsafe bool[] RemoveAll (bool[] array, params int[] indices)
		{
			if (id_removeAll_arrayZarrayI == IntPtr.Zero)
				id_removeAll_arrayZarrayI = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "([Z[I)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_indices = JNIEnv.NewArray (indices);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_indices);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAll_arrayZarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (indices != null) {
					JNIEnv.CopyArray (native_indices, indices);
					JNIEnv.DeleteLocalRef (native_indices);
				}
			}
		}

		static IntPtr id_removeAll_arrayBarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int...']]"
		[Register ("removeAll", "([B[I)[B", "")]
		public static unsafe byte[] RemoveAll (byte[] array, params int[] indices)
		{
			if (id_removeAll_arrayBarrayI == IntPtr.Zero)
				id_removeAll_arrayBarrayI = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "([B[I)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_indices = JNIEnv.NewArray (indices);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_indices);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAll_arrayBarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (indices != null) {
					JNIEnv.CopyArray (native_indices, indices);
					JNIEnv.DeleteLocalRef (native_indices);
				}
			}
		}

		static IntPtr id_removeAll_arrayCarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='int...']]"
		[Register ("removeAll", "([C[I)[C", "")]
		public static unsafe char[] RemoveAll (char[] array, params int[] indices)
		{
			if (id_removeAll_arrayCarrayI == IntPtr.Zero)
				id_removeAll_arrayCarrayI = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "([C[I)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_indices = JNIEnv.NewArray (indices);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_indices);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAll_arrayCarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (indices != null) {
					JNIEnv.CopyArray (native_indices, indices);
					JNIEnv.DeleteLocalRef (native_indices);
				}
			}
		}

		static IntPtr id_removeAll_arrayDarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='int...']]"
		[Register ("removeAll", "([D[I)[D", "")]
		public static unsafe double[] RemoveAll (double[] array, params int[] indices)
		{
			if (id_removeAll_arrayDarrayI == IntPtr.Zero)
				id_removeAll_arrayDarrayI = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "([D[I)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_indices = JNIEnv.NewArray (indices);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_indices);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAll_arrayDarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (indices != null) {
					JNIEnv.CopyArray (native_indices, indices);
					JNIEnv.DeleteLocalRef (native_indices);
				}
			}
		}

		static IntPtr id_removeAll_arrayFarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int...']]"
		[Register ("removeAll", "([F[I)[F", "")]
		public static unsafe float[] RemoveAll (float[] array, params int[] indices)
		{
			if (id_removeAll_arrayFarrayI == IntPtr.Zero)
				id_removeAll_arrayFarrayI = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "([F[I)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_indices = JNIEnv.NewArray (indices);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_indices);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAll_arrayFarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (indices != null) {
					JNIEnv.CopyArray (native_indices, indices);
					JNIEnv.DeleteLocalRef (native_indices);
				}
			}
		}

		static IntPtr id_removeAll_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int...']]"
		[Register ("removeAll", "([I[I)[I", "")]
		public static unsafe int[] RemoveAll (int[] array, params int[] indices)
		{
			if (id_removeAll_arrayIarrayI == IntPtr.Zero)
				id_removeAll_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "([I[I)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_indices = JNIEnv.NewArray (indices);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_indices);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAll_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (indices != null) {
					JNIEnv.CopyArray (native_indices, indices);
					JNIEnv.DeleteLocalRef (native_indices);
				}
			}
		}

		static IntPtr id_removeAll_arrayJarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='int...']]"
		[Register ("removeAll", "([J[I)[J", "")]
		public static unsafe long[] RemoveAll (long[] array, params int[] indices)
		{
			if (id_removeAll_arrayJarrayI == IntPtr.Zero)
				id_removeAll_arrayJarrayI = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "([J[I)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_indices = JNIEnv.NewArray (indices);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_indices);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAll_arrayJarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (indices != null) {
					JNIEnv.CopyArray (native_indices, indices);
					JNIEnv.DeleteLocalRef (native_indices);
				}
			}
		}

		static IntPtr id_removeAll_arraySarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='int...']]"
		[Register ("removeAll", "([S[I)[S", "")]
		public static unsafe short[] RemoveAll (short[] array, params int[] indices)
		{
			if (id_removeAll_arraySarrayI == IntPtr.Zero)
				id_removeAll_arraySarrayI = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "([S[I)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_indices = JNIEnv.NewArray (indices);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_indices);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAll_arraySarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (indices != null) {
					JNIEnv.CopyArray (native_indices, indices);
					JNIEnv.DeleteLocalRef (native_indices);
				}
			}
		}

		static IntPtr id_removeAll_arrayLjava_lang_Object_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='int...']]"
		[Register ("removeAll", "([Ljava/lang/Object;[I)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] RemoveAll (global::Java.Lang.Object[] array, params int[] indices)
		{
			if (id_removeAll_arrayLjava_lang_Object_arrayI == IntPtr.Zero)
				id_removeAll_arrayLjava_lang_Object_arrayI = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "([Ljava/lang/Object;[I)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_indices = JNIEnv.NewArray (indices);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_indices);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAll_arrayLjava_lang_Object_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (indices != null) {
					JNIEnv.CopyArray (native_indices, indices);
					JNIEnv.DeleteLocalRef (native_indices);
				}
			}
		}

		static IntPtr id_removeAllOccurences_arrayZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAllOccurences' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean']]"
		[Register ("removeAllOccurences", "([ZZ)[Z", "")]
		public static unsafe bool[] RemoveAllOccurences (bool[] array, bool element)
		{
			if (id_removeAllOccurences_arrayZZ == IntPtr.Zero)
				id_removeAllOccurences_arrayZZ = JNIEnv.GetStaticMethodID (class_ref, "removeAllOccurences", "([ZZ)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAllOccurences_arrayZZ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeAllOccurences_arrayBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAllOccurences' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register ("removeAllOccurences", "([BB)[B", "")]
		public static unsafe byte[] RemoveAllOccurences (byte[] array, sbyte element)
		{
			if (id_removeAllOccurences_arrayBB == IntPtr.Zero)
				id_removeAllOccurences_arrayBB = JNIEnv.GetStaticMethodID (class_ref, "removeAllOccurences", "([BB)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAllOccurences_arrayBB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeAllOccurences_arrayCC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAllOccurences' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char']]"
		[Register ("removeAllOccurences", "([CC)[C", "")]
		public static unsafe char[] RemoveAllOccurences (char[] array, char element)
		{
			if (id_removeAllOccurences_arrayCC == IntPtr.Zero)
				id_removeAllOccurences_arrayCC = JNIEnv.GetStaticMethodID (class_ref, "removeAllOccurences", "([CC)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAllOccurences_arrayCC, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeAllOccurences_arrayDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAllOccurences' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double']]"
		[Register ("removeAllOccurences", "([DD)[D", "")]
		public static unsafe double[] RemoveAllOccurences (double[] array, double element)
		{
			if (id_removeAllOccurences_arrayDD == IntPtr.Zero)
				id_removeAllOccurences_arrayDD = JNIEnv.GetStaticMethodID (class_ref, "removeAllOccurences", "([DD)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAllOccurences_arrayDD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeAllOccurences_arrayFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAllOccurences' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float']]"
		[Register ("removeAllOccurences", "([FF)[F", "")]
		public static unsafe float[] RemoveAllOccurences (float[] array, float element)
		{
			if (id_removeAllOccurences_arrayFF == IntPtr.Zero)
				id_removeAllOccurences_arrayFF = JNIEnv.GetStaticMethodID (class_ref, "removeAllOccurences", "([FF)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAllOccurences_arrayFF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeAllOccurences_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAllOccurences' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("removeAllOccurences", "([II)[I", "")]
		public static unsafe int[] RemoveAllOccurences (int[] array, int element)
		{
			if (id_removeAllOccurences_arrayII == IntPtr.Zero)
				id_removeAllOccurences_arrayII = JNIEnv.GetStaticMethodID (class_ref, "removeAllOccurences", "([II)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAllOccurences_arrayII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeAllOccurences_arrayJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAllOccurences' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long']]"
		[Register ("removeAllOccurences", "([JJ)[J", "")]
		public static unsafe long[] RemoveAllOccurences (long[] array, long element)
		{
			if (id_removeAllOccurences_arrayJJ == IntPtr.Zero)
				id_removeAllOccurences_arrayJJ = JNIEnv.GetStaticMethodID (class_ref, "removeAllOccurences", "([JJ)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAllOccurences_arrayJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeAllOccurences_arraySS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAllOccurences' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short']]"
		[Register ("removeAllOccurences", "([SS)[S", "")]
		public static unsafe short[] RemoveAllOccurences (short[] array, short element)
		{
			if (id_removeAllOccurences_arraySS == IntPtr.Zero)
				id_removeAllOccurences_arraySS = JNIEnv.GetStaticMethodID (class_ref, "removeAllOccurences", "([SS)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAllOccurences_arraySS, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeAllOccurences_arrayLjava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeAllOccurences' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='T']]"
		[Register ("removeAllOccurences", "([Ljava/lang/Object;Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] RemoveAllOccurences (global::Java.Lang.Object[] array, global::Java.Lang.Object element)
		{
			if (id_removeAllOccurences_arrayLjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeAllOccurences_arrayLjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "removeAllOccurences", "([Ljava/lang/Object;Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_element);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeAllOccurences_arrayLjava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_removeElement_arrayZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElement' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean']]"
		[Register ("removeElement", "([ZZ)[Z", "")]
		public static unsafe bool[] RemoveElement (bool[] array, bool element)
		{
			if (id_removeElement_arrayZZ == IntPtr.Zero)
				id_removeElement_arrayZZ = JNIEnv.GetStaticMethodID (class_ref, "removeElement", "([ZZ)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElement_arrayZZ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeElement_arrayBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElement' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register ("removeElement", "([BB)[B", "")]
		public static unsafe byte[] RemoveElement (byte[] array, sbyte element)
		{
			if (id_removeElement_arrayBB == IntPtr.Zero)
				id_removeElement_arrayBB = JNIEnv.GetStaticMethodID (class_ref, "removeElement", "([BB)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElement_arrayBB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeElement_arrayCC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElement' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char']]"
		[Register ("removeElement", "([CC)[C", "")]
		public static unsafe char[] RemoveElement (char[] array, char element)
		{
			if (id_removeElement_arrayCC == IntPtr.Zero)
				id_removeElement_arrayCC = JNIEnv.GetStaticMethodID (class_ref, "removeElement", "([CC)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElement_arrayCC, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeElement_arrayDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElement' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double']]"
		[Register ("removeElement", "([DD)[D", "")]
		public static unsafe double[] RemoveElement (double[] array, double element)
		{
			if (id_removeElement_arrayDD == IntPtr.Zero)
				id_removeElement_arrayDD = JNIEnv.GetStaticMethodID (class_ref, "removeElement", "([DD)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElement_arrayDD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeElement_arrayFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElement' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float']]"
		[Register ("removeElement", "([FF)[F", "")]
		public static unsafe float[] RemoveElement (float[] array, float element)
		{
			if (id_removeElement_arrayFF == IntPtr.Zero)
				id_removeElement_arrayFF = JNIEnv.GetStaticMethodID (class_ref, "removeElement", "([FF)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElement_arrayFF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeElement_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElement' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("removeElement", "([II)[I", "")]
		public static unsafe int[] RemoveElement (int[] array, int element)
		{
			if (id_removeElement_arrayII == IntPtr.Zero)
				id_removeElement_arrayII = JNIEnv.GetStaticMethodID (class_ref, "removeElement", "([II)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElement_arrayII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeElement_arrayJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElement' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long']]"
		[Register ("removeElement", "([JJ)[J", "")]
		public static unsafe long[] RemoveElement (long[] array, long element)
		{
			if (id_removeElement_arrayJJ == IntPtr.Zero)
				id_removeElement_arrayJJ = JNIEnv.GetStaticMethodID (class_ref, "removeElement", "([JJ)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElement_arrayJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeElement_arraySS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElement' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short']]"
		[Register ("removeElement", "([SS)[S", "")]
		public static unsafe short[] RemoveElement (short[] array, short element)
		{
			if (id_removeElement_arraySS == IntPtr.Zero)
				id_removeElement_arraySS = JNIEnv.GetStaticMethodID (class_ref, "removeElement", "([SS)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElement_arraySS, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeElement_arrayLjava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElement' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='java.lang.Object']]"
		[Register ("removeElement", "([Ljava/lang/Object;Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] RemoveElement (global::Java.Lang.Object[] array, global::Java.Lang.Object element)
		{
			if (id_removeElement_arrayLjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeElement_arrayLjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "removeElement", "([Ljava/lang/Object;Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (element);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElement_arrayLjava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_removeElements_arrayZarrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElements' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean...']]"
		[Register ("removeElements", "([Z[Z)[Z", "")]
		public static unsafe bool[] RemoveElements (bool[] array, params bool[] values)
		{
			if (id_removeElements_arrayZarrayZ == IntPtr.Zero)
				id_removeElements_arrayZarrayZ = JNIEnv.GetStaticMethodID (class_ref, "removeElements", "([Z[Z)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_values);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElements_arrayZarrayZ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_removeElements_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElements' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte...']]"
		[Register ("removeElements", "([B[B)[B", "")]
		public static unsafe byte[] RemoveElements (byte[] array, params byte[] values)
		{
			if (id_removeElements_arrayBarrayB == IntPtr.Zero)
				id_removeElements_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "removeElements", "([B[B)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_values);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElements_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_removeElements_arrayCarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElements' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char...']]"
		[Register ("removeElements", "([C[C)[C", "")]
		public static unsafe char[] RemoveElements (char[] array, params char[] values)
		{
			if (id_removeElements_arrayCarrayC == IntPtr.Zero)
				id_removeElements_arrayCarrayC = JNIEnv.GetStaticMethodID (class_ref, "removeElements", "([C[C)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_values);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElements_arrayCarrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_removeElements_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElements' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double...']]"
		[Register ("removeElements", "([D[D)[D", "")]
		public static unsafe double[] RemoveElements (double[] array, params double[] values)
		{
			if (id_removeElements_arrayDarrayD == IntPtr.Zero)
				id_removeElements_arrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "removeElements", "([D[D)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_values);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElements_arrayDarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_removeElements_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElements' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float...']]"
		[Register ("removeElements", "([F[F)[F", "")]
		public static unsafe float[] RemoveElements (float[] array, params float[] values)
		{
			if (id_removeElements_arrayFarrayF == IntPtr.Zero)
				id_removeElements_arrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "removeElements", "([F[F)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_values);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElements_arrayFarrayF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_removeElements_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElements' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int...']]"
		[Register ("removeElements", "([I[I)[I", "")]
		public static unsafe int[] RemoveElements (int[] array, params int[] values)
		{
			if (id_removeElements_arrayIarrayI == IntPtr.Zero)
				id_removeElements_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "removeElements", "([I[I)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_values);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElements_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_removeElements_arrayJarrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElements' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long...']]"
		[Register ("removeElements", "([J[J)[J", "")]
		public static unsafe long[] RemoveElements (long[] array, params long[] values)
		{
			if (id_removeElements_arrayJarrayJ == IntPtr.Zero)
				id_removeElements_arrayJarrayJ = JNIEnv.GetStaticMethodID (class_ref, "removeElements", "([J[J)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_values);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElements_arrayJarrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_removeElements_arraySarrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElements' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short...']]"
		[Register ("removeElements", "([S[S)[S", "")]
		public static unsafe short[] RemoveElements (short[] array, params short[] values)
		{
			if (id_removeElements_arraySarrayS == IntPtr.Zero)
				id_removeElements_arraySarrayS = JNIEnv.GetStaticMethodID (class_ref, "removeElements", "([S[S)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_values);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElements_arraySarrayS, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_removeElements_arrayLjava_lang_Object_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='removeElements' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='T...']]"
		[Register ("removeElements", "([Ljava/lang/Object;[Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] RemoveElements (global::Java.Lang.Object[] array, params global::Java.Lang.Object[] values)
		{
			if (id_removeElements_arrayLjava_lang_Object_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_removeElements_arrayLjava_lang_Object_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "removeElements", "([Ljava/lang/Object;[Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_values);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeElements_arrayLjava_lang_Object_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_reverse_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("reverse", "([Z)V", "")]
		public static unsafe void Reverse (bool[] array)
		{
			if (id_reverse_arrayZ == IntPtr.Zero)
				id_reverse_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([Z)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayZ, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=3 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reverse", "([ZII)V", "")]
		public static unsafe void Reverse (bool[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_reverse_arrayZII == IntPtr.Zero)
				id_reverse_arrayZII = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([ZII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayZII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("reverse", "([B)V", "")]
		public static unsafe void Reverse (byte[] array)
		{
			if (id_reverse_arrayB == IntPtr.Zero)
				id_reverse_arrayB = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([B)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayB, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reverse", "([BII)V", "")]
		public static unsafe void Reverse (byte[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_reverse_arrayBII == IntPtr.Zero)
				id_reverse_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([BII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayBII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("reverse", "([C)V", "")]
		public static unsafe void Reverse (char[] array)
		{
			if (id_reverse_arrayC == IntPtr.Zero)
				id_reverse_arrayC = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([C)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayC, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reverse", "([CII)V", "")]
		public static unsafe void Reverse (char[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_reverse_arrayCII == IntPtr.Zero)
				id_reverse_arrayCII = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([CII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayCII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("reverse", "([D)V", "")]
		public static unsafe void Reverse (double[] array)
		{
			if (id_reverse_arrayD == IntPtr.Zero)
				id_reverse_arrayD = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([D)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayD, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayDII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reverse", "([DII)V", "")]
		public static unsafe void Reverse (double[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_reverse_arrayDII == IntPtr.Zero)
				id_reverse_arrayDII = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([DII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayDII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("reverse", "([F)V", "")]
		public static unsafe void Reverse (float[] array)
		{
			if (id_reverse_arrayF == IntPtr.Zero)
				id_reverse_arrayF = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([F)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayF, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=3 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reverse", "([FII)V", "")]
		public static unsafe void Reverse (float[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_reverse_arrayFII == IntPtr.Zero)
				id_reverse_arrayFII = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([FII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayFII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("reverse", "([I)V", "")]
		public static unsafe void Reverse (int[] array)
		{
			if (id_reverse_arrayI == IntPtr.Zero)
				id_reverse_arrayI = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([I)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayI, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reverse", "([III)V", "")]
		public static unsafe void Reverse (int[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_reverse_arrayIII == IntPtr.Zero)
				id_reverse_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([III)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("reverse", "([Ljava/lang/Object;)V", "")]
		public static unsafe void Reverse (global::Java.Lang.Object[] array)
		{
			if (id_reverse_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_reverse_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([Ljava/lang/Object;)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayLjava_lang_Object_, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayLjava_lang_Object_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=3 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reverse", "([Ljava/lang/Object;II)V", "")]
		public static unsafe void Reverse (global::Java.Lang.Object[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_reverse_arrayLjava_lang_Object_II == IntPtr.Zero)
				id_reverse_arrayLjava_lang_Object_II = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([Ljava/lang/Object;II)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayLjava_lang_Object_II, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("reverse", "([J)V", "")]
		public static unsafe void Reverse (long[] array)
		{
			if (id_reverse_arrayJ == IntPtr.Zero)
				id_reverse_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([J)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayJ, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayJII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=3 and parameter[1][@type='long[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reverse", "([JII)V", "")]
		public static unsafe void Reverse (long[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_reverse_arrayJII == IntPtr.Zero)
				id_reverse_arrayJII = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([JII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayJII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("reverse", "([S)V", "")]
		public static unsafe void Reverse (short[] array)
		{
			if (id_reverse_arrayS == IntPtr.Zero)
				id_reverse_arrayS = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([S)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arrayS, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_reverse_arraySII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='reverse' and count(parameter)=3 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reverse", "([SII)V", "")]
		public static unsafe void Reverse (short[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_reverse_arraySII == IntPtr.Zero)
				id_reverse_arraySII = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([SII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reverse_arraySII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='int']]"
		[Register ("shift", "([ZI)V", "")]
		public static unsafe void Shift (bool[] array, int offset)
		{
			if (id_shift_arrayZI == IntPtr.Zero)
				id_shift_arrayZI = JNIEnv.GetStaticMethodID (class_ref, "shift", "([ZI)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayZI, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayZIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=4 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("shift", "([ZIII)V", "")]
		public static unsafe void Shift (bool[] array, int startIndexInclusive, int endIndexExclusive, int offset)
		{
			if (id_shift_arrayZIII == IntPtr.Zero)
				id_shift_arrayZIII = JNIEnv.GetStaticMethodID (class_ref, "shift", "([ZIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				__args [3] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayZIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("shift", "([BI)V", "")]
		public static unsafe void Shift (byte[] array, int offset)
		{
			if (id_shift_arrayBI == IntPtr.Zero)
				id_shift_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "shift", "([BI)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayBI, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("shift", "([BIII)V", "")]
		public static unsafe void Shift (byte[] array, int startIndexInclusive, int endIndexExclusive, int offset)
		{
			if (id_shift_arrayBIII == IntPtr.Zero)
				id_shift_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "shift", "([BIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				__args [3] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayBIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayCI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='int']]"
		[Register ("shift", "([CI)V", "")]
		public static unsafe void Shift (char[] array, int offset)
		{
			if (id_shift_arrayCI == IntPtr.Zero)
				id_shift_arrayCI = JNIEnv.GetStaticMethodID (class_ref, "shift", "([CI)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayCI, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayCIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=4 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("shift", "([CIII)V", "")]
		public static unsafe void Shift (char[] array, int startIndexInclusive, int endIndexExclusive, int offset)
		{
			if (id_shift_arrayCIII == IntPtr.Zero)
				id_shift_arrayCIII = JNIEnv.GetStaticMethodID (class_ref, "shift", "([CIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				__args [3] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayCIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='int']]"
		[Register ("shift", "([DI)V", "")]
		public static unsafe void Shift (double[] array, int offset)
		{
			if (id_shift_arrayDI == IntPtr.Zero)
				id_shift_arrayDI = JNIEnv.GetStaticMethodID (class_ref, "shift", "([DI)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayDI, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayDIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=4 and parameter[1][@type='double[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("shift", "([DIII)V", "")]
		public static unsafe void Shift (double[] array, int startIndexInclusive, int endIndexExclusive, int offset)
		{
			if (id_shift_arrayDIII == IntPtr.Zero)
				id_shift_arrayDIII = JNIEnv.GetStaticMethodID (class_ref, "shift", "([DIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				__args [3] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayDIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("shift", "([FI)V", "")]
		public static unsafe void Shift (float[] array, int offset)
		{
			if (id_shift_arrayFI == IntPtr.Zero)
				id_shift_arrayFI = JNIEnv.GetStaticMethodID (class_ref, "shift", "([FI)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayFI, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayFIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("shift", "([FIII)V", "")]
		public static unsafe void Shift (float[] array, int startIndexInclusive, int endIndexExclusive, int offset)
		{
			if (id_shift_arrayFIII == IntPtr.Zero)
				id_shift_arrayFIII = JNIEnv.GetStaticMethodID (class_ref, "shift", "([FIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				__args [3] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayFIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("shift", "([II)V", "")]
		public static unsafe void Shift (int[] array, int offset)
		{
			if (id_shift_arrayII == IntPtr.Zero)
				id_shift_arrayII = JNIEnv.GetStaticMethodID (class_ref, "shift", "([II)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("shift", "([IIII)V", "")]
		public static unsafe void Shift (int[] array, int startIndexInclusive, int endIndexExclusive, int offset)
		{
			if (id_shift_arrayIIII == IntPtr.Zero)
				id_shift_arrayIIII = JNIEnv.GetStaticMethodID (class_ref, "shift", "([IIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				__args [3] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayIIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayLjava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='int']]"
		[Register ("shift", "([Ljava/lang/Object;I)V", "")]
		public static unsafe void Shift (global::Java.Lang.Object[] array, int offset)
		{
			if (id_shift_arrayLjava_lang_Object_I == IntPtr.Zero)
				id_shift_arrayLjava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "shift", "([Ljava/lang/Object;I)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayLjava_lang_Object_I, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayLjava_lang_Object_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=4 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("shift", "([Ljava/lang/Object;III)V", "")]
		public static unsafe void Shift (global::Java.Lang.Object[] array, int startIndexInclusive, int endIndexExclusive, int offset)
		{
			if (id_shift_arrayLjava_lang_Object_III == IntPtr.Zero)
				id_shift_arrayLjava_lang_Object_III = JNIEnv.GetStaticMethodID (class_ref, "shift", "([Ljava/lang/Object;III)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				__args [3] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayLjava_lang_Object_III, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayJI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='int']]"
		[Register ("shift", "([JI)V", "")]
		public static unsafe void Shift (long[] array, int offset)
		{
			if (id_shift_arrayJI == IntPtr.Zero)
				id_shift_arrayJI = JNIEnv.GetStaticMethodID (class_ref, "shift", "([JI)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayJI, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arrayJIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=4 and parameter[1][@type='long[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("shift", "([JIII)V", "")]
		public static unsafe void Shift (long[] array, int startIndexInclusive, int endIndexExclusive, int offset)
		{
			if (id_shift_arrayJIII == IntPtr.Zero)
				id_shift_arrayJIII = JNIEnv.GetStaticMethodID (class_ref, "shift", "([JIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				__args [3] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arrayJIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arraySI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='int']]"
		[Register ("shift", "([SI)V", "")]
		public static unsafe void Shift (short[] array, int offset)
		{
			if (id_shift_arraySI == IntPtr.Zero)
				id_shift_arraySI = JNIEnv.GetStaticMethodID (class_ref, "shift", "([SI)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arraySI, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shift_arraySIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shift' and count(parameter)=4 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("shift", "([SIII)V", "")]
		public static unsafe void Shift (short[] array, int startIndexInclusive, int endIndexExclusive, int offset)
		{
			if (id_shift_arraySIII == IntPtr.Zero)
				id_shift_arraySIII = JNIEnv.GetStaticMethodID (class_ref, "shift", "([SIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				__args [3] = new JValue (offset);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shift_arraySIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("shuffle", "([Z)V", "")]
		public static unsafe void Shuffle (bool[] array)
		{
			if (id_shuffle_arrayZ == IntPtr.Zero)
				id_shuffle_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([Z)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayZ, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayZLjava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='java.util.Random']]"
		[Register ("shuffle", "([ZLjava/util/Random;)V", "")]
		public static unsafe void Shuffle (bool[] array, global::Java.Util.Random random)
		{
			if (id_shuffle_arrayZLjava_util_Random_ == IntPtr.Zero)
				id_shuffle_arrayZLjava_util_Random_ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([ZLjava/util/Random;)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (random);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayZLjava_util_Random_, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("shuffle", "([B)V", "")]
		public static unsafe void Shuffle (byte[] array)
		{
			if (id_shuffle_arrayB == IntPtr.Zero)
				id_shuffle_arrayB = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([B)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayB, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayBLjava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.Random']]"
		[Register ("shuffle", "([BLjava/util/Random;)V", "")]
		public static unsafe void Shuffle (byte[] array, global::Java.Util.Random random)
		{
			if (id_shuffle_arrayBLjava_util_Random_ == IntPtr.Zero)
				id_shuffle_arrayBLjava_util_Random_ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([BLjava/util/Random;)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (random);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayBLjava_util_Random_, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("shuffle", "([C)V", "")]
		public static unsafe void Shuffle (char[] array)
		{
			if (id_shuffle_arrayC == IntPtr.Zero)
				id_shuffle_arrayC = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([C)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayC, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayCLjava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='java.util.Random']]"
		[Register ("shuffle", "([CLjava/util/Random;)V", "")]
		public static unsafe void Shuffle (char[] array, global::Java.Util.Random random)
		{
			if (id_shuffle_arrayCLjava_util_Random_ == IntPtr.Zero)
				id_shuffle_arrayCLjava_util_Random_ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([CLjava/util/Random;)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (random);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayCLjava_util_Random_, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("shuffle", "([D)V", "")]
		public static unsafe void Shuffle (double[] array)
		{
			if (id_shuffle_arrayD == IntPtr.Zero)
				id_shuffle_arrayD = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([D)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayD, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayDLjava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='java.util.Random']]"
		[Register ("shuffle", "([DLjava/util/Random;)V", "")]
		public static unsafe void Shuffle (double[] array, global::Java.Util.Random random)
		{
			if (id_shuffle_arrayDLjava_util_Random_ == IntPtr.Zero)
				id_shuffle_arrayDLjava_util_Random_ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([DLjava/util/Random;)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (random);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayDLjava_util_Random_, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("shuffle", "([F)V", "")]
		public static unsafe void Shuffle (float[] array)
		{
			if (id_shuffle_arrayF == IntPtr.Zero)
				id_shuffle_arrayF = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([F)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayF, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayFLjava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='java.util.Random']]"
		[Register ("shuffle", "([FLjava/util/Random;)V", "")]
		public static unsafe void Shuffle (float[] array, global::Java.Util.Random random)
		{
			if (id_shuffle_arrayFLjava_util_Random_ == IntPtr.Zero)
				id_shuffle_arrayFLjava_util_Random_ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([FLjava/util/Random;)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (random);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayFLjava_util_Random_, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("shuffle", "([I)V", "")]
		public static unsafe void Shuffle (int[] array)
		{
			if (id_shuffle_arrayI == IntPtr.Zero)
				id_shuffle_arrayI = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([I)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayI, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayILjava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='java.util.Random']]"
		[Register ("shuffle", "([ILjava/util/Random;)V", "")]
		public static unsafe void Shuffle (int[] array, global::Java.Util.Random random)
		{
			if (id_shuffle_arrayILjava_util_Random_ == IntPtr.Zero)
				id_shuffle_arrayILjava_util_Random_ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([ILjava/util/Random;)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (random);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayILjava_util_Random_, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("shuffle", "([Ljava/lang/Object;)V", "")]
		public static unsafe void Shuffle (global::Java.Lang.Object[] array)
		{
			if (id_shuffle_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_shuffle_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([Ljava/lang/Object;)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayLjava_lang_Object_, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayLjava_lang_Object_Ljava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.util.Random']]"
		[Register ("shuffle", "([Ljava/lang/Object;Ljava/util/Random;)V", "")]
		public static unsafe void Shuffle (global::Java.Lang.Object[] array, global::Java.Util.Random random)
		{
			if (id_shuffle_arrayLjava_lang_Object_Ljava_util_Random_ == IntPtr.Zero)
				id_shuffle_arrayLjava_lang_Object_Ljava_util_Random_ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([Ljava/lang/Object;Ljava/util/Random;)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (random);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayLjava_lang_Object_Ljava_util_Random_, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("shuffle", "([J)V", "")]
		public static unsafe void Shuffle (long[] array)
		{
			if (id_shuffle_arrayJ == IntPtr.Zero)
				id_shuffle_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([J)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayJ, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayJLjava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='java.util.Random']]"
		[Register ("shuffle", "([JLjava/util/Random;)V", "")]
		public static unsafe void Shuffle (long[] array, global::Java.Util.Random random)
		{
			if (id_shuffle_arrayJLjava_util_Random_ == IntPtr.Zero)
				id_shuffle_arrayJLjava_util_Random_ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([JLjava/util/Random;)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (random);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayJLjava_util_Random_, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("shuffle", "([S)V", "")]
		public static unsafe void Shuffle (short[] array)
		{
			if (id_shuffle_arrayS == IntPtr.Zero)
				id_shuffle_arrayS = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([S)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arrayS, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_shuffle_arraySLjava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='shuffle' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='java.util.Random']]"
		[Register ("shuffle", "([SLjava/util/Random;)V", "")]
		public static unsafe void Shuffle (short[] array, global::Java.Util.Random random)
		{
			if (id_shuffle_arraySLjava_util_Random_ == IntPtr.Zero)
				id_shuffle_arraySLjava_util_Random_ = JNIEnv.GetStaticMethodID (class_ref, "shuffle", "([SLjava/util/Random;)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (random);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shuffle_arraySLjava_util_Random_, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_subarray_arrayZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='subarray' and count(parameter)=3 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("subarray", "([ZII)[Z", "")]
		public static unsafe bool[] Subarray (bool[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_subarray_arrayZII == IntPtr.Zero)
				id_subarray_arrayZII = JNIEnv.GetStaticMethodID (class_ref, "subarray", "([ZII)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_subarray_arrayZII, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_subarray_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='subarray' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("subarray", "([BII)[B", "")]
		public static unsafe byte[] Subarray (byte[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_subarray_arrayBII == IntPtr.Zero)
				id_subarray_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "subarray", "([BII)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_subarray_arrayBII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_subarray_arrayCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='subarray' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("subarray", "([CII)[C", "")]
		public static unsafe char[] Subarray (char[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_subarray_arrayCII == IntPtr.Zero)
				id_subarray_arrayCII = JNIEnv.GetStaticMethodID (class_ref, "subarray", "([CII)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_subarray_arrayCII, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_subarray_arrayDII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='subarray' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("subarray", "([DII)[D", "")]
		public static unsafe double[] Subarray (double[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_subarray_arrayDII == IntPtr.Zero)
				id_subarray_arrayDII = JNIEnv.GetStaticMethodID (class_ref, "subarray", "([DII)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_subarray_arrayDII, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_subarray_arrayFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='subarray' and count(parameter)=3 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("subarray", "([FII)[F", "")]
		public static unsafe float[] Subarray (float[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_subarray_arrayFII == IntPtr.Zero)
				id_subarray_arrayFII = JNIEnv.GetStaticMethodID (class_ref, "subarray", "([FII)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_subarray_arrayFII, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_subarray_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='subarray' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("subarray", "([III)[I", "")]
		public static unsafe int[] Subarray (int[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_subarray_arrayIII == IntPtr.Zero)
				id_subarray_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "subarray", "([III)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_subarray_arrayIII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_subarray_arrayJII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='subarray' and count(parameter)=3 and parameter[1][@type='long[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("subarray", "([JII)[J", "")]
		public static unsafe long[] Subarray (long[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_subarray_arrayJII == IntPtr.Zero)
				id_subarray_arrayJII = JNIEnv.GetStaticMethodID (class_ref, "subarray", "([JII)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_subarray_arrayJII, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_subarray_arraySII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='subarray' and count(parameter)=3 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("subarray", "([SII)[S", "")]
		public static unsafe short[] Subarray (short[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_subarray_arraySII == IntPtr.Zero)
				id_subarray_arraySII = JNIEnv.GetStaticMethodID (class_ref, "subarray", "([SII)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_subarray_arraySII, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_subarray_arrayLjava_lang_Object_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='subarray' and count(parameter)=3 and parameter[1][@type='T[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("subarray", "([Ljava/lang/Object;II)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] Subarray (global::Java.Lang.Object[] array, int startIndexInclusive, int endIndexExclusive)
		{
			if (id_subarray_arrayLjava_lang_Object_II == IntPtr.Zero)
				id_subarray_arrayLjava_lang_Object_II = JNIEnv.GetStaticMethodID (class_ref, "subarray", "([Ljava/lang/Object;II)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (startIndexInclusive);
				__args [2] = new JValue (endIndexExclusive);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_subarray_arrayLjava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=3 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("swap", "([ZII)V", "")]
		public static unsafe void Swap (bool[] array, int offset1, int offset2)
		{
			if (id_swap_arrayZII == IntPtr.Zero)
				id_swap_arrayZII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([ZII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayZII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayZIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=4 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("swap", "([ZIII)V", "")]
		public static unsafe void Swap (bool[] array, int offset1, int offset2, int len)
		{
			if (id_swap_arrayZIII == IntPtr.Zero)
				id_swap_arrayZIII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([ZIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				__args [3] = new JValue (len);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayZIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("swap", "([BII)V", "")]
		public static unsafe void Swap (byte[] array, int offset1, int offset2)
		{
			if (id_swap_arrayBII == IntPtr.Zero)
				id_swap_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([BII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayBII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("swap", "([BIII)V", "")]
		public static unsafe void Swap (byte[] array, int offset1, int offset2, int len)
		{
			if (id_swap_arrayBIII == IntPtr.Zero)
				id_swap_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([BIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				__args [3] = new JValue (len);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayBIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("swap", "([CII)V", "")]
		public static unsafe void Swap (char[] array, int offset1, int offset2)
		{
			if (id_swap_arrayCII == IntPtr.Zero)
				id_swap_arrayCII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([CII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayCII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayCIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=4 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("swap", "([CIII)V", "")]
		public static unsafe void Swap (char[] array, int offset1, int offset2, int len)
		{
			if (id_swap_arrayCIII == IntPtr.Zero)
				id_swap_arrayCIII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([CIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				__args [3] = new JValue (len);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayCIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayDII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("swap", "([DII)V", "")]
		public static unsafe void Swap (double[] array, int offset1, int offset2)
		{
			if (id_swap_arrayDII == IntPtr.Zero)
				id_swap_arrayDII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([DII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayDII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayDIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=4 and parameter[1][@type='double[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("swap", "([DIII)V", "")]
		public static unsafe void Swap (double[] array, int offset1, int offset2, int len)
		{
			if (id_swap_arrayDIII == IntPtr.Zero)
				id_swap_arrayDIII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([DIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				__args [3] = new JValue (len);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayDIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=3 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("swap", "([FII)V", "")]
		public static unsafe void Swap (float[] array, int offset1, int offset2)
		{
			if (id_swap_arrayFII == IntPtr.Zero)
				id_swap_arrayFII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([FII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayFII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayFIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("swap", "([FIII)V", "")]
		public static unsafe void Swap (float[] array, int offset1, int offset2, int len)
		{
			if (id_swap_arrayFIII == IntPtr.Zero)
				id_swap_arrayFIII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([FIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				__args [3] = new JValue (len);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayFIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("swap", "([III)V", "")]
		public static unsafe void Swap (int[] array, int offset1, int offset2)
		{
			if (id_swap_arrayIII == IntPtr.Zero)
				id_swap_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([III)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("swap", "([IIII)V", "")]
		public static unsafe void Swap (int[] array, int offset1, int offset2, int len)
		{
			if (id_swap_arrayIIII == IntPtr.Zero)
				id_swap_arrayIIII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([IIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				__args [3] = new JValue (len);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayIIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayLjava_lang_Object_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=3 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("swap", "([Ljava/lang/Object;II)V", "")]
		public static unsafe void Swap (global::Java.Lang.Object[] array, int offset1, int offset2)
		{
			if (id_swap_arrayLjava_lang_Object_II == IntPtr.Zero)
				id_swap_arrayLjava_lang_Object_II = JNIEnv.GetStaticMethodID (class_ref, "swap", "([Ljava/lang/Object;II)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayLjava_lang_Object_II, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayLjava_lang_Object_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=4 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("swap", "([Ljava/lang/Object;III)V", "")]
		public static unsafe void Swap (global::Java.Lang.Object[] array, int offset1, int offset2, int len)
		{
			if (id_swap_arrayLjava_lang_Object_III == IntPtr.Zero)
				id_swap_arrayLjava_lang_Object_III = JNIEnv.GetStaticMethodID (class_ref, "swap", "([Ljava/lang/Object;III)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				__args [3] = new JValue (len);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayLjava_lang_Object_III, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayJII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=3 and parameter[1][@type='long[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("swap", "([JII)V", "")]
		public static unsafe void Swap (long[] array, int offset1, int offset2)
		{
			if (id_swap_arrayJII == IntPtr.Zero)
				id_swap_arrayJII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([JII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayJII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arrayJIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=4 and parameter[1][@type='long[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("swap", "([JIII)V", "")]
		public static unsafe void Swap (long[] array, int offset1, int offset2, int len)
		{
			if (id_swap_arrayJIII == IntPtr.Zero)
				id_swap_arrayJIII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([JIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				__args [3] = new JValue (len);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arrayJIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arraySII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=3 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("swap", "([SII)V", "")]
		public static unsafe void Swap (short[] array, int offset1, int offset2)
		{
			if (id_swap_arraySII == IntPtr.Zero)
				id_swap_arraySII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([SII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arraySII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_swap_arraySIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='swap' and count(parameter)=4 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("swap", "([SIII)V", "")]
		public static unsafe void Swap (short[] array, int offset1, int offset2, int len)
		{
			if (id_swap_arraySIII == IntPtr.Zero)
				id_swap_arraySIII = JNIEnv.GetStaticMethodID (class_ref, "swap", "([SIII)V");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (offset1);
				__args [2] = new JValue (offset2);
				__args [3] = new JValue (len);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_swap_arraySIII, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toArray_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toArray' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] ToArray (params global::Java.Lang.Object[] items)
		{
			if (id_toArray_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_toArray_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_items);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toArray_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (items != null) {
					JNIEnv.CopyArray (native_items, items);
					JNIEnv.DeleteLocalRef (native_items);
				}
			}
		}

		static IntPtr id_toMap_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toMap' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("toMap", "([Ljava/lang/Object;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<global::Java.Lang.Object, global::Java.Lang.Object> ToMap (global::Java.Lang.Object[] array)
		{
			if (id_toMap_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_toMap_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "toMap", "([Ljava/lang/Object;)Ljava/util/Map;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::System.Collections.Generic.IDictionary<global::Java.Lang.Object, global::Java.Lang.Object> __ret = global::Android.Runtime.JavaDictionary<global::Java.Lang.Object, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_toMap_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toObject_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toObject' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("toObject", "([Z)[Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean[] ToObject (bool[] array)
		{
			if (id_toObject_arrayZ == IntPtr.Zero)
				id_toObject_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "toObject", "([Z)[Ljava/lang/Boolean;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Boolean[] __ret = (global::Java.Lang.Boolean[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toObject_arrayZ, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Boolean));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toObject_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toObject' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toObject", "([B)[Ljava/lang/Byte;", "")]
		public static unsafe global::Java.Lang.Byte[] ToObject (byte[] array)
		{
			if (id_toObject_arrayB == IntPtr.Zero)
				id_toObject_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toObject", "([B)[Ljava/lang/Byte;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Byte[] __ret = (global::Java.Lang.Byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toObject_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toObject_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toObject' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("toObject", "([C)[Ljava/lang/Character;", "")]
		public static unsafe global::Java.Lang.Character[] ToObject (char[] array)
		{
			if (id_toObject_arrayC == IntPtr.Zero)
				id_toObject_arrayC = JNIEnv.GetStaticMethodID (class_ref, "toObject", "([C)[Ljava/lang/Character;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Character[] __ret = (global::Java.Lang.Character[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toObject_arrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Character));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toObject_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toObject' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("toObject", "([D)[Ljava/lang/Double;", "")]
		public static unsafe global::Java.Lang.Double[] ToObject (double[] array)
		{
			if (id_toObject_arrayD == IntPtr.Zero)
				id_toObject_arrayD = JNIEnv.GetStaticMethodID (class_ref, "toObject", "([D)[Ljava/lang/Double;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Double[] __ret = (global::Java.Lang.Double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toObject_arrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toObject_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toObject' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("toObject", "([F)[Ljava/lang/Float;", "")]
		public static unsafe global::Java.Lang.Float[] ToObject (float[] array)
		{
			if (id_toObject_arrayF == IntPtr.Zero)
				id_toObject_arrayF = JNIEnv.GetStaticMethodID (class_ref, "toObject", "([F)[Ljava/lang/Float;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Float[] __ret = (global::Java.Lang.Float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toObject_arrayF, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toObject_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toObject' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("toObject", "([I)[Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer[] ToObject (int[] array)
		{
			if (id_toObject_arrayI == IntPtr.Zero)
				id_toObject_arrayI = JNIEnv.GetStaticMethodID (class_ref, "toObject", "([I)[Ljava/lang/Integer;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Integer[] __ret = (global::Java.Lang.Integer[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toObject_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Integer));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toObject_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toObject' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("toObject", "([J)[Ljava/lang/Long;", "")]
		public static unsafe global::Java.Lang.Long[] ToObject (long[] array)
		{
			if (id_toObject_arrayJ == IntPtr.Zero)
				id_toObject_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "toObject", "([J)[Ljava/lang/Long;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Long[] __ret = (global::Java.Lang.Long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toObject_arrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toObject_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toObject' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("toObject", "([S)[Ljava/lang/Short;", "")]
		public static unsafe global::Java.Lang.Short[] ToObject (short[] array)
		{
			if (id_toObject_arrayS == IntPtr.Zero)
				id_toObject_arrayS = JNIEnv.GetStaticMethodID (class_ref, "toObject", "([S)[Ljava/lang/Short;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				global::Java.Lang.Short[] __ret = (global::Java.Lang.Short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toObject_arrayS, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean[]']]"
		[Register ("toPrimitive", "([Ljava/lang/Boolean;)[Z", "")]
		public static unsafe bool[] ToPrimitive (global::Java.Lang.Boolean[] array)
		{
			if (id_toPrimitive_arrayLjava_lang_Boolean_ == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Boolean;)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Boolean_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=2 and parameter[1][@type='java.lang.Boolean[]'] and parameter[2][@type='boolean']]"
		[Register ("toPrimitive", "([Ljava/lang/Boolean;Z)[Z", "")]
		public static unsafe bool[] ToPrimitive (global::Java.Lang.Boolean[] array, bool valueForNull)
		{
			if (id_toPrimitive_arrayLjava_lang_Boolean_Z == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Boolean_Z = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Boolean;Z)[Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueForNull);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Boolean_Z, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Byte_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Byte[]']]"
		[Register ("toPrimitive", "([Ljava/lang/Byte;)[B", "")]
		public static unsafe byte[] ToPrimitive (global::Java.Lang.Byte[] array)
		{
			if (id_toPrimitive_arrayLjava_lang_Byte_ == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Byte_ = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Byte;)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Byte_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Byte_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=2 and parameter[1][@type='java.lang.Byte[]'] and parameter[2][@type='byte']]"
		[Register ("toPrimitive", "([Ljava/lang/Byte;B)[B", "")]
		public static unsafe byte[] ToPrimitive (global::Java.Lang.Byte[] array, sbyte valueForNull)
		{
			if (id_toPrimitive_arrayLjava_lang_Byte_B == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Byte_B = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Byte;B)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueForNull);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Byte_B, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Character_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Character[]']]"
		[Register ("toPrimitive", "([Ljava/lang/Character;)[C", "")]
		public static unsafe char[] ToPrimitive (global::Java.Lang.Character[] array)
		{
			if (id_toPrimitive_arrayLjava_lang_Character_ == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Character_ = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Character;)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Character_, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Character_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=2 and parameter[1][@type='java.lang.Character[]'] and parameter[2][@type='char']]"
		[Register ("toPrimitive", "([Ljava/lang/Character;C)[C", "")]
		public static unsafe char[] ToPrimitive (global::Java.Lang.Character[] array, char valueForNull)
		{
			if (id_toPrimitive_arrayLjava_lang_Character_C == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Character_C = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Character;C)[C");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueForNull);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Character_C, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Double[]']]"
		[Register ("toPrimitive", "([Ljava/lang/Double;)[D", "")]
		public static unsafe double[] ToPrimitive (global::Java.Lang.Double[] array)
		{
			if (id_toPrimitive_arrayLjava_lang_Double_ == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Double_ = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Double;)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Double_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=2 and parameter[1][@type='java.lang.Double[]'] and parameter[2][@type='double']]"
		[Register ("toPrimitive", "([Ljava/lang/Double;D)[D", "")]
		public static unsafe double[] ToPrimitive (global::Java.Lang.Double[] array, double valueForNull)
		{
			if (id_toPrimitive_arrayLjava_lang_Double_D == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Double_D = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Double;D)[D");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueForNull);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Double_D, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Float_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("toPrimitive", "([Ljava/lang/Float;)[F", "")]
		public static unsafe float[] ToPrimitive (global::Java.Lang.Float[] array)
		{
			if (id_toPrimitive_arrayLjava_lang_Float_ == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Float_ = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Float;)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Float_, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Float_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=2 and parameter[1][@type='java.lang.Float[]'] and parameter[2][@type='float']]"
		[Register ("toPrimitive", "([Ljava/lang/Float;F)[F", "")]
		public static unsafe float[] ToPrimitive (global::Java.Lang.Float[] array, float valueForNull)
		{
			if (id_toPrimitive_arrayLjava_lang_Float_F == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Float_F = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Float;F)[F");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueForNull);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Float_F, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Integer[]']]"
		[Register ("toPrimitive", "([Ljava/lang/Integer;)[I", "")]
		public static unsafe int[] ToPrimitive (global::Java.Lang.Integer[] array)
		{
			if (id_toPrimitive_arrayLjava_lang_Integer_ == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Integer;)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Integer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=2 and parameter[1][@type='java.lang.Integer[]'] and parameter[2][@type='int']]"
		[Register ("toPrimitive", "([Ljava/lang/Integer;I)[I", "")]
		public static unsafe int[] ToPrimitive (global::Java.Lang.Integer[] array, int valueForNull)
		{
			if (id_toPrimitive_arrayLjava_lang_Integer_I == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Integer_I = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Integer;I)[I");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueForNull);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Integer_I, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Long[]']]"
		[Register ("toPrimitive", "([Ljava/lang/Long;)[J", "")]
		public static unsafe long[] ToPrimitive (global::Java.Lang.Long[] array)
		{
			if (id_toPrimitive_arrayLjava_lang_Long_ == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Long;)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Long_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=2 and parameter[1][@type='java.lang.Long[]'] and parameter[2][@type='long']]"
		[Register ("toPrimitive", "([Ljava/lang/Long;J)[J", "")]
		public static unsafe long[] ToPrimitive (global::Java.Lang.Long[] array, long valueForNull)
		{
			if (id_toPrimitive_arrayLjava_lang_Long_J == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Long_J = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Long;J)[J");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueForNull);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Long_J, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toPrimitive", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ToPrimitive (global::Java.Lang.Object array)
		{
			if (id_toPrimitive_Ljava_lang_Object_ == IntPtr.Zero)
				id_toPrimitive_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (array);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Short_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Short[]']]"
		[Register ("toPrimitive", "([Ljava/lang/Short;)[S", "")]
		public static unsafe short[] ToPrimitive (global::Java.Lang.Short[] array)
		{
			if (id_toPrimitive_arrayLjava_lang_Short_ == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Short_ = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Short;)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Short_, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toPrimitive_arrayLjava_lang_Short_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toPrimitive' and count(parameter)=2 and parameter[1][@type='java.lang.Short[]'] and parameter[2][@type='short']]"
		[Register ("toPrimitive", "([Ljava/lang/Short;S)[S", "")]
		public static unsafe short[] ToPrimitive (global::Java.Lang.Short[] array, short valueForNull)
		{
			if (id_toPrimitive_arrayLjava_lang_Short_S == IntPtr.Zero)
				id_toPrimitive_arrayLjava_lang_Short_S = JNIEnv.GetStaticMethodID (class_ref, "toPrimitive", "([Ljava/lang/Short;S)[S");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (valueForNull);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrimitive_arrayLjava_lang_Short_S, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Object array)
		{
			if (id_toString_Ljava_lang_Object_ == IntPtr.Zero)
				id_toString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (array);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toString' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("toString", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Object array, string stringIfNull)
		{
			if (id_toString_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_toString_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_stringIfNull = JNIEnv.NewString (stringIfNull);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (array);
				__args [1] = new JValue (native_stringIfNull);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stringIfNull);
			}
		}

		static IntPtr id_toStringArray_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toStringArray' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("toStringArray", "([Ljava/lang/Object;)[Ljava/lang/String;", "")]
		public static unsafe string[] ToStringArray (global::Java.Lang.Object[] array)
		{
			if (id_toStringArray_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_toStringArray_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "toStringArray", "([Ljava/lang/Object;)[Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringArray_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static IntPtr id_toStringArray_arrayLjava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArrayUtils']/method[@name='toStringArray' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("toStringArray", "([Ljava/lang/Object;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] ToStringArray (global::Java.Lang.Object[] array, string valueForNullElements)
		{
			if (id_toStringArray_arrayLjava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_toStringArray_arrayLjava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toStringArray", "([Ljava/lang/Object;Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_valueForNullElements = JNIEnv.NewString (valueForNullElements);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_valueForNullElements);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringArray_arrayLjava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_valueForNullElements);
			}
		}

	}
}
