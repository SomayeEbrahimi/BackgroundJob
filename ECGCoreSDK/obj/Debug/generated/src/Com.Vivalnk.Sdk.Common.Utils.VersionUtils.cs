using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='VersionUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/VersionUtils", DoNotGenerateAcw=true)]
	public partial class VersionUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/VersionUtils", typeof (VersionUtils));
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

		protected VersionUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='VersionUtils']/constructor[@name='VersionUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VersionUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='VersionUtils']/method[@name='compareVersion' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("compareVersion", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int CompareVersion (string ver1, string ver2)
		{
			const string __id = "compareVersion.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_ver1 = JNIEnv.NewString (ver1);
			IntPtr native_ver2 = JNIEnv.NewString (ver2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_ver1);
				__args [1] = new JniArgumentValue (native_ver2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_ver1);
				JNIEnv.DeleteLocalRef (native_ver2);
			}
		}

	}
}
