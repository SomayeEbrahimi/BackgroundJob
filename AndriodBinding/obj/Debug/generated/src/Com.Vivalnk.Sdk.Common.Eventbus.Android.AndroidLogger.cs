using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.android']/class[@name='AndroidLogger']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/android/AndroidLogger", DoNotGenerateAcw=true)]
	public partial class AndroidLogger : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/android/AndroidLogger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidLogger); }
		}

		protected AndroidLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.android']/class[@name='AndroidLogger']/constructor[@name='AndroidLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AndroidLogger (string tag)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_tag);
				if (((object) this).GetType () != typeof (AndroidLogger)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static IntPtr id_isAndroidLogAvailable;
		public static unsafe bool IsAndroidLogAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.android']/class[@name='AndroidLogger']/method[@name='isAndroidLogAvailable' and count(parameter)=0]"
			[Register ("isAndroidLogAvailable", "()Z", "")]
			get {
				if (id_isAndroidLogAvailable == IntPtr.Zero)
					id_isAndroidLogAvailable = JNIEnv.GetStaticMethodID (class_ref, "isAndroidLogAvailable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAndroidLogAvailable);
				} finally {
				}
			}
		}

		static Delegate cb_log_Ljava_util_logging_Level_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_util_logging_Level_Ljava_lang_String_Handler ()
		{
			if (cb_log_Ljava_util_logging_Level_Ljava_lang_String_ == null)
				cb_log_Ljava_util_logging_Level_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Log_Ljava_util_logging_Level_Ljava_lang_String_);
			return cb_log_Ljava_util_logging_Level_Ljava_lang_String_;
		}

		static void n_Log_Ljava_util_logging_Level_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_level, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Android.AndroidLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var level = global::Java.Lang.Object.GetObject<global::Java.Util.Logging.Level> (native_level, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Log (level, msg);
		}
#pragma warning restore 0169

		static IntPtr id_log_Ljava_util_logging_Level_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.android']/class[@name='AndroidLogger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String']]"
		[Register ("log", "(Ljava/util/logging/Level;Ljava/lang/String;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Handler")]
		public virtual unsafe void Log (global::Java.Util.Logging.Level level, string msg)
		{
			if (id_log_Ljava_util_logging_Level_Ljava_lang_String_ == IntPtr.Zero)
				id_log_Ljava_util_logging_Level_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "log", "(Ljava/util/logging/Level;Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (level);
				__args [1] = new JValue (native_msg);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_util_logging_Level_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_level, IntPtr native_msg, IntPtr native_th)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Android.AndroidLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var level = global::Java.Lang.Object.GetObject<global::Java.Util.Logging.Level> (native_level, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var th = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_th, JniHandleOwnership.DoNotTransfer);
			__this.Log (level, msg, th);
		}
#pragma warning restore 0169

		static IntPtr id_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.android']/class[@name='AndroidLogger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Log (global::Java.Util.Logging.Level level, string msg, global::Java.Lang.Throwable th)
		{
			if (id_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (level);
				__args [1] = new JValue (native_msg);
				__args [2] = new JValue (th);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
