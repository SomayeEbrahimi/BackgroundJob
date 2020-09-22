using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='MultilineRecursiveToStringStyle']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/MultilineRecursiveToStringStyle", DoNotGenerateAcw=true)]
	public partial class MultilineRecursiveToStringStyle : global::Org.Apache.Commons.Lang3.Builder.RecursiveToStringStyle {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/builder/MultilineRecursiveToStringStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultilineRecursiveToStringStyle); }
		}

		protected MultilineRecursiveToStringStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='MultilineRecursiveToStringStyle']/constructor[@name='MultilineRecursiveToStringStyle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MultilineRecursiveToStringStyle ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MultilineRecursiveToStringStyle)) {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.MultilineRecursiveToStringStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var fieldName = JNIEnv.GetString (native_fieldName, JniHandleOwnership.DoNotTransfer);
			var array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.AppendDetail (buffer, fieldName, array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		static IntPtr id_appendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='MultilineRecursiveToStringStyle']/method[@name='appendDetail' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("appendDetail", "(Ljava/lang/StringBuffer;Ljava/lang/String;[Ljava/lang/Object;)V", "GetAppendDetail_Ljava_lang_StringBuffer_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		protected override unsafe void AppendDetail (global::Java.Lang.StringBuffer buffer, string fieldName, global::Java.Lang.Object[] array)
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

	}
}
