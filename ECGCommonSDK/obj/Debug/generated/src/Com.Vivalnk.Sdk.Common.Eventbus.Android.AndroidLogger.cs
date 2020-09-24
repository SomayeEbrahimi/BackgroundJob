using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.android']/class[@name='AndroidLogger']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/android/AndroidLogger", DoNotGenerateAcw=true)]
	public partial class AndroidLogger : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/android/AndroidLogger", typeof (AndroidLogger));
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

		protected AndroidLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.android']/class[@name='AndroidLogger']/constructor[@name='AndroidLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AndroidLogger (string tag)
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

		public static unsafe bool IsAndroidLogAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.android']/class[@name='AndroidLogger']/method[@name='isAndroidLogAvailable' and count(parameter)=0]"
			[Register ("isAndroidLogAvailable", "()Z", "")]
			get {
				const string __id = "isAndroidLogAvailable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.android']/class[@name='AndroidLogger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Android.AndroidLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var level = global::Java.Lang.Object.GetObject<global::Java.Util.Logging.Level> (native_level, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var th = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_th, JniHandleOwnership.DoNotTransfer);
			__this.Log (level, msg, th);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.android']/class[@name='AndroidLogger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='java.util.logging.Level'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
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
}
