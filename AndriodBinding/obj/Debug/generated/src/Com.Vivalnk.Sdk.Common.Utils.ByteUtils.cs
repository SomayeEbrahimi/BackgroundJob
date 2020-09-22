using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/ByteUtils", DoNotGenerateAcw=true)]
	public partial class ByteUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/field[@name='BYTE_MAX']"
		[Register ("BYTE_MAX")]
		public const int ByteMax = (int) 255;

		static IntPtr EMPTY_BYTES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/field[@name='EMPTY_BYTES']"
		[Register ("EMPTY_BYTES")]
		public static IList<byte> EmptyBytes {
			get {
				if (EMPTY_BYTES_jfieldId == IntPtr.Zero)
					EMPTY_BYTES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_BYTES", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_BYTES_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/ByteUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteUtils); }
		}

		protected ByteUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/constructor[@name='ByteUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ByteUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ByteUtils)) {
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

		static IntPtr id_byte2Char_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2Char' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byte2Char", "([B)[C", "")]
		public static unsafe char[] Byte2Char (byte[] b)
		{
			if (id_byte2Char_arrayB == IntPtr.Zero)
				id_byte2Char_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byte2Char", "([B)[C");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_byte2Char_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_byte2CharOriginal_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2CharOriginal' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byte2CharOriginal", "([B)[C", "")]
		public static unsafe char[] Byte2CharOriginal (byte[] b)
		{
			if (id_byte2CharOriginal_arrayB == IntPtr.Zero)
				id_byte2CharOriginal_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byte2CharOriginal", "([B)[C");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_byte2CharOriginal_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_byte2Int2_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2Int2' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byte2Int2", "([B)I", "")]
		public static unsafe int Byte2Int2 (byte[] b)
		{
			if (id_byte2Int2_arrayB == IntPtr.Zero)
				id_byte2Int2_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byte2Int2", "([B)I");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_byte2Int2_arrayB, __args);
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_byte2IntByStream_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2IntByStream' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byte2IntByStream", "([B)I", "")]
		public static unsafe int Byte2IntByStream (byte[] b)
		{
			if (id_byte2IntByStream_arrayB == IntPtr.Zero)
				id_byte2IntByStream_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byte2IntByStream", "([B)I");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_byte2IntByStream_arrayB, __args);
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_byte2Long_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2Long' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("byte2Long", "([BI)J", "")]
		public static unsafe long Byte2Long (byte[] buf, int index)
		{
			if (id_byte2Long_arrayBI == IntPtr.Zero)
				id_byte2Long_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "byte2Long", "([BI)J");
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_buf);
				__args [1] = new JValue (index);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_byte2Long_arrayBI, __args);
				return __ret;
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
			}
		}

		static IntPtr id_byte2Short_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2Short' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byte2Short", "([B)S", "")]
		public static unsafe short Byte2Short (byte[] b)
		{
			if (id_byte2Short_arrayB == IntPtr.Zero)
				id_byte2Short_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byte2Short", "([B)S");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				short __ret = JNIEnv.CallStaticShortMethod  (class_ref, id_byte2Short_arrayB, __args);
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_byte2SignedInt_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2SignedInt' and count(parameter)=1 and parameter[1][@type='byte...']]"
		[Register ("byte2SignedInt", "([B)I", "")]
		public static unsafe int Byte2SignedInt (params byte[] args)
		{
			if (id_byte2SignedInt_arrayB == IntPtr.Zero)
				id_byte2SignedInt_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byte2SignedInt", "([B)I");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_args);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_byte2SignedInt_arrayB, __args);
				return __ret;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_byte2UnsignedInt_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2UnsignedInt' and count(parameter)=1 and parameter[1][@type='byte...']]"
		[Register ("byte2UnsignedInt", "([B)I", "")]
		public static unsafe int Byte2UnsignedInt (params byte[] args)
		{
			if (id_byte2UnsignedInt_arrayB == IntPtr.Zero)
				id_byte2UnsignedInt_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byte2UnsignedInt", "([B)I");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_args);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_byte2UnsignedInt_arrayB, __args);
				return __ret;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static IntPtr id_byteEquals_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byteEquals' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("byteEquals", "([B[B)Z", "")]
		public static unsafe bool ByteEquals (byte[] lbytes, byte[] rbytes)
		{
			if (id_byteEquals_arrayBarrayB == IntPtr.Zero)
				id_byteEquals_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "byteEquals", "([B[B)Z");
			IntPtr native_lbytes = JNIEnv.NewArray (lbytes);
			IntPtr native_rbytes = JNIEnv.NewArray (rbytes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lbytes);
				__args [1] = new JValue (native_rbytes);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_byteEquals_arrayBarrayB, __args);
				return __ret;
			} finally {
				if (lbytes != null) {
					JNIEnv.CopyArray (native_lbytes, lbytes);
					JNIEnv.DeleteLocalRef (native_lbytes);
				}
				if (rbytes != null) {
					JNIEnv.CopyArray (native_rbytes, rbytes);
					JNIEnv.DeleteLocalRef (native_rbytes);
				}
			}
		}

		static IntPtr id_byteToString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byteToString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byteToString", "([B)Ljava/lang/String;", "")]
		public static unsafe string ByteToString (byte[] bytes)
		{
			if (id_byteToString_arrayB == IntPtr.Zero)
				id_byteToString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byteToString", "([B)Ljava/lang/String;");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteToString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_char2Byte_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='char2Byte' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("char2Byte", "(C)B", "")]
		public static unsafe sbyte Char2Byte (char c)
		{
			if (id_char2Byte_C == IntPtr.Zero)
				id_char2Byte_C = JNIEnv.GetStaticMethodID (class_ref, "char2Byte", "(C)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (c);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_char2Byte_C, __args);
			} finally {
			}
		}

		static IntPtr id_char2Byte_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='char2Byte' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("char2Byte", "([C)[B", "")]
		public static unsafe byte[] Char2Byte (char[] c)
		{
			if (id_char2Byte_arrayC == IntPtr.Zero)
				id_char2Byte_arrayC = JNIEnv.GetStaticMethodID (class_ref, "char2Byte", "([C)[B");
			IntPtr native_c = JNIEnv.NewArray (c);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_c);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_char2Byte_arrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (c != null) {
					JNIEnv.CopyArray (native_c, c);
					JNIEnv.DeleteLocalRef (native_c);
				}
			}
		}

		static IntPtr id_copy_arrayBarrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='copy' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("copy", "([B[BII)V", "")]
		public static unsafe void Copy (byte[] lbytes, byte[] rbytes, int lstart, int rstart)
		{
			if (id_copy_arrayBarrayBII == IntPtr.Zero)
				id_copy_arrayBarrayBII = JNIEnv.GetStaticMethodID (class_ref, "copy", "([B[BII)V");
			IntPtr native_lbytes = JNIEnv.NewArray (lbytes);
			IntPtr native_rbytes = JNIEnv.NewArray (rbytes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_lbytes);
				__args [1] = new JValue (native_rbytes);
				__args [2] = new JValue (lstart);
				__args [3] = new JValue (rstart);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copy_arrayBarrayBII, __args);
			} finally {
				if (lbytes != null) {
					JNIEnv.CopyArray (native_lbytes, lbytes);
					JNIEnv.DeleteLocalRef (native_lbytes);
				}
				if (rbytes != null) {
					JNIEnv.CopyArray (native_rbytes, rbytes);
					JNIEnv.DeleteLocalRef (native_rbytes);
				}
			}
		}

		static IntPtr id_cutAfterBytes_arrayBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='cutAfterBytes' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register ("cutAfterBytes", "([BB)[B", "")]
		public static unsafe byte[] CutAfterBytes (byte[] bytes, sbyte cut)
		{
			if (id_cutAfterBytes_arrayBB == IntPtr.Zero)
				id_cutAfterBytes_arrayBB = JNIEnv.GetStaticMethodID (class_ref, "cutAfterBytes", "([BB)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_bytes);
				__args [1] = new JValue (cut);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_cutAfterBytes_arrayBB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_cutBeforeBytes_arrayBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='cutBeforeBytes' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register ("cutBeforeBytes", "([BB)[B", "")]
		public static unsafe byte[] CutBeforeBytes (byte[] bytes, sbyte cut)
		{
			if (id_cutBeforeBytes_arrayBB == IntPtr.Zero)
				id_cutBeforeBytes_arrayBB = JNIEnv.GetStaticMethodID (class_ref, "cutBeforeBytes", "([BB)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_bytes);
				__args [1] = new JValue (cut);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_cutBeforeBytes_arrayBB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_equals_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("equals", "([B[B)Z", "")]
		public static unsafe bool Equals (byte[] array1, byte[] array2)
		{
			if (id_equals_arrayBarrayB == IntPtr.Zero)
				id_equals_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "equals", "([B[B)Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_arrayBarrayB, __args);
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

		static IntPtr id_equals_arrayBarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='equals' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("equals", "([B[BI)Z", "")]
		public static unsafe bool Equals (byte[] array1, byte[] array2, int len)
		{
			if (id_equals_arrayBarrayBI == IntPtr.Zero)
				id_equals_arrayBarrayBI = JNIEnv.GetStaticMethodID (class_ref, "equals", "([B[BI)Z");
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_array1);
				__args [1] = new JValue (native_array2);
				__args [2] = new JValue (len);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_arrayBarrayBI, __args);
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

		static IntPtr id_fillBeforeBytes_arrayBIB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='fillBeforeBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte']]"
		[Register ("fillBeforeBytes", "([BIB)[B", "")]
		public static unsafe byte[] FillBeforeBytes (byte[] bytes, int len, sbyte fill)
		{
			if (id_fillBeforeBytes_arrayBIB == IntPtr.Zero)
				id_fillBeforeBytes_arrayBIB = JNIEnv.GetStaticMethodID (class_ref, "fillBeforeBytes", "([BIB)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_bytes);
				__args [1] = new JValue (len);
				__args [2] = new JValue (fill);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fillBeforeBytes_arrayBIB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_fromInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='fromInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromInt", "(I)[B", "")]
		public static unsafe byte[] FromInt (int n)
		{
			if (id_fromInt_I == IntPtr.Zero)
				id_fromInt_I = JNIEnv.GetStaticMethodID (class_ref, "fromInt", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (n);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromInt_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_fromLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='fromLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("fromLong", "(J)[B", "")]
		public static unsafe byte[] FromLong (long n)
		{
			if (id_fromLong_J == IntPtr.Zero)
				id_fromLong_J = JNIEnv.GetStaticMethodID (class_ref, "fromLong", "(J)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (n);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromLong_J, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_fromShort_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='fromShort' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("fromShort", "(S)[B", "")]
		public static unsafe byte[] FromShort (short n)
		{
			if (id_fromShort_S == IntPtr.Zero)
				id_fromShort_S = JNIEnv.GetStaticMethodID (class_ref, "fromShort", "(S)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (n);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromShort_S, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_get_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='get' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("get", "([BI)[B", "")]
		public static unsafe byte[] Get (byte[] bytes, int offset)
		{
			if (id_get_arrayBI == IntPtr.Zero)
				id_get_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "get", "([BI)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_bytes);
				__args [1] = new JValue (offset);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_arrayBI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_get_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='get' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("get", "([BII)[B", "")]
		public static unsafe byte[] Get (byte[] bytes, int offset, int len)
		{
			if (id_get_arrayBII == IntPtr.Zero)
				id_get_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "get", "([BII)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_bytes);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (len);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_arrayBII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_getByte_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("getByte", "(C)B", "")]
		public static unsafe sbyte GetByte (char c)
		{
			if (id_getByte_C == IntPtr.Zero)
				id_getByte_C = JNIEnv.GetStaticMethodID (class_ref, "getByte", "(C)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (c);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_getByte_C, __args);
			} finally {
			}
		}

		static IntPtr id_getBytes_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getBytes", "([BII)[B", "")]
		public static unsafe byte[] GetBytes (byte[] bytes, int start, int end)
		{
			if (id_getBytes_arrayBII == IntPtr.Zero)
				id_getBytes_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "getBytes", "([BII)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_bytes);
				__args [1] = new JValue (start);
				__args [2] = new JValue (end);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytes_arrayBII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_getBytes_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("getBytes", "([C)[B", "")]
		public static unsafe byte[] GetBytes (char[] chars)
		{
			if (id_getBytes_arrayC == IntPtr.Zero)
				id_getBytes_arrayC = JNIEnv.GetStaticMethodID (class_ref, "getBytes", "([C)[B");
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_chars);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytes_arrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		static IntPtr id_getChar_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getChar' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("getChar", "(B)C", "")]
		public static unsafe char GetChar (sbyte bytes)
		{
			if (id_getChar_B == IntPtr.Zero)
				id_getChar_B = JNIEnv.GetStaticMethodID (class_ref, "getChar", "(B)C");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bytes);
				return JNIEnv.CallStaticCharMethod  (class_ref, id_getChar_B, __args);
			} finally {
			}
		}

		static IntPtr id_getChars_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getChars' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getChars", "([B)[C", "")]
		public static unsafe char[] GetChars (byte[] bytes)
		{
			if (id_getChars_arrayB == IntPtr.Zero)
				id_getChars_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getChars", "([B)[C");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getChars_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_getNonEmptyByte_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getNonEmptyByte' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getNonEmptyByte", "([B)[B", "")]
		public static unsafe byte[] GetNonEmptyByte (byte[] bytes)
		{
			if (id_getNonEmptyByte_arrayB == IntPtr.Zero)
				id_getNonEmptyByte_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getNonEmptyByte", "([B)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNonEmptyByte_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_getRawData_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getRawData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getRawData", "([B)Ljava/lang/String;", "")]
		public static unsafe string GetRawData (byte[] btValues)
		{
			if (id_getRawData_arrayB == IntPtr.Zero)
				id_getRawData_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getRawData", "([B)Ljava/lang/String;");
			IntPtr native_btValues = JNIEnv.NewArray (btValues);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_btValues);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRawData_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (btValues != null) {
					JNIEnv.CopyArray (native_btValues, btValues);
					JNIEnv.DeleteLocalRef (native_btValues);
				}
			}
		}

		static IntPtr id_getUnSignedLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getUnSignedLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getUnSignedLong", "(J)J", "")]
		public static unsafe long GetUnSignedLong (long l)
		{
			if (id_getUnSignedLong_J == IntPtr.Zero)
				id_getUnSignedLong_J = JNIEnv.GetStaticMethodID (class_ref, "getUnSignedLong", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (l);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_getUnSignedLong_J, __args);
			} finally {
			}
		}

		static IntPtr id_getUnsignedByte_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getUnsignedByte' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("getUnsignedByte", "(B)I", "")]
		public static unsafe int GetUnsignedByte (sbyte data)
		{
			if (id_getUnsignedByte_B == IntPtr.Zero)
				id_getUnsignedByte_B = JNIEnv.GetStaticMethodID (class_ref, "getUnsignedByte", "(B)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (data);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getUnsignedByte_B, __args);
			} finally {
			}
		}

		static IntPtr id_getUnsignedInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getUnsignedInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUnsignedInt", "(I)J", "")]
		public static unsafe long GetUnsignedInt (int data)
		{
			if (id_getUnsignedInt_I == IntPtr.Zero)
				id_getUnsignedInt_I = JNIEnv.GetStaticMethodID (class_ref, "getUnsignedInt", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (data);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_getUnsignedInt_I, __args);
			} finally {
			}
		}

		static IntPtr id_getUnsignedShort_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getUnsignedShort' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("getUnsignedShort", "(S)I", "")]
		public static unsafe int GetUnsignedShort (short data)
		{
			if (id_getUnsignedShort_S == IntPtr.Zero)
				id_getUnsignedShort_S = JNIEnv.GetStaticMethodID (class_ref, "getUnsignedShort", "(S)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (data);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getUnsignedShort_S, __args);
			} finally {
			}
		}

		static IntPtr id_int2Byte_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='int2Byte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("int2Byte", "(I)[B", "")]
		public static unsafe byte[] Int2Byte (int res)
		{
			if (id_int2Byte_I == IntPtr.Zero)
				id_int2Byte_I = JNIEnv.GetStaticMethodID (class_ref, "int2Byte", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (res);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_int2Byte_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_intArray2ByteArray_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='intArray2ByteArray' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("intArray2ByteArray", "([I)[B", "")]
		public static unsafe byte[] IntArray2ByteArray (int[] srcArray)
		{
			if (id_intArray2ByteArray_arrayI == IntPtr.Zero)
				id_intArray2ByteArray_arrayI = JNIEnv.GetStaticMethodID (class_ref, "intArray2ByteArray", "([I)[B");
			IntPtr native_srcArray = JNIEnv.NewArray (srcArray);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_srcArray);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_intArray2ByteArray_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (srcArray != null) {
					JNIEnv.CopyArray (native_srcArray, srcArray);
					JNIEnv.DeleteLocalRef (native_srcArray);
				}
			}
		}

		static IntPtr id_isAllFF_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='isAllFF' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isAllFF", "([B)Z", "")]
		public static unsafe bool IsAllFF (byte[] bytes)
		{
			if (id_isAllFF_arrayB == IntPtr.Zero)
				id_isAllFF_arrayB = JNIEnv.GetStaticMethodID (class_ref, "isAllFF", "([B)Z");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAllFF_arrayB, __args);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_isEmpty_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isEmpty", "([B)Z", "")]
		public static unsafe bool IsEmpty (byte[] bytes)
		{
			if (id_isEmpty_arrayB == IntPtr.Zero)
				id_isEmpty_arrayB = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "([B)Z");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_arrayB, __args);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_long2Dword_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='long2Dword' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("long2Dword", "(J)[B", "")]
		public static unsafe byte[] Long2Dword (long value)
		{
			if (id_long2Dword_J == IntPtr.Zero)
				id_long2Dword_J = JNIEnv.GetStaticMethodID (class_ref, "long2Dword", "(J)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_long2Dword_J, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_reverse_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("reverse", "([B)[B", "")]
		public static unsafe byte[] Reverse (byte[] b)
		{
			if (id_reverse_arrayB == IntPtr.Zero)
				id_reverse_arrayB = JNIEnv.GetStaticMethodID (class_ref, "reverse", "([B)[B");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_reverse_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_short2Byte_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='short2Byte' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("short2Byte", "(S)[B", "")]
		public static unsafe byte[] Short2Byte (short number)
		{
			if (id_short2Byte_S == IntPtr.Zero)
				id_short2Byte_S = JNIEnv.GetStaticMethodID (class_ref, "short2Byte", "(S)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (number);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_short2Byte_S, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_stringToBytes_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='stringToBytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringToBytes", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] StringToBytes (string text)
		{
			if (id_stringToBytes_Ljava_lang_String_ == IntPtr.Zero)
				id_stringToBytes_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stringToBytes", "(Ljava/lang/String;)[B");
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_text);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_stringToBytes_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static IntPtr id_toUnsignedInt_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='toUnsignedInt' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toUnsignedInt", "(B)I", "")]
		public static unsafe int ToUnsignedInt (sbyte x)
		{
			if (id_toUnsignedInt_B == IntPtr.Zero)
				id_toUnsignedInt_B = JNIEnv.GetStaticMethodID (class_ref, "toUnsignedInt", "(B)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (x);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_toUnsignedInt_B, __args);
			} finally {
			}
		}

		static IntPtr id_toUnsignedLong_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='toUnsignedLong' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toUnsignedLong", "(B)J", "")]
		public static unsafe long ToUnsignedLong (sbyte x)
		{
			if (id_toUnsignedLong_B == IntPtr.Zero)
				id_toUnsignedLong_B = JNIEnv.GetStaticMethodID (class_ref, "toUnsignedLong", "(B)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (x);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_toUnsignedLong_B, __args);
			} finally {
			}
		}

		static IntPtr id_trimLast_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='trimLast' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("trimLast", "([B)[B", "")]
		public static unsafe byte[] TrimLast (byte[] bytes)
		{
			if (id_trimLast_arrayB == IntPtr.Zero)
				id_trimLast_arrayB = JNIEnv.GetStaticMethodID (class_ref, "trimLast", "([B)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_trimLast_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_ubyteToInt_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='ubyteToInt' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("ubyteToInt", "(B)I", "")]
		public static unsafe int UbyteToInt (sbyte b)
		{
			if (id_ubyteToInt_B == IntPtr.Zero)
				id_ubyteToInt_B = JNIEnv.GetStaticMethodID (class_ref, "ubyteToInt", "(B)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (b);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_ubyteToInt_B, __args);
			} finally {
			}
		}

	}
}
