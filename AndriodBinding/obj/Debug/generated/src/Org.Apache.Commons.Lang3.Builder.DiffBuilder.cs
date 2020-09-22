using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/DiffBuilder", DoNotGenerateAcw=true)]
	public partial class DiffBuilder : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Builder.IBuilder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/builder/DiffBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiffBuilder); }
		}

		protected DiffBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/constructor[@name='DiffBuilder' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.apache.commons.lang3.builder.ToStringStyle']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V", "")]
		public unsafe DiffBuilder (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (style);
				if (((object) this).GetType () != typeof (DiffBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/constructor[@name='DiffBuilder' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.apache.commons.lang3.builder.ToStringStyle'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Z)V", "")]
		public unsafe DiffBuilder (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style, bool testTriviallyEqual)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (lhs);
				__args [1] = new JValue (rhs);
				__args [2] = new JValue (style);
				__args [3] = new JValue (testTriviallyEqual);
				if (((object) this).GetType () != typeof (DiffBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z, __args);
			} finally {
			}
		}

		static Delegate cb_append_Ljava_lang_String_ZZ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_ZZHandler ()
		{
			if (cb_append_Ljava_lang_String_ZZ == null)
				cb_append_Ljava_lang_String_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZ_L) n_Append_Ljava_lang_String_ZZ);
			return cb_append_Ljava_lang_String_ZZ;
		}

		static IntPtr n_Append_Ljava_lang_String_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, bool lhs, bool rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;ZZ)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_ZZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, bool lhs, bool rhs)
		{
			if (id_append_Ljava_lang_String_ZZ == IntPtr.Zero)
				id_append_Ljava_lang_String_ZZ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;ZZ)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (lhs);
				__args [2] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;ZZ)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayZarrayZ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayZarrayZHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayZarrayZ == null)
				cb_append_Ljava_lang_String_arrayZarrayZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_Ljava_lang_String_arrayZarrayZ);
			return cb_append_Ljava_lang_String_arrayZarrayZ;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayZarrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var lhs = (bool[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (bool));
			var rhs = (bool[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (bool));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayZarrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean[]'] and parameter[3][@type='boolean[]']]"
		[Register ("append", "(Ljava/lang/String;[Z[Z)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_arrayZarrayZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, bool[] lhs, bool[] rhs)
		{
			if (id_append_Ljava_lang_String_arrayZarrayZ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayZarrayZ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[Z[Z)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_lhs);
				__args [2] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayZarrayZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[Z[Z)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
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

		static Delegate cb_append_Ljava_lang_String_BB;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_BBHandler ()
		{
			if (cb_append_Ljava_lang_String_BB == null)
				cb_append_Ljava_lang_String_BB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLBB_L) n_Append_Ljava_lang_String_BB);
			return cb_append_Ljava_lang_String_BB;
		}

		static IntPtr n_Append_Ljava_lang_String_BB (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, sbyte lhs, sbyte rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_BB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte'] and parameter[3][@type='byte']]"
		[Register ("append", "(Ljava/lang/String;BB)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_BBHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, sbyte lhs, sbyte rhs)
		{
			if (id_append_Ljava_lang_String_BB == IntPtr.Zero)
				id_append_Ljava_lang_String_BB = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;BB)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (lhs);
				__args [2] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_BB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;BB)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayBarrayBHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayBarrayB == null)
				cb_append_Ljava_lang_String_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_Ljava_lang_String_arrayBarrayB);
			return cb_append_Ljava_lang_String_arrayBarrayB;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var lhs = (byte[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var rhs = (byte[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("append", "(Ljava/lang/String;[B[B)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_arrayBarrayBHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, byte[] lhs, byte[] rhs)
		{
			if (id_append_Ljava_lang_String_arrayBarrayB == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[B[B)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_lhs);
				__args [2] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[B[B)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
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

		static Delegate cb_append_Ljava_lang_String_CC;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_CCHandler ()
		{
			if (cb_append_Ljava_lang_String_CC == null)
				cb_append_Ljava_lang_String_CC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLCC_L) n_Append_Ljava_lang_String_CC);
			return cb_append_Ljava_lang_String_CC;
		}

		static IntPtr n_Append_Ljava_lang_String_CC (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, char lhs, char rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_CC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char'] and parameter[3][@type='char']]"
		[Register ("append", "(Ljava/lang/String;CC)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_CCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, char lhs, char rhs)
		{
			if (id_append_Ljava_lang_String_CC == IntPtr.Zero)
				id_append_Ljava_lang_String_CC = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;CC)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (lhs);
				__args [2] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_CC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;CC)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayCarrayC;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayCarrayCHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayCarrayC == null)
				cb_append_Ljava_lang_String_arrayCarrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_Ljava_lang_String_arrayCarrayC);
			return cb_append_Ljava_lang_String_arrayCarrayC;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayCarrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var lhs = (char[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (char));
			var rhs = (char[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayCarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char[]'] and parameter[3][@type='char[]']]"
		[Register ("append", "(Ljava/lang/String;[C[C)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_arrayCarrayCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, char[] lhs, char[] rhs)
		{
			if (id_append_Ljava_lang_String_arrayCarrayC == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayCarrayC = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[C[C)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_lhs);
				__args [2] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayCarrayC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[C[C)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
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

		static Delegate cb_append_Ljava_lang_String_DD;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_DDHandler ()
		{
			if (cb_append_Ljava_lang_String_DD == null)
				cb_append_Ljava_lang_String_DD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLDD_L) n_Append_Ljava_lang_String_DD);
			return cb_append_Ljava_lang_String_DD;
		}

		static IntPtr n_Append_Ljava_lang_String_DD (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, double lhs, double rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("append", "(Ljava/lang/String;DD)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_DDHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, double lhs, double rhs)
		{
			if (id_append_Ljava_lang_String_DD == IntPtr.Zero)
				id_append_Ljava_lang_String_DD = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;DD)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (lhs);
				__args [2] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_DD, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;DD)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayDarrayD;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayDarrayDHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayDarrayD == null)
				cb_append_Ljava_lang_String_arrayDarrayD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_Ljava_lang_String_arrayDarrayD);
			return cb_append_Ljava_lang_String_arrayDarrayD;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var lhs = (double[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (double));
			var rhs = (double[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double[]'] and parameter[3][@type='double[]']]"
		[Register ("append", "(Ljava/lang/String;[D[D)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_arrayDarrayDHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, double[] lhs, double[] rhs)
		{
			if (id_append_Ljava_lang_String_arrayDarrayD == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[D[D)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_lhs);
				__args [2] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayDarrayD, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[D[D)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
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

		static Delegate cb_append_Ljava_lang_String_FF;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_FFHandler ()
		{
			if (cb_append_Ljava_lang_String_FF == null)
				cb_append_Ljava_lang_String_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLFF_L) n_Append_Ljava_lang_String_FF);
			return cb_append_Ljava_lang_String_FF;
		}

		static IntPtr n_Append_Ljava_lang_String_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, float lhs, float rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("append", "(Ljava/lang/String;FF)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_FFHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, float lhs, float rhs)
		{
			if (id_append_Ljava_lang_String_FF == IntPtr.Zero)
				id_append_Ljava_lang_String_FF = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;FF)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (lhs);
				__args [2] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_FF, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;FF)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayFarrayF;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayFarrayFHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayFarrayF == null)
				cb_append_Ljava_lang_String_arrayFarrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_Ljava_lang_String_arrayFarrayF);
			return cb_append_Ljava_lang_String_arrayFarrayF;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayFarrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var lhs = (float[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (float));
			var rhs = (float[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]']]"
		[Register ("append", "(Ljava/lang/String;[F[F)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_arrayFarrayFHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, float[] lhs, float[] rhs)
		{
			if (id_append_Ljava_lang_String_arrayFarrayF == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayFarrayF = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[F[F)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_lhs);
				__args [2] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayFarrayF, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[F[F)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
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

		static Delegate cb_append_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_IIHandler ()
		{
			if (cb_append_Ljava_lang_String_II == null)
				cb_append_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Append_Ljava_lang_String_II);
			return cb_append_Ljava_lang_String_II;
		}

		static IntPtr n_Append_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, int lhs, int rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("append", "(Ljava/lang/String;II)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, int lhs, int rhs)
		{
			if (id_append_Ljava_lang_String_II == IntPtr.Zero)
				id_append_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;II)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (lhs);
				__args [2] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;II)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayIarrayIHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayIarrayI == null)
				cb_append_Ljava_lang_String_arrayIarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_Ljava_lang_String_arrayIarrayI);
			return cb_append_Ljava_lang_String_arrayIarrayI;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var lhs = (int[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (int));
			var rhs = (int[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
		[Register ("append", "(Ljava/lang/String;[I[I)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_arrayIarrayIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, int[] lhs, int[] rhs)
		{
			if (id_append_Ljava_lang_String_arrayIarrayI == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayIarrayI = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[I[I)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_lhs);
				__args [2] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[I[I)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
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

		static Delegate cb_append_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_append_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_append_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_append_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Append_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var lhs = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_lhs, JniHandleOwnership.DoNotTransfer);
			var rhs = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_rhs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("append", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, global::Java.Lang.Object lhs, global::Java.Lang.Object rhs)
		{
			if (id_append_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_append_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (lhs);
				__args [2] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_Handler ()
		{
			if (cb_append_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_ == null)
				cb_append_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_);
			return cb_append_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var lhs = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			var rhs = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("append", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, global::Java.Lang.Object[] lhs, global::Java.Lang.Object[] rhs)
		{
			if (id_append_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_lhs);
				__args [2] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayLjava_lang_Object_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
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

		static Delegate cb_append_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_JJHandler ()
		{
			if (cb_append_Ljava_lang_String_JJ == null)
				cb_append_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJJ_L) n_Append_Ljava_lang_String_JJ);
			return cb_append_Ljava_lang_String_JJ;
		}

		static IntPtr n_Append_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, long lhs, long rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("append", "(Ljava/lang/String;JJ)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_JJHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, long lhs, long rhs)
		{
			if (id_append_Ljava_lang_String_JJ == IntPtr.Zero)
				id_append_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;JJ)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (lhs);
				__args [2] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_JJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;JJ)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayJarrayJ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayJarrayJHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayJarrayJ == null)
				cb_append_Ljava_lang_String_arrayJarrayJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_Ljava_lang_String_arrayJarrayJ);
			return cb_append_Ljava_lang_String_arrayJarrayJ;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayJarrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var lhs = (long[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (long));
			var rhs = (long[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (long));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayJarrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long[]'] and parameter[3][@type='long[]']]"
		[Register ("append", "(Ljava/lang/String;[J[J)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_arrayJarrayJHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, long[] lhs, long[] rhs)
		{
			if (id_append_Ljava_lang_String_arrayJarrayJ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayJarrayJ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[J[J)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_lhs);
				__args [2] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayJarrayJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[J[J)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
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

		static Delegate cb_append_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_Handler ()
		{
			if (cb_append_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_ == null)
				cb_append_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_);
			return cb_append_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_;
		}

		static IntPtr n_Append_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_diffResult)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var diffResult = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffResult> (native_diffResult, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, diffResult));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.commons.lang3.builder.DiffResult']]"
		[Register ("append", "(Ljava/lang/String;Lorg/apache/commons/lang3/builder/DiffResult;)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, global::Org.Apache.Commons.Lang3.Builder.DiffResult diffResult)
		{
			if (id_append_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_ == IntPtr.Zero)
				id_append_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;Lorg/apache/commons/lang3/builder/DiffResult;)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (diffResult);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_Lorg_apache_commons_lang3_builder_DiffResult_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;Lorg/apache/commons/lang3/builder/DiffResult;)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_SS;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_SSHandler ()
		{
			if (cb_append_Ljava_lang_String_SS == null)
				cb_append_Ljava_lang_String_SS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLSS_L) n_Append_Ljava_lang_String_SS);
			return cb_append_Ljava_lang_String_SS;
		}

		static IntPtr n_Append_Ljava_lang_String_SS (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, short lhs, short rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_SS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short'] and parameter[3][@type='short']]"
		[Register ("append", "(Ljava/lang/String;SS)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_SSHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, short lhs, short rhs)
		{
			if (id_append_Ljava_lang_String_SS == IntPtr.Zero)
				id_append_Ljava_lang_String_SS = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;SS)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (lhs);
				__args [2] = new JValue (rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_SS, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;SS)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arraySarrayS;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arraySarraySHandler ()
		{
			if (cb_append_Ljava_lang_String_arraySarrayS == null)
				cb_append_Ljava_lang_String_arraySarrayS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Append_Ljava_lang_String_arraySarrayS);
			return cb_append_Ljava_lang_String_arraySarrayS;
		}

		static IntPtr n_Append_Ljava_lang_String_arraySarrayS (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_lhs, IntPtr native_rhs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var lhs = (short[]) JNIEnv.GetArray (native_lhs, JniHandleOwnership.DoNotTransfer, typeof (short));
			var rhs = (short[]) JNIEnv.GetArray (native_rhs, JniHandleOwnership.DoNotTransfer, typeof (short));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, lhs, rhs));
			if (lhs != null)
				JNIEnv.CopyArray (lhs, native_lhs);
			if (rhs != null)
				JNIEnv.CopyArray (rhs, native_rhs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arraySarrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short[]'] and parameter[3][@type='short[]']]"
		[Register ("append", "(Ljava/lang/String;[S[S)Lorg/apache/commons/lang3/builder/DiffBuilder;", "GetAppend_Ljava_lang_String_arraySarraySHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffBuilder Append (string fieldName, short[] lhs, short[] rhs)
		{
			if (id_append_Ljava_lang_String_arraySarrayS == IntPtr.Zero)
				id_append_Ljava_lang_String_arraySarrayS = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[S[S)Lorg/apache/commons/lang3/builder/DiffBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_lhs = JNIEnv.NewArray (lhs);
			IntPtr native_rhs = JNIEnv.NewArray (rhs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_lhs);
				__args [2] = new JValue (native_rhs);

				global::Org.Apache.Commons.Lang3.Builder.DiffBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arraySarrayS, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[S[S)Lorg/apache/commons/lang3/builder/DiffBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lorg/apache/commons/lang3/builder/DiffResult;", "GetBuildHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffResult Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lorg/apache/commons/lang3/builder/DiffResult;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lorg/apache/commons/lang3/builder/DiffResult;")), JniHandleOwnership.TransferLocalRef);
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
