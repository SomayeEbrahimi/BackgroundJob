using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils.Algorithm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.algorithm']/class[@name='KalmanFilter']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/algorithm/KalmanFilter", DoNotGenerateAcw=true)]
	public partial class KalmanFilter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/algorithm/KalmanFilter", typeof (KalmanFilter));
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

		protected KalmanFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.algorithm']/class[@name='KalmanFilter']/constructor[@name='KalmanFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KalmanFilter ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.algorithm']/class[@name='KalmanFilter']/method[@name='calculate' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Double&gt;']]"
		[Register ("calculate", "(Ljava/util/ArrayList;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Double> Calculate (global::System.Collections.Generic.IList<global::Java.Lang.Double> dataArrayList)
		{
			const string __id = "calculate.(Ljava/util/ArrayList;)Ljava/util/ArrayList;";
			IntPtr native_dataArrayList = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (dataArrayList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dataArrayList);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_dataArrayList);
			}
		}

	}
}
