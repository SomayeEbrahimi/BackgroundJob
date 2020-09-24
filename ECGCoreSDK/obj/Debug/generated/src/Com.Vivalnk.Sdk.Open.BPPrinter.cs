using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPPrinter']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/open/BPPrinter", DoNotGenerateAcw=true)]
	public partial class BPPrinter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/open/BPPrinter", typeof (BPPrinter));
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

		protected BPPrinter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPPrinter']/constructor[@name='BPPrinter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BPPrinter ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPPrinter']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.vivalnk.sdk.model.Person'] and parameter[2][@type='com.vivalnk.sdk.open.DataSet'] and parameter[3][@type='int[]']]"
		[Register ("a", "(Lcom/vivalnk/sdk/model/Person;Lcom/vivalnk/sdk/open/DataSet;[I)V", "")]
		public static unsafe void A (global::Com.Vivalnk.Sdk.Model.Person p0, global::Com.Vivalnk.Sdk.Open.DataSet p1, int[] p2)
		{
			const string __id = "a.(Lcom/vivalnk/sdk/model/Person;Lcom/vivalnk/sdk/open/DataSet;[I)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPPrinter']/method[@name='a' and count(parameter)=4 and parameter[1][@type='com.vivalnk.sdk.model.Person'] and parameter[2][@type='com.vivalnk.sdk.open.DataSet'] and parameter[3][@type='int[]'] and parameter[4][@type='java.lang.String']]"
		[Register ("a", "(Lcom/vivalnk/sdk/model/Person;Lcom/vivalnk/sdk/open/DataSet;[ILjava/lang/String;)V", "")]
		public static unsafe void A (global::Com.Vivalnk.Sdk.Model.Person p0, global::Com.Vivalnk.Sdk.Open.DataSet p1, int[] p2, string p3)
		{
			const string __id = "a.(Lcom/vivalnk/sdk/model/Person;Lcom/vivalnk/sdk/open/DataSet;[ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPPrinter']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.open.DataSet']]"
		[Register ("a", "(Lcom/vivalnk/sdk/open/DataSet;)Ljava/lang/String;", "")]
		public static unsafe string A (global::Com.Vivalnk.Sdk.Open.DataSet p0)
		{
			const string __id = "a.(Lcom/vivalnk/sdk/open/DataSet;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPPrinter']/method[@name='b' and count(parameter)=3 and parameter[1][@type='com.vivalnk.sdk.model.Person'] and parameter[2][@type='com.vivalnk.sdk.open.DataSet'] and parameter[3][@type='int[]']]"
		[Register ("b", "(Lcom/vivalnk/sdk/model/Person;Lcom/vivalnk/sdk/open/DataSet;[I)V", "")]
		public static unsafe void B (global::Com.Vivalnk.Sdk.Model.Person p0, global::Com.Vivalnk.Sdk.Open.DataSet p1, int[] p2)
		{
			const string __id = "b.(Lcom/vivalnk/sdk/model/Person;Lcom/vivalnk/sdk/open/DataSet;[I)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
