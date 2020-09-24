using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.JavaLogger']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/Logger$JavaLogger", DoNotGenerateAcw=true)]
	public partial class LoggerJavaLogger : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.JavaLogger']/field[@name='logger']"
		[Register ("logger")]
		protected global::Java.Util.Logging.Logger Logger {
			get {
				const string __id = "logger.Ljava/util/logging/Logger;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Logging.Logger> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "logger.Ljava/util/logging/Logger;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/Logger$JavaLogger", typeof (LoggerJavaLogger));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected LoggerJavaLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.JavaLogger']/constructor[@name='Logger.JavaLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe LoggerJavaLogger (string tag)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tag);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.JavaLogger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String']]"
		[Register ("log", "(Ljava/util/logging/Level;Ljava/lang/String;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Handler")]
		public virtual unsafe void Log (global::Java.Util.Logging.Level level, string msg)
		{
			const string __id = "log.(Ljava/util/logging/Level;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((level == null) ? IntPtr.Zero : ((global::Java.Lang.Object) level).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.JavaLogger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Log (global::Java.Util.Logging.Level level, string msg, global::Java.Lang.Throwable th)
		{
			const string __id = "log.(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((level == null) ? IntPtr.Zero : ((global::Java.Lang.Object) level).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((th == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) th).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.SystemOutLogger']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/Logger$SystemOutLogger", DoNotGenerateAcw=true)]
	public partial class LoggerSystemOutLogger : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/Logger$SystemOutLogger", typeof (LoggerSystemOutLogger));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected LoggerSystemOutLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.SystemOutLogger']/constructor[@name='Logger.SystemOutLogger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoggerSystemOutLogger ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.SystemOutLogger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String']]"
		[Register ("log", "(Ljava/util/logging/Level;Ljava/lang/String;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Handler")]
		public virtual unsafe void Log (global::Java.Util.Logging.Level level, string msg)
		{
			const string __id = "log.(Ljava/util/logging/Level;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((level == null) ? IntPtr.Zero : ((global::Java.Lang.Object) level).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='Logger.SystemOutLogger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Log (global::Java.Util.Logging.Level level, string msg, global::Java.Lang.Throwable th)
		{
			const string __id = "log.(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((level == null) ? IntPtr.Zero : ((global::Java.Lang.Object) level).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((th == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) th).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='Logger']"
	[Register ("com/vivalnk/sdk/common/eventbus/Logger", "", "Com.Vivalnk.Sdk.Common.Eventbus.ILoggerInvoker")]
	public partial interface ILogger : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='Logger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String']]"
		[Register ("log", "(Ljava/util/logging/Level;Ljava/lang/String;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Handler:Com.Vivalnk.Sdk.Common.Eventbus.ILoggerInvoker, ECGCoreSDK")]
		void Log (global::Java.Util.Logging.Level p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='Logger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Vivalnk.Sdk.Common.Eventbus.ILoggerInvoker, ECGCoreSDK")]
		void Log (global::Java.Util.Logging.Level p0, string p1, global::Java.Lang.Throwable p2);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/Logger", DoNotGenerateAcw=true)]
	internal partial class ILoggerInvoker : global::Java.Lang.Object, ILogger {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/Logger", typeof (ILoggerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
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
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
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
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
