using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Exception {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3.exception']/interface[@name='ExceptionContext']"
	[Register ("org/apache/commons/lang3/exception/ExceptionContext", "", "Org.Apache.Commons.Lang3.Exception.IExceptionContextInvoker")]
	public partial interface IExceptionContext : IJavaObject {

		global::System.Collections.Generic.IList<global::Org.Apache.Commons.Lang3.Tuple.Pair> ContextEntries {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/interface[@name='ExceptionContext']/method[@name='getContextEntries' and count(parameter)=0]"
			[Register ("getContextEntries", "()Ljava/util/List;", "GetGetContextEntriesHandler:Org.Apache.Commons.Lang3.Exception.IExceptionContextInvoker, AndriodBinding")] get;
		}

		global::System.Collections.Generic.ICollection<string> ContextLabels {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/interface[@name='ExceptionContext']/method[@name='getContextLabels' and count(parameter)=0]"
			[Register ("getContextLabels", "()Ljava/util/Set;", "GetGetContextLabelsHandler:Org.Apache.Commons.Lang3.Exception.IExceptionContextInvoker, AndriodBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/interface[@name='ExceptionContext']/method[@name='addContextValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("addContextValue", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/exception/ExceptionContext;", "GetAddContextValue_Ljava_lang_String_Ljava_lang_Object_Handler:Org.Apache.Commons.Lang3.Exception.IExceptionContextInvoker, AndriodBinding")]
		global::Org.Apache.Commons.Lang3.Exception.IExceptionContext AddContextValue (string p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/interface[@name='ExceptionContext']/method[@name='getContextValues' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getContextValues", "(Ljava/lang/String;)Ljava/util/List;", "GetGetContextValues_Ljava_lang_String_Handler:Org.Apache.Commons.Lang3.Exception.IExceptionContextInvoker, AndriodBinding")]
		global::System.Collections.Generic.IList<global::Java.Lang.Object> GetContextValues (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/interface[@name='ExceptionContext']/method[@name='getFirstContextValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFirstContextValue", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetFirstContextValue_Ljava_lang_String_Handler:Org.Apache.Commons.Lang3.Exception.IExceptionContextInvoker, AndriodBinding")]
		global::Java.Lang.Object GetFirstContextValue (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/interface[@name='ExceptionContext']/method[@name='getFormattedExceptionMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFormattedExceptionMessage", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetFormattedExceptionMessage_Ljava_lang_String_Handler:Org.Apache.Commons.Lang3.Exception.IExceptionContextInvoker, AndriodBinding")]
		string GetFormattedExceptionMessage (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/interface[@name='ExceptionContext']/method[@name='setContextValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setContextValue", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/exception/ExceptionContext;", "GetSetContextValue_Ljava_lang_String_Ljava_lang_Object_Handler:Org.Apache.Commons.Lang3.Exception.IExceptionContextInvoker, AndriodBinding")]
		global::Org.Apache.Commons.Lang3.Exception.IExceptionContext SetContextValue (string p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/exception/ExceptionContext", DoNotGenerateAcw=true)]
	internal partial class IExceptionContextInvoker : global::Java.Lang.Object, IExceptionContext {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/exception/ExceptionContext");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IExceptionContextInvoker); }
		}

		IntPtr class_ref;

		public static IExceptionContext GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExceptionContext> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.exception.ExceptionContext"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExceptionContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.IExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Apache.Commons.Lang3.Tuple.Pair>.ToLocalJniHandle (__this.ContextEntries);
		}
#pragma warning restore 0169

		IntPtr id_getContextEntries;
		public unsafe global::System.Collections.Generic.IList<global::Org.Apache.Commons.Lang3.Tuple.Pair> ContextEntries {
			get {
				if (id_getContextEntries == IntPtr.Zero)
					id_getContextEntries = JNIEnv.GetMethodID (class_ref, "getContextEntries", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Org.Apache.Commons.Lang3.Tuple.Pair>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContextEntries), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.IExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.ContextLabels);
		}
#pragma warning restore 0169

		IntPtr id_getContextLabels;
		public unsafe global::System.Collections.Generic.ICollection<string> ContextLabels {
			get {
				if (id_getContextLabels == IntPtr.Zero)
					id_getContextLabels = JNIEnv.GetMethodID (class_ref, "getContextLabels", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContextLabels), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_AddContextValue_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.IExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddContextValue (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addContextValue_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe global::Org.Apache.Commons.Lang3.Exception.IExceptionContext AddContextValue (string p0, global::Java.Lang.Object p1)
		{
			if (id_addContextValue_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_addContextValue_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addContextValue", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/exception/ExceptionContext;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.IExceptionContext> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addContextValue_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getContextValues_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetContextValues_Ljava_lang_String_Handler ()
		{
			if (cb_getContextValues_Ljava_lang_String_ == null)
				cb_getContextValues_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetContextValues_Ljava_lang_String_);
			return cb_getContextValues_Ljava_lang_String_;
		}

		static IntPtr n_GetContextValues_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.IExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (__this.GetContextValues (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getContextValues_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Object> GetContextValues (string p0)
		{
			if (id_getContextValues_Ljava_lang_String_ == IntPtr.Zero)
				id_getContextValues_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getContextValues", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContextValues_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getFirstContextValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFirstContextValue_Ljava_lang_String_Handler ()
		{
			if (cb_getFirstContextValue_Ljava_lang_String_ == null)
				cb_getFirstContextValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetFirstContextValue_Ljava_lang_String_);
			return cb_getFirstContextValue_Ljava_lang_String_;
		}

		static IntPtr n_GetFirstContextValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.IExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFirstContextValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFirstContextValue_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object GetFirstContextValue (string p0)
		{
			if (id_getFirstContextValue_Ljava_lang_String_ == IntPtr.Zero)
				id_getFirstContextValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFirstContextValue", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstContextValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getFormattedExceptionMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFormattedExceptionMessage_Ljava_lang_String_Handler ()
		{
			if (cb_getFormattedExceptionMessage_Ljava_lang_String_ == null)
				cb_getFormattedExceptionMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetFormattedExceptionMessage_Ljava_lang_String_);
			return cb_getFormattedExceptionMessage_Ljava_lang_String_;
		}

		static IntPtr n_GetFormattedExceptionMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.IExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFormattedExceptionMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFormattedExceptionMessage_Ljava_lang_String_;
		public unsafe string GetFormattedExceptionMessage (string p0)
		{
			if (id_getFormattedExceptionMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_getFormattedExceptionMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFormattedExceptionMessage", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormattedExceptionMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setContextValue_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetContextValue_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setContextValue_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setContextValue_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SetContextValue_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setContextValue_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_SetContextValue_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.IExceptionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContextValue (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setContextValue_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe global::Org.Apache.Commons.Lang3.Exception.IExceptionContext SetContextValue (string p0, global::Java.Lang.Object p1)
		{
			if (id_setContextValue_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setContextValue_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setContextValue", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/commons/lang3/exception/ExceptionContext;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Exception.IExceptionContext> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContextValue_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
