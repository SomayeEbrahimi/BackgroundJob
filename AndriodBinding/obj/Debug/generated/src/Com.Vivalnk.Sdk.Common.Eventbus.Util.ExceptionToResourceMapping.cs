using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/ExceptionToResourceMapping", DoNotGenerateAcw=true)]
	public partial class ExceptionToResourceMapping : global::Java.Lang.Object {


		static IntPtr throwableToMsgIdMap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']/field[@name='throwableToMsgIdMap']"
		[Register ("throwableToMsgIdMap")]
		public global::System.Collections.IDictionary ThrowableToMsgIdMap {
			get {
				if (throwableToMsgIdMap_jfieldId == IntPtr.Zero)
					throwableToMsgIdMap_jfieldId = JNIEnv.GetFieldID (class_ref, "throwableToMsgIdMap", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, throwableToMsgIdMap_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (throwableToMsgIdMap_jfieldId == IntPtr.Zero)
					throwableToMsgIdMap_jfieldId = JNIEnv.GetFieldID (class_ref, "throwableToMsgIdMap", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, throwableToMsgIdMap_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/util/ExceptionToResourceMapping", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExceptionToResourceMapping); }
		}

		protected ExceptionToResourceMapping (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']/constructor[@name='ExceptionToResourceMapping' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExceptionToResourceMapping ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ExceptionToResourceMapping)) {
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

		static Delegate cb_addMapping_Ljava_lang_Class_I;
#pragma warning disable 0169
		static Delegate GetAddMapping_Ljava_lang_Class_IHandler ()
		{
			if (cb_addMapping_Ljava_lang_Class_I == null)
				cb_addMapping_Ljava_lang_Class_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_AddMapping_Ljava_lang_Class_I);
			return cb_addMapping_Ljava_lang_Class_I;
		}

		static IntPtr n_AddMapping_Ljava_lang_Class_I (IntPtr jnienv, IntPtr native__this, IntPtr native_clazz, int msgId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ExceptionToResourceMapping> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clazz = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_clazz, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMapping (clazz, msgId));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMapping_Ljava_lang_Class_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']/method[@name='addMapping' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends java.lang.Throwable&gt;'] and parameter[2][@type='int']]"
		[Register ("addMapping", "(Ljava/lang/Class;I)Lcom/vivalnk/sdk/common/eventbus/util/ExceptionToResourceMapping;", "GetAddMapping_Ljava_lang_Class_IHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ExceptionToResourceMapping AddMapping (global::Java.Lang.Class clazz, int msgId)
		{
			if (id_addMapping_Ljava_lang_Class_I == IntPtr.Zero)
				id_addMapping_Ljava_lang_Class_I = JNIEnv.GetMethodID (class_ref, "addMapping", "(Ljava/lang/Class;I)Lcom/vivalnk/sdk/common/eventbus/util/ExceptionToResourceMapping;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (clazz);
				__args [1] = new JValue (msgId);

				global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ExceptionToResourceMapping __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ExceptionToResourceMapping> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMapping_Ljava_lang_Class_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ExceptionToResourceMapping> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMapping", "(Ljava/lang/Class;I)Lcom/vivalnk/sdk/common/eventbus/util/ExceptionToResourceMapping;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_mapThrowable_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetMapThrowable_Ljava_lang_Throwable_Handler ()
		{
			if (cb_mapThrowable_Ljava_lang_Throwable_ == null)
				cb_mapThrowable_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_MapThrowable_Ljava_lang_Throwable_);
			return cb_mapThrowable_Ljava_lang_Throwable_;
		}

		static IntPtr n_MapThrowable_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ExceptionToResourceMapping> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapThrowable (throwable));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_mapThrowable_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']/method[@name='mapThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("mapThrowable", "(Ljava/lang/Throwable;)Ljava/lang/Integer;", "GetMapThrowable_Ljava_lang_Throwable_Handler")]
		public virtual unsafe global::Java.Lang.Integer MapThrowable (global::Java.Lang.Throwable throwable)
		{
			if (id_mapThrowable_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_mapThrowable_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "mapThrowable", "(Ljava/lang/Throwable;)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);

				global::Java.Lang.Integer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mapThrowable_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mapThrowable", "(Ljava/lang/Throwable;)Ljava/lang/Integer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_mapThrowableFlat_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetMapThrowableFlat_Ljava_lang_Throwable_Handler ()
		{
			if (cb_mapThrowableFlat_Ljava_lang_Throwable_ == null)
				cb_mapThrowableFlat_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_MapThrowableFlat_Ljava_lang_Throwable_);
			return cb_mapThrowableFlat_Ljava_lang_Throwable_;
		}

		static IntPtr n_MapThrowableFlat_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ExceptionToResourceMapping> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapThrowableFlat (throwable));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_mapThrowableFlat_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']/method[@name='mapThrowableFlat' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("mapThrowableFlat", "(Ljava/lang/Throwable;)Ljava/lang/Integer;", "GetMapThrowableFlat_Ljava_lang_Throwable_Handler")]
		protected virtual unsafe global::Java.Lang.Integer MapThrowableFlat (global::Java.Lang.Throwable throwable)
		{
			if (id_mapThrowableFlat_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_mapThrowableFlat_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "mapThrowableFlat", "(Ljava/lang/Throwable;)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);

				global::Java.Lang.Integer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mapThrowableFlat_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mapThrowableFlat", "(Ljava/lang/Throwable;)Ljava/lang/Integer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
