using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='DefaultExceptionContext']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/exception/DefaultExceptionContext", DoNotGenerateAcw=true)]
	public partial class DefaultExceptionContext : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Org.Apache.Commons.Lang3.Exception.IExceptionContext {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/exception/DefaultExceptionContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultExceptionContext); }
		}

		protected DefaultExceptionContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='DefaultExceptionContext']/constructor[@name='DefaultExceptionContext' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultExceptionContext ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DefaultExceptionContext)) {
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

		static Delegate cb_getContextEntries;
#pragma warning disable 0169
		static Delegate GetGetContextEntriesHandler ()
		{
			if (cb_getContextEntries == null)
				cb_getContextEntries = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContextEntries);
			return cb_getContextEntries;
		}

		static IntPtr n_GetContextEntries (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Apache.Commons.Lang3.Tuple.Pair>.ToLocalJniHandle (__this.ContextEntries);
		}
#pragma warning restore 0169

		static IntPtr id_getContextEntries;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Apache.Commons.Lang3.Tuple.Pair> ContextEntries {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='DefaultExceptionContext']/method[@name='getContextEntries' and count(parameter)=0]"
			[Register ("getContextEntries", "()Ljava/util/List;", "GetGetContextEntriesHandler")]
			get {
				if (id_getContextEntries == IntPtr.Zero)
					id_getContextEntries = JNIEnv.GetMethodID (class_ref, "getContextEntries", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Apache.Commons.Lang3.Tuple.Pair>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContextEntries), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Apache.Commons.Lang3.Tuple.Pair>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContextEntries", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContextLabels;
#pragma warning disable 0169
		static Delegate GetGetContextLabelsHandler ()
		{
			if (cb_getContextLabels == null)
				cb_getContextLabels = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContextLabels);
			return cb_getContextLabels;
		}

		static IntPtr n_GetContextLabels (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.ContextLabels);
		}
#pragma warning restore 0169

		static IntPtr id_getContextLabels;
		public virtual unsafe global::System.Collections.Generic.ICollection<string> ContextLabels {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='DefaultExceptionContext']/method[@name='getContextLabels' and count(parameter)=0]"
			[Register ("getContextLabels", "()Ljava/util/Set;", "GetGetContextLabelsHandler")]
			get {
				if (id_getContextLabels == IntPtr.Zero)
					id_getContextLabels = JNIEnv.GetMethodID (class_ref, "getContextLabels", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContextLabels), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContextLabels", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addContextValue_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddContextValue_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_addContextValue_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_addContextValue_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddContextValue_Ljava_lang_String_Ljava_lang_Object_);
			return cb_addContextValue_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_AddContextValue_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddContextValue (label, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addContextValue_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='DefaultExceptionContext']/method[@name='addContextValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("addContextValue", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/exception/DefaultExceptionContext;", "GetAddContextValue_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext AddContextValue (string label, global::Java.Lang.Object value)
		{
			if (id_addContextValue_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_addContextValue_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addContextValue", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/exception/DefaultExceptionContext;");
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_label);
				__args [1] = new JValue (value);

				global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addContextValue_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addContextValue", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/exception/DefaultExceptionContext;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_getContextValues_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetContextValues_Ljava_lang_String_Handler ()
		{
			if (cb_getContextValues_Ljava_lang_String_ == null)
				cb_getContextValues_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetContextValues_Ljava_lang_String_);
			return cb_getContextValues_Ljava_lang_String_;
		}

		static IntPtr n_GetContextValues_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (__this.GetContextValues (label));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getContextValues_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='DefaultExceptionContext']/method[@name='getContextValues' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getContextValues", "(Ljava/lang/String;)Ljava/util/List;", "GetGetContextValues_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Object> GetContextValues (string label)
		{
			if (id_getContextValues_Ljava_lang_String_ == IntPtr.Zero)
				id_getContextValues_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getContextValues", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_label);

				global::System.Collections.Generic.IList<global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContextValues_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContextValues", "(Ljava/lang/String;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_getFirstContextValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFirstContextValue_Ljava_lang_String_Handler ()
		{
			if (cb_getFirstContextValue_Ljava_lang_String_ == null)
				cb_getFirstContextValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetFirstContextValue_Ljava_lang_String_);
			return cb_getFirstContextValue_Ljava_lang_String_;
		}

		static IntPtr n_GetFirstContextValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFirstContextValue (label));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstContextValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='DefaultExceptionContext']/method[@name='getFirstContextValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFirstContextValue", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetFirstContextValue_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetFirstContextValue (string label)
		{
			if (id_getFirstContextValue_Ljava_lang_String_ == IntPtr.Zero)
				id_getFirstContextValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFirstContextValue", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_label);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstContextValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstContextValue", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_getFormattedExceptionMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFormattedExceptionMessage_Ljava_lang_String_Handler ()
		{
			if (cb_getFormattedExceptionMessage_Ljava_lang_String_ == null)
				cb_getFormattedExceptionMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetFormattedExceptionMessage_Ljava_lang_String_);
			return cb_getFormattedExceptionMessage_Ljava_lang_String_;
		}

		static IntPtr n_GetFormattedExceptionMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_baseMessage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var baseMessage = JNIEnv.GetString (native_baseMessage, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFormattedExceptionMessage (baseMessage));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFormattedExceptionMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='DefaultExceptionContext']/method[@name='getFormattedExceptionMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFormattedExceptionMessage", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetFormattedExceptionMessage_Ljava_lang_String_Handler")]
		public virtual unsafe string GetFormattedExceptionMessage (string baseMessage)
		{
			if (id_getFormattedExceptionMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_getFormattedExceptionMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFormattedExceptionMessage", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_baseMessage = JNIEnv.NewString (baseMessage);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_baseMessage);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormattedExceptionMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormattedExceptionMessage", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_baseMessage);
			}
		}

		static Delegate cb_setContextValue_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetContextValue_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setContextValue_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setContextValue_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SetContextValue_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setContextValue_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_SetContextValue_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContextValue (label, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setContextValue_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='DefaultExceptionContext']/method[@name='setContextValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setContextValue", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/exception/DefaultExceptionContext;", "GetSetContextValue_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext SetContextValue (string label, global::Java.Lang.Object value)
		{
			if (id_setContextValue_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setContextValue_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setContextValue", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/exception/DefaultExceptionContext;");
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_label);
				__args [1] = new JValue (value);

				global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContextValue_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.DefaultExceptionContext> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContextValue", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/exception/DefaultExceptionContext;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

	}
}
