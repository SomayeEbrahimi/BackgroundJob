using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.exception']/class[@name='VivalnkCrashHandler']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/exception/VivalnkCrashHandler", DoNotGenerateAcw=true)]
	public partial class VivalnkCrashHandler : global::Java.Lang.Object, global::Java.Lang.Thread.IUncaughtExceptionHandler {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.exception']/class[@name='VivalnkCrashHandler']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "VivalnkCrashHandler";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/exception/VivalnkCrashHandler", typeof (VivalnkCrashHandler));
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

		protected VivalnkCrashHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Vivalnk.Sdk.Common.Exception.VivalnkCrashHandler Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.exception']/class[@name='VivalnkCrashHandler']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/vivalnk/sdk/common/exception/VivalnkCrashHandler;", "")]
			get {
				const string __id = "getInstance.()Lcom/vivalnk/sdk/common/exception/VivalnkCrashHandler;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Exception.VivalnkCrashHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_collectDeviceInfoString;
#pragma warning disable 0169
		static Delegate GetCollectDeviceInfoStringHandler ()
		{
			if (cb_collectDeviceInfoString == null)
				cb_collectDeviceInfoString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CollectDeviceInfoString);
			return cb_collectDeviceInfoString;
		}

		static IntPtr n_CollectDeviceInfoString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Exception.VivalnkCrashHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CollectDeviceInfoString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.exception']/class[@name='VivalnkCrashHandler']/method[@name='collectDeviceInfoString' and count(parameter)=0]"
		[Register ("collectDeviceInfoString", "()Ljava/lang/String;", "GetCollectDeviceInfoStringHandler")]
		public virtual unsafe string CollectDeviceInfoString ()
		{
			const string __id = "collectDeviceInfoString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_collectDeviceInfosMap;
#pragma warning disable 0169
		static Delegate GetCollectDeviceInfosMapHandler ()
		{
			if (cb_collectDeviceInfosMap == null)
				cb_collectDeviceInfosMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CollectDeviceInfosMap);
			return cb_collectDeviceInfosMap;
		}

		static IntPtr n_CollectDeviceInfosMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Exception.VivalnkCrashHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CollectDeviceInfosMap ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.exception']/class[@name='VivalnkCrashHandler']/method[@name='collectDeviceInfosMap' and count(parameter)=0]"
		[Register ("collectDeviceInfosMap", "()Ljava/util/Map;", "GetCollectDeviceInfosMapHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> CollectDeviceInfosMap ()
		{
			const string __id = "collectDeviceInfosMap.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Exception.VivalnkCrashHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Init (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.exception']/class[@name='VivalnkCrashHandler']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context context)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_putExtra_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutExtra_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putExtra_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putExtra_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PutExtra_Ljava_lang_String_Ljava_lang_String_);
			return cb_putExtra_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PutExtra_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Exception.VivalnkCrashHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.PutExtra (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.exception']/class[@name='VivalnkCrashHandler']/method[@name='putExtra' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putExtra", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutExtra_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void PutExtra (string key, string value)
		{
			const string __id = "putExtra.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler ()
		{
			if (cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == null)
				cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_);
			return cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		}

		static void n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Exception.VivalnkCrashHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_thread, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.UncaughtException (thread, error);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.exception']/class[@name='VivalnkCrashHandler']/method[@name='uncaughtException' and count(parameter)=2 and parameter[1][@type='java.lang.Thread'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", "GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void UncaughtException (global::Java.Lang.Thread thread, global::Java.Lang.Throwable error)
		{
			const string __id = "uncaughtException.(Ljava/lang/Thread;Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
				__args [1] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
