using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/EqualsBuilder", DoNotGenerateAcw=true)]
	public partial class EqualsBuilder : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Builder.IBuilder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/builder/EqualsBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EqualsBuilder); }
		}

		protected EqualsBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/constructor[@name='EqualsBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EqualsBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EqualsBuilder)) {
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

		static Delegate cb_isEquals;
#pragma warning disable 0169
		static Delegate GetIsEqualsHandler ()
		{
			if (cb_isEquals == null)
				cb_isEquals = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEquals);
			return cb_isEquals;
		}

		static bool n_IsEquals (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEquals;
		}
#pragma warning restore 0169

		static IntPtr id_isEquals;
		public virtual unsafe bool IsEquals {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='isEquals' and count(parameter)=0]"
			[Register ("isEquals", "()Z", "GetIsEqualsHandler")]
			get {
				if (id_isEquals == IntPtr.Zero)
					id_isEquals = JNIEnv.GetMethodID (class_ref, "isEquals", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEquals);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEquals", "()Z"));
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("append", "(ZZ)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_ZZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (bool lhs, bool rhs)
		{
			if (id_append_ZZ == IntPtr.Zero)
				id_append_ZZ = JNIEnv.GetMethodID (class_ref, "append", "(ZZ)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(ZZ)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean[]']]"
		[Register ("append", "([Z[Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_arrayZarrayZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (bool[] lhs, bool[] rhs)
		{
			if (id_append_arrayZarrayZ == IntPtr.Zero)
				id_append_arrayZarrayZ = JNIEnv.GetMethodID (class_ref, "append", "([Z[Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayZarrayZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([Z[Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_BB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("append", "(BB)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_BBHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (sbyte lhs, sbyte rhs)
		{
			if (id_append_BB == IntPtr.Zero)
				id_append_BB = JNIEnv.GetMethodID (class_ref, "append", "(BB)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_BB, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(BB)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("append", "([B[B)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_arrayBarrayBHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (byte[] lhs, byte[] rhs)
		{
			if (id_append_arrayBarrayB == IntPtr.Zero)
				id_append_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "append", "([B[B)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([B[B)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_CC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
		[Register ("append", "(CC)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_CCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (char lhs, char rhs)
		{
			if (id_append_CC == IntPtr.Zero)
				id_append_CC = JNIEnv.GetMethodID (class_ref, "append", "(CC)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_CC, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(CC)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char[]']]"
		[Register ("append", "([C[C)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_arrayCarrayCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (char[] lhs, char[] rhs)
		{
			if (id_append_arrayCarrayC == IntPtr.Zero)
				id_append_arrayCarrayC = JNIEnv.GetMethodID (class_ref, "append", "([C[C)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayCarrayC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([C[C)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("append", "(DD)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_DDHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (double lhs, double rhs)
		{
			if (id_append_DD == IntPtr.Zero)
				id_append_DD = JNIEnv.GetMethodID (class_ref, "append", "(DD)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_DD, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(DD)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("append", "([D[D)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_arrayDarrayDHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (double[] lhs, double[] rhs)
		{
			if (id_append_arrayDarrayD == IntPtr.Zero)
				id_append_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "append", "([D[D)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayDarrayD, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([D[D)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("append", "(FF)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_FFHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (float lhs, float rhs)
		{
			if (id_append_FF == IntPtr.Zero)
				id_append_FF = JNIEnv.GetMethodID (class_ref, "append", "(FF)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_FF, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(FF)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register ("append", "([F[F)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_arrayFarrayFHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (float[] lhs, float[] rhs)
		{
			if (id_append_arrayFarrayF == IntPtr.Zero)
				id_append_arrayFarrayF = JNIEnv.GetMethodID (class_ref, "append", "([F[F)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayFarrayF, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([F[F)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("append", "(II)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (int lhs, int rhs)
		{
			if (id_append_II == IntPtr.Zero)
				id_append_II = JNIEnv.GetMethodID (class_ref, "append", "(II)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(II)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("append", "([I[I)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_arrayIarrayIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (int[] lhs, int[] rhs)
		{
			if (id_append_arrayIarrayI == IntPtr.Zero)
				id_append_arrayIarrayI = JNIEnv.GetMethodID (class_ref, "append", "([I[I)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([I[I)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_lhs, JniHandleOwnership.DoNotTransfer);
			var rhs = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_rhs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("append", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs)
		{
			if (id_append_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_append_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("append", "([Ljava/lang/Object;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_arrayLjava_lang_Object_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (global::Java.Lang.Object[] lhs, global::Java.Lang.Object[] rhs)
		{
			if (id_append_arrayLjava_lang_Object_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_append_arrayLjava_lang_Object_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "([Ljava/lang/Object;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayLjava_lang_Object_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([Ljava/lang/Object;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("append", "(JJ)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_JJHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (long lhs, long rhs)
		{
			if (id_append_JJ == IntPtr.Zero)
				id_append_JJ = JNIEnv.GetMethodID (class_ref, "append", "(JJ)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_JJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(JJ)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long[]']]"
		[Register ("append", "([J[J)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_arrayJarrayJHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (long[] lhs, long[] rhs)
		{
			if (id_append_arrayJarrayJ == IntPtr.Zero)
				id_append_arrayJarrayJ = JNIEnv.GetMethodID (class_ref, "append", "([J[J)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayJarrayJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([J[J)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (lhs, rhs));
		}
#pragma warning restore 0169

		static IntPtr id_append_SS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='short']]"
		[Register ("append", "(SS)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_SSHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (short lhs, short rhs)
		{
			if (id_append_SS == IntPtr.Zero)
				id_append_SS = JNIEnv.GetMethodID (class_ref, "append", "(SS)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_SS, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(SS)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short[]']]"
		[Register ("append", "([S[S)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppend_arraySarraySHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder Append (short[] lhs, short[] rhs)
		{
			if (id_append_arraySarrayS == IntPtr.Zero)
				id_append_arraySarrayS = JNIEnv.GetMethodID (class_ref, "append", "([S[S)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arraySarrayS, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([S[S)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static Delegate cb_appendSuper_Z;
#pragma warning disable 0169
		static Delegate GetAppendSuper_ZHandler ()
		{
			if (cb_appendSuper_Z == null)
				cb_appendSuper_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_AppendSuper_Z);
			return cb_appendSuper_Z;
		}

		static IntPtr n_AppendSuper_Z (IntPtr jnienv, IntPtr native__this, bool superEquals)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppendSuper (superEquals));
		}
#pragma warning restore 0169

		static IntPtr id_appendSuper_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='appendSuper' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("appendSuper", "(Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetAppendSuper_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder AppendSuper (bool superEquals)
		{
			if (id_appendSuper_Z == IntPtr.Zero)
				id_appendSuper_Z = JNIEnv.GetMethodID (class_ref, "appendSuper", "(Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (superEquals);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendSuper_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSuper", "(Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Ljava/lang/Boolean;", "GetBuildHandler")]
		public virtual unsafe global::Java.Lang.Boolean Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Ljava/lang/Boolean;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reflectionAppend_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetReflectionAppend_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_reflectionAppend_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_reflectionAppend_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ReflectionAppend_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_reflectionAppend_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_ReflectionAppend_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lhs = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_lhs, JniHandleOwnership.DoNotTransfer);
			var rhs = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_rhs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReflectionAppend (lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_reflectionAppend_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='reflectionAppend' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("reflectionAppend", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetReflectionAppend_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder ReflectionAppend (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs)
		{
			if (id_reflectionAppend_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_reflectionAppend_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "reflectionAppend", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reflectionAppend_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reflectionAppend", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='reflectionEquals' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean']]"
		[Register ("reflectionEquals", "(Ljava/lang/Object;Ljava/lang/Object;Z)Z", "")]
		public static unsafe bool ReflectionEquals (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, bool testTransients)
		{
			if (id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_Z == IntPtr.Zero)
				id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_Z = JNIEnv.GetStaticMethodID (class_ref, "reflectionEquals", "(Ljava/lang/Object;Ljava/lang/Object;Z)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (testTransients);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_ZarrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='reflectionEquals' and count(parameter)=6 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.Class&lt;?&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='java.lang.String...']]"
		[Register ("reflectionEquals", "(Ljava/lang/Object;Ljava/lang/Object;ZLjava/lang/Class;Z[Ljava/lang/String;)Z", "")]
		public static unsafe bool ReflectionEquals (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, bool testTransients, global::Java.Lang.Class reflectUpToClass, bool testRecursive, params string[] excludeFields)
		{
			if (id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_ZarrayLjava_lang_String_ == IntPtr.Zero)
				id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_ZarrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionEquals", "(Ljava/lang/Object;Ljava/lang/Object;ZLjava/lang/Class;Z[Ljava/lang/String;)Z");
			IntPtr native_excludeFields = JNIEnv.NewArray (excludeFields);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (testTransients);
				__args [3] = new JValue (reflectUpToClass);
				__args [4] = new JValue (testRecursive);
				__args [5] = new JValue (native_excludeFields);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_ZarrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (excludeFields != null) {
					JNIEnv.CopyArray (native_excludeFields, excludeFields);
					JNIEnv.DeleteLocalRef (native_excludeFields);
				}
			}
		}

		static IntPtr id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='reflectionEquals' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.Class&lt;?&gt;'] and parameter[5][@type='java.lang.String...']]"
		[Register ("reflectionEquals", "(Ljava/lang/Object;Ljava/lang/Object;ZLjava/lang/Class;[Ljava/lang/String;)Z", "")]
		public static unsafe bool ReflectionEquals (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, bool testTransients, global::Java.Lang.Class reflectUpToClass, params string[] excludeFields)
		{
			if (id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_ == IntPtr.Zero)
				id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionEquals", "(Ljava/lang/Object;Ljava/lang/Object;ZLjava/lang/Class;[Ljava/lang/String;)Z");
			IntPtr native_excludeFields = JNIEnv.NewArray (excludeFields);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (testTransients);
				__args [3] = new JValue (reflectUpToClass);
				__args [4] = new JValue (native_excludeFields);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (excludeFields != null) {
					JNIEnv.CopyArray (native_excludeFields, excludeFields);
					JNIEnv.DeleteLocalRef (native_excludeFields);
				}
			}
		}

		static IntPtr id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='reflectionEquals' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String...']]"
		[Register ("reflectionEquals", "(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)Z", "")]
		public static unsafe bool ReflectionEquals (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, params string[] excludeFields)
		{
			if (id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ == IntPtr.Zero)
				id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionEquals", "(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)Z");
			IntPtr native_excludeFields = JNIEnv.NewArray (excludeFields);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (native_excludeFields);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (excludeFields != null) {
					JNIEnv.CopyArray (native_excludeFields, excludeFields);
					JNIEnv.DeleteLocalRef (native_excludeFields);
				}
			}
		}

		static IntPtr id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='reflectionEquals' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("reflectionEquals", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Collection;)Z", "")]
		public static unsafe bool ReflectionEquals (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, global::System.Collections.Generic.ICollection<string> excludeFields)
		{
			if (id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Collection_ == IntPtr.Zero)
				id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionEquals", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Collection;)Z");
			IntPtr native_excludeFields = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (excludeFields);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (native_excludeFields);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_reflectionEquals_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Collection_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_excludeFields);
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_setBypassReflectionClasses_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetBypassReflectionClasses_Ljava_util_List_Handler ()
		{
			if (cb_setBypassReflectionClasses_Ljava_util_List_ == null)
				cb_setBypassReflectionClasses_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetBypassReflectionClasses_Ljava_util_List_);
			return cb_setBypassReflectionClasses_Ljava_util_List_;
		}

		static IntPtr n_SetBypassReflectionClasses_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bypassReflectionClasses)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bypassReflectionClasses = global::Android.Runtime.JavaList<global::Java.Lang.Class>.FromJniHandle (native_bypassReflectionClasses, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBypassReflectionClasses (bypassReflectionClasses));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setBypassReflectionClasses_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='setBypassReflectionClasses' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Class&lt;?&gt;&gt;']]"
		[Register ("setBypassReflectionClasses", "(Ljava/util/List;)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetSetBypassReflectionClasses_Ljava_util_List_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder SetBypassReflectionClasses (global::System.Collections.Generic.IList<global::Java.Lang.Class> bypassReflectionClasses)
		{
			if (id_setBypassReflectionClasses_Ljava_util_List_ == IntPtr.Zero)
				id_setBypassReflectionClasses_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setBypassReflectionClasses", "(Ljava/util/List;)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			IntPtr native_bypassReflectionClasses = global::Android.Runtime.JavaList<global::Java.Lang.Class>.ToLocalJniHandle (bypassReflectionClasses);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bypassReflectionClasses);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setBypassReflectionClasses_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBypassReflectionClasses", "(Ljava/util/List;)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_bypassReflectionClasses);
			}
		}

		static Delegate cb_setEquals_Z;
#pragma warning disable 0169
		static Delegate GetSetEquals_ZHandler ()
		{
			if (cb_setEquals_Z == null)
				cb_setEquals_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEquals_Z);
			return cb_setEquals_Z;
		}

		static void n_SetEquals_Z (IntPtr jnienv, IntPtr native__this, bool isEquals)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEquals (isEquals);
		}
#pragma warning restore 0169

		static IntPtr id_setEquals_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='setEquals' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEquals", "(Z)V", "GetSetEquals_ZHandler")]
		protected virtual unsafe void SetEquals (bool isEquals)
		{
			if (id_setEquals_Z == IntPtr.Zero)
				id_setEquals_Z = JNIEnv.GetMethodID (class_ref, "setEquals", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (isEquals);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEquals_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEquals", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setExcludeFields_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExcludeFields_arrayLjava_lang_String_Handler ()
		{
			if (cb_setExcludeFields_arrayLjava_lang_String_ == null)
				cb_setExcludeFields_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetExcludeFields_arrayLjava_lang_String_);
			return cb_setExcludeFields_arrayLjava_lang_String_;
		}

		static IntPtr n_SetExcludeFields_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_excludeFields)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var excludeFields = (string[]) JNIEnv.GetArray (native_excludeFields, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetExcludeFields (excludeFields));
			if (excludeFields != null)
				JNIEnv.CopyArray (excludeFields, native_excludeFields);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setExcludeFields_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='setExcludeFields' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setExcludeFields", "([Ljava/lang/String;)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetSetExcludeFields_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder SetExcludeFields (params string[] excludeFields)
		{
			if (id_setExcludeFields_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setExcludeFields_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExcludeFields", "([Ljava/lang/String;)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			IntPtr native_excludeFields = JNIEnv.NewArray (excludeFields);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_excludeFields);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setExcludeFields_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExcludeFields", "([Ljava/lang/String;)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (excludeFields != null) {
					JNIEnv.CopyArray (native_excludeFields, excludeFields);
					JNIEnv.DeleteLocalRef (native_excludeFields);
				}
			}
		}

		static Delegate cb_setReflectUpToClass_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSetReflectUpToClass_Ljava_lang_Class_Handler ()
		{
			if (cb_setReflectUpToClass_Ljava_lang_Class_ == null)
				cb_setReflectUpToClass_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetReflectUpToClass_Ljava_lang_Class_);
			return cb_setReflectUpToClass_Ljava_lang_Class_;
		}

		static IntPtr n_SetReflectUpToClass_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reflectUpToClass)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reflectUpToClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_reflectUpToClass, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetReflectUpToClass (reflectUpToClass));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setReflectUpToClass_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='setReflectUpToClass' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("setReflectUpToClass", "(Ljava/lang/Class;)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetSetReflectUpToClass_Ljava_lang_Class_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder SetReflectUpToClass (global::Java.Lang.Class reflectUpToClass)
		{
			if (id_setReflectUpToClass_Ljava_lang_Class_ == IntPtr.Zero)
				id_setReflectUpToClass_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setReflectUpToClass", "(Ljava/lang/Class;)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (reflectUpToClass);

				global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReflectUpToClass_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReflectUpToClass", "(Ljava/lang/Class;)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setTestRecursive_Z;
#pragma warning disable 0169
		static Delegate GetSetTestRecursive_ZHandler ()
		{
			if (cb_setTestRecursive_Z == null)
				cb_setTestRecursive_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetTestRecursive_Z);
			return cb_setTestRecursive_Z;
		}

		static IntPtr n_SetTestRecursive_Z (IntPtr jnienv, IntPtr native__this, bool testRecursive)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTestRecursive (testRecursive));
		}
#pragma warning restore 0169

		static IntPtr id_setTestRecursive_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='setTestRecursive' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTestRecursive", "(Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetSetTestRecursive_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder SetTestRecursive (bool testRecursive)
		{
			if (id_setTestRecursive_Z == IntPtr.Zero)
				id_setTestRecursive_Z = JNIEnv.GetMethodID (class_ref, "setTestRecursive", "(Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (testRecursive);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTestRecursive_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTestRecursive", "(Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTestTransients_Z;
#pragma warning disable 0169
		static Delegate GetSetTestTransients_ZHandler ()
		{
			if (cb_setTestTransients_Z == null)
				cb_setTestTransients_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetTestTransients_Z);
			return cb_setTestTransients_Z;
		}

		static IntPtr n_SetTestTransients_Z (IntPtr jnienv, IntPtr native__this, bool testTransients)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTestTransients (testTransients));
		}
#pragma warning restore 0169

		static IntPtr id_setTestTransients_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='EqualsBuilder']/method[@name='setTestTransients' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTestTransients", "(Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;", "GetSetTestTransients_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder SetTestTransients (bool testTransients)
		{
			if (id_setTestTransients_Z == IntPtr.Zero)
				id_setTestTransients_Z = JNIEnv.GetMethodID (class_ref, "setTestTransients", "(Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (testTransients);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTestTransients_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.EqualsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTestTransients", "(Z)Lorg/apache/commons/lang3/builder/EqualsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
