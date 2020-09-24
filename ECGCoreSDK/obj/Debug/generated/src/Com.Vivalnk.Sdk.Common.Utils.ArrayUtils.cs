using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/ArrayUtils", DoNotGenerateAcw=true)]
	public partial class ArrayUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/ArrayUtils", typeof (ArrayUtils));
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

		protected ArrayUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']/constructor[@name='ArrayUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ArrayUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']/method[@name='spliceArrays' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("spliceArrays", "([BI)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<byte[]> SpliceArrays (byte[] datas, int splitSize)
		{
			const string __id = "spliceArrays.([BI)Ljava/util/List;";
			IntPtr native_datas = JNIEnv.NewArray (datas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_datas);
				__args [1] = new JniArgumentValue (splitSize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (datas != null) {
					JNIEnv.CopyArray (native_datas, datas);
					JNIEnv.DeleteLocalRef (native_datas);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']/method[@name='spliceArrays' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='int']]"
		[Register ("spliceArrays", "([CI)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<char[]> SpliceArrays (char[] datas, int splitSize)
		{
			const string __id = "spliceArrays.([CI)Ljava/util/List;";
			IntPtr native_datas = JNIEnv.NewArray (datas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_datas);
				__args [1] = new JniArgumentValue (splitSize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<char[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (datas != null) {
					JNIEnv.CopyArray (native_datas, datas);
					JNIEnv.DeleteLocalRef (native_datas);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']/method[@name='spliceArrays' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='int']]"
		[Register ("spliceArrays", "(Ljava/util/List;I)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.Generic.IList<global::System.Collections.IList> SpliceArrays (global::System.Collections.IList datas, int splitSize)
		{
			const string __id = "spliceArrays.(Ljava/util/List;I)Ljava/util/List;";
			IntPtr native_datas = global::Android.Runtime.JavaList.ToLocalJniHandle (datas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_datas);
				__args [1] = new JniArgumentValue (splitSize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::System.Collections.IList>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_datas);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']/method[@name='spliceArrays' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='int']]"
		[Register ("spliceArrays", "([Ljava/lang/Object;I)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Object[]> SpliceArrays (global::Java.Lang.Object[] datas, int splitSize)
		{
			const string __id = "spliceArrays.([Ljava/lang/Object;I)Ljava/util/List;";
			IntPtr native_datas = JNIEnv.NewArray (datas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_datas);
				__args [1] = new JniArgumentValue (splitSize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Object[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (datas != null) {
					JNIEnv.CopyArray (native_datas, datas);
					JNIEnv.DeleteLocalRef (native_datas);
				}
			}
		}

	}
}
