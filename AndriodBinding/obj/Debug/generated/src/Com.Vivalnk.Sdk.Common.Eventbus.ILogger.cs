using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.JavaLogger']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/Logger$JavaLogger", DoNotGenerateAcw=true)]
	public partial class LoggerJavaLogger : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger {


		static IntPtr logger_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.JavaLogger']/field[@name='logger']"
		[Register ("logger")]
		protected global::Java.Util.Logging.Logger Logger {
			get {
				if (logger_jfieldId == IntPtr.Zero)
					logger_jfieldId = JNIEnv.GetFieldID (class_ref, "logger", "Ljava/util/logging/Logger;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, logger_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Logging.Logger> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (logger_jfieldId == IntPtr.Zero)
					logger_jfieldId = JNIEnv.GetFieldID (class_ref, "logger", "Ljava/util/logging/Logger;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, logger_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/Logger$JavaLogger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoggerJavaLogger); }
		}

		protected LoggerJavaLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.JavaLogger']/constructor[@name='Logger.JavaLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe LoggerJavaLogger (string tag)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_tag);
				if (((object) this).GetType () != typeof (LoggerJavaLogger)) {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.LoggerJavaLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var level = global::Java.Lang.Object.GetObject<global::Java.Util.Logging.Level> (native_level, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Log (level, msg);
		}
#pragma warning restore 0169

		static IntPtr id_log_Ljava_util_logging_Level_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.JavaLogger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.LoggerJavaLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var level = global::Java.Lang.Object.GetObject<global::Java.Util.Logging.Level> (native_level, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var th = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_th, JniHandleOwnership.DoNotTransfer);
			__this.Log (level, msg, th);
		}
#pragma warning restore 0169

		static IntPtr id_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.JavaLogger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.SystemOutLogger']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/Logger$SystemOutLogger", DoNotGenerateAcw=true)]
	public partial class LoggerSystemOutLogger : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/Logger$SystemOutLogger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoggerSystemOutLogger); }
		}

		protected LoggerSystemOutLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.SystemOutLogger']/constructor[@name='Logger.SystemOutLogger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoggerSystemOutLogger ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LoggerSystemOutLogger)) {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.LoggerSystemOutLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var level = global::Java.Lang.Object.GetObject<global::Java.Util.Logging.Level> (native_level, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Log (level, msg);
		}
#pragma warning restore 0169

		static IntPtr id_log_Ljava_util_logging_Level_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.SystemOutLogger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.LoggerSystemOutLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var level = global::Java.Lang.Object.GetObject<global::Java.Util.Logging.Level> (native_level, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var th = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_th, JniHandleOwnership.DoNotTransfer);
			__this.Log (level, msg, th);
		}
#pragma warning restore 0169

		static IntPtr id_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.SystemOutLogger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='Logger']"
	[Register ("com/vivalnk/sdk/common/eventbus/Logger", "", "Com.Vivalnk.Sdk.Common.Eventbus.ILoggerInvoker")]
	public partial interface ILogger : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='Logger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String']]"
		[Register ("log", "(Ljava/util/logging/Level;Ljava/lang/String;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Handler:Com.Vivalnk.Sdk.Common.Eventbus.ILoggerInvoker, AndriodBinding")]
		void Log (global::Java.Util.Logging.Level p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='Logger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Vivalnk.Sdk.Common.Eventbus.ILoggerInvoker, AndriodBinding")]
		void Log (global::Java.Util.Logging.Level p0, string p1, global::Java.Lang.Throwable p2);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/Logger", DoNotGenerateAcw=true)]
	internal partial class ILoggerInvoker : global::Java.Lang.Object, ILogger {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/Logger");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILoggerInvoker); }
		}

		IntPtr class_ref;

		public static ILogger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.eventbus.Logger"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_log_Ljava_util_logging_Level_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_util_logging_Level_Ljava_lang_String_Handler ()
		{
			if (cb_log_Ljava_util_logging_Level_Ljava_lang_String_ == null)
				cb_log_Ljava_util_logging_Level_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Log_Ljava_util_logging_Level_Ljava_lang_String_);
			return cb_log_Ljava_util_logging_Level_Ljava_lang_String_;
		}

		static void n_Log_Ljava_util_logging_Level_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Logging.Level> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_log_Ljava_util_logging_Level_Ljava_lang_String_;
		public unsafe void Log (global::Java.Util.Logging.Level p0, string p1)
		{
			if (id_log_Ljava_util_logging_Level_Ljava_lang_String_ == IntPtr.Zero)
				id_log_Ljava_util_logging_Level_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "log", "(Ljava/util/logging/Level;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_util_logging_Level_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Logging.Level> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Log (global::Java.Util.Logging.Level p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
