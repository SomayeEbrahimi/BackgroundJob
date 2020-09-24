using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/EventBus", DoNotGenerateAcw=true)]
	public partial class EventBus : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				const string __id = "TAG.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "TAG.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/EventBus", typeof (EventBus));
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

		protected EventBus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/constructor[@name='EventBus' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventBus ()
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

		public static unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus Default {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='getDefault' and count(parameter)=0]"
			[Register ("getDefault", "()Lcom/vivalnk/sdk/common/eventbus/EventBus;", "")]
			get {
				const string __id = "getDefault.()Lcom/vivalnk/sdk/common/eventbus/EventBus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLogger;
#pragma warning disable 0169
		static Delegate GetGetLoggerHandler ()
		{
			if (cb_getLogger == null)
				cb_getLogger = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLogger);
			return cb_getLogger;
		}

		static IntPtr n_GetLogger (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Logger);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger Logger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='getLogger' and count(parameter)=0]"
			[Register ("getLogger", "()Lcom/vivalnk/sdk/common/eventbus/Logger;", "GetGetLoggerHandler")]
			get {
				const string __id = "getLogger.()Lcom/vivalnk/sdk/common/eventbus/Logger;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder Builder ()
		{
			const string __id = "builder.()Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cancelEventDelivery_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCancelEventDelivery_Ljava_lang_Object_Handler ()
		{
			if (cb_cancelEventDelivery_Ljava_lang_Object_ == null)
				cb_cancelEventDelivery_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CancelEventDelivery_Ljava_lang_Object_);
			return cb_cancelEventDelivery_Ljava_lang_Object_;
		}

		static void n_CancelEventDelivery_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.CancelEventDelivery (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='cancelEventDelivery' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("cancelEventDelivery", "(Ljava/lang/Object;)V", "GetCancelEventDelivery_Ljava_lang_Object_Handler")]
		public virtual unsafe void CancelEventDelivery (global::Java.Lang.Object e)
		{
			const string __id = "cancelEventDelivery.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='clearCaches' and count(parameter)=0]"
		[Register ("clearCaches", "()V", "")]
		public static unsafe void ClearCaches ()
		{
			const string __id = "clearCaches.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		static Delegate cb_getStickyEvent_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetStickyEvent_Ljava_lang_Class_Handler ()
		{
			if (cb_getStickyEvent_Ljava_lang_Class_ == null)
				cb_getStickyEvent_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetStickyEvent_Ljava_lang_Class_);
			return cb_getStickyEvent_Ljava_lang_Class_;
		}

		static IntPtr n_GetStickyEvent_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetStickyEvent (eventType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='getStickyEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getStickyEvent", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetGetStickyEvent_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object GetStickyEvent (global::Java.Lang.Class eventType)
		{
			const string __id = "getStickyEvent.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hasSubscriberForEvent_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetHasSubscriberForEvent_Ljava_lang_Class_Handler ()
		{
			if (cb_hasSubscriberForEvent_Ljava_lang_Class_ == null)
				cb_hasSubscriberForEvent_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasSubscriberForEvent_Ljava_lang_Class_);
			return cb_hasSubscriberForEvent_Ljava_lang_Class_;
		}

		static bool n_HasSubscriberForEvent_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventClass)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventClass, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasSubscriberForEvent (eventClass);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='hasSubscriberForEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("hasSubscriberForEvent", "(Ljava/lang/Class;)Z", "GetHasSubscriberForEvent_Ljava_lang_Class_Handler")]
		public virtual unsafe bool HasSubscriberForEvent (global::Java.Lang.Class eventClass)
		{
			const string __id = "hasSubscriberForEvent.(Ljava/lang/Class;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventClass).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isRegistered_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIsRegistered_Ljava_lang_Object_Handler ()
		{
			if (cb_isRegistered_Ljava_lang_Object_ == null)
				cb_isRegistered_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsRegistered_Ljava_lang_Object_);
			return cb_isRegistered_Ljava_lang_Object_;
		}

		static bool n_IsRegistered_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsRegistered (subscriber);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='isRegistered' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isRegistered", "(Ljava/lang/Object;)Z", "GetIsRegistered_Ljava_lang_Object_Handler")]
		public virtual unsafe bool IsRegistered (global::Java.Lang.Object subscriber)
		{
			const string __id = "isRegistered.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_post_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_Object_Handler ()
		{
			if (cb_post_Ljava_lang_Object_ == null)
				cb_post_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Post_Ljava_lang_Object_);
			return cb_post_Ljava_lang_Object_;
		}

		static void n_Post_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Post (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='post' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("post", "(Ljava/lang/Object;)V", "GetPost_Ljava_lang_Object_Handler")]
		public virtual unsafe void Post (global::Java.Lang.Object e)
		{
			const string __id = "post.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_postSticky_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPostSticky_Ljava_lang_Object_Handler ()
		{
			if (cb_postSticky_Ljava_lang_Object_ == null)
				cb_postSticky_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PostSticky_Ljava_lang_Object_);
			return cb_postSticky_Ljava_lang_Object_;
		}

		static void n_PostSticky_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.PostSticky (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='postSticky' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("postSticky", "(Ljava/lang/Object;)V", "GetPostSticky_Ljava_lang_Object_Handler")]
		public virtual unsafe void PostSticky (global::Java.Lang.Object e)
		{
			const string __id = "postSticky.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_register_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_Object_Handler ()
		{
			if (cb_register_Ljava_lang_Object_ == null)
				cb_register_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Register_Ljava_lang_Object_);
			return cb_register_Ljava_lang_Object_;
		}

		static void n_Register_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			__this.Register (subscriber);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='register' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("register", "(Ljava/lang/Object;)V", "GetRegister_Ljava_lang_Object_Handler")]
		public virtual unsafe void Register (global::Java.Lang.Object subscriber)
		{
			const string __id = "register.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeAllStickyEvents;
#pragma warning disable 0169
		static Delegate GetRemoveAllStickyEventsHandler ()
		{
			if (cb_removeAllStickyEvents == null)
				cb_removeAllStickyEvents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveAllStickyEvents);
			return cb_removeAllStickyEvents;
		}

		static void n_RemoveAllStickyEvents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllStickyEvents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='removeAllStickyEvents' and count(parameter)=0]"
		[Register ("removeAllStickyEvents", "()V", "GetRemoveAllStickyEventsHandler")]
		public virtual unsafe void RemoveAllStickyEvents ()
		{
			const string __id = "removeAllStickyEvents.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeStickyEvent_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetRemoveStickyEvent_Ljava_lang_Class_Handler ()
		{
			if (cb_removeStickyEvent_Ljava_lang_Class_ == null)
				cb_removeStickyEvent_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RemoveStickyEvent_Ljava_lang_Class_);
			return cb_removeStickyEvent_Ljava_lang_Class_;
		}

		static IntPtr n_RemoveStickyEvent_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_eventType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveStickyEvent (eventType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='removeStickyEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("removeStickyEvent", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetRemoveStickyEvent_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object RemoveStickyEvent (global::Java.Lang.Class eventType)
		{
			const string __id = "removeStickyEvent.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeStickyEvent_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveStickyEvent_Ljava_lang_Object_Handler ()
		{
			if (cb_removeStickyEvent_Ljava_lang_Object_ == null)
				cb_removeStickyEvent_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveStickyEvent_Ljava_lang_Object_);
			return cb_removeStickyEvent_Ljava_lang_Object_;
		}

		static bool n_RemoveStickyEvent_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveStickyEvent (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='removeStickyEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeStickyEvent", "(Ljava/lang/Object;)Z", "GetRemoveStickyEvent_Ljava_lang_Object_Handler")]
		public virtual unsafe bool RemoveStickyEvent (global::Java.Lang.Object e)
		{
			const string __id = "removeStickyEvent.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_unregister_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUnregister_Ljava_lang_Object_Handler ()
		{
			if (cb_unregister_Ljava_lang_Object_ == null)
				cb_unregister_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Unregister_Ljava_lang_Object_);
			return cb_unregister_Ljava_lang_Object_;
		}

		static void n_Unregister_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscriber)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var subscriber = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_subscriber, JniHandleOwnership.DoNotTransfer);
			__this.Unregister (subscriber);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='unregister' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("unregister", "(Ljava/lang/Object;)V", "GetUnregister_Ljava_lang_Object_Handler")]
		public virtual unsafe void Unregister (global::Java.Lang.Object subscriber)
		{
			const string __id = "unregister.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
