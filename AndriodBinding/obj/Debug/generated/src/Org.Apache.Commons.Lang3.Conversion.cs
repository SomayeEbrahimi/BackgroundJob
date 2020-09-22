using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/Conversion", DoNotGenerateAcw=true)]
	public partial class Conversion : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/Conversion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Conversion); }
		}

		protected Conversion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/constructor[@name='Conversion' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Conversion ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Conversion)) {
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

		static IntPtr id_binaryBeMsb0ToHexDigit_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='binaryBeMsb0ToHexDigit' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("binaryBeMsb0ToHexDigit", "([Z)C", "")]
		public static unsafe char BinaryBeMsb0ToHexDigit (bool[] src)
		{
			if (id_binaryBeMsb0ToHexDigit_arrayZ == IntPtr.Zero)
				id_binaryBeMsb0ToHexDigit_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "binaryBeMsb0ToHexDigit", "([Z)C");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_src);
				char __ret = JNIEnv.CallStaticCharMethod  (class_ref, id_binaryBeMsb0ToHexDigit_arrayZ, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_binaryBeMsb0ToHexDigit_arrayZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='binaryBeMsb0ToHexDigit' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='int']]"
		[Register ("binaryBeMsb0ToHexDigit", "([ZI)C", "")]
		public static unsafe char BinaryBeMsb0ToHexDigit (bool[] src, int srcPos)
		{
			if (id_binaryBeMsb0ToHexDigit_arrayZI == IntPtr.Zero)
				id_binaryBeMsb0ToHexDigit_arrayZI = JNIEnv.GetStaticMethodID (class_ref, "binaryBeMsb0ToHexDigit", "([ZI)C");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				char __ret = JNIEnv.CallStaticCharMethod  (class_ref, id_binaryBeMsb0ToHexDigit_arrayZI, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_binaryToByte_arrayZIBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='binaryToByte' and count(parameter)=5 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='byte'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("binaryToByte", "([ZIBII)B", "")]
		public static unsafe sbyte BinaryToByte (bool[] src, int srcPos, sbyte dstInit, int dstPos, int nBools)
		{
			if (id_binaryToByte_arrayZIBII == IntPtr.Zero)
				id_binaryToByte_arrayZIBII = JNIEnv.GetStaticMethodID (class_ref, "binaryToByte", "([ZIBII)B");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBools);
				sbyte __ret = JNIEnv.CallStaticByteMethod  (class_ref, id_binaryToByte_arrayZIBII, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_binaryToHexDigit_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='binaryToHexDigit' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("binaryToHexDigit", "([Z)C", "")]
		public static unsafe char BinaryToHexDigit (bool[] src)
		{
			if (id_binaryToHexDigit_arrayZ == IntPtr.Zero)
				id_binaryToHexDigit_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "binaryToHexDigit", "([Z)C");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_src);
				char __ret = JNIEnv.CallStaticCharMethod  (class_ref, id_binaryToHexDigit_arrayZ, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_binaryToHexDigit_arrayZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='binaryToHexDigit' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='int']]"
		[Register ("binaryToHexDigit", "([ZI)C", "")]
		public static unsafe char BinaryToHexDigit (bool[] src, int srcPos)
		{
			if (id_binaryToHexDigit_arrayZI == IntPtr.Zero)
				id_binaryToHexDigit_arrayZI = JNIEnv.GetStaticMethodID (class_ref, "binaryToHexDigit", "([ZI)C");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				char __ret = JNIEnv.CallStaticCharMethod  (class_ref, id_binaryToHexDigit_arrayZI, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_binaryToHexDigitMsb0_4bits_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='binaryToHexDigitMsb0_4bits' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("binaryToHexDigitMsb0_4bits", "([Z)C", "")]
		public static unsafe char BinaryToHexDigitMsb0_4bits (bool[] src)
		{
			if (id_binaryToHexDigitMsb0_4bits_arrayZ == IntPtr.Zero)
				id_binaryToHexDigitMsb0_4bits_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "binaryToHexDigitMsb0_4bits", "([Z)C");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_src);
				char __ret = JNIEnv.CallStaticCharMethod  (class_ref, id_binaryToHexDigitMsb0_4bits_arrayZ, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_binaryToHexDigitMsb0_4bits_arrayZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='binaryToHexDigitMsb0_4bits' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='int']]"
		[Register ("binaryToHexDigitMsb0_4bits", "([ZI)C", "")]
		public static unsafe char BinaryToHexDigitMsb0_4bits (bool[] src, int srcPos)
		{
			if (id_binaryToHexDigitMsb0_4bits_arrayZI == IntPtr.Zero)
				id_binaryToHexDigitMsb0_4bits_arrayZI = JNIEnv.GetStaticMethodID (class_ref, "binaryToHexDigitMsb0_4bits", "([ZI)C");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				char __ret = JNIEnv.CallStaticCharMethod  (class_ref, id_binaryToHexDigitMsb0_4bits_arrayZI, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_binaryToInt_arrayZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='binaryToInt' and count(parameter)=5 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("binaryToInt", "([ZIIII)I", "")]
		public static unsafe int BinaryToInt (bool[] src, int srcPos, int dstInit, int dstPos, int nBools)
		{
			if (id_binaryToInt_arrayZIIII == IntPtr.Zero)
				id_binaryToInt_arrayZIIII = JNIEnv.GetStaticMethodID (class_ref, "binaryToInt", "([ZIIII)I");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBools);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_binaryToInt_arrayZIIII, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_binaryToLong_arrayZIJII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='binaryToLong' and count(parameter)=5 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("binaryToLong", "([ZIJII)J", "")]
		public static unsafe long BinaryToLong (bool[] src, int srcPos, long dstInit, int dstPos, int nBools)
		{
			if (id_binaryToLong_arrayZIJII == IntPtr.Zero)
				id_binaryToLong_arrayZIJII = JNIEnv.GetStaticMethodID (class_ref, "binaryToLong", "([ZIJII)J");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBools);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_binaryToLong_arrayZIJII, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_binaryToShort_arrayZISII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='binaryToShort' and count(parameter)=5 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='short'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("binaryToShort", "([ZISII)S", "")]
		public static unsafe short BinaryToShort (bool[] src, int srcPos, short dstInit, int dstPos, int nBools)
		{
			if (id_binaryToShort_arrayZISII == IntPtr.Zero)
				id_binaryToShort_arrayZISII = JNIEnv.GetStaticMethodID (class_ref, "binaryToShort", "([ZISII)S");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBools);
				short __ret = JNIEnv.CallStaticShortMethod  (class_ref, id_binaryToShort_arrayZISII, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_byteArrayToInt_arrayBIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='byteArrayToInt' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("byteArrayToInt", "([BIIII)I", "")]
		public static unsafe int ByteArrayToInt (byte[] src, int srcPos, int dstInit, int dstPos, int nBytes)
		{
			if (id_byteArrayToInt_arrayBIIII == IntPtr.Zero)
				id_byteArrayToInt_arrayBIIII = JNIEnv.GetStaticMethodID (class_ref, "byteArrayToInt", "([BIIII)I");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBytes);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_byteArrayToInt_arrayBIIII, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_byteArrayToLong_arrayBIJII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='byteArrayToLong' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("byteArrayToLong", "([BIJII)J", "")]
		public static unsafe long ByteArrayToLong (byte[] src, int srcPos, long dstInit, int dstPos, int nBytes)
		{
			if (id_byteArrayToLong_arrayBIJII == IntPtr.Zero)
				id_byteArrayToLong_arrayBIJII = JNIEnv.GetStaticMethodID (class_ref, "byteArrayToLong", "([BIJII)J");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBytes);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_byteArrayToLong_arrayBIJII, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_byteArrayToShort_arrayBISII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='byteArrayToShort' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='short'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("byteArrayToShort", "([BISII)S", "")]
		public static unsafe short ByteArrayToShort (byte[] src, int srcPos, short dstInit, int dstPos, int nBytes)
		{
			if (id_byteArrayToShort_arrayBISII == IntPtr.Zero)
				id_byteArrayToShort_arrayBISII = JNIEnv.GetStaticMethodID (class_ref, "byteArrayToShort", "([BISII)S");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBytes);
				short __ret = JNIEnv.CallStaticShortMethod  (class_ref, id_byteArrayToShort_arrayBISII, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_byteArrayToUuid_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='byteArrayToUuid' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("byteArrayToUuid", "([BI)Ljava/util/UUID;", "")]
		public static unsafe global::Java.Util.UUID ByteArrayToUuid (byte[] src, int srcPos)
		{
			if (id_byteArrayToUuid_arrayBI == IntPtr.Zero)
				id_byteArrayToUuid_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "byteArrayToUuid", "([BI)Ljava/util/UUID;");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				global::Java.Util.UUID __ret = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteArrayToUuid_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_byteToBinary_BIarrayZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='byteToBinary' and count(parameter)=5 and parameter[1][@type='byte'] and parameter[2][@type='int'] and parameter[3][@type='boolean[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("byteToBinary", "(BI[ZII)[Z", "")]
		public static unsafe bool[] ByteToBinary (sbyte src, int srcPos, bool[] dst, int dstPos, int nBools)
		{
			if (id_byteToBinary_BIarrayZII == IntPtr.Zero)
				id_byteToBinary_BIarrayZII = JNIEnv.GetStaticMethodID (class_ref, "byteToBinary", "(BI[ZII)[Z");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dst);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBools);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteToBinary_BIarrayZII, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_byteToHex_BILjava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='byteToHex' and count(parameter)=5 and parameter[1][@type='byte'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("byteToHex", "(BILjava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string ByteToHex (sbyte src, int srcPos, string dstInit, int dstPos, int nHexs)
		{
			if (id_byteToHex_BILjava_lang_String_II == IntPtr.Zero)
				id_byteToHex_BILjava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "byteToHex", "(BILjava/lang/String;II)Ljava/lang/String;");
			IntPtr native_dstInit = JNIEnv.NewString (dstInit);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nHexs);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteToHex_BILjava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_dstInit);
			}
		}

		static IntPtr id_hexDigitMsb0ToBinary_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='hexDigitMsb0ToBinary' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("hexDigitMsb0ToBinary", "(C)[Z", "")]
		public static unsafe bool[] HexDigitMsb0ToBinary (char hexDigit)
		{
			if (id_hexDigitMsb0ToBinary_C == IntPtr.Zero)
				id_hexDigitMsb0ToBinary_C = JNIEnv.GetStaticMethodID (class_ref, "hexDigitMsb0ToBinary", "(C)[Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (hexDigit);
				return (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexDigitMsb0ToBinary_C, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

		static IntPtr id_hexDigitMsb0ToInt_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='hexDigitMsb0ToInt' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("hexDigitMsb0ToInt", "(C)I", "")]
		public static unsafe int HexDigitMsb0ToInt (char hexDigit)
		{
			if (id_hexDigitMsb0ToInt_C == IntPtr.Zero)
				id_hexDigitMsb0ToInt_C = JNIEnv.GetStaticMethodID (class_ref, "hexDigitMsb0ToInt", "(C)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (hexDigit);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_hexDigitMsb0ToInt_C, __args);
			} finally {
			}
		}

		static IntPtr id_hexDigitToBinary_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='hexDigitToBinary' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("hexDigitToBinary", "(C)[Z", "")]
		public static unsafe bool[] HexDigitToBinary (char hexDigit)
		{
			if (id_hexDigitToBinary_C == IntPtr.Zero)
				id_hexDigitToBinary_C = JNIEnv.GetStaticMethodID (class_ref, "hexDigitToBinary", "(C)[Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (hexDigit);
				return (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexDigitToBinary_C, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

		static IntPtr id_hexDigitToInt_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='hexDigitToInt' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("hexDigitToInt", "(C)I", "")]
		public static unsafe int HexDigitToInt (char hexDigit)
		{
			if (id_hexDigitToInt_C == IntPtr.Zero)
				id_hexDigitToInt_C = JNIEnv.GetStaticMethodID (class_ref, "hexDigitToInt", "(C)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (hexDigit);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_hexDigitToInt_C, __args);
			} finally {
			}
		}

		static IntPtr id_hexToByte_Ljava_lang_String_IBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='hexToByte' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='byte'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("hexToByte", "(Ljava/lang/String;IBII)B", "")]
		public static unsafe sbyte HexToByte (string src, int srcPos, sbyte dstInit, int dstPos, int nHex)
		{
			if (id_hexToByte_Ljava_lang_String_IBII == IntPtr.Zero)
				id_hexToByte_Ljava_lang_String_IBII = JNIEnv.GetStaticMethodID (class_ref, "hexToByte", "(Ljava/lang/String;IBII)B");
			IntPtr native_src = JNIEnv.NewString (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nHex);
				sbyte __ret = JNIEnv.CallStaticByteMethod  (class_ref, id_hexToByte_Ljava_lang_String_IBII, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_src);
			}
		}

		static IntPtr id_hexToInt_Ljava_lang_String_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='hexToInt' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("hexToInt", "(Ljava/lang/String;IIII)I", "")]
		public static unsafe int HexToInt (string src, int srcPos, int dstInit, int dstPos, int nHex)
		{
			if (id_hexToInt_Ljava_lang_String_IIII == IntPtr.Zero)
				id_hexToInt_Ljava_lang_String_IIII = JNIEnv.GetStaticMethodID (class_ref, "hexToInt", "(Ljava/lang/String;IIII)I");
			IntPtr native_src = JNIEnv.NewString (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nHex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hexToInt_Ljava_lang_String_IIII, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_src);
			}
		}

		static IntPtr id_hexToLong_Ljava_lang_String_IJII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='hexToLong' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("hexToLong", "(Ljava/lang/String;IJII)J", "")]
		public static unsafe long HexToLong (string src, int srcPos, long dstInit, int dstPos, int nHex)
		{
			if (id_hexToLong_Ljava_lang_String_IJII == IntPtr.Zero)
				id_hexToLong_Ljava_lang_String_IJII = JNIEnv.GetStaticMethodID (class_ref, "hexToLong", "(Ljava/lang/String;IJII)J");
			IntPtr native_src = JNIEnv.NewString (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nHex);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_hexToLong_Ljava_lang_String_IJII, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_src);
			}
		}

		static IntPtr id_hexToShort_Ljava_lang_String_ISII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='hexToShort' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='short'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("hexToShort", "(Ljava/lang/String;ISII)S", "")]
		public static unsafe short HexToShort (string src, int srcPos, short dstInit, int dstPos, int nHex)
		{
			if (id_hexToShort_Ljava_lang_String_ISII == IntPtr.Zero)
				id_hexToShort_Ljava_lang_String_ISII = JNIEnv.GetStaticMethodID (class_ref, "hexToShort", "(Ljava/lang/String;ISII)S");
			IntPtr native_src = JNIEnv.NewString (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nHex);
				short __ret = JNIEnv.CallStaticShortMethod  (class_ref, id_hexToShort_Ljava_lang_String_ISII, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_src);
			}
		}

		static IntPtr id_intArrayToLong_arrayIIJII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='intArrayToLong' and count(parameter)=5 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("intArrayToLong", "([IIJII)J", "")]
		public static unsafe long IntArrayToLong (int[] src, int srcPos, long dstInit, int dstPos, int nInts)
		{
			if (id_intArrayToLong_arrayIIJII == IntPtr.Zero)
				id_intArrayToLong_arrayIIJII = JNIEnv.GetStaticMethodID (class_ref, "intArrayToLong", "([IIJII)J");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nInts);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_intArrayToLong_arrayIIJII, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_intToBinary_IIarrayZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='intToBinary' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("intToBinary", "(II[ZII)[Z", "")]
		public static unsafe bool[] IntToBinary (int src, int srcPos, bool[] dst, int dstPos, int nBools)
		{
			if (id_intToBinary_IIarrayZII == IntPtr.Zero)
				id_intToBinary_IIarrayZII = JNIEnv.GetStaticMethodID (class_ref, "intToBinary", "(II[ZII)[Z");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dst);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBools);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_intToBinary_IIarrayZII, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_intToByteArray_IIarrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='intToByteArray' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("intToByteArray", "(II[BII)[B", "")]
		public static unsafe byte[] IntToByteArray (int src, int srcPos, byte[] dst, int dstPos, int nBytes)
		{
			if (id_intToByteArray_IIarrayBII == IntPtr.Zero)
				id_intToByteArray_IIarrayBII = JNIEnv.GetStaticMethodID (class_ref, "intToByteArray", "(II[BII)[B");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dst);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBytes);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_intToByteArray_IIarrayBII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_intToHex_IILjava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='intToHex' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("intToHex", "(IILjava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string IntToHex (int src, int srcPos, string dstInit, int dstPos, int nHexs)
		{
			if (id_intToHex_IILjava_lang_String_II == IntPtr.Zero)
				id_intToHex_IILjava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "intToHex", "(IILjava/lang/String;II)Ljava/lang/String;");
			IntPtr native_dstInit = JNIEnv.NewString (dstInit);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nHexs);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_intToHex_IILjava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_dstInit);
			}
		}

		static IntPtr id_intToHexDigit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='intToHexDigit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("intToHexDigit", "(I)C", "")]
		public static unsafe char IntToHexDigit (int nibble)
		{
			if (id_intToHexDigit_I == IntPtr.Zero)
				id_intToHexDigit_I = JNIEnv.GetStaticMethodID (class_ref, "intToHexDigit", "(I)C");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (nibble);
				return JNIEnv.CallStaticCharMethod  (class_ref, id_intToHexDigit_I, __args);
			} finally {
			}
		}

		static IntPtr id_intToHexDigitMsb0_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='intToHexDigitMsb0' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("intToHexDigitMsb0", "(I)C", "")]
		public static unsafe char IntToHexDigitMsb0 (int nibble)
		{
			if (id_intToHexDigitMsb0_I == IntPtr.Zero)
				id_intToHexDigitMsb0_I = JNIEnv.GetStaticMethodID (class_ref, "intToHexDigitMsb0", "(I)C");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (nibble);
				return JNIEnv.CallStaticCharMethod  (class_ref, id_intToHexDigitMsb0_I, __args);
			} finally {
			}
		}

		static IntPtr id_intToShortArray_IIarraySII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='intToShortArray' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='short[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("intToShortArray", "(II[SII)[S", "")]
		public static unsafe short[] IntToShortArray (int src, int srcPos, short[] dst, int dstPos, int nShorts)
		{
			if (id_intToShortArray_IIarraySII == IntPtr.Zero)
				id_intToShortArray_IIarraySII = JNIEnv.GetStaticMethodID (class_ref, "intToShortArray", "(II[SII)[S");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dst);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nShorts);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_intToShortArray_IIarraySII, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_longToBinary_JIarrayZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='longToBinary' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='boolean[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("longToBinary", "(JI[ZII)[Z", "")]
		public static unsafe bool[] LongToBinary (long src, int srcPos, bool[] dst, int dstPos, int nBools)
		{
			if (id_longToBinary_JIarrayZII == IntPtr.Zero)
				id_longToBinary_JIarrayZII = JNIEnv.GetStaticMethodID (class_ref, "longToBinary", "(JI[ZII)[Z");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dst);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBools);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_longToBinary_JIarrayZII, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_longToByteArray_JIarrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='longToByteArray' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("longToByteArray", "(JI[BII)[B", "")]
		public static unsafe byte[] LongToByteArray (long src, int srcPos, byte[] dst, int dstPos, int nBytes)
		{
			if (id_longToByteArray_JIarrayBII == IntPtr.Zero)
				id_longToByteArray_JIarrayBII = JNIEnv.GetStaticMethodID (class_ref, "longToByteArray", "(JI[BII)[B");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dst);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBytes);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_longToByteArray_JIarrayBII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_longToHex_JILjava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='longToHex' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("longToHex", "(JILjava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string LongToHex (long src, int srcPos, string dstInit, int dstPos, int nHexs)
		{
			if (id_longToHex_JILjava_lang_String_II == IntPtr.Zero)
				id_longToHex_JILjava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "longToHex", "(JILjava/lang/String;II)Ljava/lang/String;");
			IntPtr native_dstInit = JNIEnv.NewString (dstInit);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nHexs);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_longToHex_JILjava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_dstInit);
			}
		}

		static IntPtr id_longToIntArray_JIarrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='longToIntArray' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("longToIntArray", "(JI[III)[I", "")]
		public static unsafe int[] LongToIntArray (long src, int srcPos, int[] dst, int dstPos, int nInts)
		{
			if (id_longToIntArray_JIarrayIII == IntPtr.Zero)
				id_longToIntArray_JIarrayIII = JNIEnv.GetStaticMethodID (class_ref, "longToIntArray", "(JI[III)[I");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dst);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nInts);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_longToIntArray_JIarrayIII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_longToShortArray_JIarraySII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='longToShortArray' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='short[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("longToShortArray", "(JI[SII)[S", "")]
		public static unsafe short[] LongToShortArray (long src, int srcPos, short[] dst, int dstPos, int nShorts)
		{
			if (id_longToShortArray_JIarraySII == IntPtr.Zero)
				id_longToShortArray_JIarraySII = JNIEnv.GetStaticMethodID (class_ref, "longToShortArray", "(JI[SII)[S");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dst);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nShorts);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_longToShortArray_JIarraySII, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_shortArrayToInt_arraySIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='shortArrayToInt' and count(parameter)=5 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("shortArrayToInt", "([SIIII)I", "")]
		public static unsafe int ShortArrayToInt (short[] src, int srcPos, int dstInit, int dstPos, int nShorts)
		{
			if (id_shortArrayToInt_arraySIIII == IntPtr.Zero)
				id_shortArrayToInt_arraySIIII = JNIEnv.GetStaticMethodID (class_ref, "shortArrayToInt", "([SIIII)I");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nShorts);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_shortArrayToInt_arraySIIII, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_shortArrayToLong_arraySIJII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='shortArrayToLong' and count(parameter)=5 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("shortArrayToLong", "([SIJII)J", "")]
		public static unsafe long ShortArrayToLong (short[] src, int srcPos, long dstInit, int dstPos, int nShorts)
		{
			if (id_shortArrayToLong_arraySIJII == IntPtr.Zero)
				id_shortArrayToLong_arraySIJII = JNIEnv.GetStaticMethodID (class_ref, "shortArrayToLong", "([SIJII)J");
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nShorts);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_shortArrayToLong_arraySIJII, __args);
				return __ret;
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
			}
		}

		static IntPtr id_shortToBinary_SIarrayZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='shortToBinary' and count(parameter)=5 and parameter[1][@type='short'] and parameter[2][@type='int'] and parameter[3][@type='boolean[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("shortToBinary", "(SI[ZII)[Z", "")]
		public static unsafe bool[] ShortToBinary (short src, int srcPos, bool[] dst, int dstPos, int nBools)
		{
			if (id_shortToBinary_SIarrayZII == IntPtr.Zero)
				id_shortToBinary_SIarrayZII = JNIEnv.GetStaticMethodID (class_ref, "shortToBinary", "(SI[ZII)[Z");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dst);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBools);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_shortToBinary_SIarrayZII, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_shortToByteArray_SIarrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='shortToByteArray' and count(parameter)=5 and parameter[1][@type='short'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("shortToByteArray", "(SI[BII)[B", "")]
		public static unsafe byte[] ShortToByteArray (short src, int srcPos, byte[] dst, int dstPos, int nBytes)
		{
			if (id_shortToByteArray_SIarrayBII == IntPtr.Zero)
				id_shortToByteArray_SIarrayBII = JNIEnv.GetStaticMethodID (class_ref, "shortToByteArray", "(SI[BII)[B");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dst);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nBytes);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_shortToByteArray_SIarrayBII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_shortToHex_SILjava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='shortToHex' and count(parameter)=5 and parameter[1][@type='short'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("shortToHex", "(SILjava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string ShortToHex (short src, int srcPos, string dstInit, int dstPos, int nHexs)
		{
			if (id_shortToHex_SILjava_lang_String_II == IntPtr.Zero)
				id_shortToHex_SILjava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "shortToHex", "(SILjava/lang/String;II)Ljava/lang/String;");
			IntPtr native_dstInit = JNIEnv.NewString (dstInit);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (src);
				__args [1] = new JValue (srcPos);
				__args [2] = new JValue (native_dstInit);
				__args [3] = new JValue (dstPos);
				__args [4] = new JValue (nHexs);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_shortToHex_SILjava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_dstInit);
			}
		}

		static IntPtr id_uuidToByteArray_Ljava_util_UUID_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Conversion']/method[@name='uuidToByteArray' and count(parameter)=4 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("uuidToByteArray", "(Ljava/util/UUID;[BII)[B", "")]
		public static unsafe byte[] UuidToByteArray (global::Java.Util.UUID src, byte[] dst, int dstPos, int nBytes)
		{
			if (id_uuidToByteArray_Ljava_util_UUID_arrayBII == IntPtr.Zero)
				id_uuidToByteArray_Ljava_util_UUID_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "uuidToByteArray", "(Ljava/util/UUID;[BII)[B");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (src);
				__args [1] = new JValue (native_dst);
				__args [2] = new JValue (dstPos);
				__args [3] = new JValue (nBytes);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_uuidToByteArray_Ljava_util_UUID_arrayBII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

	}
}
