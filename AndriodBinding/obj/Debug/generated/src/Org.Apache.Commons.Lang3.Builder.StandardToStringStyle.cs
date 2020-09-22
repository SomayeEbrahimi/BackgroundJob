using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/StandardToStringStyle", DoNotGenerateAcw=true)]
	public partial class StandardToStringStyle : global::Org.Apache.Commons.Lang3.Builder.ToStringStyle {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/builder/StandardToStringStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StandardToStringStyle); }
		}

		protected StandardToStringStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/constructor[@name='StandardToStringStyle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StandardToStringStyle ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StandardToStringStyle)) {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ArrayContentDetail = arrayContentDetail;
		}
#pragma warning restore 0169

		static IntPtr id_isArrayContentDetail;
		static IntPtr id_setArrayContentDetail_Z;
		protected override unsafe bool ArrayContentDetail {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='isArrayContentDetail' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setArrayContentDetail' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var arrayEnd = JNIEnv.GetString (native_arrayEnd, JniHandleOwnership.DoNotTransfer);
			__this.ArrayEnd = arrayEnd;
		}
#pragma warning restore 0169

		static IntPtr id_getArrayEnd;
		static IntPtr id_setArrayEnd_Ljava_lang_String_;
		protected override unsafe string ArrayEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getArrayEnd' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setArrayEnd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var arraySeparator = JNIEnv.GetString (native_arraySeparator, JniHandleOwnership.DoNotTransfer);
			__this.ArraySeparator = arraySeparator;
		}
#pragma warning restore 0169

		static IntPtr id_getArraySeparator;
		static IntPtr id_setArraySeparator_Ljava_lang_String_;
		protected override unsafe string ArraySeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getArraySeparator' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setArraySeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var arrayStart = JNIEnv.GetString (native_arrayStart, JniHandleOwnership.DoNotTransfer);
			__this.ArrayStart = arrayStart;
		}
#pragma warning restore 0169

		static IntPtr id_getArrayStart;
		static IntPtr id_setArrayStart_Ljava_lang_String_;
		protected override unsafe string ArrayStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getArrayStart' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setArrayStart' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var contentEnd = JNIEnv.GetString (native_contentEnd, JniHandleOwnership.DoNotTransfer);
			__this.ContentEnd = contentEnd;
		}
#pragma warning restore 0169

		static IntPtr id_getContentEnd;
		static IntPtr id_setContentEnd_Ljava_lang_String_;
		protected override unsafe string ContentEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getContentEnd' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setContentEnd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var contentStart = JNIEnv.GetString (native_contentStart, JniHandleOwnership.DoNotTransfer);
			__this.ContentStart = contentStart;
		}
#pragma warning restore 0169

		static IntPtr id_getContentStart;
		static IntPtr id_setContentStart_Ljava_lang_String_;
		protected override unsafe string ContentStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getContentStart' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setContentStart' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DefaultFullDetail = defaultFullDetail;
		}
#pragma warning restore 0169

		static IntPtr id_isDefaultFullDetail;
		static IntPtr id_setDefaultFullDetail_Z;
		protected override unsafe bool DefaultFullDetail {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='isDefaultFullDetail' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setDefaultFullDetail' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldNameValueSeparator = JNIEnv.GetString (native_fieldNameValueSeparator, JniHandleOwnership.DoNotTransfer);
			__this.FieldNameValueSeparator = fieldNameValueSeparator;
		}
#pragma warning restore 0169

		static IntPtr id_getFieldNameValueSeparator;
		static IntPtr id_setFieldNameValueSeparator_Ljava_lang_String_;
		protected override unsafe string FieldNameValueSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getFieldNameValueSeparator' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setFieldNameValueSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldSeparator = JNIEnv.GetString (native_fieldSeparator, JniHandleOwnership.DoNotTransfer);
			__this.FieldSeparator = fieldSeparator;
		}
#pragma warning restore 0169

		static IntPtr id_getFieldSeparator;
		static IntPtr id_setFieldSeparator_Ljava_lang_String_;
		protected override unsafe string FieldSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getFieldSeparator' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setFieldSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FieldSeparatorAtEnd = fieldSeparatorAtEnd;
		}
#pragma warning restore 0169

		static IntPtr id_isFieldSeparatorAtEnd;
		static IntPtr id_setFieldSeparatorAtEnd_Z;
		protected override unsafe bool FieldSeparatorAtEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='isFieldSeparatorAtEnd' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setFieldSeparatorAtEnd' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FieldSeparatorAtStart = fieldSeparatorAtStart;
		}
#pragma warning restore 0169

		static IntPtr id_isFieldSeparatorAtStart;
		static IntPtr id_setFieldSeparatorAtStart_Z;
		protected override unsafe bool FieldSeparatorAtStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='isFieldSeparatorAtStart' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setFieldSeparatorAtStart' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nullText = JNIEnv.GetString (native_nullText, JniHandleOwnership.DoNotTransfer);
			__this.NullText = nullText;
		}
#pragma warning restore 0169

		static IntPtr id_getNullText;
		static IntPtr id_setNullText_Ljava_lang_String_;
		protected override unsafe string NullText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getNullText' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setNullText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sizeEndText = JNIEnv.GetString (native_sizeEndText, JniHandleOwnership.DoNotTransfer);
			__this.SizeEndText = sizeEndText;
		}
#pragma warning restore 0169

		static IntPtr id_getSizeEndText;
		static IntPtr id_setSizeEndText_Ljava_lang_String_;
		protected override unsafe string SizeEndText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getSizeEndText' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setSizeEndText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sizeStartText = JNIEnv.GetString (native_sizeStartText, JniHandleOwnership.DoNotTransfer);
			__this.SizeStartText = sizeStartText;
		}
#pragma warning restore 0169

		static IntPtr id_getSizeStartText;
		static IntPtr id_setSizeStartText_Ljava_lang_String_;
		protected override unsafe string SizeStartText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getSizeStartText' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setSizeStartText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var summaryObjectEndText = JNIEnv.GetString (native_summaryObjectEndText, JniHandleOwnership.DoNotTransfer);
			__this.SummaryObjectEndText = summaryObjectEndText;
		}
#pragma warning restore 0169

		static IntPtr id_getSummaryObjectEndText;
		static IntPtr id_setSummaryObjectEndText_Ljava_lang_String_;
		protected override unsafe string SummaryObjectEndText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getSummaryObjectEndText' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setSummaryObjectEndText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var summaryObjectStartText = JNIEnv.GetString (native_summaryObjectStartText, JniHandleOwnership.DoNotTransfer);
			__this.SummaryObjectStartText = summaryObjectStartText;
		}
#pragma warning restore 0169

		static IntPtr id_getSummaryObjectStartText;
		static IntPtr id_setSummaryObjectStartText_Ljava_lang_String_;
		protected override unsafe string SummaryObjectStartText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='getSummaryObjectStartText' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setSummaryObjectStartText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseClassName = useClassName;
		}
#pragma warning restore 0169

		static IntPtr id_isUseClassName;
		static IntPtr id_setUseClassName_Z;
		protected override unsafe bool UseClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='isUseClassName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setUseClassName' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseFieldNames = useFieldNames;
		}
#pragma warning restore 0169

		static IntPtr id_isUseFieldNames;
		static IntPtr id_setUseFieldNames_Z;
		protected override unsafe bool UseFieldNames {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='isUseFieldNames' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setUseFieldNames' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseIdentityHashCode = useIdentityHashCode;
		}
#pragma warning restore 0169

		static IntPtr id_isUseIdentityHashCode;
		static IntPtr id_setUseIdentityHashCode_Z;
		protected override unsafe bool UseIdentityHashCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='isUseIdentityHashCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setUseIdentityHashCode' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.StandardToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseShortClassName = useShortClassName;
		}
#pragma warning restore 0169

		static IntPtr id_isUseShortClassName;
		static IntPtr id_setUseShortClassName_Z;
		protected override unsafe bool UseShortClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='isUseShortClassName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='StandardToStringStyle']/method[@name='setUseShortClassName' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

	}
}
