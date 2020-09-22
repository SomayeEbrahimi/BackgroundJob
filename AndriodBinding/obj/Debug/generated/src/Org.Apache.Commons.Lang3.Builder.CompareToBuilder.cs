using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/CompareToBuilder", DoNotGenerateAcw=true)]
	public partial class CompareToBuilder : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Builder.IBuilder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/builder/CompareToBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompareToBuilder); }
		}

		protected CompareToBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/constructor[@name='CompareToBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CompareToBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CompareToBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_append_ZZ;
#pragma warning disable 0169
		static Delegate GetAppend_ZZHandler ()
		{
			if (cb_append_ZZ == null)
				cb_append_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZZ_L) n_Append_ZZ);
			return cb_append_ZZ;
		}

		static IntPtr n_Append_ZZ (IntPtr jnienv, IntPtr native__this, bool lhs, bool rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("append", "(ZZ)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_ZZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (bool lhs, bool rhs)
		{
			if (id_append_ZZ == IntPtr.Zero)
				id_append_ZZ = JNIEnv.GetMethodID (class_ref, "append", "(ZZ)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(ZZ)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayZarrayZ;
#pragma warning disable 0169
		static Delegate GetAppend_arrayZarrayZHandler ()
		{
			if (cb_append_arrayZarrayZ == null)
				cb_append_arrayZarrayZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_arrayZarrayZ);
			return cb_append_arrayZarrayZ;
		}

		static IntPtr n_Append_arrayZarrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = (bool[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (bool));
			var rhs = (bool[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (bool));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayZarrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean[]']]"
		[Register ("append", "([Z[Z)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_arrayZarrayZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (bool[] lhs, bool[] rhs)
		{
			if (id_append_arrayZarrayZ == IntPtr.Zero)
				id_append_arrayZarrayZ = JNIEnv.GetMethodID (class_ref, "append", "([Z[Z)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayZarrayZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([Z[Z)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (lhs != null) {
					JNIEnv.CopyArray (native_lhs, lhs);
					JNIEnv.DeleteLocalRef (native_lhs);
				}
				if (rhs != null) {
					JNIEnv.CopyArray (native_rhs, rhs);
					JNIEnv.DeleteLocalRef (native_rhs);
				}
			}
		}

		static Delegate cb_append_BB;
#pragma warning disable 0169
		static Delegate GetAppend_BBHandler ()
		{
			if (cb_append_BB == null)
				cb_append_BB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPBB_L) n_Append_BB);
			return cb_append_BB;
		}

		static IntPtr n_Append_BB (IntPtr jnienv, IntPtr native__this, sbyte lhs, sbyte rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_BB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("append", "(BB)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_BBHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (sbyte lhs, sbyte rhs)
		{
			if (id_append_BB == IntPtr.Zero)
				id_append_BB = JNIEnv.GetMethodID (class_ref, "append", "(BB)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_BB, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(BB)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetAppend_arrayBarrayBHandler ()
		{
			if (cb_append_arrayBarrayB == null)
				cb_append_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_arrayBarrayB);
			return cb_append_arrayBarrayB;
		}

		static IntPtr n_Append_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = (byte[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var rhs = (byte[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("append", "([B[B)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_arrayBarrayBHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (byte[] lhs, byte[] rhs)
		{
			if (id_append_arrayBarrayB == IntPtr.Zero)
				id_append_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "append", "([B[B)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([B[B)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (lhs != null) {
					JNIEnv.CopyArray (native_lhs, lhs);
					JNIEnv.DeleteLocalRef (native_lhs);
				}
				if (rhs != null) {
					JNIEnv.CopyArray (native_rhs, rhs);
					JNIEnv.DeleteLocalRef (native_rhs);
				}
			}
		}

		static Delegate cb_append_CC;
#pragma warning disable 0169
		static Delegate GetAppend_CCHandler ()
		{
			if (cb_append_CC == null)
				cb_append_CC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPCC_L) n_Append_CC);
			return cb_append_CC;
		}

		static IntPtr n_Append_CC (IntPtr jnienv, IntPtr native__this, char lhs, char rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_CC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
		[Register ("append", "(CC)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_CCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (char lhs, char rhs)
		{
			if (id_append_CC == IntPtr.Zero)
				id_append_CC = JNIEnv.GetMethodID (class_ref, "append", "(CC)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_CC, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(CC)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayCarrayC;
#pragma warning disable 0169
		static Delegate GetAppend_arrayCarrayCHandler ()
		{
			if (cb_append_arrayCarrayC == null)
				cb_append_arrayCarrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_arrayCarrayC);
			return cb_append_arrayCarrayC;
		}

		static IntPtr n_Append_arrayCarrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = (char[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (char));
			var rhs = (char[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayCarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char[]']]"
		[Register ("append", "([C[C)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_arrayCarrayCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (char[] lhs, char[] rhs)
		{
			if (id_append_arrayCarrayC == IntPtr.Zero)
				id_append_arrayCarrayC = JNIEnv.GetMethodID (class_ref, "append", "([C[C)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayCarrayC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([C[C)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (lhs != null) {
					JNIEnv.CopyArray (native_lhs, lhs);
					JNIEnv.DeleteLocalRef (native_lhs);
				}
				if (rhs != null) {
					JNIEnv.CopyArray (native_rhs, rhs);
					JNIEnv.DeleteLocalRef (native_rhs);
				}
			}
		}

		static Delegate cb_append_DD;
#pragma warning disable 0169
		static Delegate GetAppend_DDHandler ()
		{
			if (cb_append_DD == null)
				cb_append_DD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPDD_L) n_Append_DD);
			return cb_append_DD;
		}

		static IntPtr n_Append_DD (IntPtr jnienv, IntPtr native__this, double lhs, double rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("append", "(DD)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_DDHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (double lhs, double rhs)
		{
			if (id_append_DD == IntPtr.Zero)
				id_append_DD = JNIEnv.GetMethodID (class_ref, "append", "(DD)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_DD, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(DD)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayDarrayD;
#pragma warning disable 0169
		static Delegate GetAppend_arrayDarrayDHandler ()
		{
			if (cb_append_arrayDarrayD == null)
				cb_append_arrayDarrayD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_arrayDarrayD);
			return cb_append_arrayDarrayD;
		}

		static IntPtr n_Append_arrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = (double[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (double));
			var rhs = (double[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("append", "([D[D)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_arrayDarrayDHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (double[] lhs, double[] rhs)
		{
			if (id_append_arrayDarrayD == IntPtr.Zero)
				id_append_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "append", "([D[D)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayDarrayD, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([D[D)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (lhs != null) {
					JNIEnv.CopyArray (native_lhs, lhs);
					JNIEnv.DeleteLocalRef (native_lhs);
				}
				if (rhs != null) {
					JNIEnv.CopyArray (native_rhs, rhs);
					JNIEnv.DeleteLocalRef (native_rhs);
				}
			}
		}

		static Delegate cb_append_FF;
#pragma warning disable 0169
		static Delegate GetAppend_FFHandler ()
		{
			if (cb_append_FF == null)
				cb_append_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_L) n_Append_FF);
			return cb_append_FF;
		}

		static IntPtr n_Append_FF (IntPtr jnienv, IntPtr native__this, float lhs, float rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("append", "(FF)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_FFHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (float lhs, float rhs)
		{
			if (id_append_FF == IntPtr.Zero)
				id_append_FF = JNIEnv.GetMethodID (class_ref, "append", "(FF)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_FF, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(FF)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayFarrayF;
#pragma warning disable 0169
		static Delegate GetAppend_arrayFarrayFHandler ()
		{
			if (cb_append_arrayFarrayF == null)
				cb_append_arrayFarrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_arrayFarrayF);
			return cb_append_arrayFarrayF;
		}

		static IntPtr n_Append_arrayFarrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = (float[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (float));
			var rhs = (float[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register ("append", "([F[F)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_arrayFarrayFHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (float[] lhs, float[] rhs)
		{
			if (id_append_arrayFarrayF == IntPtr.Zero)
				id_append_arrayFarrayF = JNIEnv.GetMethodID (class_ref, "append", "([F[F)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayFarrayF, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([F[F)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (lhs != null) {
					JNIEnv.CopyArray (native_lhs, lhs);
					JNIEnv.DeleteLocalRef (native_lhs);
				}
				if (rhs != null) {
					JNIEnv.CopyArray (native_rhs, rhs);
					JNIEnv.DeleteLocalRef (native_rhs);
				}
			}
		}

		static Delegate cb_append_II;
#pragma warning disable 0169
		static Delegate GetAppend_IIHandler ()
		{
			if (cb_append_II == null)
				cb_append_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_Append_II);
			return cb_append_II;
		}

		static IntPtr n_Append_II (IntPtr jnienv, IntPtr native__this, int lhs, int rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("append", "(II)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (int lhs, int rhs)
		{
			if (id_append_II == IntPtr.Zero)
				id_append_II = JNIEnv.GetMethodID (class_ref, "append", "(II)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(II)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetAppend_arrayIarrayIHandler ()
		{
			if (cb_append_arrayIarrayI == null)
				cb_append_arrayIarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_arrayIarrayI);
			return cb_append_arrayIarrayI;
		}

		static IntPtr n_Append_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = (int[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (int));
			var rhs = (int[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("append", "([I[I)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_arrayIarrayIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (int[] lhs, int[] rhs)
		{
			if (id_append_arrayIarrayI == IntPtr.Zero)
				id_append_arrayIarrayI = JNIEnv.GetMethodID (class_ref, "append", "([I[I)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([I[I)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (lhs != null) {
					JNIEnv.CopyArray (native_lhs, lhs);
					JNIEnv.DeleteLocalRef (native_lhs);
				}
				if (rhs != null) {
					JNIEnv.CopyArray (native_rhs, rhs);
					JNIEnv.DeleteLocalRef (native_rhs);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_append_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_append_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_append_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Append_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_lhs, JniHandleOwnership.DoNotTransfer);
			var rhs = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_rhs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("append", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs)
		{
			if (id_append_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_append_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_append_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_Handler ()
		{
			if (cb_append_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_ == null)
				cb_append_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_);
			return cb_append_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_;
		}

		static IntPtr n_Append_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs, IntPtr native_comparator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_lhs, JniHandleOwnership.DoNotTransfer);
			var rhs = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_rhs, JniHandleOwnership.DoNotTransfer);
			var comparator = (global::Java.Util.IComparator)global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (native_comparator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs, comparator));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.util.Comparator&lt;?&gt;']]"
		[Register ("append", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, global::Java.Util.IComparator comparator)
		{
			if (id_append_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_ == IntPtr.Zero)
				id_append_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (comparator);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_append_arrayLjava_lang_Object_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_arrayLjava_lang_Object_arrayLjava_lang_Object_Handler ()
		{
			if (cb_append_arrayLjava_lang_Object_arrayLjava_lang_Object_ == null)
				cb_append_arrayLjava_lang_Object_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_arrayLjava_lang_Object_arrayLjava_lang_Object_);
			return cb_append_arrayLjava_lang_Object_arrayLjava_lang_Object_;
		}

		static IntPtr n_Append_arrayLjava_lang_Object_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			var rhs = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayLjava_lang_Object_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("append", "([Ljava/lang/Object;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_arrayLjava_lang_Object_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (global::Java.Lang.Object[] lhs, global::Java.Lang.Object[] rhs)
		{
			if (id_append_arrayLjava_lang_Object_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_append_arrayLjava_lang_Object_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "([Ljava/lang/Object;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayLjava_lang_Object_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([Ljava/lang/Object;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (lhs != null) {
					JNIEnv.CopyArray (native_lhs, lhs);
					JNIEnv.DeleteLocalRef (native_lhs);
				}
				if (rhs != null) {
					JNIEnv.CopyArray (native_rhs, rhs);
					JNIEnv.DeleteLocalRef (native_rhs);
				}
			}
		}

		static Delegate cb_append_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_;
#pragma warning disable 0169
		static Delegate GetAppend_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_Handler ()
		{
			if (cb_append_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_ == null)
				cb_append_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_);
			return cb_append_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_;
		}

		static IntPtr n_Append_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs, IntPtr native_comparator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			var rhs = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			var comparator = (global::Java.Util.IComparator)global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (native_comparator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs, comparator));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object[]'] and parameter[3][@type='java.util.Comparator&lt;?&gt;']]"
		[Register ("append", "([Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (global::Java.Lang.Object[] lhs, global::Java.Lang.Object[] rhs, global::Java.Util.IComparator comparator)
		{
			if (id_append_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_ == IntPtr.Zero)
				id_append_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_ = JNIEnv.GetMethodID (class_ref, "append", "([Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);
				__args [2] = new JValue (comparator);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayLjava_lang_Object_arrayLjava_lang_Object_Ljava_util_Comparator_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([Ljava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (lhs != null) {
					JNIEnv.CopyArray (native_lhs, lhs);
					JNIEnv.DeleteLocalRef (native_lhs);
				}
				if (rhs != null) {
					JNIEnv.CopyArray (native_rhs, rhs);
					JNIEnv.DeleteLocalRef (native_rhs);
				}
			}
		}

		static Delegate cb_append_JJ;
#pragma warning disable 0169
		static Delegate GetAppend_JJHandler ()
		{
			if (cb_append_JJ == null)
				cb_append_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_L) n_Append_JJ);
			return cb_append_JJ;
		}

		static IntPtr n_Append_JJ (IntPtr jnienv, IntPtr native__this, long lhs, long rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("append", "(JJ)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_JJHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (long lhs, long rhs)
		{
			if (id_append_JJ == IntPtr.Zero)
				id_append_JJ = JNIEnv.GetMethodID (class_ref, "append", "(JJ)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_JJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(JJ)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayJarrayJ;
#pragma warning disable 0169
		static Delegate GetAppend_arrayJarrayJHandler ()
		{
			if (cb_append_arrayJarrayJ == null)
				cb_append_arrayJarrayJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_arrayJarrayJ);
			return cb_append_arrayJarrayJ;
		}

		static IntPtr n_Append_arrayJarrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = (long[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (long));
			var rhs = (long[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (long));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayJarrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long[]']]"
		[Register ("append", "([J[J)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_arrayJarrayJHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (long[] lhs, long[] rhs)
		{
			if (id_append_arrayJarrayJ == IntPtr.Zero)
				id_append_arrayJarrayJ = JNIEnv.GetMethodID (class_ref, "append", "([J[J)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayJarrayJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([J[J)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (lhs != null) {
					JNIEnv.CopyArray (native_lhs, lhs);
					JNIEnv.DeleteLocalRef (native_lhs);
				}
				if (rhs != null) {
					JNIEnv.CopyArray (native_rhs, rhs);
					JNIEnv.DeleteLocalRef (native_rhs);
				}
			}
		}

		static Delegate cb_append_SS;
#pragma warning disable 0169
		static Delegate GetAppend_SSHandler ()
		{
			if (cb_append_SS == null)
				cb_append_SS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPSS_L) n_Append_SS);
			return cb_append_SS;
		}

		static IntPtr n_Append_SS (IntPtr jnienv, IntPtr native__this, short lhs, short rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_SS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='short']]"
		[Register ("append", "(SS)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_SSHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (short lhs, short rhs)
		{
			if (id_append_SS == IntPtr.Zero)
				id_append_SS = JNIEnv.GetMethodID (class_ref, "append", "(SS)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_SS, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(SS)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arraySarrayS;
#pragma warning disable 0169
		static Delegate GetAppend_arraySarraySHandler ()
		{
			if (cb_append_arraySarrayS == null)
				cb_append_arraySarrayS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_arraySarrayS);
			return cb_append_arraySarrayS;
		}

		static IntPtr n_Append_arraySarrayS (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = (short[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (short));
			var rhs = (short[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (short));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arraySarrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short[]']]"
		[Register ("append", "([S[S)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppend_arraySarraySHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder Append (short[] lhs, short[] rhs)
		{
			if (id_append_arraySarrayS == IntPtr.Zero)
				id_append_arraySarrayS = JNIEnv.GetMethodID (class_ref, "append", "([S[S)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arraySarrayS, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([S[S)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (lhs != null) {
					JNIEnv.CopyArray (native_lhs, lhs);
					JNIEnv.DeleteLocalRef (native_lhs);
				}
				if (rhs != null) {
					JNIEnv.CopyArray (native_rhs, rhs);
					JNIEnv.DeleteLocalRef (native_rhs);
				}
			}
		}

		static Delegate cb_appendSuper_I;
#pragma warning disable 0169
		static Delegate GetAppendSuper_IHandler ()
		{
			if (cb_appendSuper_I == null)
				cb_appendSuper_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_AppendSuper_I);
			return cb_appendSuper_I;
		}

		static IntPtr n_AppendSuper_I (IntPtr jnienv, IntPtr native__this, int superCompareTo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppendSuper (superCompareTo));
		}
#pragma warning restore 0169

		static IntPtr id_appendSuper_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='appendSuper' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("appendSuper", "(I)Lorg/apache/commons/lang3/builder/CompareToBuilder;", "GetAppendSuper_IHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder AppendSuper (int superCompareTo)
		{
			if (id_appendSuper_I == IntPtr.Zero)
				id_appendSuper_I = JNIEnv.GetMethodID (class_ref, "appendSuper", "(I)Lorg/apache/commons/lang3/builder/CompareToBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (superCompareTo);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendSuper_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSuper", "(I)Lorg/apache/commons/lang3/builder/CompareToBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Ljava/lang/Integer;", "GetBuildHandler")]
		public virtual unsafe global::Java.Lang.Integer Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Ljava/lang/Integer;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='reflectionCompare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("reflectionCompare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "")]
		public static unsafe int ReflectionCompare (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs)
		{
			if (id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionCompare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='reflectionCompare' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean']]"
		[Register ("reflectionCompare", "(Ljava/lang/Object;Ljava/lang/Object;Z)I", "")]
		public static unsafe int ReflectionCompare (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, bool compareTransients)
		{
			if (id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_Z == IntPtr.Zero)
				id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_Z = JNIEnv.GetStaticMethodID (class_ref, "reflectionCompare", "(Ljava/lang/Object;Ljava/lang/Object;Z)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (compareTransients);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='reflectionCompare' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.Class&lt;?&gt;'] and parameter[5][@type='java.lang.String...']]"
		[Register ("reflectionCompare", "(Ljava/lang/Object;Ljava/lang/Object;ZLjava/lang/Class;[Ljava/lang/String;)I", "")]
		public static unsafe int ReflectionCompare (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, bool compareTransients, global::Java.Lang.Class reflectUpToClass, params string[] excludeFields)
		{
			if (id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_ == IntPtr.Zero)
				id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionCompare", "(Ljava/lang/Object;Ljava/lang/Object;ZLjava/lang/Class;[Ljava/lang/String;)I");
			IntPtr native_excludeFields = JNIEnv.NewArray (excludeFields);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (compareTransients);
				__args [3] = new JValue (reflectUpToClass);
				__args [4] = new JValue (native_excludeFields);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (excludeFields != null) {
					JNIEnv.CopyArray (native_excludeFields, excludeFields);
					JNIEnv.DeleteLocalRef (native_excludeFields);
				}
			}
		}

		static IntPtr id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='reflectionCompare' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String...']]"
		[Register ("reflectionCompare", "(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)I", "")]
		public static unsafe int ReflectionCompare (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, params string[] excludeFields)
		{
			if (id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ == IntPtr.Zero)
				id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionCompare", "(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)I");
			IntPtr native_excludeFields = JNIEnv.NewArray (excludeFields);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (native_excludeFields);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (excludeFields != null) {
					JNIEnv.CopyArray (native_excludeFields, excludeFields);
					JNIEnv.DeleteLocalRef (native_excludeFields);
				}
			}
		}

		static IntPtr id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='reflectionCompare' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("reflectionCompare", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Collection;)I", "")]
		public static unsafe int ReflectionCompare (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, global::System.Collections.Generic.ICollection<string> excludeFields)
		{
			if (id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Collection_ == IntPtr.Zero)
				id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionCompare", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Collection;)I");
			IntPtr native_excludeFields = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (excludeFields);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (native_excludeFields);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_reflectionCompare_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Collection_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_excludeFields);
			}
		}

		static Delegate cb_toComparison;
#pragma warning disable 0169
		static Delegate GetToComparisonHandler ()
		{
			if (cb_toComparison == null)
				cb_toComparison = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_ToComparison);
			return cb_toComparison;
		}

		static int n_ToComparison (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.CompareToBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ToComparison ();
		}
#pragma warning restore 0169

		static IntPtr id_toComparison;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='CompareToBuilder']/method[@name='toComparison' and count(parameter)=0]"
		[Register ("toComparison", "()I", "GetToComparisonHandler")]
		public virtual unsafe int ToComparison ()
		{
			if (id_toComparison == IntPtr.Zero)
				id_toComparison = JNIEnv.GetMethodID (class_ref, "toComparison", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_toComparison);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toComparison", "()I"));
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Org.Apache.Commons.Lang3.Builder.IBuilder
		global::Java.Lang.Object global::Org.Apache.Commons.Lang3.Builder.IBuilder.Build ()
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Build ());
		}

	}
}
