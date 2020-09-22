using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogInfo']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/log/LogInfo", DoNotGenerateAcw=true)]
	public partial class LogInfo : global::Java.Lang.Object {


		static IntPtr message_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogInfo']/field[@name='message']"
		[Register ("message")]
		public string Message {
			get {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, message_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, message_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr priority_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogInfo']/field[@name='priority']"
		[Register ("priority")]
		public global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Priority {
			get {
				if (priority_jfieldId == IntPtr.Zero)
					priority_jfieldId = JNIEnv.GetFieldID (class_ref, "priority", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, priority_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (priority_jfieldId == IntPtr.Zero)
					priority_jfieldId = JNIEnv.GetFieldID (class_ref, "priority", "Lcom/vivalnk/sdk/common/utils/log/LogLevel;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, priority_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr tag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogInfo']/field[@name='tag']"
		[Register ("tag")]
		public string Tag {
			get {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tag_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tag_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr threadInfo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogInfo']/field[@name='threadInfo']"
		[Register ("threadInfo")]
		public string ThreadInfo {
			get {
				if (threadInfo_jfieldId == IntPtr.Zero)
					threadInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "threadInfo", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, threadInfo_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (threadInfo_jfieldId == IntPtr.Zero)
					threadInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "threadInfo", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, threadInfo_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr timeStamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogInfo']/field[@name='timeStamp']"
		[Register ("timeStamp")]
		public long TimeStamp {
			get {
				if (timeStamp_jfieldId == IntPtr.Zero)
					timeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timeStamp", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, timeStamp_jfieldId);
			}
			set {
				if (timeStamp_jfieldId == IntPtr.Zero)
					timeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timeStamp", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timeStamp_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/log/LogInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogInfo); }
		}

		protected LogInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogInfo']/constructor[@name='LogInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LogInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LogInfo)) {
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

		static Delegate cb_getInfo;
#pragma warning disable 0169
		static Delegate GetGetInfoHandler ()
		{
			if (cb_getInfo == null)
				cb_getInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInfo);
			return cb_getInfo;
		}

		static IntPtr n_GetInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Info);
		}
#pragma warning restore 0169

		static IntPtr id_getInfo;
		public virtual unsafe string Info {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogInfo']/method[@name='getInfo' and count(parameter)=0]"
			[Register ("getInfo", "()Ljava/lang/String;", "GetGetInfoHandler")]
			get {
				if (id_getInfo == IntPtr.Zero)
					id_getInfo = JNIEnv.GetMethodID (class_ref, "getInfo", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInfo), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInfo", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
