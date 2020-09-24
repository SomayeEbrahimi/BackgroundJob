using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/core/VivalnkLibrary", DoNotGenerateAcw=true)]
	public partial class VivalnkLibrary : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/field[@name='afib_init_code']"
		[Register ("afib_init_code")]
		public static int AfibInitCode {
			get {
				const string __id = "afib_init_code.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "afib_init_code.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/field[@name='pause_init_code']"
		[Register ("pause_init_code")]
		public static int PauseInitCode {
			get {
				const string __id = "pause_init_code.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "pause_init_code.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/core/VivalnkLibrary", typeof (VivalnkLibrary));
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

		protected VivalnkLibrary (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/constructor[@name='VivalnkLibrary' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VivalnkLibrary ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='aes128_Decrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("aes128_Decrypt", "([B)[B", "")]
		public static unsafe byte[] Aes128_Decrypt (byte[] p0)
		{
			const string __id = "aes128_Decrypt.([B)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='aes128_Encrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("aes128_Encrypt", "([B)[B", "")]
		public static unsafe byte[] Aes128_Encrypt (byte[] p0)
		{
			const string __id = "aes128_Encrypt.([B)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='aes128_init' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("aes128_init", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Aes128_init (string p0, string p1)
		{
			const string __id = "aes128_init.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='afib_init' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("afib_init", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int Afib_init (string p0, string p1)
		{
			const string __id = "afib_init.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='afib_predict' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("afib_predict", "([D)I", "")]
		public static unsafe int Afib_predict (double[] p0)
		{
			const string __id = "afib_predict.([D)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='calculatePercentage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vivalnk.sdk.model.BatteryInfo.ChargeStatus']]"
		[Register ("calculatePercentage", "(ILcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;)I", "")]
		public static unsafe int CalculatePercentage (int p0, global::Com.Vivalnk.Sdk.Model.BatteryInfo.ChargeStatus p1)
		{
			const string __id = "calculatePercentage.(ILcom/vivalnk/sdk/model/BatteryInfo$ChargeStatus;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='detectActivity' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]'] and parameter[4][@type='short[]']]"
		[Register ("detectActivity", "([F[F[F[S)Z", "")]
		public static unsafe bool DetectActivity (float[] p0, float[] p1, float[] p2, short[] p3)
		{
			const string __id = "detectActivity.([F[F[F[S)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='detectAfib' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("detectAfib", "([D)[I", "")]
		public static unsafe int[] DetectAfib (double[] p0)
		{
			const string __id = "detectAfib.([D)[I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='estimate_bp' and count(parameter)=5 and parameter[1][@type='int[][]'] and parameter[2][@type='int[][]'] and parameter[3][@type='int[][]'] and parameter[4][@type='int[][]'] and parameter[5][@type='int[][]']]"
		[Register ("estimate_bp", "([[I[[I[[I[[I[[I)[I", "")]
		public static unsafe int[] Estimate_bp (int[][] p0, int[][] p1, int[][] p2, int[][] p3, int[][] p4)
		{
			const string __id = "estimate_bp.([[I[[I[[I[[I[[I)[I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='estimate_init_calibrate' and count(parameter)=12 and parameter[1][@type='int[][]'] and parameter[2][@type='int[][]'] and parameter[3][@type='int[][]'] and parameter[4][@type='int[][]'] and parameter[5][@type='int[][]'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("estimate_init_calibrate", "([[I[[I[[I[[I[[IIIIIIII)V", "")]
		public static unsafe void Estimate_init_calibrate (int[][] p0, int[][] p1, int[][] p2, int[][] p3, int[][] p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11)
		{
			const string __id = "estimate_init_calibrate.([[I[[I[[I[[I[[IIIIIIII)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [12];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (p7);
				__args [8] = new JniArgumentValue (p8);
				__args [9] = new JniArgumentValue (p9);
				__args [10] = new JniArgumentValue (p10);
				__args [11] = new JniArgumentValue (p11);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='filterEcg' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='boolean']]"
		[Register ("filterEcg", "([FZ)[F", "")]
		public static unsafe float[] FilterEcg (float[] p0, bool p1)
		{
			const string __id = "filterEcg.([FZ)[F";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='pause_init' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("pause_init", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int Pause_init (string p0, string p1)
		{
			const string __id = "pause_init.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core']/class[@name='VivalnkLibrary']/method[@name='pause_predict' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("pause_predict", "([D)I", "")]
		public static unsafe int Pause_predict (double[] p0)
		{
			const string __id = "pause_predict.([D)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
