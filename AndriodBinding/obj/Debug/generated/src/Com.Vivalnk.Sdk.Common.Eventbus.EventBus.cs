using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/EventBus", DoNotGenerateAcw=true)]
	public partial class EventBus : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, TAG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/eventbus/EventBus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventBus); }
		}

		protected EventBus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/constructor[@name='EventBus' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventBus ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EventBus)) {
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

		static IntPtr id_getDefault;
		public static unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus Default {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='getDefault' and count(parameter)=0]"
			[Register ("getDefault", "()Lcom/vivalnk/sdk/common/eventbus/EventBus;", "")]
			get {
				if (id_getDefault == IntPtr.Zero)
					id_getDefault = JNIEnv.GetStaticMethodID (class_ref, "getDefault", "()Lcom/vivalnk/sdk/common/eventbus/EventBus;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefault), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_getLogger;
		public virtual unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger Logger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='getLogger' and count(parameter)=0]"
			[Register ("getLogger", "()Lcom/vivalnk/sdk/common/eventbus/Logger;", "GetGetLoggerHandler")]
			get {
				if (id_getLogger == IntPtr.Zero)
					id_getLogger = JNIEnv.GetMethodID (class_ref, "getLogger", "()Lcom/vivalnk/sdk/common/eventbus/Logger;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogger), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ILogger> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogger", "()Lcom/vivalnk/sdk/common/eventbus/Logger;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_builder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder Builder ()
		{
			if (id_builder == IntPtr.Zero)
				id_builder = JNIEnv.GetStaticMethodID (class_ref, "builder", "()Lcom/vivalnk/sdk/common/eventbus/EventBusBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBusBuilder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_cancelEventDelivery_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='cancelEventDelivery' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("cancelEventDelivery", "(Ljava/lang/Object;)V", "GetCancelEventDelivery_Ljava_lang_Object_Handler")]
		public virtual unsafe void CancelEventDelivery (global::Java.Lang.Object e)
		{
			if (id_cancelEventDelivery_Ljava_lang_Object_ == IntPtr.Zero)
				id_cancelEventDelivery_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "cancelEventDelivery", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelEventDelivery_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelEventDelivery", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_clearCaches;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='clearCaches' and count(parameter)=0]"
		[Register ("clearCaches", "()V", "")]
		public static unsafe void ClearCaches ()
		{
			if (id_clearCaches == IntPtr.Zero)
				id_clearCaches = JNIEnv.GetStaticMethodID (class_ref, "clearCaches", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearCaches);
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

		static IntPtr id_getStickyEvent_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='getStickyEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getStickyEvent", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetGetStickyEvent_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object GetStickyEvent (global::Java.Lang.Class eventType)
		{
			if (id_getStickyEvent_Ljava_lang_Class_ == IntPtr.Zero)
				id_getStickyEvent_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getStickyEvent", "(Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (eventType);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStickyEvent_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStickyEvent", "(Ljava/lang/Class;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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

		static IntPtr id_hasSubscriberForEvent_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='hasSubscriberForEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("hasSubscriberForEvent", "(Ljava/lang/Class;)Z", "GetHasSubscriberForEvent_Ljava_lang_Class_Handler")]
		public virtual unsafe bool HasSubscriberForEvent (global::Java.Lang.Class eventClass)
		{
			if (id_hasSubscriberForEvent_Ljava_lang_Class_ == IntPtr.Zero)
				id_hasSubscriberForEvent_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "hasSubscriberForEvent", "(Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (eventClass);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasSubscriberForEvent_Ljava_lang_Class_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasSubscriberForEvent", "(Ljava/lang/Class;)Z"), __args);
				return __ret;
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

		static IntPtr id_isRegistered_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='isRegistered' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isRegistered", "(Ljava/lang/Object;)Z", "GetIsRegistered_Ljava_lang_Object_Handler")]
		public virtual unsafe bool IsRegistered (global::Java.Lang.Object subscriber)
		{
			if (id_isRegistered_Ljava_lang_Object_ == IntPtr.Zero)
				id_isRegistered_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isRegistered", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (subscriber);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRegistered_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRegistered", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
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

		static IntPtr id_post_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='post' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("post", "(Ljava/lang/Object;)V", "GetPost_Ljava_lang_Object_Handler")]
		public virtual unsafe void Post (global::Java.Lang.Object e)
		{
			if (id_post_Ljava_lang_Object_ == IntPtr.Zero)
				id_post_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/lang/Object;)V"), __args);
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

		static IntPtr id_postSticky_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='postSticky' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("postSticky", "(Ljava/lang/Object;)V", "GetPostSticky_Ljava_lang_Object_Handler")]
		public virtual unsafe void PostSticky (global::Java.Lang.Object e)
		{
			if (id_postSticky_Ljava_lang_Object_ == IntPtr.Zero)
				id_postSticky_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "postSticky", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postSticky_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postSticky", "(Ljava/lang/Object;)V"), __args);
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

		static IntPtr id_register_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='register' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("register", "(Ljava/lang/Object;)V", "GetRegister_Ljava_lang_Object_Handler")]
		public virtual unsafe void Register (global::Java.Lang.Object subscriber)
		{
			if (id_register_Ljava_lang_Object_ == IntPtr.Zero)
				id_register_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (subscriber);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Ljava/lang/Object;)V"), __args);
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

		static IntPtr id_removeAllStickyEvents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='removeAllStickyEvents' and count(parameter)=0]"
		[Register ("removeAllStickyEvents", "()V", "GetRemoveAllStickyEventsHandler")]
		public virtual unsafe void RemoveAllStickyEvents ()
		{
			if (id_removeAllStickyEvents == IntPtr.Zero)
				id_removeAllStickyEvents = JNIEnv.GetMethodID (class_ref, "removeAllStickyEvents", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllStickyEvents);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllStickyEvents", "()V"));
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

		static IntPtr id_removeStickyEvent_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='removeStickyEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("removeStickyEvent", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetRemoveStickyEvent_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object RemoveStickyEvent (global::Java.Lang.Class eventType)
		{
			if (id_removeStickyEvent_Ljava_lang_Class_ == IntPtr.Zero)
				id_removeStickyEvent_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "removeStickyEvent", "(Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (eventType);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeStickyEvent_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeStickyEvent", "(Ljava/lang/Class;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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

		static IntPtr id_removeStickyEvent_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='removeStickyEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeStickyEvent", "(Ljava/lang/Object;)Z", "GetRemoveStickyEvent_Ljava_lang_Object_Handler")]
		public virtual unsafe bool RemoveStickyEvent (global::Java.Lang.Object e)
		{
			if (id_removeStickyEvent_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeStickyEvent_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeStickyEvent", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeStickyEvent_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeStickyEvent", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
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

		static IntPtr id_unregister_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='EventBus']/method[@name='unregister' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("unregister", "(Ljava/lang/Object;)V", "GetUnregister_Ljava_lang_Object_Handler")]
		public virtual unsafe void Unregister (global::Java.Lang.Object subscriber)
		{
			if (id_unregister_Ljava_lang_Object_ == IntPtr.Zero)
				id_unregister_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "unregister", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (subscriber);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregister_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregister", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

	}
}
