using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FI.Firstbeat.Ete {

	// Metadata.xml XPath class reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']"
	[global::Android.Runtime.Register ("fi/firstbeat/ete/ETEc", DoNotGenerateAcw=true)]
	public partial class ETEc : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("fi/firstbeat/ete/ETEc", typeof (ETEc));
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

		protected ETEc (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']/constructor[@name='ETEc' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ETEc ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']/method[@name='AnalyzerStruct' and count(parameter)=2 and parameter[1][@type='fi.firstbeat.ete.FBTinput'] and parameter[2][@type='long']]"
		[Register ("AnalyzerStruct", "(Lfi/firstbeat/ete/FBTinput;J)I", "")]
		public static unsafe int AnalyzerStruct (global::FI.Firstbeat.Ete.FBTinput p0, long p1)
		{
			const string __id = "AnalyzerStruct.(Lfi/firstbeat/ete/FBTinput;J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']/method[@name='ETEVersion' and count(parameter)=0]"
		[Register ("ETEVersion", "()Ljava/lang/String;", "")]
		public static unsafe string ETEVersion ()
		{
			const string __id = "ETEVersion.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']/method[@name='GetResult' and count(parameter)=2 and parameter[1][@type='fi.firstbeat.ete.ETEresults'] and parameter[2][@type='long']]"
		[Register ("GetResult", "(Lfi/firstbeat/ete/ETEresults;J)I", "")]
		public static unsafe int GetResult (global::FI.Firstbeat.Ete.ETEresults p0, long p1)
		{
			const string __id = "GetResult.(Lfi/firstbeat/ete/ETEresults;J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']/method[@name='SetExercise' and count(parameter)=2 and parameter[1][@type='fi.firstbeat.ete.FBTexercise'] and parameter[2][@type='long']]"
		[Register ("SetExercise", "(Lfi/firstbeat/ete/FBTexercise;J)I", "")]
		public static unsafe int SetExercise (global::FI.Firstbeat.Ete.FBTexercise p0, long p1)
		{
			const string __id = "SetExercise.(Lfi/firstbeat/ete/FBTexercise;J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']/method[@name='SetParameters' and count(parameter)=3 and parameter[1][@type='fi.firstbeat.ete.FBTvars'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("SetParameters", "(Lfi/firstbeat/ete/FBTvars;IJ)I", "")]
		public static unsafe int SetParameters (global::FI.Firstbeat.Ete.FBTvars p0, int p1, long p2)
		{
			const string __id = "SetParameters.(Lfi/firstbeat/ete/FBTvars;IJ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']/method[@name='SetWalkingTest' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='long']]"
		[Register ("SetWalkingTest", "(ZJ)V", "")]
		public static unsafe void SetWalkingTest (bool p0, long p1)
		{
			const string __id = "SetWalkingTest.(ZJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']/method[@name='createFromExistingInstance' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("createFromExistingInstance", "([B)J", "")]
		public static unsafe long CreateFromExistingInstance (byte[] p0)
		{
			const string __id = "createFromExistingInstance.([B)J";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']/method[@name='createInstance' and count(parameter)=0]"
		[Register ("createInstance", "()J", "")]
		public static unsafe long CreateInstance ()
		{
			const string __id = "createInstance.()J";
			try {
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']/method[@name='freeInstance' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("freeInstance", "(J)V", "")]
		public static unsafe void FreeInstance (long p0)
		{
			const string __id = "freeInstance.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETEc']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getInstance", "(J)[B", "")]
		public static unsafe byte[] GetInstance (long p0)
		{
			const string __id = "getInstance.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
