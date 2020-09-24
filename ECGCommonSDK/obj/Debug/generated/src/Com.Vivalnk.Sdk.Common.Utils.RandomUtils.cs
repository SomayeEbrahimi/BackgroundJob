using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='RandomUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/RandomUtils", DoNotGenerateAcw=true)]
	public partial class RandomUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/RandomUtils", typeof (RandomUtils));
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

		protected RandomUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='RandomUtils']/constructor[@name='RandomUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RandomUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='RandomUtils']/method[@name='nextDouble' and count(parameter)=0]"
		[Register ("nextDouble", "()D", "")]
		public static unsafe double NextDouble ()
		{
			const string __id = "nextDouble.()D";
			try {
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='RandomUtils']/method[@name='nextInt' and count(parameter)=0]"
		[Register ("nextInt", "()D", "")]
		public static unsafe double NextInt ()
		{
			const string __id = "nextInt.()D";
			try {
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='RandomUtils']/method[@name='nextLong' and count(parameter)=0]"
		[Register ("nextLong", "()D", "")]
		public static unsafe double NextLong ()
		{
			const string __id = "nextLong.()D";
			try {
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, null);
				return __rm;
			} finally {
			}
		}

	}
}
