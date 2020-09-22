using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/ReflectionToStringBuilder", DoNotGenerateAcw=true)]
	public partial class ReflectionToStringBuilder : global::Org.Apache.Commons.Lang3.Builder.ToStringBuilder {


		static IntPtr excludeFieldNames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/field[@name='excludeFieldNames']"
		[Register ("excludeFieldNames")]
		protected IList<string> ExcludeFieldNames {
			get {
				if (excludeFieldNames_jfieldId == IntPtr.Zero)
					excludeFieldNames_jfieldId = JNIEnv.GetFieldID (class_ref, "excludeFieldNames", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, excludeFieldNames_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (excludeFieldNames_jfieldId == IntPtr.Zero)
					excludeFieldNames_jfieldId = JNIEnv.GetFieldID (class_ref, "excludeFieldNames", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, excludeFieldNames_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/builder/ReflectionToStringBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReflectionToStringBuilder); }
		}

		protected ReflectionToStringBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/constructor[@name='ReflectionToStringBuilder' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe ReflectionToStringBuilder (global::Java.Lang.Object @object)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);
				if (((object) this).GetType () != typeof (ReflectionToStringBuilder)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/constructor[@name='ReflectionToStringBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle']]"
		[Register (".ctor", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V", "")]
		public unsafe ReflectionToStringBuilder (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (style);
				if (((object) this).GetType () != typeof (ReflectionToStringBuilder)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/constructor[@name='ReflectionToStringBuilder' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle'] and parameter[3][@type='java.lang.StringBuffer']]"
		[Register (".ctor", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;)V", "")]
		public unsafe ReflectionToStringBuilder (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style, global::Java.Lang.StringBuffer buffer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (style);
				__args [2] = new JValue (buffer);
				if (((object) this).GetType () != typeof (ReflectionToStringBuilder)) {
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

		static IntPtr id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_Ljava_lang_Class_ZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/constructor[@name='ReflectionToStringBuilder' and count(parameter)=6 and parameter[1][@type='T'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle'] and parameter[3][@type='java.lang.StringBuffer'] and parameter[4][@type='java.lang.Class&lt;? super T&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;Ljava/lang/Class;ZZ)V", "")]
		public unsafe ReflectionToStringBuilder (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style, global::Java.Lang.StringBuffer buffer, global::Java.Lang.Class reflectUpToClass, bool outputTransients, bool outputStatics)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native__object);
				__args [1] = new JValue (style);
				__args [2] = new JValue (buffer);
				__args [3] = new JValue (reflectUpToClass);
				__args [4] = new JValue (outputTransients);
				__args [5] = new JValue (outputStatics);
				if (((object) this).GetType () != typeof (ReflectionToStringBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;Ljava/lang/Class;ZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;Ljava/lang/Class;ZZ)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_Ljava_lang_Class_ZZ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_Ljava_lang_Class_ZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;Ljava/lang/Class;ZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_Ljava_lang_Class_ZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_Ljava_lang_Class_ZZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_Ljava_lang_Class_ZZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/constructor[@name='ReflectionToStringBuilder' and count(parameter)=7 and parameter[1][@type='T'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle'] and parameter[3][@type='java.lang.StringBuffer'] and parameter[4][@type='java.lang.Class&lt;? super T&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;Ljava/lang/Class;ZZZ)V", "")]
		public unsafe ReflectionToStringBuilder (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style, global::Java.Lang.StringBuffer buffer, global::Java.Lang.Class reflectUpToClass, bool outputTransients, bool outputStatics, bool excludeNullValues)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native__object);
				__args [1] = new JValue (style);
				__args [2] = new JValue (buffer);
				__args [3] = new JValue (reflectUpToClass);
				__args [4] = new JValue (outputTransients);
				__args [5] = new JValue (outputStatics);
				__args [6] = new JValue (excludeNullValues);
				if (((object) this).GetType () != typeof (ReflectionToStringBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;Ljava/lang/Class;ZZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;Ljava/lang/Class;ZZZ)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_Ljava_lang_Class_ZZZ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_Ljava_lang_Class_ZZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Ljava/lang/StringBuffer;Ljava/lang/Class;ZZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_Ljava_lang_Class_ZZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Ljava_lang_StringBuffer_Ljava_lang_Class_ZZZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
			}
		}

		static Delegate cb_isAppendStatics;
#pragma warning disable 0169
		static Delegate GetIsAppendStaticsHandler ()
		{
			if (cb_isAppendStatics == null)
				cb_isAppendStatics = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAppendStatics);
			return cb_isAppendStatics;
		}

		static bool n_IsAppendStatics (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AppendStatics;
		}
#pragma warning restore 0169

		static Delegate cb_setAppendStatics_Z;
#pragma warning disable 0169
		static Delegate GetSetAppendStatics_ZHandler ()
		{
			if (cb_setAppendStatics_Z == null)
				cb_setAppendStatics_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAppendStatics_Z);
			return cb_setAppendStatics_Z;
		}

		static void n_SetAppendStatics_Z (IntPtr jnienv, IntPtr native__this, bool appendStatics)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AppendStatics = appendStatics;
		}
#pragma warning restore 0169

		static IntPtr id_isAppendStatics;
		static IntPtr id_setAppendStatics_Z;
		public virtual unsafe bool AppendStatics {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='isAppendStatics' and count(parameter)=0]"
			[Register ("isAppendStatics", "()Z", "GetIsAppendStaticsHandler")]
			get {
				if (id_isAppendStatics == IntPtr.Zero)
					id_isAppendStatics = JNIEnv.GetMethodID (class_ref, "isAppendStatics", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAppendStatics);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAppendStatics", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='setAppendStatics' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAppendStatics", "(Z)V", "GetSetAppendStatics_ZHandler")]
			set {
				if (id_setAppendStatics_Z == IntPtr.Zero)
					id_setAppendStatics_Z = JNIEnv.GetMethodID (class_ref, "setAppendStatics", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppendStatics_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppendStatics", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAppendTransients;
#pragma warning disable 0169
		static Delegate GetIsAppendTransientsHandler ()
		{
			if (cb_isAppendTransients == null)
				cb_isAppendTransients = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAppendTransients);
			return cb_isAppendTransients;
		}

		static bool n_IsAppendTransients (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AppendTransients;
		}
#pragma warning restore 0169

		static Delegate cb_setAppendTransients_Z;
#pragma warning disable 0169
		static Delegate GetSetAppendTransients_ZHandler ()
		{
			if (cb_setAppendTransients_Z == null)
				cb_setAppendTransients_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAppendTransients_Z);
			return cb_setAppendTransients_Z;
		}

		static void n_SetAppendTransients_Z (IntPtr jnienv, IntPtr native__this, bool appendTransients)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AppendTransients = appendTransients;
		}
#pragma warning restore 0169

		static IntPtr id_isAppendTransients;
		static IntPtr id_setAppendTransients_Z;
		public virtual unsafe bool AppendTransients {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='isAppendTransients' and count(parameter)=0]"
			[Register ("isAppendTransients", "()Z", "GetIsAppendTransientsHandler")]
			get {
				if (id_isAppendTransients == IntPtr.Zero)
					id_isAppendTransients = JNIEnv.GetMethodID (class_ref, "isAppendTransients", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAppendTransients);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAppendTransients", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='setAppendTransients' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAppendTransients", "(Z)V", "GetSetAppendTransients_ZHandler")]
			set {
				if (id_setAppendTransients_Z == IntPtr.Zero)
					id_setAppendTransients_Z = JNIEnv.GetMethodID (class_ref, "setAppendTransients", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppendTransients_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppendTransients", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isExcludeNullValues;
#pragma warning disable 0169
		static Delegate GetIsExcludeNullValuesHandler ()
		{
			if (cb_isExcludeNullValues == null)
				cb_isExcludeNullValues = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExcludeNullValues);
			return cb_isExcludeNullValues;
		}

		static bool n_IsExcludeNullValues (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExcludeNullValues;
		}
#pragma warning restore 0169

		static Delegate cb_setExcludeNullValues_Z;
#pragma warning disable 0169
		static Delegate GetSetExcludeNullValues_ZHandler ()
		{
			if (cb_setExcludeNullValues_Z == null)
				cb_setExcludeNullValues_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetExcludeNullValues_Z);
			return cb_setExcludeNullValues_Z;
		}

		static void n_SetExcludeNullValues_Z (IntPtr jnienv, IntPtr native__this, bool excludeNullValues)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExcludeNullValues = excludeNullValues;
		}
#pragma warning restore 0169

		static IntPtr id_isExcludeNullValues;
		static IntPtr id_setExcludeNullValues_Z;
		public virtual unsafe bool ExcludeNullValues {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='isExcludeNullValues' and count(parameter)=0]"
			[Register ("isExcludeNullValues", "()Z", "GetIsExcludeNullValuesHandler")]
			get {
				if (id_isExcludeNullValues == IntPtr.Zero)
					id_isExcludeNullValues = JNIEnv.GetMethodID (class_ref, "isExcludeNullValues", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExcludeNullValues);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExcludeNullValues", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='setExcludeNullValues' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExcludeNullValues", "(Z)V", "GetSetExcludeNullValues_ZHandler")]
			set {
				if (id_setExcludeNullValues_Z == IntPtr.Zero)
					id_setExcludeNullValues_Z = JNIEnv.GetMethodID (class_ref, "setExcludeNullValues", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExcludeNullValues_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExcludeNullValues", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUpToClass;
#pragma warning disable 0169
		static Delegate GetGetUpToClassHandler ()
		{
			if (cb_getUpToClass == null)
				cb_getUpToClass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUpToClass);
			return cb_getUpToClass;
		}

		static IntPtr n_GetUpToClass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UpToClass);
		}
#pragma warning restore 0169

		static Delegate cb_setUpToClass_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSetUpToClass_Ljava_lang_Class_Handler ()
		{
			if (cb_setUpToClass_Ljava_lang_Class_ == null)
				cb_setUpToClass_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUpToClass_Ljava_lang_Class_);
			return cb_setUpToClass_Ljava_lang_Class_;
		}

		static void n_SetUpToClass_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clazz)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clazz = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_clazz, JniHandleOwnership.DoNotTransfer);
			__this.UpToClass = clazz;
		}
#pragma warning restore 0169

		static IntPtr id_getUpToClass;
		static IntPtr id_setUpToClass_Ljava_lang_Class_;
		public virtual unsafe global::Java.Lang.Class UpToClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='getUpToClass' and count(parameter)=0]"
			[Register ("getUpToClass", "()Ljava/lang/Class;", "GetGetUpToClassHandler")]
			get {
				if (id_getUpToClass == IntPtr.Zero)
					id_getUpToClass = JNIEnv.GetMethodID (class_ref, "getUpToClass", "()Ljava/lang/Class;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpToClass), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpToClass", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='setUpToClass' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
			[Register ("setUpToClass", "(Ljava/lang/Class;)V", "GetSetUpToClass_Ljava_lang_Class_Handler")]
			set {
				if (id_setUpToClass_Ljava_lang_Class_ == IntPtr.Zero)
					id_setUpToClass_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setUpToClass", "(Ljava/lang/Class;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpToClass_Ljava_lang_Class_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpToClass", "(Ljava/lang/Class;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_accept_Ljava_lang_reflect_Field_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_lang_reflect_Field_Handler ()
		{
			if (cb_accept_Ljava_lang_reflect_Field_ == null)
				cb_accept_Ljava_lang_reflect_Field_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Accept_Ljava_lang_reflect_Field_);
			return cb_accept_Ljava_lang_reflect_Field_;
		}

		static bool n_Accept_Ljava_lang_reflect_Field_ (IntPtr jnienv, IntPtr native__this, IntPtr native_field)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var field = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (native_field, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Accept (field);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_accept_Ljava_lang_reflect_Field_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register ("accept", "(Ljava/lang/reflect/Field;)Z", "GetAccept_Ljava_lang_reflect_Field_Handler")]
		protected virtual unsafe bool Accept (global::Java.Lang.Reflect.Field field)
		{
			if (id_accept_Ljava_lang_reflect_Field_ == IntPtr.Zero)
				id_accept_Ljava_lang_reflect_Field_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/lang/reflect/Field;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (field);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_lang_reflect_Field_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accept", "(Ljava/lang/reflect/Field;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendFieldsIn_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetAppendFieldsIn_Ljava_lang_Class_Handler ()
		{
			if (cb_appendFieldsIn_Ljava_lang_Class_ == null)
				cb_appendFieldsIn_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AppendFieldsIn_Ljava_lang_Class_);
			return cb_appendFieldsIn_Ljava_lang_Class_;
		}

		static void n_AppendFieldsIn_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clazz)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clazz = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_clazz, JniHandleOwnership.DoNotTransfer);
			__this.AppendFieldsIn (clazz);
		}
#pragma warning restore 0169

		static IntPtr id_appendFieldsIn_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='appendFieldsIn' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("appendFieldsIn", "(Ljava/lang/Class;)V", "GetAppendFieldsIn_Ljava_lang_Class_Handler")]
		protected virtual unsafe void AppendFieldsIn (global::Java.Lang.Class clazz)
		{
			if (id_appendFieldsIn_Ljava_lang_Class_ == IntPtr.Zero)
				id_appendFieldsIn_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "appendFieldsIn", "(Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clazz);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendFieldsIn_Ljava_lang_Class_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendFieldsIn", "(Ljava/lang/Class;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getExcludeFieldNames;
#pragma warning disable 0169
		static Delegate GetGetExcludeFieldNamesHandler ()
		{
			if (cb_getExcludeFieldNames == null)
				cb_getExcludeFieldNames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExcludeFieldNames);
			return cb_getExcludeFieldNames;
		}

		static IntPtr n_GetExcludeFieldNames (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExcludeFieldNames ());
		}
#pragma warning restore 0169

		static IntPtr id_getExcludeFieldNames;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='getExcludeFieldNames' and count(parameter)=0]"
		[Register ("getExcludeFieldNames", "()[Ljava/lang/String;", "GetGetExcludeFieldNamesHandler")]
		public virtual unsafe string[] GetExcludeFieldNames ()
		{
			if (id_getExcludeFieldNames == IntPtr.Zero)
				id_getExcludeFieldNames = JNIEnv.GetMethodID (class_ref, "getExcludeFieldNames", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExcludeFieldNames), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExcludeFieldNames", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getValue_Ljava_lang_reflect_Field_;
#pragma warning disable 0169
		static Delegate GetGetValue_Ljava_lang_reflect_Field_Handler ()
		{
			if (cb_getValue_Ljava_lang_reflect_Field_ == null)
				cb_getValue_Ljava_lang_reflect_Field_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetValue_Ljava_lang_reflect_Field_);
			return cb_getValue_Ljava_lang_reflect_Field_;
		}

		static IntPtr n_GetValue_Ljava_lang_reflect_Field_ (IntPtr jnienv, IntPtr native__this, IntPtr native_field)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var field = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (native_field, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetValue (field));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getValue_Ljava_lang_reflect_Field_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register ("getValue", "(Ljava/lang/reflect/Field;)Ljava/lang/Object;", "GetGetValue_Ljava_lang_reflect_Field_Handler")]
		protected virtual unsafe global::Java.Lang.Object GetValue (global::Java.Lang.Reflect.Field field)
		{
			if (id_getValue_Ljava_lang_reflect_Field_ == IntPtr.Zero)
				id_getValue_Ljava_lang_reflect_Field_ = JNIEnv.GetMethodID (class_ref, "getValue", "(Ljava/lang/reflect/Field;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (field);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue_Ljava_lang_reflect_Field_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "(Ljava/lang/reflect/Field;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_reflectionAppendArray_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetReflectionAppendArray_Ljava_lang_Object_Handler ()
		{
			if (cb_reflectionAppendArray_Ljava_lang_Object_ == null)
				cb_reflectionAppendArray_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ReflectionAppendArray_Ljava_lang_Object_);
			return cb_reflectionAppendArray_Ljava_lang_Object_;
		}

		static IntPtr n_ReflectionAppendArray_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_array, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReflectionAppendArray (array));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_reflectionAppendArray_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='reflectionAppendArray' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("reflectionAppendArray", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ReflectionToStringBuilder;", "GetReflectionAppendArray_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder ReflectionAppendArray (global::Java.Lang.Object array)
		{
			if (id_reflectionAppendArray_Ljava_lang_Object_ == IntPtr.Zero)
				id_reflectionAppendArray_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "reflectionAppendArray", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ReflectionToStringBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (array);

				global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reflectionAppendArray_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reflectionAppendArray", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/ReflectionToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setExcludeFieldNames_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExcludeFieldNames_arrayLjava_lang_String_Handler ()
		{
			if (cb_setExcludeFieldNames_arrayLjava_lang_String_ == null)
				cb_setExcludeFieldNames_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetExcludeFieldNames_arrayLjava_lang_String_);
			return cb_setExcludeFieldNames_arrayLjava_lang_String_;
		}

		static IntPtr n_SetExcludeFieldNames_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_excludeFieldNamesParam)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var excludeFieldNamesParam = (string[]) JNIEnv.GetArray (native_excludeFieldNamesParam, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetExcludeFieldNames (excludeFieldNamesParam));
			if (excludeFieldNamesParam != null)
				JNIEnv.CopyArray (excludeFieldNamesParam, native_excludeFieldNamesParam);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setExcludeFieldNames_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='setExcludeFieldNames' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setExcludeFieldNames", "([Ljava/lang/String;)Lorg/apache/commons/lang3/builder/ReflectionToStringBuilder;", "GetSetExcludeFieldNames_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder SetExcludeFieldNames (params string[] excludeFieldNamesParam)
		{
			if (id_setExcludeFieldNames_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setExcludeFieldNames_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExcludeFieldNames", "([Ljava/lang/String;)Lorg/apache/commons/lang3/builder/ReflectionToStringBuilder;");
			IntPtr native_excludeFieldNamesParam = JNIEnv.NewArray (excludeFieldNamesParam);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_excludeFieldNamesParam);

				global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setExcludeFieldNames_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionToStringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExcludeFieldNames", "([Ljava/lang/String;)Lorg/apache/commons/lang3/builder/ReflectionToStringBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (excludeFieldNamesParam != null) {
					JNIEnv.CopyArray (native_excludeFieldNamesParam, excludeFieldNamesParam);
					JNIEnv.DeleteLocalRef (native_excludeFieldNamesParam);
				}
			}
		}

		static IntPtr id_toString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Object @object)
		{
			if (id_toString_Ljava_lang_Object_ == IntPtr.Zero)
				id_toString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='toString' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle']]"
		[Register ("toString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style)
		{
			if (id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ == IntPtr.Zero)
				id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (style);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='toString' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle'] and parameter[3][@type='boolean']]"
		[Register ("toString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Z)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style, bool outputTransients)
		{
			if (id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z == IntPtr.Zero)
				id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (style);
				__args [2] = new JValue (outputTransients);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='toString' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("toString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;ZZ)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style, bool outputTransients, bool outputStatics)
		{
			if (id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZ == IntPtr.Zero)
				id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;ZZ)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (style);
				__args [2] = new JValue (outputTransients);
				__args [3] = new JValue (outputStatics);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZZLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='toString' and count(parameter)=6 and parameter[1][@type='T'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='java.lang.Class&lt;? super T&gt;']]"
		[Register ("toString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;ZZZLjava/lang/Class;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe string ToString (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style, bool outputTransients, bool outputStatics, bool excludeNullValues, global::Java.Lang.Class reflectUpToClass)
		{
			if (id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZZLjava_lang_Class_ == IntPtr.Zero)
				id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZZLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;ZZZLjava/lang/Class;)Ljava/lang/String;");
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native__object);
				__args [1] = new JValue (style);
				__args [2] = new JValue (outputTransients);
				__args [3] = new JValue (outputStatics);
				__args [4] = new JValue (excludeNullValues);
				__args [5] = new JValue (reflectUpToClass);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZZLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
			}
		}

		static IntPtr id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='toString' and count(parameter)=5 and parameter[1][@type='T'] and parameter[2][@type='org.apache.commons.lang3.builder.ToStringStyle'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.Class&lt;? super T&gt;']]"
		[Register ("toString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;ZZLjava/lang/Class;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe string ToString (global::Java.Lang.Object @object, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style, bool outputTransients, bool outputStatics, global::Java.Lang.Class reflectUpToClass)
		{
			if (id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZLjava_lang_Class_ == IntPtr.Zero)
				id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "toString", "(Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;ZZLjava/lang/Class;)Ljava/lang/String;");
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native__object);
				__args [1] = new JValue (style);
				__args [2] = new JValue (outputTransients);
				__args [3] = new JValue (outputStatics);
				__args [4] = new JValue (reflectUpToClass);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ZZLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
			}
		}

		static IntPtr id_toStringExclude_Ljava_lang_Object_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='toStringExclude' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String...']]"
		[Register ("toStringExclude", "(Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToStringExclude (global::Java.Lang.Object @object, params string[] excludeFieldNames)
		{
			if (id_toStringExclude_Ljava_lang_Object_arrayLjava_lang_String_ == IntPtr.Zero)
				id_toStringExclude_Ljava_lang_Object_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toStringExclude", "(Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_excludeFieldNames = JNIEnv.NewArray (excludeFieldNames);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_excludeFieldNames);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringExclude_Ljava_lang_Object_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (excludeFieldNames != null) {
					JNIEnv.CopyArray (native_excludeFieldNames, excludeFieldNames);
					JNIEnv.DeleteLocalRef (native_excludeFieldNames);
				}
			}
		}

		static IntPtr id_toStringExclude_Ljava_lang_Object_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionToStringBuilder']/method[@name='toStringExclude' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("toStringExclude", "(Ljava/lang/Object;Ljava/util/Collection;)Ljava/lang/String;", "")]
		public static unsafe string ToStringExclude (global::Java.Lang.Object @object, global::System.Collections.Generic.ICollection<string> excludeFieldNames)
		{
			if (id_toStringExclude_Ljava_lang_Object_Ljava_util_Collection_ == IntPtr.Zero)
				id_toStringExclude_Ljava_lang_Object_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "toStringExclude", "(Ljava/lang/Object;Ljava/util/Collection;)Ljava/lang/String;");
			IntPtr native_excludeFieldNames = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (excludeFieldNames);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@object);
				__args [1] = new JValue (native_excludeFieldNames);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringExclude_Ljava_lang_Object_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_excludeFieldNames);
			}
		}

	}
}
