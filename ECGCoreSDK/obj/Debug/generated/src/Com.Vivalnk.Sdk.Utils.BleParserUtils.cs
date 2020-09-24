using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='BleParserUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/BleParserUtils", DoNotGenerateAcw=true)]
	public partial class BleParserUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/utils/BleParserUtils", typeof (BleParserUtils));
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

		protected BleParserUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='BleParserUtils']/constructor[@name='BleParserUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BleParserUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='BleParserUtils']/method[@name='checkOneByteValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkOneByteValue", "(I)I", "")]
		public static unsafe int CheckOneByteValue (int p0)
		{
			const string __id = "checkOneByteValue.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='BleParserUtils']/method[@name='checkRawRRI' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkRawRRI", "(I)I", "")]
		public static unsafe int CheckRawRRI (int p0)
		{
			const string __id = "checkRawRRI.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='BleParserUtils']/method[@name='getDate' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getDate", "([B)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date GetDate (byte[] p0)
		{
			const string __id = "getDate.([B)Ljava/util/Date;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='BleParserUtils']/method[@name='getTwoLengthStr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTwoLengthStr", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetTwoLengthStr (int p0)
		{
			const string __id = "getTwoLengthStr.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='BleParserUtils']/method[@name='hexStringToByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexStringToByteArray", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] HexStringToByteArray (string p0)
		{
			const string __id = "hexStringToByteArray.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='BleParserUtils']/method[@name='stringLeftAddZero' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("stringLeftAddZero", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string StringLeftAddZero (string p0, int p1)
		{
			const string __id = "stringLeftAddZero.(Ljava/lang/String;I)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
