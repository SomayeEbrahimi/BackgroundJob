using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/HashCodeBuilder", DoNotGenerateAcw=true)]
	public partial class HashCodeBuilder : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Builder.IBuilder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/builder/HashCodeBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HashCodeBuilder); }
		}

		protected HashCodeBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/constructor[@name='HashCodeBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HashCodeBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HashCodeBuilder)) {
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

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/constructor[@name='HashCodeBuilder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe HashCodeBuilder (int initialOddNumber, int multiplierOddNumber)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (initialOddNumber);
				__args [1] = new JValue (multiplierOddNumber);
				if (((object) this).GetType () != typeof (HashCodeBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_append_Z;
#pragma warning disable 0169
		static Delegate GetAppend_ZHandler ()
		{
			if (cb_append_Z == null)
				cb_append_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Append_Z);
			return cb_append_Z;
		}

		static IntPtr n_Append_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("append", "(Z)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (bool value)
		{
			if (id_append_Z == IntPtr.Zero)
				id_append_Z = JNIEnv.GetMethodID (class_ref, "append", "(Z)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Z)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayZ;
#pragma warning disable 0169
		static Delegate GetAppend_arrayZHandler ()
		{
			if (cb_append_arrayZ == null)
				cb_append_arrayZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_arrayZ);
			return cb_append_arrayZ;
		}

		static IntPtr n_Append_arrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (bool[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (bool));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("append", "([Z)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_arrayZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (bool[] array)
		{
			if (id_append_arrayZ == IntPtr.Zero)
				id_append_arrayZ = JNIEnv.GetMethodID (class_ref, "append", "([Z)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([Z)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_B;
#pragma warning disable 0169
		static Delegate GetAppend_BHandler ()
		{
			if (cb_append_B == null)
				cb_append_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_L) n_Append_B);
			return cb_append_B;
		}

		static IntPtr n_Append_B (IntPtr jnienv, IntPtr native__this, sbyte value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("append", "(B)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_BHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (sbyte value)
		{
			if (id_append_B == IntPtr.Zero)
				id_append_B = JNIEnv.GetMethodID (class_ref, "append", "(B)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_B, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(B)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayB;
#pragma warning disable 0169
		static Delegate GetAppend_arrayBHandler ()
		{
			if (cb_append_arrayB == null)
				cb_append_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_arrayB);
			return cb_append_arrayB;
		}

		static IntPtr n_Append_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (byte[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("append", "([B)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_arrayBHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (byte[] array)
		{
			if (id_append_arrayB == IntPtr.Zero)
				id_append_arrayB = JNIEnv.GetMethodID (class_ref, "append", "([B)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([B)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_C;
#pragma warning disable 0169
		static Delegate GetAppend_CHandler ()
		{
			if (cb_append_C == null)
				cb_append_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_Append_C);
			return cb_append_C;
		}

		static IntPtr n_Append_C (IntPtr jnienv, IntPtr native__this, char value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("append", "(C)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (char value)
		{
			if (id_append_C == IntPtr.Zero)
				id_append_C = JNIEnv.GetMethodID (class_ref, "append", "(C)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(C)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayC;
#pragma warning disable 0169
		static Delegate GetAppend_arrayCHandler ()
		{
			if (cb_append_arrayC == null)
				cb_append_arrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_arrayC);
			return cb_append_arrayC;
		}

		static IntPtr n_Append_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (char[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("append", "([C)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_arrayCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (char[] array)
		{
			if (id_append_arrayC == IntPtr.Zero)
				id_append_arrayC = JNIEnv.GetMethodID (class_ref, "append", "([C)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([C)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_D;
#pragma warning disable 0169
		static Delegate GetAppend_DHandler ()
		{
			if (cb_append_D == null)
				cb_append_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_L) n_Append_D);
			return cb_append_D;
		}

		static IntPtr n_Append_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("append", "(D)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_DHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (double value)
		{
			if (id_append_D == IntPtr.Zero)
				id_append_D = JNIEnv.GetMethodID (class_ref, "append", "(D)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(D)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayD;
#pragma warning disable 0169
		static Delegate GetAppend_arrayDHandler ()
		{
			if (cb_append_arrayD == null)
				cb_append_arrayD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_arrayD);
			return cb_append_arrayD;
		}

		static IntPtr n_Append_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (double[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("append", "([D)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_arrayDHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (double[] array)
		{
			if (id_append_arrayD == IntPtr.Zero)
				id_append_arrayD = JNIEnv.GetMethodID (class_ref, "append", "([D)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayD, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([D)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_F;
#pragma warning disable 0169
		static Delegate GetAppend_FHandler ()
		{
			if (cb_append_F == null)
				cb_append_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_Append_F);
			return cb_append_F;
		}

		static IntPtr n_Append_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("append", "(F)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_FHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (float value)
		{
			if (id_append_F == IntPtr.Zero)
				id_append_F = JNIEnv.GetMethodID (class_ref, "append", "(F)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(F)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayF;
#pragma warning disable 0169
		static Delegate GetAppend_arrayFHandler ()
		{
			if (cb_append_arrayF == null)
				cb_append_arrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_arrayF);
			return cb_append_arrayF;
		}

		static IntPtr n_Append_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (float[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("append", "([F)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_arrayFHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (float[] array)
		{
			if (id_append_arrayF == IntPtr.Zero)
				id_append_arrayF = JNIEnv.GetMethodID (class_ref, "append", "([F)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([F)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_I;
#pragma warning disable 0169
		static Delegate GetAppend_IHandler ()
		{
			if (cb_append_I == null)
				cb_append_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Append_I);
			return cb_append_I;
		}

		static IntPtr n_Append_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("append", "(I)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_IHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (int value)
		{
			if (id_append_I == IntPtr.Zero)
				id_append_I = JNIEnv.GetMethodID (class_ref, "append", "(I)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(I)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayI;
#pragma warning disable 0169
		static Delegate GetAppend_arrayIHandler ()
		{
			if (cb_append_arrayI == null)
				cb_append_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_arrayI);
			return cb_append_arrayI;
		}

		static IntPtr n_Append_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (int[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("append", "([I)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_arrayIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (int[] array)
		{
			if (id_append_arrayI == IntPtr.Zero)
				id_append_arrayI = JNIEnv.GetMethodID (class_ref, "append", "([I)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([I)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_Object_Handler ()
		{
			if (cb_append_Ljava_lang_Object_ == null)
				cb_append_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_Ljava_lang_Object_);
			return cb_append_Ljava_lang_Object_;
		}

		static IntPtr n_Append_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (@object));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("append", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (global::Java.Lang.Object @object)
		{
			if (id_append_Ljava_lang_Object_ == IntPtr.Zero)
				id_append_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);

				global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_append_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_arrayLjava_lang_Object_Handler ()
		{
			if (cb_append_arrayLjava_lang_Object_ == null)
				cb_append_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_arrayLjava_lang_Object_);
			return cb_append_arrayLjava_lang_Object_;
		}

		static IntPtr n_Append_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("append", "([Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (global::Java.Lang.Object[] array)
		{
			if (id_append_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_append_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "([Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_J;
#pragma warning disable 0169
		static Delegate GetAppend_JHandler ()
		{
			if (cb_append_J == null)
				cb_append_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_Append_J);
			return cb_append_J;
		}

		static IntPtr n_Append_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("append", "(J)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_JHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (long value)
		{
			if (id_append_J == IntPtr.Zero)
				id_append_J = JNIEnv.GetMethodID (class_ref, "append", "(J)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(J)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayJ;
#pragma warning disable 0169
		static Delegate GetAppend_arrayJHandler ()
		{
			if (cb_append_arrayJ == null)
				cb_append_arrayJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_arrayJ);
			return cb_append_arrayJ;
		}

		static IntPtr n_Append_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (long[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (long));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("append", "([J)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_arrayJHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (long[] array)
		{
			if (id_append_arrayJ == IntPtr.Zero)
				id_append_arrayJ = JNIEnv.GetMethodID (class_ref, "append", "([J)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([J)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_S;
#pragma warning disable 0169
		static Delegate GetAppend_SHandler ()
		{
			if (cb_append_S == null)
				cb_append_S = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPS_L) n_Append_S);
			return cb_append_S;
		}

		static IntPtr n_Append_S (IntPtr jnienv, IntPtr native__this, short value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("append", "(S)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_SHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (short value)
		{
			if (id_append_S == IntPtr.Zero)
				id_append_S = JNIEnv.GetMethodID (class_ref, "append", "(S)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_S, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(S)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayS;
#pragma warning disable 0169
		static Delegate GetAppend_arraySHandler ()
		{
			if (cb_append_arrayS == null)
				cb_append_arrayS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_arrayS);
			return cb_append_arrayS;
		}

		static IntPtr n_Append_arrayS (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (short[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (short));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("append", "([S)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppend_arraySHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder Append (short[] array)
		{
			if (id_append_arrayS == IntPtr.Zero)
				id_append_arrayS = JNIEnv.GetMethodID (class_ref, "append", "([S)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayS, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([S)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
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

		static IntPtr n_AppendSuper_I (IntPtr jnienv, IntPtr native__this, int superHashCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppendSuper (superHashCode));
		}
#pragma warning restore 0169

		static IntPtr id_appendSuper_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='appendSuper' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("appendSuper", "(I)Lorg/apache/commons/lang3/builder/HashCodeBuilder;", "GetAppendSuper_IHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder AppendSuper (int superHashCode)
		{
			if (id_appendSuper_I == IntPtr.Zero)
				id_appendSuper_I = JNIEnv.GetMethodID (class_ref, "appendSuper", "(I)Lorg/apache/commons/lang3/builder/HashCodeBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (superHashCode);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendSuper_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSuper", "(I)Lorg/apache/commons/lang3/builder/HashCodeBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='build' and count(parameter)=0]"
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

		static IntPtr id_reflectionHashCode_IILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='reflectionHashCode' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("reflectionHashCode", "(IILjava/lang/Object;)I", "")]
		public static unsafe int ReflectionHashCode (int initialNonZeroOddNumber, int multiplierNonZeroOddNumber, global::Java.Lang.Object @object)
		{
			if (id_reflectionHashCode_IILjava_lang_Object_ == IntPtr.Zero)
				id_reflectionHashCode_IILjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionHashCode", "(IILjava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (initialNonZeroOddNumber);
				__args [1] = new JValue (multiplierNonZeroOddNumber);
				__args [2] = new JValue (@object);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_reflectionHashCode_IILjava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reflectionHashCode_IILjava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='reflectionHashCode' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='boolean']]"
		[Register ("reflectionHashCode", "(IILjava/lang/Object;Z)I", "")]
		public static unsafe int ReflectionHashCode (int initialNonZeroOddNumber, int multiplierNonZeroOddNumber, global::Java.Lang.Object @object, bool testTransients)
		{
			if (id_reflectionHashCode_IILjava_lang_Object_Z == IntPtr.Zero)
				id_reflectionHashCode_IILjava_lang_Object_Z = JNIEnv.GetStaticMethodID (class_ref, "reflectionHashCode", "(IILjava/lang/Object;Z)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (initialNonZeroOddNumber);
				__args [1] = new JValue (multiplierNonZeroOddNumber);
				__args [2] = new JValue (@object);
				__args [3] = new JValue (testTransients);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_reflectionHashCode_IILjava_lang_Object_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reflectionHashCode_IILjava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='reflectionHashCode' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='T'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.Class&lt;? super T&gt;'] and parameter[6][@type='java.lang.String...']]"
		[Register ("reflectionHashCode", "(IILjava/lang/Object;ZLjava/lang/Class;[Ljava/lang/String;)I", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe int ReflectionHashCode (int initialNonZeroOddNumber, int multiplierNonZeroOddNumber, global::Java.Lang.Object @object, bool testTransients, global::Java.Lang.Class reflectUpToClass, params string[] excludeFields)
		{
			if (id_reflectionHashCode_IILjava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_ == IntPtr.Zero)
				id_reflectionHashCode_IILjava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionHashCode", "(IILjava/lang/Object;ZLjava/lang/Class;[Ljava/lang/String;)I");
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			IntPtr native_excludeFields = JNIEnv.NewArray (excludeFields);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (initialNonZeroOddNumber);
				__args [1] = new JValue (multiplierNonZeroOddNumber);
				__args [2] = new JValue (native__object);
				__args [3] = new JValue (testTransients);
				__args [4] = new JValue (reflectUpToClass);
				__args [5] = new JValue (native_excludeFields);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_reflectionHashCode_IILjava_lang_Object_ZLjava_lang_Class_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
				if (excludeFields != null) {
					JNIEnv.CopyArray (native_excludeFields, excludeFields);
					JNIEnv.DeleteLocalRef (native_excludeFields);
				}
			}
		}

		static IntPtr id_reflectionHashCode_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='reflectionHashCode' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean']]"
		[Register ("reflectionHashCode", "(Ljava/lang/Object;Z)I", "")]
		public static unsafe int ReflectionHashCode (global::Java.Lang.Object @object, bool testTransients)
		{
			if (id_reflectionHashCode_Ljava_lang_Object_Z == IntPtr.Zero)
				id_reflectionHashCode_Ljava_lang_Object_Z = JNIEnv.GetStaticMethodID (class_ref, "reflectionHashCode", "(Ljava/lang/Object;Z)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (testTransients);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_reflectionHashCode_Ljava_lang_Object_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reflectionHashCode_Ljava_lang_Object_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='reflectionHashCode' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String...']]"
		[Register ("reflectionHashCode", "(Ljava/lang/Object;[Ljava/lang/String;)I", "")]
		public static unsafe int ReflectionHashCode (global::Java.Lang.Object @object, params string[] excludeFields)
		{
			if (id_reflectionHashCode_Ljava_lang_Object_arrayLjava_lang_String_ == IntPtr.Zero)
				id_reflectionHashCode_Ljava_lang_Object_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionHashCode", "(Ljava/lang/Object;[Ljava/lang/String;)I");
			IntPtr native_excludeFields = JNIEnv.NewArray (excludeFields);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_excludeFields);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_reflectionHashCode_Ljava_lang_Object_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (excludeFields != null) {
					JNIEnv.CopyArray (native_excludeFields, excludeFields);
					JNIEnv.DeleteLocalRef (native_excludeFields);
				}
			}
		}

		static IntPtr id_reflectionHashCode_Ljava_lang_Object_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='reflectionHashCode' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("reflectionHashCode", "(Ljava/lang/Object;Ljava/util/Collection;)I", "")]
		public static unsafe int ReflectionHashCode (global::Java.Lang.Object @object, global::System.Collections.Generic.ICollection<string> excludeFields)
		{
			if (id_reflectionHashCode_Ljava_lang_Object_Ljava_util_Collection_ == IntPtr.Zero)
				id_reflectionHashCode_Ljava_lang_Object_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionHashCode", "(Ljava/lang/Object;Ljava/util/Collection;)I");
			IntPtr native_excludeFields = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (excludeFields);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_excludeFields);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_reflectionHashCode_Ljava_lang_Object_Ljava_util_Collection_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_excludeFields);
			}
		}

		static Delegate cb_toHashCode;
#pragma warning disable 0169
		static Delegate GetToHashCodeHandler ()
		{
			if (cb_toHashCode == null)
				cb_toHashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_ToHashCode);
			return cb_toHashCode;
		}

		static int n_ToHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.HashCodeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ToHashCode ();
		}
#pragma warning restore 0169

		static IntPtr id_toHashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='HashCodeBuilder']/method[@name='toHashCode' and count(parameter)=0]"
		[Register ("toHashCode", "()I", "GetToHashCodeHandler")]
		public virtual unsafe int ToHashCode ()
		{
			if (id_toHashCode == IntPtr.Zero)
				id_toHashCode = JNIEnv.GetMethodID (class_ref, "toHashCode", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_toHashCode);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toHashCode", "()I"));
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
