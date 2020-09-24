using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Core.RR {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/core/rr/NewRR", DoNotGenerateAcw=true)]
	public partial class NewRR : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/field[@name='e']"
		[Register ("e")]
		public bool E {
			get {
				const string __id = "e.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "e.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/field[@name='f']"
		[Register ("f")]
		public double F {
			get {
				const string __id = "f.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "f.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/core/rr/NewRR", typeof (NewRR));
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

		protected NewRR (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/constructor[@name='NewRR' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NewRR ()
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

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_A);
			return cb_a;
		}

		static float n_A (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.RR.NewRR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()F", "GetAHandler")]
		public virtual unsafe float A ()
		{
			const string __id = "a.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='a' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("a", "([F)[D", "")]
		public static unsafe double[] A (float[] p0)
		{
			const string __id = "a.([F)[D";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_a_I;
#pragma warning disable 0169
		static Delegate GetA_IHandler ()
		{
			if (cb_a_I == null)
				cb_a_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_A_I);
			return cb_a_I;
		}

		static int n_A_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.RR.NewRR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)I", "GetA_IHandler")]
		public virtual unsafe int A (int p0)
		{
			const string __id = "a.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_a_ILcom_vivalnk_sdk_model_SampleData_;
#pragma warning disable 0169
		static Delegate GetA_ILcom_vivalnk_sdk_model_SampleData_Handler ()
		{
			if (cb_a_ILcom_vivalnk_sdk_model_SampleData_ == null)
				cb_a_ILcom_vivalnk_sdk_model_SampleData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_F) n_A_ILcom_vivalnk_sdk_model_SampleData_);
			return cb_a_ILcom_vivalnk_sdk_model_SampleData_;
		}

		static float n_A_ILcom_vivalnk_sdk_model_SampleData_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.RR.NewRR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (native_p1, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.A (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='a' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.vivalnk.sdk.model.SampleData']]"
		[Register ("a", "(ILcom/vivalnk/sdk/model/SampleData;)F", "GetA_ILcom_vivalnk_sdk_model_SampleData_Handler")]
		public virtual unsafe float A (int p0, global::Com.Vivalnk.Sdk.Model.SampleData p1)
		{
			const string __id = "a.(ILcom/vivalnk/sdk/model/SampleData;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("a", "([I)I", "")]
		public static unsafe int A (int[] p0)
		{
			const string __id = "a.([I)I";
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

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.RR.NewRR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		public virtual unsafe void B ()
		{
			const string __id = "b.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_C);
			return cb_c;
		}

		static void n_C (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.RR.NewRR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.C ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "GetCHandler")]
		public virtual unsafe void C ()
		{
			const string __id = "c.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_D);
			return cb_d;
		}

		static void n_D (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.RR.NewRR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.D ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "GetDHandler")]
		public virtual unsafe void D ()
		{
			const string __id = "d.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='newrr_append_ecg' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='double[]'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int[]'] and parameter[8][@type='int[]'] and parameter[9][@type='int[]']]"
		[Register ("newrr_append_ecg", "(I[DI[III[I[I[I)D", "")]
		public static unsafe double Newrr_append_ecg (int p0, double[] p1, int p2, int[] p3, int p4, int p5, int[] p6, int[] p7, int[] p8)
		{
			const string __id = "newrr_append_ecg.(I[DI[III[I[I[I)D";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			IntPtr native_p8 = JNIEnv.NewArray (p8);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (native_p7);
				__args [8] = new JniArgumentValue (native_p8);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
				if (p8 != null) {
					JNIEnv.CopyArray (native_p8, p8);
					JNIEnv.DeleteLocalRef (native_p8);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='newrr_get_moving_average' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("newrr_get_moving_average", "(I)D", "")]
		public static unsafe double Newrr_get_moving_average (int p0)
		{
			const string __id = "newrr_get_moving_average.(I)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='newrr_get_use_acc_result' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("newrr_get_use_acc_result", "(I)I", "")]
		public static unsafe int Newrr_get_use_acc_result (int p0)
		{
			const string __id = "newrr_get_use_acc_result.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='newrr_get_use_fft_fusion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("newrr_get_use_fft_fusion", "(I)I", "")]
		public static unsafe int Newrr_get_use_fft_fusion (int p0)
		{
			const string __id = "newrr_get_use_fft_fusion.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='newrr_new' and count(parameter)=0]"
		[Register ("newrr_new", "()I", "")]
		public static unsafe int Newrr_new ()
		{
			const string __id = "newrr_new.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='newrr_release' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("newrr_release", "(I)V", "")]
		public static unsafe void Newrr_release (int p0)
		{
			const string __id = "newrr_release.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='newrr_set_cal_rwl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("newrr_set_cal_rwl", "(II)V", "")]
		public static unsafe void Newrr_set_cal_rwl (int p0, int p1)
		{
			const string __id = "newrr_set_cal_rwl.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.rr']/class[@name='NewRR']/method[@name='newrr_set_hz' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("newrr_set_hz", "(II)I", "")]
		public static unsafe int Newrr_set_hz (int p0, int p1)
		{
			const string __id = "newrr_set_hz.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
