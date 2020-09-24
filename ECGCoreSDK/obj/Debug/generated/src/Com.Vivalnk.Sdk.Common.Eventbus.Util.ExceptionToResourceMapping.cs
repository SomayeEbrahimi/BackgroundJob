using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/ExceptionToResourceMapping", DoNotGenerateAcw=true)]
	public partial class ExceptionToResourceMapping : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']/field[@name='throwableToMsgIdMap']"
		[Register ("throwableToMsgIdMap")]
		public global::System.Collections.IDictionary ThrowableToMsgIdMap {
			get {
				const string __id = "throwableToMsgIdMap.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "throwableToMsgIdMap.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/util/ExceptionToResourceMapping", typeof (ExceptionToResourceMapping));
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

		protected ExceptionToResourceMapping (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']/constructor[@name='ExceptionToResourceMapping' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExceptionToResourceMapping ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']/method[@name='addMapping' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends java.lang.Throwable&gt;'] and parameter[2][@type='int']]"
		[Register ("addMapping", "(Ljava/lang/Class;I)Lcom/vivalnk/sdk/common/eventbus/util/ExceptionToResourceMapping;", "GetAddMapping_Ljava_lang_Class_IHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ExceptionToResourceMapping AddMapping (global::Java.Lang.Class clazz, int msgId)
		{
			const string __id = "addMapping.(Ljava/lang/Class;I)Lcom/vivalnk/sdk/common/eventbus/util/ExceptionToResourceMapping;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (msgId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.ExceptionToResourceMapping> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']/method[@name='mapThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("mapThrowable", "(Ljava/lang/Throwable;)Ljava/lang/Integer;", "GetMapThrowable_Ljava_lang_Throwable_Handler")]
		public virtual unsafe global::Java.Lang.Integer MapThrowable (global::Java.Lang.Throwable throwable)
		{
			const string __id = "mapThrowable.(Ljava/lang/Throwable;)Ljava/lang/Integer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/class[@name='ExceptionToResourceMapping']/method[@name='mapThrowableFlat' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("mapThrowableFlat", "(Ljava/lang/Throwable;)Ljava/lang/Integer;", "GetMapThrowableFlat_Ljava_lang_Throwable_Handler")]
		protected virtual unsafe global::Java.Lang.Integer MapThrowableFlat (global::Java.Lang.Throwable throwable)
		{
			const string __id = "mapThrowableFlat.(Ljava/lang/Throwable;)Ljava/lang/Integer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
