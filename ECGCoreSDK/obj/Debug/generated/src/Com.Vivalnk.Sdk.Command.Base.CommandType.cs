using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Command.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/command/base/CommandType", DoNotGenerateAcw=true)]
	public partial class CommandType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='base_common']"
		[Register ("base_common")]
		public const int BaseCommon = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='cancelUploadFlash']"
		[Register ("cancelUploadFlash")]
		public const int CancelUploadFlash = (int) 1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='checkFlashDataStatus']"
		[Register ("checkFlashDataStatus")]
		public const int CheckFlashDataStatus = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='checkPatchStatus']"
		[Register ("checkPatchStatus")]
		public const int CheckPatchStatus = (int) 1017;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='eraseFlash']"
		[Register ("eraseFlash")]
		public const int EraseFlash = (int) 1004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='eraseUserInfoFromFlash']"
		[Register ("eraseUserInfoFromFlash")]
		public const int EraseUserInfoFromFlash = (int) 1013;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='readDeviceInfo']"
		[Register ("readDeviceInfo")]
		public const int ReadDeviceInfo = (int) 1018;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='readPatchVersion']"
		[Register ("readPatchVersion")]
		public const int ReadPatchVersion = (int) 1016;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='readSnFromPatch']"
		[Register ("readSnFromPatch")]
		public const int ReadSnFromPatch = (int) 1015;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='readUserInfoFromFlash']"
		[Register ("readUserInfoFromFlash")]
		public const int ReadUserInfoFromFlash = (int) 1014;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='selfTest']"
		[Register ("selfTest")]
		public const int SelfTest = (int) 1005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='setPatchClock']"
		[Register ("setPatchClock")]
		public const int SetPatchClock = (int) 1006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='setUserInfoToFlash']"
		[Register ("setUserInfoToFlash")]
		public const int SetUserInfoToFlash = (int) 1012;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='shutdown']"
		[Register ("shutdown")]
		public const int Shutdown = (int) 1011;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='startOTA']"
		[Register ("startOTA")]
		public const int StartOTA = (int) 1007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='startSampling']"
		[Register ("startSampling")]
		public const int StartSampling = (int) 1009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='stopSampling']"
		[Register ("stopSampling")]
		public const int StopSampling = (int) 1010;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='unknow']"
		[Register ("unknow")]
		public const int Unknow = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/field[@name='uploadFlash']"
		[Register ("uploadFlash")]
		public const int UploadFlash = (int) 1002;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/command/base/CommandType", typeof (CommandType));
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

		protected CommandType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/constructor[@name='CommandType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommandType ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.command.base']/class[@name='CommandType']/method[@name='getTypeName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTypeName", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetTypeName (int p0)
		{
			const string __id = "getTypeName.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
