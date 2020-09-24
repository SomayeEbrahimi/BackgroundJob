using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/ByteUtils", DoNotGenerateAcw=true)]
	public partial class ByteUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/field[@name='BYTE_MAX']"
		[Register ("BYTE_MAX")]
		public const int ByteMax = (int) 255;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/field[@name='EMPTY_BYTES']"
		[Register ("EMPTY_BYTES")]
		public static IList<byte> EmptyBytes {
			get {
				const string __id = "EMPTY_BYTES.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/ByteUtils", typeof (ByteUtils));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ByteUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/constructor[@name='ByteUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ByteUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2Char' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byte2Char", "([B)[C", "")]
		public static unsafe char[] Byte2Char (byte[] b)
		{
			const string __id = "byte2Char.([B)[C";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2CharOriginal' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byte2CharOriginal", "([B)[C", "")]
		public static unsafe char[] Byte2CharOriginal (byte[] b)
		{
			const string __id = "byte2CharOriginal.([B)[C";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2Int2' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byte2Int2", "([B)I", "")]
		public static unsafe int Byte2Int2 (byte[] b)
		{
			const string __id = "byte2Int2.([B)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2IntByStream' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byte2IntByStream", "([B)I", "")]
		public static unsafe int Byte2IntByStream (byte[] b)
		{
			const string __id = "byte2IntByStream.([B)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2Long' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("byte2Long", "([BI)J", "")]
		public static unsafe long Byte2Long (byte[] buf, int index)
		{
			const string __id = "byte2Long.([BI)J";
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_buf);
				__args [1] = new JniArgumentValue (index);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2Short' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byte2Short", "([B)S", "")]
		public static unsafe short Byte2Short (byte[] b)
		{
			const string __id = "byte2Short.([B)S";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2SignedInt' and count(parameter)=1 and parameter[1][@type='byte...']]"
		[Register ("byte2SignedInt", "([B)I", "")]
		public static unsafe int Byte2SignedInt (params byte[] args)
		{
			const string __id = "byte2SignedInt.([B)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byte2UnsignedInt' and count(parameter)=1 and parameter[1][@type='byte...']]"
		[Register ("byte2UnsignedInt", "([B)I", "")]
		public static unsafe int Byte2UnsignedInt (params byte[] args)
		{
			const string __id = "byte2UnsignedInt.([B)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byteEquals' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("byteEquals", "([B[B)Z", "")]
		public static unsafe bool ByteEquals (byte[] lbytes, byte[] rbytes)
		{
			const string __id = "byteEquals.([B[B)Z";
			IntPtr native_lbytes = JNIEnv.NewArray (lbytes);
			IntPtr native_rbytes = JNIEnv.NewArray (rbytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_lbytes);
				__args [1] = new JniArgumentValue (native_rbytes);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='byteToString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byteToString", "([B)Ljava/lang/String;", "")]
		public static unsafe string ByteToString (byte[] bytes)
		{
			const string __id = "byteToString.([B)Ljava/lang/String;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='char2Byte' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("char2Byte", "(C)B", "")]
		public static unsafe sbyte Char2Byte (char c)
		{
			const string __id = "char2Byte.(C)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='char2Byte' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("char2Byte", "([C)[B", "")]
		public static unsafe byte[] Char2Byte (char[] c)
		{
			const string __id = "char2Byte.([C)[B";
			IntPtr native_c = JNIEnv.NewArray (c);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_c);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (c != null) {
					JNIEnv.CopyArray (native_c, c);
					JNIEnv.DeleteLocalRef (native_c);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='copy' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("copy", "([B[BII)V", "")]
		public static unsafe void Copy (byte[] lbytes, byte[] rbytes, int lstart, int rstart)
		{
			const string __id = "copy.([B[BII)V";
			IntPtr native_lbytes = JNIEnv.NewArray (lbytes);
			IntPtr native_rbytes = JNIEnv.NewArray (rbytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_lbytes);
				__args [1] = new JniArgumentValue (native_rbytes);
				__args [2] = new JniArgumentValue (lstart);
				__args [3] = new JniArgumentValue (rstart);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='cutAfterBytes' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register ("cutAfterBytes", "([BB)[B", "")]
		public static unsafe byte[] CutAfterBytes (byte[] bytes, sbyte cut)
		{
			const string __id = "cutAfterBytes.([BB)[B";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (cut);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='cutBeforeBytes' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register ("cutBeforeBytes", "([BB)[B", "")]
		public static unsafe byte[] CutBeforeBytes (byte[] bytes, sbyte cut)
		{
			const string __id = "cutBeforeBytes.([BB)[B";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (cut);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("equals", "([B[B)Z", "")]
		public static unsafe bool Equals (byte[] array1, byte[] array2)
		{
			const string __id = "equals.([B[B)Z";
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_array1);
				__args [1] = new JniArgumentValue (native_array2);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='equals' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("equals", "([B[BI)Z", "")]
		public static unsafe bool Equals (byte[] array1, byte[] array2, int len)
		{
			const string __id = "equals.([B[BI)Z";
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_array1);
				__args [1] = new JniArgumentValue (native_array2);
				__args [2] = new JniArgumentValue (len);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='fillBeforeBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte']]"
		[Register ("fillBeforeBytes", "([BIB)[B", "")]
		public static unsafe byte[] FillBeforeBytes (byte[] bytes, int len, sbyte fill)
		{
			const string __id = "fillBeforeBytes.([BIB)[B";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (len);
				__args [2] = new JniArgumentValue (fill);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='fromInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromInt", "(I)[B", "")]
		public static unsafe byte[] FromInt (int n)
		{
			const string __id = "fromInt.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='fromLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("fromLong", "(J)[B", "")]
		public static unsafe byte[] FromLong (long n)
		{
			const string __id = "fromLong.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='fromShort' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("fromShort", "(S)[B", "")]
		public static unsafe byte[] FromShort (short n)
		{
			const string __id = "fromShort.(S)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='get' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("get", "([BI)[B", "")]
		public static unsafe byte[] Get (byte[] bytes, int offset)
		{
			const string __id = "get.([BI)[B";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='get' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("get", "([BII)[B", "")]
		public static unsafe byte[] Get (byte[] bytes, int offset, int len)
		{
			const string __id = "get.([BII)[B";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (len);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("getByte", "(C)B", "")]
		public static unsafe sbyte GetByte (char c)
		{
			const string __id = "getByte.(C)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getBytes", "([BII)[B", "")]
		public static unsafe byte[] GetBytes (byte[] bytes, int start, int end)
		{
			const string __id = "getBytes.([BII)[B";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (end);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("getBytes", "([C)[B", "")]
		public static unsafe byte[] GetBytes (char[] chars)
		{
			const string __id = "getBytes.([C)[B";
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_chars);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getChar' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("getChar", "(B)C", "")]
		public static unsafe char GetChar (sbyte bytes)
		{
			const string __id = "getChar.(B)C";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bytes);
				var __rm = _members.StaticMethods.InvokeCharMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getChars' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getChars", "([B)[C", "")]
		public static unsafe char[] GetChars (byte[] bytes)
		{
			const string __id = "getChars.([B)[C";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getNonEmptyByte' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getNonEmptyByte", "([B)[B", "")]
		public static unsafe byte[] GetNonEmptyByte (byte[] bytes)
		{
			const string __id = "getNonEmptyByte.([B)[B";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getRawData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getRawData", "([B)Ljava/lang/String;", "")]
		public static unsafe string GetRawData (byte[] btValues)
		{
			const string __id = "getRawData.([B)Ljava/lang/String;";
			IntPtr native_btValues = JNIEnv.NewArray (btValues);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_btValues);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (btValues != null) {
					JNIEnv.CopyArray (native_btValues, btValues);
					JNIEnv.DeleteLocalRef (native_btValues);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getUnSignedLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getUnSignedLong", "(J)J", "")]
		public static unsafe long GetUnSignedLong (long l)
		{
			const string __id = "getUnSignedLong.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (l);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getUnsignedByte' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("getUnsignedByte", "(B)I", "")]
		public static unsafe int GetUnsignedByte (sbyte data)
		{
			const string __id = "getUnsignedByte.(B)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (data);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getUnsignedInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUnsignedInt", "(I)J", "")]
		public static unsafe long GetUnsignedInt (int data)
		{
			const string __id = "getUnsignedInt.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (data);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='getUnsignedShort' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("getUnsignedShort", "(S)I", "")]
		public static unsafe int GetUnsignedShort (short data)
		{
			const string __id = "getUnsignedShort.(S)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (data);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='int2Byte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("int2Byte", "(I)[B", "")]
		public static unsafe byte[] Int2Byte (int res)
		{
			const string __id = "int2Byte.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (res);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='intArray2ByteArray' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("intArray2ByteArray", "([I)[B", "")]
		public static unsafe byte[] IntArray2ByteArray (int[] srcArray)
		{
			const string __id = "intArray2ByteArray.([I)[B";
			IntPtr native_srcArray = JNIEnv.NewArray (srcArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_srcArray);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (srcArray != null) {
					JNIEnv.CopyArray (native_srcArray, srcArray);
					JNIEnv.DeleteLocalRef (native_srcArray);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='isAllFF' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isAllFF", "([B)Z", "")]
		public static unsafe bool IsAllFF (byte[] bytes)
		{
			const string __id = "isAllFF.([B)Z";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isEmpty", "([B)Z", "")]
		public static unsafe bool IsEmpty (byte[] bytes)
		{
			const string __id = "isEmpty.([B)Z";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='long2Dword' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("long2Dword", "(J)[B", "")]
		public static unsafe byte[] Long2Dword (long value)
		{
			const string __id = "long2Dword.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("reverse", "([B)[B", "")]
		public static unsafe byte[] Reverse (byte[] b)
		{
			const string __id = "reverse.([B)[B";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='short2Byte' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("short2Byte", "(S)[B", "")]
		public static unsafe byte[] Short2Byte (short number)
		{
			const string __id = "short2Byte.(S)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='stringToBytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringToBytes", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] StringToBytes (string text)
		{
			const string __id = "stringToBytes.(Ljava/lang/String;)[B";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='toUnsignedInt' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toUnsignedInt", "(B)I", "")]
		public static unsafe int ToUnsignedInt (sbyte x)
		{
			const string __id = "toUnsignedInt.(B)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (x);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='toUnsignedLong' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toUnsignedLong", "(B)J", "")]
		public static unsafe long ToUnsignedLong (sbyte x)
		{
			const string __id = "toUnsignedLong.(B)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (x);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='trimLast' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("trimLast", "([B)[B", "")]
		public static unsafe byte[] TrimLast (byte[] bytes)
		{
			const string __id = "trimLast.([B)[B";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ByteUtils']/method[@name='ubyteToInt' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("ubyteToInt", "(B)I", "")]
		public static unsafe int UbyteToInt (sbyte b)
		{
			const string __id = "ubyteToInt.(B)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
