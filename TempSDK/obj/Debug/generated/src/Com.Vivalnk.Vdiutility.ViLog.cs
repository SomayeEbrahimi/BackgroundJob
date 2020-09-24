using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Vdiutility {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdiutility']/class[@name='viLog']"
	[global::Android.Runtime.Register ("com/vivalnk/vdiutility/viLog", DoNotGenerateAcw=true)]
	public partial class ViLog : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdiutility/viLog", typeof (ViLog));
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

		protected ViLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdiutility']/class[@name='viLog']/constructor[@name='viLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ViLog ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdiutility']/class[@name='viLog']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdiutility']/class[@name='viLog']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdiutility']/class[@name='viLog']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (string p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdiutility']/class[@name='viLog']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "")]
		public static unsafe void Init ()
		{
			const string __id = "init.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdiutility']/class[@name='viLog']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (string p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdiutility']/class[@name='viLog']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (string p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
