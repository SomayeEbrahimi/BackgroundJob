using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='StringUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/StringUtils", DoNotGenerateAcw=true)]
	public partial class StringUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/StringUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringUtils); }
		}

		protected StringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='StringUtils']/constructor[@name='StringUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StringUtils)) {
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

		static IntPtr id_isBlank_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='StringUtils']/method[@name='isBlank' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isBlank", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsBlank (string str)
		{
			if (id_isBlank_Ljava_lang_String_ == IntPtr.Zero)
				id_isBlank_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isBlank", "(Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBlank_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_isEmpty_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='StringUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isEmpty", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsEmpty (global::Java.Lang.ICharSequence str)
		{
			if (id_isEmpty_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isEmpty_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		public static bool IsEmpty (string str)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			bool __result = IsEmpty (jls_str);
			var __rsval = __result;
			jls_str?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isNotBlank_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='StringUtils']/method[@name='isNotBlank' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isNotBlank", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsNotBlank (string cs)
		{
			if (id_isNotBlank_Ljava_lang_String_ == IntPtr.Zero)
				id_isNotBlank_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isNotBlank", "(Ljava/lang/String;)Z");
			IntPtr native_cs = JNIEnv.NewString (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNotBlank_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

	}
}
