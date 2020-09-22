using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/ToStringStyle", DoNotGenerateAcw=true)]
	public abstract partial class ToStringStyle : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr DEFAULT_STYLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/field[@name='DEFAULT_STYLE']"
		[Register ("DEFAULT_STYLE")]
		public static global::Org.Apache.Commons.Lang3.Builder.ToStringStyle DefaultStyle {
			get {
				if (DEFAULT_STYLE_jfieldId == IntPtr.Zero)
					DEFAULT_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_STYLE", "Lorg/apache/commons/lang3/builder/ToStringStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_STYLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JSON_STYLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/field[@name='JSON_STYLE']"
		[Register ("JSON_STYLE")]
		public static global::Org.Apache.Commons.Lang3.Builder.ToStringStyle JsonStyle {
			get {
				if (JSON_STYLE_jfieldId == IntPtr.Zero)
					JSON_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JSON_STYLE", "Lorg/apache/commons/lang3/builder/ToStringStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JSON_STYLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MULTI_LINE_STYLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/field[@name='MULTI_LINE_STYLE']"
		[Register ("MULTI_LINE_STYLE")]
		public static global::Org.Apache.Commons.Lang3.Builder.ToStringStyle MultiLineStyle {
			get {
				if (MULTI_LINE_STYLE_jfieldId == IntPtr.Zero)
					MULTI_LINE_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MULTI_LINE_STYLE", "Lorg/apache/commons/lang3/builder/ToStringStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MULTI_LINE_STYLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_CLASS_NAME_STYLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/field[@name='NO_CLASS_NAME_STYLE']"
		[Register ("NO_CLASS_NAME_STYLE")]
		public static global::Org.Apache.Commons.Lang3.Builder.ToStringStyle NoClassNameStyle {
			get {
				if (NO_CLASS_NAME_STYLE_jfieldId == IntPtr.Zero)
					NO_CLASS_NAME_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_CLASS_NAME_STYLE", "Lorg/apache/commons/lang3/builder/ToStringStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_CLASS_NAME_STYLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_FIELD_NAMES_STYLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/field[@name='NO_FIELD_NAMES_STYLE']"
		[Register ("NO_FIELD_NAMES_STYLE")]
		public static global::Org.Apache.Commons.Lang3.Builder.ToStringStyle NoFieldNamesStyle {
			get {
				if (NO_FIELD_NAMES_STYLE_jfieldId == IntPtr.Zero)
					NO_FIELD_NAMES_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_FIELD_NAMES_STYLE", "Lorg/apache/commons/lang3/builder/ToStringStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_FIELD_NAMES_STYLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SHORT_PREFIX_STYLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/field[@name='SHORT_PREFIX_STYLE']"
		[Register ("SHORT_PREFIX_STYLE")]
		public static global::Org.Apache.Commons.Lang3.Builder.ToStringStyle ShortPrefixStyle {
			get {
				if (SHORT_PREFIX_STYLE_jfieldId == IntPtr.Zero)
					SHORT_PREFIX_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHORT_PREFIX_STYLE", "Lorg/apache/commons/lang3/builder/ToStringStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHORT_PREFIX_STYLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIMPLE_STYLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/field[@name='SIMPLE_STYLE']"
		[Register ("SIMPLE_STYLE")]
		public static global::Org.Apache.Commons.Lang3.Builder.ToStringStyle SimpleStyle {
			get {
				if (SIMPLE_STYLE_jfieldId == IntPtr.Zero)
					SIMPLE_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIMPLE_STYLE", "Lorg/apache/commons/lang3/builder/ToStringStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIMPLE_STYLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/builder/ToStringStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ToStringStyle); }
		}

		protected ToStringStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/constructor[@name='ToStringStyle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ToStringStyle ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ToStringStyle)) {
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

		static Delegate cb_isArrayContentDetail;
#pragma warning disable 0169
		static Delegate GetIsArrayContentDetailHandler ()
		{
			if (cb_isArrayContentDetail == null)
				cb_isArrayContentDetail = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsArrayContentDetail);
			return cb_isArrayContentDetail;
		}

		static bool n_IsArrayContentDetail (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ArrayContentDetail;
		}
#pragma warning restore 0169

		static Delegate cb_setArrayContentDetail_Z;
#pragma warning disable 0169
		static Delegate GetSetArrayContentDetail_ZHandler ()
		{
			if (cb_setArrayContentDetail_Z == null)
				cb_setArrayContentDetail_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetArrayContentDetail_Z);
			return cb_setArrayContentDetail_Z;
		}

		static void n_SetArrayContentDetail_Z (IntPtr jnienv, IntPtr native__this, bool arrayContentDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ArrayContentDetail = arrayContentDetail;
		}
#pragma warning restore 0169

		static IntPtr id_isArrayContentDetail;
		static IntPtr id_setArrayContentDetail_Z;
		protected virtual unsafe bool ArrayContentDetail {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='isArrayContentDetail' and count(parameter)=0]"
			[Register ("isArrayContentDetail", "()Z", "GetIsArrayContentDetailHandler")]
			get {
				if (id_isArrayContentDetail == IntPtr.Zero)
					id_isArrayContentDetail = JNIEnv.GetMethodID (class_ref, "isArrayContentDetail", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isArrayContentDetail);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isArrayContentDetail", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setArrayContentDetail' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setArrayContentDetail", "(Z)V", "GetSetArrayContentDetail_ZHandler")]
			set {
				if (id_setArrayContentDetail_Z == IntPtr.Zero)
					id_setArrayContentDetail_Z = JNIEnv.GetMethodID (class_ref, "setArrayContentDetail", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setArrayContentDetail_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setArrayContentDetail", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getArrayEnd;
#pragma warning disable 0169
		static Delegate GetGetArrayEndHandler ()
		{
			if (cb_getArrayEnd == null)
				cb_getArrayEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetArrayEnd);
			return cb_getArrayEnd;
		}

		static IntPtr n_GetArrayEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ArrayEnd);
		}
#pragma warning restore 0169

		static Delegate cb_setArrayEnd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetArrayEnd_Ljava_lang_String_Handler ()
		{
			if (cb_setArrayEnd_Ljava_lang_String_ == null)
				cb_setArrayEnd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetArrayEnd_Ljava_lang_String_);
			return cb_setArrayEnd_Ljava_lang_String_;
		}

		static void n_SetArrayEnd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arrayEnd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var arrayEnd = JNIEnv.GetString (native_arrayEnd, JniHandleOwnership.DoNotTransfer);
			__this.ArrayEnd = arrayEnd;
		}
#pragma warning restore 0169

		static IntPtr id_getArrayEnd;
		static IntPtr id_setArrayEnd_Ljava_lang_String_;
		protected virtual unsafe string ArrayEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getArrayEnd' and count(parameter)=0]"
			[Register ("getArrayEnd", "()Ljava/lang/String;", "GetGetArrayEndHandler")]
			get {
				if (id_getArrayEnd == IntPtr.Zero)
					id_getArrayEnd = JNIEnv.GetMethodID (class_ref, "getArrayEnd", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getArrayEnd), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getArrayEnd", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setArrayEnd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setArrayEnd", "(Ljava/lang/String;)V", "GetSetArrayEnd_Ljava_lang_String_Handler")]
			set {
				if (id_setArrayEnd_Ljava_lang_String_ == IntPtr.Zero)
					id_setArrayEnd_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setArrayEnd", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setArrayEnd_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setArrayEnd", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getArraySeparator;
#pragma warning disable 0169
		static Delegate GetGetArraySeparatorHandler ()
		{
			if (cb_getArraySeparator == null)
				cb_getArraySeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetArraySeparator);
			return cb_getArraySeparator;
		}

		static IntPtr n_GetArraySeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ArraySeparator);
		}
#pragma warning restore 0169

		static Delegate cb_setArraySeparator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetArraySeparator_Ljava_lang_String_Handler ()
		{
			if (cb_setArraySeparator_Ljava_lang_String_ == null)
				cb_setArraySeparator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetArraySeparator_Ljava_lang_String_);
			return cb_setArraySeparator_Ljava_lang_String_;
		}

		static void n_SetArraySeparator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arraySeparator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var arraySeparator = JNIEnv.GetString (native_arraySeparator, JniHandleOwnership.DoNotTransfer);
			__this.ArraySeparator = arraySeparator;
		}
#pragma warning restore 0169

		static IntPtr id_getArraySeparator;
		static IntPtr id_setArraySeparator_Ljava_lang_String_;
		protected virtual unsafe string ArraySeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getArraySeparator' and count(parameter)=0]"
			[Register ("getArraySeparator", "()Ljava/lang/String;", "GetGetArraySeparatorHandler")]
			get {
				if (id_getArraySeparator == IntPtr.Zero)
					id_getArraySeparator = JNIEnv.GetMethodID (class_ref, "getArraySeparator", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getArraySeparator), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getArraySeparator", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setArraySeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setArraySeparator", "(Ljava/lang/String;)V", "GetSetArraySeparator_Ljava_lang_String_Handler")]
			set {
				if (id_setArraySeparator_Ljava_lang_String_ == IntPtr.Zero)
					id_setArraySeparator_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setArraySeparator", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setArraySeparator_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setArraySeparator", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getArrayStart;
#pragma warning disable 0169
		static Delegate GetGetArrayStartHandler ()
		{
			if (cb_getArrayStart == null)
				cb_getArrayStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetArrayStart);
			return cb_getArrayStart;
		}

		static IntPtr n_GetArrayStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ArrayStart);
		}
#pragma warning restore 0169

		static Delegate cb_setArrayStart_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetArrayStart_Ljava_lang_String_Handler ()
		{
			if (cb_setArrayStart_Ljava_lang_String_ == null)
				cb_setArrayStart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetArrayStart_Ljava_lang_String_);
			return cb_setArrayStart_Ljava_lang_String_;
		}

		static void n_SetArrayStart_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arrayStart)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var arrayStart = JNIEnv.GetString (native_arrayStart, JniHandleOwnership.DoNotTransfer);
			__this.ArrayStart = arrayStart;
		}
#pragma warning restore 0169

		static IntPtr id_getArrayStart;
		static IntPtr id_setArrayStart_Ljava_lang_String_;
		protected virtual unsafe string ArrayStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getArrayStart' and count(parameter)=0]"
			[Register ("getArrayStart", "()Ljava/lang/String;", "GetGetArrayStartHandler")]
			get {
				if (id_getArrayStart == IntPtr.Zero)
					id_getArrayStart = JNIEnv.GetMethodID (class_ref, "getArrayStart", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getArrayStart), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getArrayStart", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setArrayStart' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setArrayStart", "(Ljava/lang/String;)V", "GetSetArrayStart_Ljava_lang_String_Handler")]
			set {
				if (id_setArrayStart_Ljava_lang_String_ == IntPtr.Zero)
					id_setArrayStart_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setArrayStart", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setArrayStart_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setArrayStart", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContentEnd;
#pragma warning disable 0169
		static Delegate GetGetContentEndHandler ()
		{
			if (cb_getContentEnd == null)
				cb_getContentEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContentEnd);
			return cb_getContentEnd;
		}

		static IntPtr n_GetContentEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentEnd);
		}
#pragma warning restore 0169

		static Delegate cb_setContentEnd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentEnd_Ljava_lang_String_Handler ()
		{
			if (cb_setContentEnd_Ljava_lang_String_ == null)
				cb_setContentEnd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetContentEnd_Ljava_lang_String_);
			return cb_setContentEnd_Ljava_lang_String_;
		}

		static void n_SetContentEnd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentEnd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var contentEnd = JNIEnv.GetString (native_contentEnd, JniHandleOwnership.DoNotTransfer);
			__this.ContentEnd = contentEnd;
		}
#pragma warning restore 0169

		static IntPtr id_getContentEnd;
		static IntPtr id_setContentEnd_Ljava_lang_String_;
		protected virtual unsafe string ContentEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getContentEnd' and count(parameter)=0]"
			[Register ("getContentEnd", "()Ljava/lang/String;", "GetGetContentEndHandler")]
			get {
				if (id_getContentEnd == IntPtr.Zero)
					id_getContentEnd = JNIEnv.GetMethodID (class_ref, "getContentEnd", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentEnd), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentEnd", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setContentEnd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentEnd", "(Ljava/lang/String;)V", "GetSetContentEnd_Ljava_lang_String_Handler")]
			set {
				if (id_setContentEnd_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentEnd_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentEnd", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentEnd_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentEnd", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContentStart;
#pragma warning disable 0169
		static Delegate GetGetContentStartHandler ()
		{
			if (cb_getContentStart == null)
				cb_getContentStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContentStart);
			return cb_getContentStart;
		}

		static IntPtr n_GetContentStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentStart);
		}
#pragma warning restore 0169

		static Delegate cb_setContentStart_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentStart_Ljava_lang_String_Handler ()
		{
			if (cb_setContentStart_Ljava_lang_String_ == null)
				cb_setContentStart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetContentStart_Ljava_lang_String_);
			return cb_setContentStart_Ljava_lang_String_;
		}

		static void n_SetContentStart_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentStart)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var contentStart = JNIEnv.GetString (native_contentStart, JniHandleOwnership.DoNotTransfer);
			__this.ContentStart = contentStart;
		}
#pragma warning restore 0169

		static IntPtr id_getContentStart;
		static IntPtr id_setContentStart_Ljava_lang_String_;
		protected virtual unsafe string ContentStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getContentStart' and count(parameter)=0]"
			[Register ("getContentStart", "()Ljava/lang/String;", "GetGetContentStartHandler")]
			get {
				if (id_getContentStart == IntPtr.Zero)
					id_getContentStart = JNIEnv.GetMethodID (class_ref, "getContentStart", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentStart), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentStart", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setContentStart' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentStart", "(Ljava/lang/String;)V", "GetSetContentStart_Ljava_lang_String_Handler")]
			set {
				if (id_setContentStart_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentStart_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentStart", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentStart_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentStart", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isDefaultFullDetail;
#pragma warning disable 0169
		static Delegate GetIsDefaultFullDetailHandler ()
		{
			if (cb_isDefaultFullDetail == null)
				cb_isDefaultFullDetail = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDefaultFullDetail);
			return cb_isDefaultFullDetail;
		}

		static bool n_IsDefaultFullDetail (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultFullDetail;
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultFullDetail_Z;
#pragma warning disable 0169
		static Delegate GetSetDefaultFullDetail_ZHandler ()
		{
			if (cb_setDefaultFullDetail_Z == null)
				cb_setDefaultFullDetail_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDefaultFullDetail_Z);
			return cb_setDefaultFullDetail_Z;
		}

		static void n_SetDefaultFullDetail_Z (IntPtr jnienv, IntPtr native__this, bool defaultFullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DefaultFullDetail = defaultFullDetail;
		}
#pragma warning restore 0169

		static IntPtr id_isDefaultFullDetail;
		static IntPtr id_setDefaultFullDetail_Z;
		protected virtual unsafe bool DefaultFullDetail {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='isDefaultFullDetail' and count(parameter)=0]"
			[Register ("isDefaultFullDetail", "()Z", "GetIsDefaultFullDetailHandler")]
			get {
				if (id_isDefaultFullDetail == IntPtr.Zero)
					id_isDefaultFullDetail = JNIEnv.GetMethodID (class_ref, "isDefaultFullDetail", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDefaultFullDetail);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDefaultFullDetail", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setDefaultFullDetail' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDefaultFullDetail", "(Z)V", "GetSetDefaultFullDetail_ZHandler")]
			set {
				if (id_setDefaultFullDetail_Z == IntPtr.Zero)
					id_setDefaultFullDetail_Z = JNIEnv.GetMethodID (class_ref, "setDefaultFullDetail", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultFullDetail_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultFullDetail", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFieldNameValueSeparator;
#pragma warning disable 0169
		static Delegate GetGetFieldNameValueSeparatorHandler ()
		{
			if (cb_getFieldNameValueSeparator == null)
				cb_getFieldNameValueSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFieldNameValueSeparator);
			return cb_getFieldNameValueSeparator;
		}

		static IntPtr n_GetFieldNameValueSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FieldNameValueSeparator);
		}
#pragma warning restore 0169

		static Delegate cb_setFieldNameValueSeparator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFieldNameValueSeparator_Ljava_lang_String_Handler ()
		{
			if (cb_setFieldNameValueSeparator_Ljava_lang_String_ == null)
				cb_setFieldNameValueSeparator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFieldNameValueSeparator_Ljava_lang_String_);
			return cb_setFieldNameValueSeparator_Ljava_lang_String_;
		}

		static void n_SetFieldNameValueSeparator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldNameValueSeparator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldNameValueSeparator = JNIEnv.GetString (native_fieldNameValueSeparator, JniHandleOwnership.DoNotTransfer);
			__this.FieldNameValueSeparator = fieldNameValueSeparator;
		}
#pragma warning restore 0169

		static IntPtr id_getFieldNameValueSeparator;
		static IntPtr id_setFieldNameValueSeparator_Ljava_lang_String_;
		protected virtual unsafe string FieldNameValueSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getFieldNameValueSeparator' and count(parameter)=0]"
			[Register ("getFieldNameValueSeparator", "()Ljava/lang/String;", "GetGetFieldNameValueSeparatorHandler")]
			get {
				if (id_getFieldNameValueSeparator == IntPtr.Zero)
					id_getFieldNameValueSeparator = JNIEnv.GetMethodID (class_ref, "getFieldNameValueSeparator", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFieldNameValueSeparator), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFieldNameValueSeparator", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setFieldNameValueSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFieldNameValueSeparator", "(Ljava/lang/String;)V", "GetSetFieldNameValueSeparator_Ljava_lang_String_Handler")]
			set {
				if (id_setFieldNameValueSeparator_Ljava_lang_String_ == IntPtr.Zero)
					id_setFieldNameValueSeparator_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFieldNameValueSeparator", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFieldNameValueSeparator_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFieldNameValueSeparator", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFieldSeparator;
#pragma warning disable 0169
		static Delegate GetGetFieldSeparatorHandler ()
		{
			if (cb_getFieldSeparator == null)
				cb_getFieldSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFieldSeparator);
			return cb_getFieldSeparator;
		}

		static IntPtr n_GetFieldSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FieldSeparator);
		}
#pragma warning restore 0169

		static Delegate cb_setFieldSeparator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFieldSeparator_Ljava_lang_String_Handler ()
		{
			if (cb_setFieldSeparator_Ljava_lang_String_ == null)
				cb_setFieldSeparator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFieldSeparator_Ljava_lang_String_);
			return cb_setFieldSeparator_Ljava_lang_String_;
		}

		static void n_SetFieldSeparator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldSeparator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldSeparator = JNIEnv.GetString (native_fieldSeparator, JniHandleOwnership.DoNotTransfer);
			__this.FieldSeparator = fieldSeparator;
		}
#pragma warning restore 0169

		static IntPtr id_getFieldSeparator;
		static IntPtr id_setFieldSeparator_Ljava_lang_String_;
		protected virtual unsafe string FieldSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getFieldSeparator' and count(parameter)=0]"
			[Register ("getFieldSeparator", "()Ljava/lang/String;", "GetGetFieldSeparatorHandler")]
			get {
				if (id_getFieldSeparator == IntPtr.Zero)
					id_getFieldSeparator = JNIEnv.GetMethodID (class_ref, "getFieldSeparator", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFieldSeparator), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFieldSeparator", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setFieldSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFieldSeparator", "(Ljava/lang/String;)V", "GetSetFieldSeparator_Ljava_lang_String_Handler")]
			set {
				if (id_setFieldSeparator_Ljava_lang_String_ == IntPtr.Zero)
					id_setFieldSeparator_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFieldSeparator", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFieldSeparator_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFieldSeparator", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isFieldSeparatorAtEnd;
#pragma warning disable 0169
		static Delegate GetIsFieldSeparatorAtEndHandler ()
		{
			if (cb_isFieldSeparatorAtEnd == null)
				cb_isFieldSeparatorAtEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFieldSeparatorAtEnd);
			return cb_isFieldSeparatorAtEnd;
		}

		static bool n_IsFieldSeparatorAtEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FieldSeparatorAtEnd;
		}
#pragma warning restore 0169

		static Delegate cb_setFieldSeparatorAtEnd_Z;
#pragma warning disable 0169
		static Delegate GetSetFieldSeparatorAtEnd_ZHandler ()
		{
			if (cb_setFieldSeparatorAtEnd_Z == null)
				cb_setFieldSeparatorAtEnd_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFieldSeparatorAtEnd_Z);
			return cb_setFieldSeparatorAtEnd_Z;
		}

		static void n_SetFieldSeparatorAtEnd_Z (IntPtr jnienv, IntPtr native__this, bool fieldSeparatorAtEnd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FieldSeparatorAtEnd = fieldSeparatorAtEnd;
		}
#pragma warning restore 0169

		static IntPtr id_isFieldSeparatorAtEnd;
		static IntPtr id_setFieldSeparatorAtEnd_Z;
		protected virtual unsafe bool FieldSeparatorAtEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='isFieldSeparatorAtEnd' and count(parameter)=0]"
			[Register ("isFieldSeparatorAtEnd", "()Z", "GetIsFieldSeparatorAtEndHandler")]
			get {
				if (id_isFieldSeparatorAtEnd == IntPtr.Zero)
					id_isFieldSeparatorAtEnd = JNIEnv.GetMethodID (class_ref, "isFieldSeparatorAtEnd", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFieldSeparatorAtEnd);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFieldSeparatorAtEnd", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setFieldSeparatorAtEnd' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFieldSeparatorAtEnd", "(Z)V", "GetSetFieldSeparatorAtEnd_ZHandler")]
			set {
				if (id_setFieldSeparatorAtEnd_Z == IntPtr.Zero)
					id_setFieldSeparatorAtEnd_Z = JNIEnv.GetMethodID (class_ref, "setFieldSeparatorAtEnd", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFieldSeparatorAtEnd_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFieldSeparatorAtEnd", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isFieldSeparatorAtStart;
#pragma warning disable 0169
		static Delegate GetIsFieldSeparatorAtStartHandler ()
		{
			if (cb_isFieldSeparatorAtStart == null)
				cb_isFieldSeparatorAtStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFieldSeparatorAtStart);
			return cb_isFieldSeparatorAtStart;
		}

		static bool n_IsFieldSeparatorAtStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FieldSeparatorAtStart;
		}
#pragma warning restore 0169

		static Delegate cb_setFieldSeparatorAtStart_Z;
#pragma warning disable 0169
		static Delegate GetSetFieldSeparatorAtStart_ZHandler ()
		{
			if (cb_setFieldSeparatorAtStart_Z == null)
				cb_setFieldSeparatorAtStart_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFieldSeparatorAtStart_Z);
			return cb_setFieldSeparatorAtStart_Z;
		}

		static void n_SetFieldSeparatorAtStart_Z (IntPtr jnienv, IntPtr native__this, bool fieldSeparatorAtStart)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FieldSeparatorAtStart = fieldSeparatorAtStart;
		}
#pragma warning restore 0169

		static IntPtr id_isFieldSeparatorAtStart;
		static IntPtr id_setFieldSeparatorAtStart_Z;
		protected virtual unsafe bool FieldSeparatorAtStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='isFieldSeparatorAtStart' and count(parameter)=0]"
			[Register ("isFieldSeparatorAtStart", "()Z", "GetIsFieldSeparatorAtStartHandler")]
			get {
				if (id_isFieldSeparatorAtStart == IntPtr.Zero)
					id_isFieldSeparatorAtStart = JNIEnv.GetMethodID (class_ref, "isFieldSeparatorAtStart", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFieldSeparatorAtStart);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFieldSeparatorAtStart", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setFieldSeparatorAtStart' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFieldSeparatorAtStart", "(Z)V", "GetSetFieldSeparatorAtStart_ZHandler")]
			set {
				if (id_setFieldSeparatorAtStart_Z == IntPtr.Zero)
					id_setFieldSeparatorAtStart_Z = JNIEnv.GetMethodID (class_ref, "setFieldSeparatorAtStart", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFieldSeparatorAtStart_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFieldSeparatorAtStart", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNullText;
#pragma warning disable 0169
		static Delegate GetGetNullTextHandler ()
		{
			if (cb_getNullText == null)
				cb_getNullText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNullText);
			return cb_getNullText;
		}

		static IntPtr n_GetNullText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NullText);
		}
#pragma warning restore 0169

		static Delegate cb_setNullText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNullText_Ljava_lang_String_Handler ()
		{
			if (cb_setNullText_Ljava_lang_String_ == null)
				cb_setNullText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNullText_Ljava_lang_String_);
			return cb_setNullText_Ljava_lang_String_;
		}

		static void n_SetNullText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nullText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nullText = JNIEnv.GetString (native_nullText, JniHandleOwnership.DoNotTransfer);
			__this.NullText = nullText;
		}
#pragma warning restore 0169

		static IntPtr id_getNullText;
		static IntPtr id_setNullText_Ljava_lang_String_;
		protected virtual unsafe string NullText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getNullText' and count(parameter)=0]"
			[Register ("getNullText", "()Ljava/lang/String;", "GetGetNullTextHandler")]
			get {
				if (id_getNullText == IntPtr.Zero)
					id_getNullText = JNIEnv.GetMethodID (class_ref, "getNullText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNullText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNullText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setNullText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNullText", "(Ljava/lang/String;)V", "GetSetNullText_Ljava_lang_String_Handler")]
			set {
				if (id_setNullText_Ljava_lang_String_ == IntPtr.Zero)
					id_setNullText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNullText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNullText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNullText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSizeEndText;
#pragma warning disable 0169
		static Delegate GetGetSizeEndTextHandler ()
		{
			if (cb_getSizeEndText == null)
				cb_getSizeEndText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSizeEndText);
			return cb_getSizeEndText;
		}

		static IntPtr n_GetSizeEndText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SizeEndText);
		}
#pragma warning restore 0169

		static Delegate cb_setSizeEndText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSizeEndText_Ljava_lang_String_Handler ()
		{
			if (cb_setSizeEndText_Ljava_lang_String_ == null)
				cb_setSizeEndText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSizeEndText_Ljava_lang_String_);
			return cb_setSizeEndText_Ljava_lang_String_;
		}

		static void n_SetSizeEndText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sizeEndText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sizeEndText = JNIEnv.GetString (native_sizeEndText, JniHandleOwnership.DoNotTransfer);
			__this.SizeEndText = sizeEndText;
		}
#pragma warning restore 0169

		static IntPtr id_getSizeEndText;
		static IntPtr id_setSizeEndText_Ljava_lang_String_;
		protected virtual unsafe string SizeEndText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getSizeEndText' and count(parameter)=0]"
			[Register ("getSizeEndText", "()Ljava/lang/String;", "GetGetSizeEndTextHandler")]
			get {
				if (id_getSizeEndText == IntPtr.Zero)
					id_getSizeEndText = JNIEnv.GetMethodID (class_ref, "getSizeEndText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSizeEndText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSizeEndText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setSizeEndText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSizeEndText", "(Ljava/lang/String;)V", "GetSetSizeEndText_Ljava_lang_String_Handler")]
			set {
				if (id_setSizeEndText_Ljava_lang_String_ == IntPtr.Zero)
					id_setSizeEndText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSizeEndText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSizeEndText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSizeEndText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSizeStartText;
#pragma warning disable 0169
		static Delegate GetGetSizeStartTextHandler ()
		{
			if (cb_getSizeStartText == null)
				cb_getSizeStartText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSizeStartText);
			return cb_getSizeStartText;
		}

		static IntPtr n_GetSizeStartText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SizeStartText);
		}
#pragma warning restore 0169

		static Delegate cb_setSizeStartText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSizeStartText_Ljava_lang_String_Handler ()
		{
			if (cb_setSizeStartText_Ljava_lang_String_ == null)
				cb_setSizeStartText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSizeStartText_Ljava_lang_String_);
			return cb_setSizeStartText_Ljava_lang_String_;
		}

		static void n_SetSizeStartText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sizeStartText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sizeStartText = JNIEnv.GetString (native_sizeStartText, JniHandleOwnership.DoNotTransfer);
			__this.SizeStartText = sizeStartText;
		}
#pragma warning restore 0169

		static IntPtr id_getSizeStartText;
		static IntPtr id_setSizeStartText_Ljava_lang_String_;
		protected virtual unsafe string SizeStartText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getSizeStartText' and count(parameter)=0]"
			[Register ("getSizeStartText", "()Ljava/lang/String;", "GetGetSizeStartTextHandler")]
			get {
				if (id_getSizeStartText == IntPtr.Zero)
					id_getSizeStartText = JNIEnv.GetMethodID (class_ref, "getSizeStartText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSizeStartText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSizeStartText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setSizeStartText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSizeStartText", "(Ljava/lang/String;)V", "GetSetSizeStartText_Ljava_lang_String_Handler")]
			set {
				if (id_setSizeStartText_Ljava_lang_String_ == IntPtr.Zero)
					id_setSizeStartText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSizeStartText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSizeStartText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSizeStartText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSummaryObjectEndText;
#pragma warning disable 0169
		static Delegate GetGetSummaryObjectEndTextHandler ()
		{
			if (cb_getSummaryObjectEndText == null)
				cb_getSummaryObjectEndText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSummaryObjectEndText);
			return cb_getSummaryObjectEndText;
		}

		static IntPtr n_GetSummaryObjectEndText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SummaryObjectEndText);
		}
#pragma warning restore 0169

		static Delegate cb_setSummaryObjectEndText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSummaryObjectEndText_Ljava_lang_String_Handler ()
		{
			if (cb_setSummaryObjectEndText_Ljava_lang_String_ == null)
				cb_setSummaryObjectEndText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSummaryObjectEndText_Ljava_lang_String_);
			return cb_setSummaryObjectEndText_Ljava_lang_String_;
		}

		static void n_SetSummaryObjectEndText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_summaryObjectEndText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var summaryObjectEndText = JNIEnv.GetString (native_summaryObjectEndText, JniHandleOwnership.DoNotTransfer);
			__this.SummaryObjectEndText = summaryObjectEndText;
		}
#pragma warning restore 0169

		static IntPtr id_getSummaryObjectEndText;
		static IntPtr id_setSummaryObjectEndText_Ljava_lang_String_;
		protected virtual unsafe string SummaryObjectEndText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getSummaryObjectEndText' and count(parameter)=0]"
			[Register ("getSummaryObjectEndText", "()Ljava/lang/String;", "GetGetSummaryObjectEndTextHandler")]
			get {
				if (id_getSummaryObjectEndText == IntPtr.Zero)
					id_getSummaryObjectEndText = JNIEnv.GetMethodID (class_ref, "getSummaryObjectEndText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSummaryObjectEndText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSummaryObjectEndText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setSummaryObjectEndText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSummaryObjectEndText", "(Ljava/lang/String;)V", "GetSetSummaryObjectEndText_Ljava_lang_String_Handler")]
			set {
				if (id_setSummaryObjectEndText_Ljava_lang_String_ == IntPtr.Zero)
					id_setSummaryObjectEndText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSummaryObjectEndText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSummaryObjectEndText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSummaryObjectEndText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSummaryObjectStartText;
#pragma warning disable 0169
		static Delegate GetGetSummaryObjectStartTextHandler ()
		{
			if (cb_getSummaryObjectStartText == null)
				cb_getSummaryObjectStartText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSummaryObjectStartText);
			return cb_getSummaryObjectStartText;
		}

		static IntPtr n_GetSummaryObjectStartText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SummaryObjectStartText);
		}
#pragma warning restore 0169

		static Delegate cb_setSummaryObjectStartText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSummaryObjectStartText_Ljava_lang_String_Handler ()
		{
			if (cb_setSummaryObjectStartText_Ljava_lang_String_ == null)
				cb_setSummaryObjectStartText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSummaryObjectStartText_Ljava_lang_String_);
			return cb_setSummaryObjectStartText_Ljava_lang_String_;
		}

		static void n_SetSummaryObjectStartText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_summaryObjectStartText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var summaryObjectStartText = JNIEnv.GetString (native_summaryObjectStartText, JniHandleOwnership.DoNotTransfer);
			__this.SummaryObjectStartText = summaryObjectStartText;
		}
#pragma warning restore 0169

		static IntPtr id_getSummaryObjectStartText;
		static IntPtr id_setSummaryObjectStartText_Ljava_lang_String_;
		protected virtual unsafe string SummaryObjectStartText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getSummaryObjectStartText' and count(parameter)=0]"
			[Register ("getSummaryObjectStartText", "()Ljava/lang/String;", "GetGetSummaryObjectStartTextHandler")]
			get {
				if (id_getSummaryObjectStartText == IntPtr.Zero)
					id_getSummaryObjectStartText = JNIEnv.GetMethodID (class_ref, "getSummaryObjectStartText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSummaryObjectStartText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSummaryObjectStartText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setSummaryObjectStartText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSummaryObjectStartText", "(Ljava/lang/String;)V", "GetSetSummaryObjectStartText_Ljava_lang_String_Handler")]
			set {
				if (id_setSummaryObjectStartText_Ljava_lang_String_ == IntPtr.Zero)
					id_setSummaryObjectStartText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSummaryObjectStartText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSummaryObjectStartText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSummaryObjectStartText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isUseClassName;
#pragma warning disable 0169
		static Delegate GetIsUseClassNameHandler ()
		{
			if (cb_isUseClassName == null)
				cb_isUseClassName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseClassName);
			return cb_isUseClassName;
		}

		static bool n_IsUseClassName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseClassName;
		}
#pragma warning restore 0169

		static Delegate cb_setUseClassName_Z;
#pragma warning disable 0169
		static Delegate GetSetUseClassName_ZHandler ()
		{
			if (cb_setUseClassName_Z == null)
				cb_setUseClassName_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseClassName_Z);
			return cb_setUseClassName_Z;
		}

		static void n_SetUseClassName_Z (IntPtr jnienv, IntPtr native__this, bool useClassName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseClassName = useClassName;
		}
#pragma warning restore 0169

		static IntPtr id_isUseClassName;
		static IntPtr id_setUseClassName_Z;
		protected virtual unsafe bool UseClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='isUseClassName' and count(parameter)=0]"
			[Register ("isUseClassName", "()Z", "GetIsUseClassNameHandler")]
			get {
				if (id_isUseClassName == IntPtr.Zero)
					id_isUseClassName = JNIEnv.GetMethodID (class_ref, "isUseClassName", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUseClassName);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUseClassName", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setUseClassName' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseClassName", "(Z)V", "GetSetUseClassName_ZHandler")]
			set {
				if (id_setUseClassName_Z == IntPtr.Zero)
					id_setUseClassName_Z = JNIEnv.GetMethodID (class_ref, "setUseClassName", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUseClassName_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseClassName", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseFieldNames;
#pragma warning disable 0169
		static Delegate GetIsUseFieldNamesHandler ()
		{
			if (cb_isUseFieldNames == null)
				cb_isUseFieldNames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseFieldNames);
			return cb_isUseFieldNames;
		}

		static bool n_IsUseFieldNames (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseFieldNames;
		}
#pragma warning restore 0169

		static Delegate cb_setUseFieldNames_Z;
#pragma warning disable 0169
		static Delegate GetSetUseFieldNames_ZHandler ()
		{
			if (cb_setUseFieldNames_Z == null)
				cb_setUseFieldNames_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseFieldNames_Z);
			return cb_setUseFieldNames_Z;
		}

		static void n_SetUseFieldNames_Z (IntPtr jnienv, IntPtr native__this, bool useFieldNames)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseFieldNames = useFieldNames;
		}
#pragma warning restore 0169

		static IntPtr id_isUseFieldNames;
		static IntPtr id_setUseFieldNames_Z;
		protected virtual unsafe bool UseFieldNames {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='isUseFieldNames' and count(parameter)=0]"
			[Register ("isUseFieldNames", "()Z", "GetIsUseFieldNamesHandler")]
			get {
				if (id_isUseFieldNames == IntPtr.Zero)
					id_isUseFieldNames = JNIEnv.GetMethodID (class_ref, "isUseFieldNames", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUseFieldNames);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUseFieldNames", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setUseFieldNames' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseFieldNames", "(Z)V", "GetSetUseFieldNames_ZHandler")]
			set {
				if (id_setUseFieldNames_Z == IntPtr.Zero)
					id_setUseFieldNames_Z = JNIEnv.GetMethodID (class_ref, "setUseFieldNames", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUseFieldNames_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseFieldNames", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseIdentityHashCode;
#pragma warning disable 0169
		static Delegate GetIsUseIdentityHashCodeHandler ()
		{
			if (cb_isUseIdentityHashCode == null)
				cb_isUseIdentityHashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseIdentityHashCode);
			return cb_isUseIdentityHashCode;
		}

		static bool n_IsUseIdentityHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseIdentityHashCode;
		}
#pragma warning restore 0169

		static Delegate cb_setUseIdentityHashCode_Z;
#pragma warning disable 0169
		static Delegate GetSetUseIdentityHashCode_ZHandler ()
		{
			if (cb_setUseIdentityHashCode_Z == null)
				cb_setUseIdentityHashCode_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseIdentityHashCode_Z);
			return cb_setUseIdentityHashCode_Z;
		}

		static void n_SetUseIdentityHashCode_Z (IntPtr jnienv, IntPtr native__this, bool useIdentityHashCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseIdentityHashCode = useIdentityHashCode;
		}
#pragma warning restore 0169

		static IntPtr id_isUseIdentityHashCode;
		static IntPtr id_setUseIdentityHashCode_Z;
		protected virtual unsafe bool UseIdentityHashCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='isUseIdentityHashCode' and count(parameter)=0]"
			[Register ("isUseIdentityHashCode", "()Z", "GetIsUseIdentityHashCodeHandler")]
			get {
				if (id_isUseIdentityHashCode == IntPtr.Zero)
					id_isUseIdentityHashCode = JNIEnv.GetMethodID (class_ref, "isUseIdentityHashCode", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUseIdentityHashCode);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUseIdentityHashCode", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setUseIdentityHashCode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseIdentityHashCode", "(Z)V", "GetSetUseIdentityHashCode_ZHandler")]
			set {
				if (id_setUseIdentityHashCode_Z == IntPtr.Zero)
					id_setUseIdentityHashCode_Z = JNIEnv.GetMethodID (class_ref, "setUseIdentityHashCode", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUseIdentityHashCode_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseIdentityHashCode", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseShortClassName;
#pragma warning disable 0169
		static Delegate GetIsUseShortClassNameHandler ()
		{
			if (cb_isUseShortClassName == null)
				cb_isUseShortClassName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseShortClassName);
			return cb_isUseShortClassName;
		}

		static bool n_IsUseShortClassName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseShortClassName;
		}
#pragma warning restore 0169

		static Delegate cb_setUseShortClassName_Z;
#pragma warning disable 0169
		static Delegate GetSetUseShortClassName_ZHandler ()
		{
			if (cb_setUseShortClassName_Z == null)
				cb_setUseShortClassName_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseShortClassName_Z);
			return cb_setUseShortClassName_Z;
		}

		static void n_SetUseShortClassName_Z (IntPtr jnienv, IntPtr native__this, bool useShortClassName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseShortClassName = useShortClassName;
		}
#pragma warning restore 0169

		static IntPtr id_isUseShortClassName;
		static IntPtr id_setUseShortClassName_Z;
		protected virtual unsafe bool UseShortClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='isUseShortClassName' and count(parameter)=0]"
			[Register ("isUseShortClassName", "()Z", "GetIsUseShortClassNameHandler")]
			get {
				if (id_isUseShortClassName == IntPtr.Zero)
					id_isUseShortClassName = JNIEnv.GetMethodID (class_ref, "isUseShortClassName", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUseShortClassName);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUseShortClassName", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='setUseShortClassName' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseShortClassName", "(Z)V", "GetSetUseShortClassName_ZHandler")]
			set {
				if (id_setUseShortClassName_Z == IntPtr.Zero)
					id_setUseShortClassName_Z = JNIEnv.GetMethodID (class_ref, "setUseShortClassName", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUseShortClassName_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseShortClassName", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_ZHandler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_Z == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_Z);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_Z;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, bool value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;Z)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_ZHandler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, bool value)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_Z == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;Z)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_ == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array, IntPtr native_fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (bool[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (bool));
			var fullDetail = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_fullDetail, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, array, fullDetail);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=4 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean[]'] and parameter[4][@type='java.lang.Boolean']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[ZLjava/lang/Boolean;)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_Handler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, bool[] array, global::Java.Lang.Boolean fullDetail)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[ZLjava/lang/Boolean;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);
				__args [3] = new JValue (fullDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZLjava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[ZLjava/lang/Boolean;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_B;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_BHandler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_B == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLB_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_B);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_B;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_B (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, sbyte value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;B)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_BHandler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, sbyte value)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_B == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_B = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;B)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_B, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;B)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_ == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array, IntPtr native_fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (byte[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var fullDetail = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_fullDetail, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, array, fullDetail);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=4 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.Boolean']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[BLjava/lang/Boolean;)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_Handler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, byte[] array, global::Java.Lang.Boolean fullDetail)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[BLjava/lang/Boolean;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);
				__args [3] = new JValue (fullDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBLjava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[BLjava/lang/Boolean;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_C;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_CHandler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_C == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLC_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_C);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_C;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_C (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, char value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='char']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;C)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_CHandler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, char value)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_C == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_C = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;C)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_C, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;C)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_ == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array, IntPtr native_fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (char[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (char));
			var fullDetail = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_fullDetail, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, array, fullDetail);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=4 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='char[]'] and parameter[4][@type='java.lang.Boolean']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[CLjava/lang/Boolean;)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_Handler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, char[] array, global::Java.Lang.Boolean fullDetail)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[CLjava/lang/Boolean;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);
				__args [3] = new JValue (fullDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCLjava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[CLjava/lang/Boolean;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_DHandler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_D == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLD_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_D);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_D;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, double value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;D)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_DHandler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, double value)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_D == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;D)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_ == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array, IntPtr native_fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (double[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (double));
			var fullDetail = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_fullDetail, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, array, fullDetail);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=4 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double[]'] and parameter[4][@type='java.lang.Boolean']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[DLjava/lang/Boolean;)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_Handler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, double[] array, global::Java.Lang.Boolean fullDetail)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[DLjava/lang/Boolean;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);
				__args [3] = new JValue (fullDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDLjava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[DLjava/lang/Boolean;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_FHandler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_F == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLF_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_F);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_F;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, float value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;F)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_FHandler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, float value)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_F == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;F)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;F)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_ == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array, IntPtr native_fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (float[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (float));
			var fullDetail = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_fullDetail, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, array, fullDetail);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=4 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float[]'] and parameter[4][@type='java.lang.Boolean']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[FLjava/lang/Boolean;)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_Handler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, float[] array, global::Java.Lang.Boolean fullDetail)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[FLjava/lang/Boolean;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);
				__args [3] = new JValue (fullDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFLjava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[FLjava/lang/Boolean;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_IHandler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_I == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_I);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_I;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;I)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_IHandler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, int value)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_I == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;I)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_ == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array, IntPtr native_fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (int[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (int));
			var fullDetail = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_fullDetail, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, array, fullDetail);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=4 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int[]'] and parameter[4][@type='java.lang.Boolean']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[ILjava/lang/Boolean;)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_Handler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, int[] array, global::Java.Lang.Boolean fullDetail)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[ILjava/lang/Boolean;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);
				__args [3] = new JValue (fullDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayILjava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[ILjava/lang/Boolean;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_ == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_value, IntPtr native_fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			var fullDetail = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_fullDetail, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, value, fullDetail);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=4 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Boolean']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Boolean;)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, global::Java.Lang.Object value, global::Java.Lang.Boolean fullDetail)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Boolean;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);
				__args [3] = new JValue (fullDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Boolean;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_ == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array, IntPtr native_fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			var fullDetail = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_fullDetail, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, array, fullDetail);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=4 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]'] and parameter[4][@type='java.lang.Boolean']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Boolean;)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, global::Java.Lang.Object[] array, global::Java.Lang.Boolean fullDetail)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Boolean;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);
				__args [3] = new JValue (fullDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Boolean;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_JHandler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_J == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJ_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_J);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_J;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, long value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;J)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_JHandler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, long value)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_J == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;J)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_ == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array, IntPtr native_fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (long[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (long));
			var fullDetail = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_fullDetail, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, array, fullDetail);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=4 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long[]'] and parameter[4][@type='java.lang.Boolean']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[JLjava/lang/Boolean;)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_Handler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, long[] array, global::Java.Lang.Boolean fullDetail)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[JLjava/lang/Boolean;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);
				__args [3] = new JValue (fullDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJLjava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[JLjava/lang/Boolean;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_SHandler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_S == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_S = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLS_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_S);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_S;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_S (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, short value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;S)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_SHandler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, short value)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_S == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_S = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;S)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_S, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;S)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_ == null)
				cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_);
			return cb_append_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_;
		}

		static void n_Append_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array, IntPtr native_fullDetail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (short[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (short));
			var fullDetail = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_fullDetail, JniHandleOwnership.DoNotTransfer);
			__this.Append (buffer, fieldName, array, fullDetail);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='append' and count(parameter)=4 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short[]'] and parameter[4][@type='java.lang.Boolean']]"
		[Register ("append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[SLjava/lang/Boolean;)V", "GetAppend_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_Handler")]
		public virtual unsafe void Append (global::Java.Lang.StringBuffer buffer, string fieldName, short[] array, global::Java.Lang.Boolean fullDetail)
		{
			if (id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[SLjava/lang/Boolean;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);
				__args [3] = new JValue (fullDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_Ljava_lang_String_arraySLjava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;Ljava/lang/String;[SLjava/lang/Boolean;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_Handler ()
		{
			if (cb_appendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_ == null)
				cb_appendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AppendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_);
			return cb_appendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_;
		}

		static void n_AppendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native__object)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			__this.AppendClassName (buffer, @object);
		}
#pragma warning restore 0169

		static IntPtr id_appendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendClassName' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.Object']]"
		[Register ("appendClassName", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V", "GetAppendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_Handler")]
		protected virtual unsafe void AppendClassName (global::Java.Lang.StringBuffer buffer, global::Java.Lang.Object @object)
		{
			if (id_appendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_ == IntPtr.Zero)
				id_appendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendClassName", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (@object);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendClassName_Ljava_lang_StringBuffer_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendClassName", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_appendContentEnd_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		static Delegate GetAppendContentEnd_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_appendContentEnd_Ljava_lang_StringBuffer_ == null)
				cb_appendContentEnd_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AppendContentEnd_Ljava_lang_StringBuffer_);
			return cb_appendContentEnd_Ljava_lang_StringBuffer_;
		}

		static void n_AppendContentEnd_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.AppendContentEnd (buffer);
		}
#pragma warning restore 0169

		static IntPtr id_appendContentEnd_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendContentEnd' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuffer']]"
		[Register ("appendContentEnd", "(Ljava/lang/StringBuffer;)V", "GetAppendContentEnd_Ljava_lang_StringBuffer_Handler")]
		protected virtual unsafe void AppendContentEnd (global::Java.Lang.StringBuffer buffer)
		{
			if (id_appendContentEnd_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_appendContentEnd_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "appendContentEnd", "(Ljava/lang/StringBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (buffer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendContentEnd_Ljava_lang_StringBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendContentEnd", "(Ljava/lang/StringBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_appendContentStart_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		static Delegate GetAppendContentStart_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_appendContentStart_Ljava_lang_StringBuffer_ == null)
				cb_appendContentStart_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AppendContentStart_Ljava_lang_StringBuffer_);
			return cb_appendContentStart_Ljava_lang_StringBuffer_;
		}

		static void n_AppendContentStart_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.AppendContentStart (buffer);
		}
#pragma warning restore 0169

		static IntPtr id_appendContentStart_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendContentStart' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuffer']]"
		[Register ("appendContentStart", "(Ljava/lang/StringBuffer;)V", "GetAppendContentStart_Ljava_lang_StringBuffer_Handler")]
		protected virtual unsafe void AppendContentStart (global::Java.Lang.StringBuffer buffer)
		{
			if (id_appendContentStart_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_appendContentStart_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "appendContentStart", "(Ljava/lang/StringBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (buffer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendContentStart_Ljava_lang_StringBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendContentStart", "(Ljava/lang/StringBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_appendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_appendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_appendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_);
			return cb_appendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_AppendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AppendCyclicObject (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_appendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendCyclicObject' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("appendCyclicObject", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V", "GetAppendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe void AppendCyclicObject (global::Java.Lang.StringBuffer buffer, string fieldName, global::Java.Lang.Object value)
		{
			if (id_appendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_appendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendCyclicObject", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendCyclicObject_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendCyclicObject", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_ZHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Z == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Z);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Z;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, bool value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendDetail (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Z)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_ZHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, bool value)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Z == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Z)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (bool[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (bool));
			__this.AppendDetail (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean[]']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Z)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, bool[] array)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Z)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_B;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_BHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_B == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLB_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_B);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_B;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_B (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, sbyte value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendDetail (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;B)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_BHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, sbyte value)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_B == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_B = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;B)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_B, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;B)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (byte[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.AppendDetail (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[B)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, byte[] array)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[B)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[B)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_C;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_CHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_C == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLC_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_C);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_C;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_C (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, char value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendDetail (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='char']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;C)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_CHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, char value)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_C == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_C = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;C)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_C, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;C)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (char[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (char));
			__this.AppendDetail (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='char[]']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[C)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, char[] array)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[C)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[C)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_DHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_D == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLD_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_D);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_D;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, double value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendDetail (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;D)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_DHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, double value)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_D == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;D)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (double[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.AppendDetail (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double[]']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[D)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, double[] array)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[D)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_FHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_F == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLF_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_F);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_F;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, float value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendDetail (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;F)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_FHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, float value)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_F == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;F)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;F)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (float[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.AppendDetail (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float[]']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[F)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, float[] array)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[F)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[F)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_IHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_I == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_I);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_I;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendDetail (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;I)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_IHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, int value)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_I == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;I)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayIHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (int[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.AppendDetail (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int[]']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[I)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayIHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, int[] array)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[I)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AppendDetail (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, global::Java.Lang.Object value)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.AppendDetail (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Ljava/lang/Object;)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, global::Java.Lang.Object[] array)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_Handler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_ == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_coll)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var coll = global::Android.Runtime.JavaCollection<object>.FromJniHandle (native_coll, JniHandleOwnership.DoNotTransfer);
			__this.AppendDetail (buffer, fieldName, coll);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Collection&lt;?&gt;']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/util/Collection;)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_Handler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, global::System.Collections.Generic.ICollection<object> coll)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_ == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/util/Collection;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_coll = global::Android.Runtime.JavaCollection<object>.ToLocalJniHandle (coll);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_coll);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Collection_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/util/Collection;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				JNIEnv.DeleteLocalRef (native_coll);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_map)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var map = global::Android.Runtime.JavaDictionary<object, object>.FromJniHandle (native_map, JniHandleOwnership.DoNotTransfer);
			__this.AppendDetail (buffer, fieldName, map);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;?, ?&gt;']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/util/Map;)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_Handler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, global::System.Collections.Generic.IDictionary<object, object> map)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_map = global::Android.Runtime.JavaDictionary<object, object>.ToLocalJniHandle (map);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_map);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_JHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_J == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJ_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_J);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_J;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, long value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendDetail (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;J)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_JHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, long value)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_J == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;J)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (long[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.AppendDetail (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long[]']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[J)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, long[] array)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[J)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_SHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_S == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_S = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLS_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_S);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_S;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_S (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, short value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendDetail (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;S)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_SHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, short value)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_S == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_S = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;S)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_S, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;S)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS;
#pragma warning disable 0169
		static Delegate GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arraySHandler ()
		{
			if (cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS == null)
				cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS);
			return cb_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS;
		}

		static void n_AppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (short[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (short));
			__this.AppendDetail (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short[]']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[S)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arraySHandler")]
		protected virtual unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, short[] array)
		{
			if (id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS == IntPtr.Zero)
				id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS = JNIEnv.GetMethodID (class_ref, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[S)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[S)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_Handler ()
		{
			if (cb_appendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_ == null)
				cb_appendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AppendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_);
			return cb_appendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_;
		}

		static void n_AppendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native__object)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			__this.AppendEnd (buffer, @object);
		}
#pragma warning restore 0169

		static IntPtr id_appendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendEnd' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.Object']]"
		[Register ("appendEnd", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V", "GetAppendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_Handler")]
		public virtual unsafe void AppendEnd (global::Java.Lang.StringBuffer buffer, global::Java.Lang.Object @object)
		{
			if (id_appendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_ == IntPtr.Zero)
				id_appendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendEnd", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (@object);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendEnd_Ljava_lang_StringBuffer_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendEnd", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_appendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_Handler ()
		{
			if (cb_appendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_ == null)
				cb_appendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AppendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_);
			return cb_appendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_;
		}

		static void n_AppendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendFieldEnd (buffer, fieldName);
		}
#pragma warning restore 0169

		static IntPtr id_appendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendFieldEnd' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendFieldEnd", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V", "GetAppendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_Handler")]
		protected virtual unsafe void AppendFieldEnd (global::Java.Lang.StringBuffer buffer, string fieldName)
		{
			if (id_appendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_ == IntPtr.Zero)
				id_appendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendFieldEnd", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendFieldEnd_Ljava_lang_StringBuffer_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendFieldEnd", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendFieldSeparator_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		static Delegate GetAppendFieldSeparator_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_appendFieldSeparator_Ljava_lang_StringBuffer_ == null)
				cb_appendFieldSeparator_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AppendFieldSeparator_Ljava_lang_StringBuffer_);
			return cb_appendFieldSeparator_Ljava_lang_StringBuffer_;
		}

		static void n_AppendFieldSeparator_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.AppendFieldSeparator (buffer);
		}
#pragma warning restore 0169

		static IntPtr id_appendFieldSeparator_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendFieldSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuffer']]"
		[Register ("appendFieldSeparator", "(Ljava/lang/StringBuffer;)V", "GetAppendFieldSeparator_Ljava_lang_StringBuffer_Handler")]
		protected virtual unsafe void AppendFieldSeparator (global::Java.Lang.StringBuffer buffer)
		{
			if (id_appendFieldSeparator_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_appendFieldSeparator_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "appendFieldSeparator", "(Ljava/lang/StringBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (buffer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendFieldSeparator_Ljava_lang_StringBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendFieldSeparator", "(Ljava/lang/StringBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_appendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_Handler ()
		{
			if (cb_appendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_ == null)
				cb_appendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AppendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_);
			return cb_appendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_;
		}

		static void n_AppendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendFieldStart (buffer, fieldName);
		}
#pragma warning restore 0169

		static IntPtr id_appendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendFieldStart' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendFieldStart", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V", "GetAppendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_Handler")]
		protected virtual unsafe void AppendFieldStart (global::Java.Lang.StringBuffer buffer, string fieldName)
		{
			if (id_appendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_ == IntPtr.Zero)
				id_appendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendFieldStart", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendFieldStart_Ljava_lang_StringBuffer_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendFieldStart", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_Handler ()
		{
			if (cb_appendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_ == null)
				cb_appendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AppendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_);
			return cb_appendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_;
		}

		static void n_AppendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native__object)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			__this.AppendIdentityHashCode (buffer, @object);
		}
#pragma warning restore 0169

		static IntPtr id_appendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendIdentityHashCode' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.Object']]"
		[Register ("appendIdentityHashCode", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V", "GetAppendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_Handler")]
		protected virtual unsafe void AppendIdentityHashCode (global::Java.Lang.StringBuffer buffer, global::Java.Lang.Object @object)
		{
			if (id_appendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_ == IntPtr.Zero)
				id_appendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendIdentityHashCode", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (@object);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendIdentityHashCode_Ljava_lang_StringBuffer_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendIdentityHashCode", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_appendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetAppendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ZHandler ()
		{
			if (cb_appendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Z == null)
				cb_appendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_AppendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Z);
			return cb_appendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Z;
		}

		static void n_AppendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_value, bool detail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AppendInternal (buffer, fieldName, value, detail);
		}
#pragma warning restore 0169

		static IntPtr id_appendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendInternal' and count(parameter)=4 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='boolean']]"
		[Register ("appendInternal", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;Z)V", "GetAppendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ZHandler")]
		protected virtual unsafe void AppendInternal (global::Java.Lang.StringBuffer buffer, string fieldName, global::Java.Lang.Object value, bool detail)
		{
			if (id_appendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Z == IntPtr.Zero)
				id_appendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "appendInternal", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;Z)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);
				__args [3] = new JValue (detail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendInternal_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendInternal", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_Handler ()
		{
			if (cb_appendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_ == null)
				cb_appendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AppendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_);
			return cb_appendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_;
		}

		static void n_AppendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendNullText (buffer, fieldName);
		}
#pragma warning restore 0169

		static IntPtr id_appendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendNullText' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendNullText", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V", "GetAppendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_Handler")]
		protected virtual unsafe void AppendNullText (global::Java.Lang.StringBuffer buffer, string fieldName)
		{
			if (id_appendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_ == IntPtr.Zero)
				id_appendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendNullText", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendNullText_Ljava_lang_StringBuffer_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendNullText", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_Handler ()
		{
			if (cb_appendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_ == null)
				cb_appendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AppendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_);
			return cb_appendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_;
		}

		static void n_AppendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native__object)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			__this.AppendStart (buffer, @object);
		}
#pragma warning restore 0169

		static IntPtr id_appendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendStart' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.Object']]"
		[Register ("appendStart", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V", "GetAppendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_Handler")]
		public virtual unsafe void AppendStart (global::Java.Lang.StringBuffer buffer, global::Java.Lang.Object @object)
		{
			if (id_appendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_ == IntPtr.Zero)
				id_appendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendStart", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (@object);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendStart_Ljava_lang_StringBuffer_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendStart", "(Ljava/lang/StringBuffer;Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ;
#pragma warning disable 0169
		static Delegate GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZHandler ()
		{
			if (cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ == null)
				cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ);
			return cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ;
		}

		static void n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (bool[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (bool));
			__this.AppendSummary (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSummary' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean[]']]"
		[Register ("appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Z)V", "GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZHandler")]
		protected virtual unsafe void AppendSummary (global::Java.Lang.StringBuffer buffer, string fieldName, bool[] array)
		{
			if (id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ == IntPtr.Zero)
				id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ = JNIEnv.GetMethodID (class_ref, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Z)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB == null)
				cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB);
			return cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB;
		}

		static void n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (byte[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.AppendSummary (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSummary' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[B)V", "GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayBHandler")]
		protected virtual unsafe void AppendSummary (global::Java.Lang.StringBuffer buffer, string fieldName, byte[] array)
		{
			if (id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[B)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[B)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC;
#pragma warning disable 0169
		static Delegate GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCHandler ()
		{
			if (cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC == null)
				cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC);
			return cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC;
		}

		static void n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (char[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (char));
			__this.AppendSummary (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSummary' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='char[]']]"
		[Register ("appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[C)V", "GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayCHandler")]
		protected virtual unsafe void AppendSummary (global::Java.Lang.StringBuffer buffer, string fieldName, char[] array)
		{
			if (id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC == IntPtr.Zero)
				id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC = JNIEnv.GetMethodID (class_ref, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[C)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayC, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[C)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD;
#pragma warning disable 0169
		static Delegate GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDHandler ()
		{
			if (cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD == null)
				cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD);
			return cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD;
		}

		static void n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (double[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.AppendSummary (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSummary' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double[]']]"
		[Register ("appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[D)V", "GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayDHandler")]
		protected virtual unsafe void AppendSummary (global::Java.Lang.StringBuffer buffer, string fieldName, double[] array)
		{
			if (id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD == IntPtr.Zero)
				id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD = JNIEnv.GetMethodID (class_ref, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[D)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF;
#pragma warning disable 0169
		static Delegate GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFHandler ()
		{
			if (cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF == null)
				cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF);
			return cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF;
		}

		static void n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (float[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.AppendSummary (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSummary' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float[]']]"
		[Register ("appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[F)V", "GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayFHandler")]
		protected virtual unsafe void AppendSummary (global::Java.Lang.StringBuffer buffer, string fieldName, float[] array)
		{
			if (id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF == IntPtr.Zero)
				id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF = JNIEnv.GetMethodID (class_ref, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[F)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[F)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayIHandler ()
		{
			if (cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI == null)
				cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI);
			return cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI;
		}

		static void n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (int[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.AppendSummary (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSummary' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int[]']]"
		[Register ("appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[I)V", "GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayIHandler")]
		protected virtual unsafe void AppendSummary (global::Java.Lang.StringBuffer buffer, string fieldName, int[] array)
		{
			if (id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI == IntPtr.Zero)
				id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[I)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_);
			return cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AppendSummary (buffer, fieldName, value);
		}
#pragma warning restore 0169

		static IntPtr id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSummary' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V", "GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe void AppendSummary (global::Java.Lang.StringBuffer buffer, string fieldName, global::Java.Lang.Object value)
		{
			if (id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.AppendSummary (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSummary' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Ljava/lang/Object;)V", "GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		protected virtual unsafe void AppendSummary (global::Java.Lang.StringBuffer buffer, string fieldName, global::Java.Lang.Object[] array)
		{
			if (id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ;
#pragma warning disable 0169
		static Delegate GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJHandler ()
		{
			if (cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ == null)
				cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ);
			return cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ;
		}

		static void n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (long[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.AppendSummary (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSummary' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long[]']]"
		[Register ("appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[J)V", "GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJHandler")]
		protected virtual unsafe void AppendSummary (global::Java.Lang.StringBuffer buffer, string fieldName, long[] array)
		{
			if (id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ == IntPtr.Zero)
				id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ = JNIEnv.GetMethodID (class_ref, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[J)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS;
#pragma warning disable 0169
		static Delegate GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arraySHandler ()
		{
			if (cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS == null)
				cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS);
			return cb_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS;
		}

		static void n_AppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (short[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (short));
			__this.AppendSummary (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSummary' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short[]']]"
		[Register ("appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[S)V", "GetAppendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arraySHandler")]
		protected virtual unsafe void AppendSummary (global::Java.Lang.StringBuffer buffer, string fieldName, short[] array)
		{
			if (id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS == IntPtr.Zero)
				id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS = JNIEnv.GetMethodID (class_ref, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[S)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (native_array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSummary_Ljava_lang_StringBuffer_Ljava_lang_String_arrayS, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSummary", "(Ljava/lang/StringBuffer;Ljava/lang/String;[S)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAppendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_IHandler ()
		{
			if (cb_appendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_I == null)
				cb_appendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_AppendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_I);
			return cb_appendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_I;
		}

		static void n_AppendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, int size)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			__this.AppendSummarySize (buffer, fieldName, size);
		}
#pragma warning restore 0169

		static IntPtr id_appendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSummarySize' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("appendSummarySize", "(Ljava/lang/StringBuffer;Ljava/lang/String;I)V", "GetAppendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_IHandler")]
		protected virtual unsafe void AppendSummarySize (global::Java.Lang.StringBuffer buffer, string fieldName, int size)
		{
			if (id_appendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_I == IntPtr.Zero)
				id_appendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "appendSummarySize", "(Ljava/lang/StringBuffer;Ljava/lang/String;I)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (size);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSummarySize_Ljava_lang_StringBuffer_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSummarySize", "(Ljava/lang/StringBuffer;Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_appendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_Handler ()
		{
			if (cb_appendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_ == null)
				cb_appendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AppendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_);
			return cb_appendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_;
		}

		static void n_AppendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_superToString)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var superToString = JNIEnv.GetString (native_superToString, JniHandleOwnership.DoNotTransfer);
			__this.AppendSuper (buffer, superToString);
		}
#pragma warning restore 0169

		static IntPtr id_appendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendSuper' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendSuper", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V", "GetAppendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_Handler")]
		public virtual unsafe void AppendSuper (global::Java.Lang.StringBuffer buffer, string superToString)
		{
			if (id_appendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_ == IntPtr.Zero)
				id_appendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendSuper", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V");
			IntPtr native_superToString = JNIEnv.NewString (superToString);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_superToString);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendSuper_Ljava_lang_StringBuffer_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSuper", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_superToString);
			}
		}

		static Delegate cb_appendToString_Ljava_lang_StringBuffer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendToString_Ljava_lang_StringBuffer_Ljava_lang_String_Handler ()
		{
			if (cb_appendToString_Ljava_lang_StringBuffer_Ljava_lang_String_ == null)
				cb_appendToString_Ljava_lang_StringBuffer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AppendToString_Ljava_lang_StringBuffer_Ljava_lang_String_);
			return cb_appendToString_Ljava_lang_StringBuffer_Ljava_lang_String_;
		}

		static void n_AppendToString_Ljava_lang_StringBuffer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_toString)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var toString = JNIEnv.GetString (native_toString, JniHandleOwnership.DoNotTransfer);
			__this.AppendToString (buffer, toString);
		}
#pragma warning restore 0169

		static IntPtr id_appendToString_Ljava_lang_StringBuffer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='appendToString' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendToString", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V", "GetAppendToString_Ljava_lang_StringBuffer_Ljava_lang_String_Handler")]
		public virtual unsafe void AppendToString (global::Java.Lang.StringBuffer buffer, string toString)
		{
			if (id_appendToString_Ljava_lang_StringBuffer_Ljava_lang_String_ == IntPtr.Zero)
				id_appendToString_Ljava_lang_StringBuffer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendToString", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V");
			IntPtr native_toString = JNIEnv.NewString (toString);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_toString);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendToString_Ljava_lang_StringBuffer_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendToString", "(Ljava/lang/StringBuffer;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_toString);
			}
		}

		static Delegate cb_getShortClassName_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetShortClassName_Ljava_lang_Class_Handler ()
		{
			if (cb_getShortClassName_Ljava_lang_Class_ == null)
				cb_getShortClassName_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetShortClassName_Ljava_lang_Class_);
			return cb_getShortClassName_Ljava_lang_Class_;
		}

		static IntPtr n_GetShortClassName_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cls)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cls = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_cls, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetShortClassName (cls));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getShortClassName_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='getShortClassName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getShortClassName", "(Ljava/lang/Class;)Ljava/lang/String;", "GetGetShortClassName_Ljava_lang_Class_Handler")]
		protected virtual unsafe string GetShortClassName (global::Java.Lang.Class cls)
		{
			if (id_getShortClassName_Ljava_lang_Class_ == IntPtr.Zero)
				id_getShortClassName_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getShortClassName", "(Ljava/lang/Class;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cls);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShortClassName_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShortClassName", "(Ljava/lang/Class;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isFullDetail_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetIsFullDetail_Ljava_lang_Boolean_Handler ()
		{
			if (cb_isFullDetail_Ljava_lang_Boolean_ == null)
				cb_isFullDetail_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsFullDetail_Ljava_lang_Boolean_);
			return cb_isFullDetail_Ljava_lang_Boolean_;
		}

		static bool n_IsFullDetail_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fullDetailRequest)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fullDetailRequest = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_fullDetailRequest, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsFullDetail (fullDetailRequest);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isFullDetail_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='isFullDetail' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("isFullDetail", "(Ljava/lang/Boolean;)Z", "GetIsFullDetail_Ljava_lang_Boolean_Handler")]
		protected virtual unsafe bool IsFullDetail (global::Java.Lang.Boolean fullDetailRequest)
		{
			if (id_isFullDetail_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_isFullDetail_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "isFullDetail", "(Ljava/lang/Boolean;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (fullDetailRequest);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFullDetail_Ljava_lang_Boolean_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFullDetail", "(Ljava/lang/Boolean;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_reflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetReflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_reflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_reflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_ReflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_);
			return cb_reflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_ReflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_fieldName, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_array, JniHandleOwnership.DoNotTransfer);
			__this.ReflectionAppendArrayDetail (buffer, fieldName, array);
		}
#pragma warning restore 0169

		static IntPtr id_reflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='reflectionAppendArrayDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("reflectionAppendArrayDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V", "GetReflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe void ReflectionAppendArrayDetail (global::Java.Lang.StringBuffer buffer, string fieldName, global::Java.Lang.Object array)
		{
			if (id_reflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_reflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "reflectionAppendArrayDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (native_fieldName);
				__args [2] = new JValue (array);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reflectionAppendArrayDetail_Ljava_lang_StringBuffer_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reflectionAppendArrayDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		static Delegate cb_removeLastFieldSeparator_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		static Delegate GetRemoveLastFieldSeparator_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_removeLastFieldSeparator_Ljava_lang_StringBuffer_ == null)
				cb_removeLastFieldSeparator_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveLastFieldSeparator_Ljava_lang_StringBuffer_);
			return cb_removeLastFieldSeparator_Ljava_lang_StringBuffer_;
		}

		static void n_RemoveLastFieldSeparator_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLastFieldSeparator (buffer);
		}
#pragma warning restore 0169

		static IntPtr id_removeLastFieldSeparator_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ToStringStyle']/method[@name='removeLastFieldSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuffer']]"
		[Register ("removeLastFieldSeparator", "(Ljava/lang/StringBuffer;)V", "GetRemoveLastFieldSeparator_Ljava_lang_StringBuffer_Handler")]
		protected virtual unsafe void RemoveLastFieldSeparator (global::Java.Lang.StringBuffer buffer)
		{
			if (id_removeLastFieldSeparator_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_removeLastFieldSeparator_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "removeLastFieldSeparator", "(Ljava/lang/StringBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (buffer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeLastFieldSeparator_Ljava_lang_StringBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLastFieldSeparator", "(Ljava/lang/StringBuffer;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/ToStringStyle", DoNotGenerateAcw=true)]
	internal partial class ToStringStyleInvoker : ToStringStyle {

		public ToStringStyleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ToStringStyleInvoker); }
		}

	}

}
