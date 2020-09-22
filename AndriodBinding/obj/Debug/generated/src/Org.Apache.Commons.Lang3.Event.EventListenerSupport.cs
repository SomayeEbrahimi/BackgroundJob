using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/event/EventListenerSupport", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L"})]
	public partial class EventListenerSupport : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport.ProxyInvocationHandler']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/event/EventListenerSupport$ProxyInvocationHandler", DoNotGenerateAcw=true)]
		protected internal partial class ProxyInvocationHandler : global::Java.Lang.Object, global::Java.Lang.Reflect.IInvocationHandler {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/event/EventListenerSupport$ProxyInvocationHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProxyInvocationHandler); }
			}

			protected ProxyInvocationHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_apache_commons_lang3_event_EventListenerSupport_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport.ProxyInvocationHandler']/constructor[@name='EventListenerSupport.ProxyInvocationHandler' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.event.EventListenerSupport']]"
			[Register (".ctor", "(Lorg/apache/commons/lang3/event/EventListenerSupport;)V", "")]
			protected unsafe ProxyInvocationHandler (global::Org.Apache.Commons.Lang3.Event.EventListenerSupport __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (ProxyInvocationHandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lorg_apache_commons_lang3_event_EventListenerSupport_ == IntPtr.Zero)
						id_ctor_Lorg_apache_commons_lang3_event_EventListenerSupport_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/lang3/event/EventListenerSupport;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_lang3_event_EventListenerSupport_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_lang3_event_EventListenerSupport_, __args);
				} finally {
				}
			}

			static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler ()
			{
				if (cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
					cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_);
				return cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
			}

			static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unusedProxy, IntPtr native_method, IntPtr native_args)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Event.EventListenerSupport.ProxyInvocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var unusedProxy = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_unusedProxy, JniHandleOwnership.DoNotTransfer);
				var method = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (native_method, JniHandleOwnership.DoNotTransfer);
				var args = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (unusedProxy, method, args));
				if (args != null)
					JNIEnv.CopyArray (args, native_args);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport.ProxyInvocationHandler']/method[@name='invoke' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
			[Register ("invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler")]
			public virtual unsafe global::Java.Lang.Object Invoke (global::Java.Lang.Object unusedProxy, global::Java.Lang.Reflect.Method method, global::Java.Lang.Object[] args)
			{
				if (id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_args = JNIEnv.NewArray (args);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (unusedProxy);
					__args [1] = new JValue (method);
					__args [2] = new JValue (native_args);

					global::Java.Lang.Object __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (args != null) {
						JNIEnv.CopyArray (native_args, args);
						JNIEnv.DeleteLocalRef (native_args);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/event/EventListenerSupport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventListenerSupport); }
		}

		protected EventListenerSupport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport']/constructor[@name='EventListenerSupport' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;L&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe EventListenerSupport (global::Java.Lang.Class listenerInterface)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listenerInterface);
				if (((object) this).GetType () != typeof (EventListenerSupport)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_lang_ClassLoader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport']/constructor[@name='EventListenerSupport' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;L&gt;'] and parameter[2][@type='java.lang.ClassLoader']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/ClassLoader;)V", "")]
		public unsafe EventListenerSupport (global::Java.Lang.Class listenerInterface, global::Java.Lang.ClassLoader classLoader)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (listenerInterface);
				__args [1] = new JValue (classLoader);
				if (((object) this).GetType () != typeof (EventListenerSupport)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Class;Ljava/lang/ClassLoader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Class;Ljava/lang/ClassLoader;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Ljava_lang_ClassLoader_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Ljava_lang_ClassLoader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/lang/ClassLoader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_ClassLoader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_ClassLoader_, __args);
			} finally {
			}
		}

		static Delegate cb_addListener_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddListener_Ljava_lang_Object_Handler ()
		{
			if (cb_addListener_Ljava_lang_Object_ == null)
				cb_addListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddListener_Ljava_lang_Object_);
			return cb_addListener_Ljava_lang_Object_;
		}

		static void n_AddListener_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Event.EventListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (listener);
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='L']]"
		[Register ("addListener", "(Ljava/lang/Object;)V", "GetAddListener_Ljava_lang_Object_Handler")]
		public virtual unsafe void AddListener (global::Java.Lang.Object listener)
		{
			if (id_addListener_Ljava_lang_Object_ == IntPtr.Zero)
				id_addListener_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Ljava/lang/Object;)V");
			IntPtr native_listener = JNIEnv.ToLocalJniHandle (listener);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addListener_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addListener", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_listener);
			}
		}

		static Delegate cb_addListener_Ljava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetAddListener_Ljava_lang_Object_ZHandler ()
		{
			if (cb_addListener_Ljava_lang_Object_Z == null)
				cb_addListener_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_AddListener_Ljava_lang_Object_Z);
			return cb_addListener_Ljava_lang_Object_Z;
		}

		static void n_AddListener_Ljava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_listener, bool allowDuplicate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Event.EventListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (listener, allowDuplicate);
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport']/method[@name='addListener' and count(parameter)=2 and parameter[1][@type='L'] and parameter[2][@type='boolean']]"
		[Register ("addListener", "(Ljava/lang/Object;Z)V", "GetAddListener_Ljava_lang_Object_ZHandler")]
		public virtual unsafe void AddListener (global::Java.Lang.Object listener, bool allowDuplicate)
		{
			if (id_addListener_Ljava_lang_Object_Z == IntPtr.Zero)
				id_addListener_Ljava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "addListener", "(Ljava/lang/Object;Z)V");
			IntPtr native_listener = JNIEnv.ToLocalJniHandle (listener);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_listener);
				__args [1] = new JValue (allowDuplicate);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addListener_Ljava_lang_Object_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addListener", "(Ljava/lang/Object;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_listener);
			}
		}

		static IntPtr id_create_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("create", "(Ljava/lang/Class;)Lorg/apache/commons/lang3/event/EventListenerSupport;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Event.EventListenerSupport Create (global::Java.Lang.Class listenerInterface)
		{
			if (id_create_Ljava_lang_Class_ == IntPtr.Zero)
				id_create_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/Class;)Lorg/apache/commons/lang3/event/EventListenerSupport;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listenerInterface);
				global::Org.Apache.Commons.Lang3.Event.EventListenerSupport __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Event.EventListenerSupport> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createInvocationHandler;
#pragma warning disable 0169
		static Delegate GetCreateInvocationHandlerHandler ()
		{
			if (cb_createInvocationHandler == null)
				cb_createInvocationHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateInvocationHandler);
			return cb_createInvocationHandler;
		}

		static IntPtr n_CreateInvocationHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Event.EventListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateInvocationHandler ());
		}
#pragma warning restore 0169

		static IntPtr id_createInvocationHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport']/method[@name='createInvocationHandler' and count(parameter)=0]"
		[Register ("createInvocationHandler", "()Ljava/lang/reflect/InvocationHandler;", "GetCreateInvocationHandlerHandler")]
		protected virtual unsafe global::Java.Lang.Reflect.IInvocationHandler CreateInvocationHandler ()
		{
			if (id_createInvocationHandler == IntPtr.Zero)
				id_createInvocationHandler = JNIEnv.GetMethodID (class_ref, "createInvocationHandler", "()Ljava/lang/reflect/InvocationHandler;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IInvocationHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createInvocationHandler), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IInvocationHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createInvocationHandler", "()Ljava/lang/reflect/InvocationHandler;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fire;
#pragma warning disable 0169
		static Delegate GetFireHandler ()
		{
			if (cb_fire == null)
				cb_fire = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Fire);
			return cb_fire;
		}

		static IntPtr n_Fire (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Event.EventListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fire ());
		}
#pragma warning restore 0169

		static IntPtr id_fire;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport']/method[@name='fire' and count(parameter)=0]"
		[Register ("fire", "()Ljava/lang/Object;", "GetFireHandler")]
		public virtual unsafe global::Java.Lang.Object Fire ()
		{
			if (id_fire == IntPtr.Zero)
				id_fire = JNIEnv.GetMethodID (class_ref, "fire", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fire), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fire", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getListeners;
#pragma warning disable 0169
		static Delegate GetGetListenersHandler ()
		{
			if (cb_getListeners == null)
				cb_getListeners = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetListeners);
			return cb_getListeners;
		}

		static IntPtr n_GetListeners (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Event.EventListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetListeners ());
		}
#pragma warning restore 0169

		static IntPtr id_getListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport']/method[@name='getListeners' and count(parameter)=0]"
		[Register ("getListeners", "()[Ljava/lang/Object;", "GetGetListenersHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetListeners ()
		{
			if (id_getListeners == IntPtr.Zero)
				id_getListeners = JNIEnv.GetMethodID (class_ref, "getListeners", "()[Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getListeners), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				else
					return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListeners", "()[Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_removeListener_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Ljava_lang_Object_Handler ()
		{
			if (cb_removeListener_Ljava_lang_Object_ == null)
				cb_removeListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveListener_Ljava_lang_Object_);
			return cb_removeListener_Ljava_lang_Object_;
		}

		static void n_RemoveListener_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Event.EventListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (listener);
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventListenerSupport']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='L']]"
		[Register ("removeListener", "(Ljava/lang/Object;)V", "GetRemoveListener_Ljava_lang_Object_Handler")]
		public virtual unsafe void RemoveListener (global::Java.Lang.Object listener)
		{
			if (id_removeListener_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeListener_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Ljava/lang/Object;)V");
			IntPtr native_listener = JNIEnv.ToLocalJniHandle (listener);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListener_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListener", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_listener);
			}
		}

	}
}
