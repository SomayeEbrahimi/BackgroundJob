using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/ToStringBuilder", DoNotGenerateAcw=true)]
	public partial class ToStringBuilder : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Builder.IBuilder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/builder/ToStringBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ToStringBuilder); }
		}

		protected ToStringBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/constructor[@name='ToStringBuilder' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe ToStringBuilder (global::Java.Lang.Object @object)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);
				if (((object) this).GetType () != typeof (ToStringBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/constructor[@name='ToStringBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle']]"
		[Register (".ctor", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V", "")]
		public unsafe ToStringBuilder (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (style);
				if (((object) this).GetType () != typeof (ToStringBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/constructor[@name='ToStringBuilder' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle'] and parameter[3][@type='java.lang.StringBuffer']]"
		[Register (".ctor", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;)V", "")]
		public unsafe ToStringBuilder (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style, global::Java.Lang.StringBuffer buffer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (style);
				__args [2] = new JValue (buffer);
				if (((object) this).GetType () != typeof (ToStringBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_getDefaultStyle;
		static IntPtr id_setDefaultStyle_Lorg_apache_commons_lang3_builder_ToStringStyle_;
		public static unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringStyle DefaultStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='getDefaultStyle' and count(parameter)=0]"
			[Register ("getDefaultStyle", "()Lorg/apache/commons/lang3/builder/ToStringStyle;", "")]
			get {
				if (id_getDefaultStyle == IntPtr.Zero)
					id_getDefaultStyle = JNIEnv.GetStaticMethodID (class_ref, "getDefaultStyle", "()Lorg/apache/commons/lang3/builder/ToStringStyle;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultStyle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='setDefaultStyle' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.builder.ToStringStyle']]"
			[Register ("setDefaultStyle", "(Lorg/apache/commons/lang3/builder/ToStringStyle;)V", "")]
			set {
				if (id_setDefaultStyle_Lorg_apache_commons_lang3_builder_ToStringStyle_ == IntPtr.Zero)
					id_setDefaultStyle_Lorg_apache_commons_lang3_builder_ToStringStyle_ = JNIEnv.GetStaticMethodID (class_ref, "setDefaultStyle", "(Lorg/apache/commons/lang3/builder/ToStringStyle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultStyle_Lorg_apache_commons_lang3_builder_ToStringStyle_, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getObject;
#pragma warning disable 0169
		static Delegate GetGetObjectHandler ()
		{
			if (cb_getObject == null)
				cb_getObject = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObject);
			return cb_getObject;
		}

		static IntPtr n_GetObject (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Object);
		}
#pragma warning restore 0169

		static IntPtr id_getObject;
		public virtual unsafe global::Java.Lang.Object Object {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='getObject' and count(parameter)=0]"
			[Register ("getObject", "()Ljava/lang/Object;", "GetGetObjectHandler")]
			get {
				if (id_getObject == IntPtr.Zero)
					id_getObject = JNIEnv.GetMethodID (class_ref, "getObject", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObject), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObject", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStringBuffer;
#pragma warning disable 0169
		static Delegate GetGetStringBufferHandler ()
		{
			if (cb_getStringBuffer == null)
				cb_getStringBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStringBuffer);
			return cb_getStringBuffer;
		}

		static IntPtr n_GetStringBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StringBuffer);
		}
#pragma warning restore 0169

		static IntPtr id_getStringBuffer;
		public virtual unsafe global::Java.Lang.StringBuffer StringBuffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='getStringBuffer' and count(parameter)=0]"
			[Register ("getStringBuffer", "()Ljava/lang/StringBuffer;", "GetGetStringBufferHandler")]
			get {
				if (id_getStringBuffer == IntPtr.Zero)
					id_getStringBuffer = JNIEnv.GetMethodID (class_ref, "getStringBuffer", "()Ljava/lang/StringBuffer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStringBuffer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStringBuffer", "()Ljava/lang/StringBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStyle;
#pragma warning disable 0169
		static Delegate GetGetStyleHandler ()
		{
			if (cb_getStyle == null)
				cb_getStyle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStyle);
			return cb_getStyle;
		}

		static IntPtr n_GetStyle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Style);
		}
#pragma warning restore 0169

		static IntPtr id_getStyle;
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringStyle Style {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='getStyle' and count(parameter)=0]"
			[Register ("getStyle", "()Lorg/apache/commons/lang3/builder/ToStringStyle;", "GetGetStyleHandler")]
			get {
				if (id_getStyle == IntPtr.Zero)
					id_getStyle = JNIEnv.GetMethodID (class_ref, "getStyle", "()Lorg/apache/commons/lang3/builder/ToStringStyle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStyle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStyle", "()Lorg/apache/commons/lang3/builder/ToStringStyle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("append", "(Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (bool value)
		{
			if (id_append_Z == IntPtr.Zero)
				id_append_Z = JNIEnv.GetMethodID (class_ref, "append", "(Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (bool[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (bool));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("append", "([Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_arrayZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (bool[] array)
		{
			if (id_append_arrayZ == IntPtr.Zero)
				id_append_arrayZ = JNIEnv.GetMethodID (class_ref, "append", "([Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("append", "(B)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_BHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (sbyte value)
		{
			if (id_append_B == IntPtr.Zero)
				id_append_B = JNIEnv.GetMethodID (class_ref, "append", "(B)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_B, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(B)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (byte[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("append", "([B)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_arrayBHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (byte[] array)
		{
			if (id_append_arrayB == IntPtr.Zero)
				id_append_arrayB = JNIEnv.GetMethodID (class_ref, "append", "([B)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([B)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("append", "(C)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (char value)
		{
			if (id_append_C == IntPtr.Zero)
				id_append_C = JNIEnv.GetMethodID (class_ref, "append", "(C)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(C)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (char[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("append", "([C)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_arrayCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (char[] array)
		{
			if (id_append_arrayC == IntPtr.Zero)
				id_append_arrayC = JNIEnv.GetMethodID (class_ref, "append", "([C)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([C)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("append", "(D)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_DHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (double value)
		{
			if (id_append_D == IntPtr.Zero)
				id_append_D = JNIEnv.GetMethodID (class_ref, "append", "(D)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(D)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (double[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("append", "([D)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_arrayDHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (double[] array)
		{
			if (id_append_arrayD == IntPtr.Zero)
				id_append_arrayD = JNIEnv.GetMethodID (class_ref, "append", "([D)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayD, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([D)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("append", "(F)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_FHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (float value)
		{
			if (id_append_F == IntPtr.Zero)
				id_append_F = JNIEnv.GetMethodID (class_ref, "append", "(F)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(F)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (float[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("append", "([F)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_arrayFHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (float[] array)
		{
			if (id_append_arrayF == IntPtr.Zero)
				id_append_arrayF = JNIEnv.GetMethodID (class_ref, "append", "([F)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([F)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("append", "(I)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_IHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (int value)
		{
			if (id_append_I == IntPtr.Zero)
				id_append_I = JNIEnv.GetMethodID (class_ref, "append", "(I)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(I)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (int[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("append", "([I)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_arrayIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (int[] array)
		{
			if (id_append_arrayI == IntPtr.Zero)
				id_append_arrayI = JNIEnv.GetMethodID (class_ref, "append", "([I)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([I)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_Append_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (obj));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("append", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (global::Java.Lang.Object obj)
		{
			if (id_append_Ljava_lang_Object_ == IntPtr.Zero)
				id_append_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("append", "([Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (global::Java.Lang.Object[] array)
		{
			if (id_append_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_append_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "([Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_ZHandler ()
		{
			if (cb_append_Ljava_lang_String_Z == null)
				cb_append_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_Append_Ljava_lang_String_Z);
			return cb_append_Ljava_lang_String_Z;
		}

		static IntPtr n_Append_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, bool value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, bool value)
		{
			if (id_append_Ljava_lang_String_Z == IntPtr.Zero)
				id_append_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (value);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayZ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayZHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayZ == null)
				cb_append_Ljava_lang_String_arrayZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_arrayZ);
			return cb_append_Ljava_lang_String_arrayZ;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (bool[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (bool));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean[]']]"
		[Register ("append", "(Ljava/lang/String;[Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, bool[] array)
		{
			if (id_append_Ljava_lang_String_arrayZ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayZ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayZZ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayZZHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayZZ == null)
				cb_append_Ljava_lang_String_arrayZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Append_Ljava_lang_String_arrayZZ);
			return cb_append_Ljava_lang_String_arrayZZ;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array, bool fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (bool[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (bool));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array, fullDetail));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean[]'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;[ZZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayZZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, bool[] array, bool fullDetail)
		{
			if (id_append_Ljava_lang_String_arrayZZ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayZZ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[ZZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (fullDetail);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayZZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[ZZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_B;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_BHandler ()
		{
			if (cb_append_Ljava_lang_String_B == null)
				cb_append_Ljava_lang_String_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLB_L) n_Append_Ljava_lang_String_B);
			return cb_append_Ljava_lang_String_B;
		}

		static IntPtr n_Append_Ljava_lang_String_B (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, sbyte value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte']]"
		[Register ("append", "(Ljava/lang/String;B)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_BHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, sbyte value)
		{
			if (id_append_Ljava_lang_String_B == IntPtr.Zero)
				id_append_Ljava_lang_String_B = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;B)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (value);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_B, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;B)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayB == null)
				cb_append_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_arrayB);
			return cb_append_Ljava_lang_String_arrayB;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (byte[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("append", "(Ljava/lang/String;[B)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, byte[] array)
		{
			if (id_append_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[B)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[B)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayBZ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayBZHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayBZ == null)
				cb_append_Ljava_lang_String_arrayBZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Append_Ljava_lang_String_arrayBZ);
			return cb_append_Ljava_lang_String_arrayBZ;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayBZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array, bool fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (byte[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array, fullDetail));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;[BZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayBZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, byte[] array, bool fullDetail)
		{
			if (id_append_Ljava_lang_String_arrayBZ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayBZ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[BZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (fullDetail);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayBZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[BZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_C;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_CHandler ()
		{
			if (cb_append_Ljava_lang_String_C == null)
				cb_append_Ljava_lang_String_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLC_L) n_Append_Ljava_lang_String_C);
			return cb_append_Ljava_lang_String_C;
		}

		static IntPtr n_Append_Ljava_lang_String_C (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, char value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("append", "(Ljava/lang/String;C)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, char value)
		{
			if (id_append_Ljava_lang_String_C == IntPtr.Zero)
				id_append_Ljava_lang_String_C = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;C)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (value);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;C)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayC;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayCHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayC == null)
				cb_append_Ljava_lang_String_arrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_arrayC);
			return cb_append_Ljava_lang_String_arrayC;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (char[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char[]']]"
		[Register ("append", "(Ljava/lang/String;[C)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, char[] array)
		{
			if (id_append_Ljava_lang_String_arrayC == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayC = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[C)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[C)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayCZ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayCZHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayCZ == null)
				cb_append_Ljava_lang_String_arrayCZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Append_Ljava_lang_String_arrayCZ);
			return cb_append_Ljava_lang_String_arrayCZ;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayCZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array, bool fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (char[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array, fullDetail));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayCZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char[]'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;[CZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayCZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, char[] array, bool fullDetail)
		{
			if (id_append_Ljava_lang_String_arrayCZ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayCZ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[CZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (fullDetail);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayCZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[CZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_DHandler ()
		{
			if (cb_append_Ljava_lang_String_D == null)
				cb_append_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLD_L) n_Append_Ljava_lang_String_D);
			return cb_append_Ljava_lang_String_D;
		}

		static IntPtr n_Append_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, double value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("append", "(Ljava/lang/String;D)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_DHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, double value)
		{
			if (id_append_Ljava_lang_String_D == IntPtr.Zero)
				id_append_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;D)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (value);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;D)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayD;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayDHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayD == null)
				cb_append_Ljava_lang_String_arrayD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_arrayD);
			return cb_append_Ljava_lang_String_arrayD;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (double[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double[]']]"
		[Register ("append", "(Ljava/lang/String;[D)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayDHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, double[] array)
		{
			if (id_append_Ljava_lang_String_arrayD == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayD = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[D)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayD, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[D)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayDZ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayDZHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayDZ == null)
				cb_append_Ljava_lang_String_arrayDZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Append_Ljava_lang_String_arrayDZ);
			return cb_append_Ljava_lang_String_arrayDZ;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayDZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array, bool fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (double[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array, fullDetail));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayDZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double[]'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;[DZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayDZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, double[] array, bool fullDetail)
		{
			if (id_append_Ljava_lang_String_arrayDZ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayDZ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[DZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (fullDetail);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayDZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[DZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_FHandler ()
		{
			if (cb_append_Ljava_lang_String_F == null)
				cb_append_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLF_L) n_Append_Ljava_lang_String_F);
			return cb_append_Ljava_lang_String_F;
		}

		static IntPtr n_Append_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, float value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("append", "(Ljava/lang/String;F)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_FHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, float value)
		{
			if (id_append_Ljava_lang_String_F == IntPtr.Zero)
				id_append_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;F)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (value);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;F)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayF;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayFHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayF == null)
				cb_append_Ljava_lang_String_arrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_arrayF);
			return cb_append_Ljava_lang_String_arrayF;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (float[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float[]']]"
		[Register ("append", "(Ljava/lang/String;[F)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayFHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, float[] array)
		{
			if (id_append_Ljava_lang_String_arrayF == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayF = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[F)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[F)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayFZ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayFZHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayFZ == null)
				cb_append_Ljava_lang_String_arrayFZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Append_Ljava_lang_String_arrayFZ);
			return cb_append_Ljava_lang_String_arrayFZ;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayFZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array, bool fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (float[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array, fullDetail));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayFZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float[]'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;[FZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayFZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, float[] array, bool fullDetail)
		{
			if (id_append_Ljava_lang_String_arrayFZ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayFZ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[FZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (fullDetail);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayFZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[FZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_IHandler ()
		{
			if (cb_append_Ljava_lang_String_I == null)
				cb_append_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_Append_Ljava_lang_String_I);
			return cb_append_Ljava_lang_String_I;
		}

		static IntPtr n_Append_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("append", "(Ljava/lang/String;I)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, int value)
		{
			if (id_append_Ljava_lang_String_I == IntPtr.Zero)
				id_append_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;I)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (value);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;I)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayIHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayI == null)
				cb_append_Ljava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_arrayI);
			return cb_append_Ljava_lang_String_arrayI;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (int[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int[]']]"
		[Register ("append", "(Ljava/lang/String;[I)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, int[] array)
		{
			if (id_append_Ljava_lang_String_arrayI == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[I)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[I)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayIZ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayIZHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayIZ == null)
				cb_append_Ljava_lang_String_arrayIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Append_Ljava_lang_String_arrayIZ);
			return cb_append_Ljava_lang_String_arrayIZ;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array, bool fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (int[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array, fullDetail));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int[]'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;[IZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayIZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, int[] array, bool fullDetail)
		{
			if (id_append_Ljava_lang_String_arrayIZ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayIZ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[IZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (fullDetail);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayIZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[IZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_append_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_append_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_Ljava_lang_Object_);
			return cb_append_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_Append_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, obj));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("append", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, global::Java.Lang.Object obj)
		{
			if (id_append_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_append_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (obj);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_Ljava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_Ljava_lang_Object_ZHandler ()
		{
			if (cb_append_Ljava_lang_String_Ljava_lang_Object_Z == null)
				cb_append_Ljava_lang_String_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Append_Ljava_lang_String_Ljava_lang_Object_Z);
			return cb_append_Ljava_lang_String_Ljava_lang_Object_Z;
		}

		static IntPtr n_Append_Ljava_lang_String_Ljava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_obj, bool fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, obj, fullDetail));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;Ljava/lang/Object;Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_Ljava_lang_Object_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, global::Java.Lang.Object obj, bool fullDetail)
		{
			if (id_append_Ljava_lang_String_Ljava_lang_Object_Z == IntPtr.Zero)
				id_append_Ljava_lang_String_Ljava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;Ljava/lang/Object;Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (obj);
				__args [2] = new JValue (fullDetail);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_Ljava_lang_Object_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;Ljava/lang/Object;Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_append_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_append_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_append_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("append", "(Ljava/lang/String;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, global::Java.Lang.Object[] array)
		{
			if (id_append_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayLjava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayLjava_lang_Object_ZHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayLjava_lang_Object_Z == null)
				cb_append_Ljava_lang_String_arrayLjava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Append_Ljava_lang_String_arrayLjava_lang_Object_Z);
			return cb_append_Ljava_lang_String_arrayLjava_lang_Object_Z;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayLjava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array, bool fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array, fullDetail));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayLjava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;[Ljava/lang/Object;Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayLjava_lang_Object_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, global::Java.Lang.Object[] array, bool fullDetail)
		{
			if (id_append_Ljava_lang_String_arrayLjava_lang_Object_Z == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayLjava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[Ljava/lang/Object;Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (fullDetail);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayLjava_lang_Object_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[Ljava/lang/Object;Z)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_JHandler ()
		{
			if (cb_append_Ljava_lang_String_J == null)
				cb_append_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_L) n_Append_Ljava_lang_String_J);
			return cb_append_Ljava_lang_String_J;
		}

		static IntPtr n_Append_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, long value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("append", "(Ljava/lang/String;J)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_JHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, long value)
		{
			if (id_append_Ljava_lang_String_J == IntPtr.Zero)
				id_append_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;J)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (value);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;J)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayJ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayJHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayJ == null)
				cb_append_Ljava_lang_String_arrayJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_arrayJ);
			return cb_append_Ljava_lang_String_arrayJ;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (long[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (long));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long[]']]"
		[Register ("append", "(Ljava/lang/String;[J)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayJHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, long[] array)
		{
			if (id_append_Ljava_lang_String_arrayJ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayJ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[J)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[J)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayJZ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayJZHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayJZ == null)
				cb_append_Ljava_lang_String_arrayJZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Append_Ljava_lang_String_arrayJZ);
			return cb_append_Ljava_lang_String_arrayJZ;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayJZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array, bool fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (long[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (long));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array, fullDetail));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayJZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long[]'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;[JZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arrayJZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, long[] array, bool fullDetail)
		{
			if (id_append_Ljava_lang_String_arrayJZ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayJZ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[JZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (fullDetail);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayJZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[JZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_SHandler ()
		{
			if (cb_append_Ljava_lang_String_S == null)
				cb_append_Ljava_lang_String_S = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLS_L) n_Append_Ljava_lang_String_S);
			return cb_append_Ljava_lang_String_S;
		}

		static IntPtr n_Append_Ljava_lang_String_S (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, short value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short']]"
		[Register ("append", "(Ljava/lang/String;S)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_SHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, short value)
		{
			if (id_append_Ljava_lang_String_S == IntPtr.Zero)
				id_append_Ljava_lang_String_S = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;S)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (value);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_S, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;S)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayS;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arraySHandler ()
		{
			if (cb_append_Ljava_lang_String_arrayS == null)
				cb_append_Ljava_lang_String_arrayS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_arrayS);
			return cb_append_Ljava_lang_String_arrayS;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayS (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (short[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (short));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short[]']]"
		[Register ("append", "(Ljava/lang/String;[S)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arraySHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, short[] array)
		{
			if (id_append_Ljava_lang_String_arrayS == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayS = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[S)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayS, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[S)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_arraySZ;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arraySZHandler ()
		{
			if (cb_append_Ljava_lang_String_arraySZ == null)
				cb_append_Ljava_lang_String_arraySZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Append_Ljava_lang_String_arraySZ);
			return cb_append_Ljava_lang_String_arraySZ;
		}

		static IntPtr n_Append_Ljava_lang_String_arraySZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldName, IntPtr native_array, bool fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (short[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (short));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (fieldName, array, fullDetail));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arraySZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short[]'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/String;[SZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_Ljava_lang_String_arraySZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (string fieldName, short[] array, bool fullDetail)
		{
			if (id_append_Ljava_lang_String_arraySZ == IntPtr.Zero)
				id_append_Ljava_lang_String_arraySZ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[SZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fieldName);
				__args [1] = new JValue (native_array);
				__args [2] = new JValue (fullDetail);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arraySZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[SZ)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("append", "(J)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_JHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (long value)
		{
			if (id_append_J == IntPtr.Zero)
				id_append_J = JNIEnv.GetMethodID (class_ref, "append", "(J)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(J)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (long[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (long));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("append", "([J)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_arrayJHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (long[] array)
		{
			if (id_append_arrayJ == IntPtr.Zero)
				id_append_arrayJ = JNIEnv.GetMethodID (class_ref, "append", "([J)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([J)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("append", "(S)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_SHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (short value)
		{
			if (id_append_S == IntPtr.Zero)
				id_append_S = JNIEnv.GetMethodID (class_ref, "append", "(S)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_S, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(S)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (short[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (short));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("append", "([S)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppend_arraySHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder Append (short[] array)
		{
			if (id_append_arrayS == IntPtr.Zero)
				id_append_arrayS = JNIEnv.GetMethodID (class_ref, "append", "([S)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayS, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([S)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendAsObjectToString_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendAsObjectToString_Ljava_lang_Object_Handler ()
		{
			if (cb_appendAsObjectToString_Ljava_lang_Object_ == null)
				cb_appendAsObjectToString_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AppendAsObjectToString_Ljava_lang_Object_);
			return cb_appendAsObjectToString_Ljava_lang_Object_;
		}

		static IntPtr n_AppendAsObjectToString_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_srcObject)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var srcObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_srcObject, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendAsObjectToString (srcObject));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendAsObjectToString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='appendAsObjectToString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("appendAsObjectToString", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppendAsObjectToString_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder AppendAsObjectToString (global::Java.Lang.Object srcObject)
		{
			if (id_appendAsObjectToString_Ljava_lang_Object_ == IntPtr.Zero)
				id_appendAsObjectToString_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendAsObjectToString", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (srcObject);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendAsObjectToString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendAsObjectToString", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendSuper_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendSuper_Ljava_lang_String_Handler ()
		{
			if (cb_appendSuper_Ljava_lang_String_ == null)
				cb_appendSuper_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AppendSuper_Ljava_lang_String_);
			return cb_appendSuper_Ljava_lang_String_;
		}

		static IntPtr n_AppendSuper_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_superToString)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var superToString = JNIEnv.GetString (native_superToString, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendSuper (superToString));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendSuper_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='appendSuper' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("appendSuper", "(Ljava/lang/String;)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppendSuper_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder AppendSuper (string superToString)
		{
			if (id_appendSuper_Ljava_lang_String_ == IntPtr.Zero)
				id_appendSuper_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendSuper", "(Ljava/lang/String;)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_superToString = JNIEnv.NewString (superToString);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_superToString);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendSuper_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSuper", "(Ljava/lang/String;)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_superToString);
			}
		}

		static Delegate cb_appendToString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendToString_Ljava_lang_String_Handler ()
		{
			if (cb_appendToString_Ljava_lang_String_ == null)
				cb_appendToString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AppendToString_Ljava_lang_String_);
			return cb_appendToString_Ljava_lang_String_;
		}

		static IntPtr n_AppendToString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_toString)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var toString = JNIEnv.GetString (native_toString, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendToString (toString));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendToString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='appendToString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("appendToString", "(Ljava/lang/String;)Lorg/apache/commons/lang3/builder/ToStringBuilder;", "GetAppendToString_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder AppendToString (string toString)
		{
			if (id_appendToString_Ljava_lang_String_ == IntPtr.Zero)
				id_appendToString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendToString", "(Ljava/lang/String;)Lorg/apache/commons/lang3/builder/ToStringBuilder;");
			IntPtr native_toString = JNIEnv.NewString (toString);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_toString);

				global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendToString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendToString", "(Ljava/lang/String;)Lorg/apache/commons/lang3/builder/ToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_toString);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Ljava/lang/String;", "GetBuildHandler")]
		public virtual unsafe string Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_reflectionToString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='reflectionToString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("reflectionToString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string ReflectionToString (global::Java.Lang.Object @object)
		{
			if (id_reflectionToString_Ljava_lang_Object_ == IntPtr.Zero)
				id_reflectionToString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionToString", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_reflectionToString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='reflectionToString' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle']]"
		[Register ("reflectionToString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)Ljava/lang/String;", "")]
		public static unsafe string ReflectionToString (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style)
		{
			if (id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ == IntPtr.Zero)
				id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionToString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (style);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='reflectionToString' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle'] and parameter[3][@type='boolean']]"
		[Register ("reflectionToString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Z)Ljava/lang/String;", "")]
		public static unsafe string ReflectionToString (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style, bool outputTransients)
		{
			if (id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z == IntPtr.Zero)
				id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z = JNIEnv.GetStaticMethodID (class_ref, "reflectionToString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (style);
				__args [2] = new JValue (outputTransients);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringBuilder']/method[@name='reflectionToString' and count(parameter)=4 and parameter[1][@type='T'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.Class&lt;? super T&gt;']]"
		[Register ("reflectionToString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;ZLjava/lang/Class;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe string ReflectionToString (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style, bool outputTransients, global::Java.Lang.Class reflectUpToClass)
		{
			if (id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZLjava_lang_Class_ == IntPtr.Zero)
				id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "reflectionToString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;ZLjava/lang/Class;)Ljava/lang/String;");
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native__object);
				__args [1] = new JValue (style);
				__args [2] = new JValue (outputTransients);
				__args [3] = new JValue (reflectUpToClass);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_reflectionToString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Org.Apache.Commons.Lang3.Builder.IBuilder
		global::Java.Lang.Object global::Org.Apache.Commons.Lang3.Builder.IBuilder.Build ()
		{
			return Build ()?.ToString ();
		}

	}
}
