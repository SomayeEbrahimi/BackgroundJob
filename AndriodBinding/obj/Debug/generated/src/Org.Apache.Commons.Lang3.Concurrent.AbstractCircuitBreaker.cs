using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/AbstractCircuitBreaker", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class AbstractCircuitBreaker : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Concurrent.ICircuitBreaker {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/field[@name='PROPERTY_NAME']"
		[Register ("PROPERTY_NAME")]
		public const string PropertyName = (string) "open";
		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker.State']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State", DoNotGenerateAcw=true)]
		protected internal abstract partial class State : global::Java.Lang.Enum {


			static IntPtr CLOSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker.State']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker.State Closed {
				get {
					if (CLOSED_jfieldId == IntPtr.Zero)
						CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED", "Lorg/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OPEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker.State']/field[@name='OPEN']"
			[Register ("OPEN")]
			public static global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker.State Open {
				get {
					if (OPEN_jfieldId == IntPtr.Zero)
						OPEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN", "Lorg/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			protected State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_oppositeState;
#pragma warning disable 0169
			static Delegate GetOppositeStateHandler ()
			{
				if (cb_oppositeState == null)
					cb_oppositeState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OppositeState);
				return cb_oppositeState;
			}

			static IntPtr n_OppositeState (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker.State> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.OppositeState ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker.State']/method[@name='oppositeState' and count(parameter)=0]"
			[Register ("oppositeState", "()Ljava/lang/Enum;", "GetOppositeStateHandler")]
			public abstract global::Java.Lang.Enum OppositeState ();

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
			public static unsafe global::Java.Lang.Enum ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Java.Lang.Enum __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State;", "")]
			public static unsafe global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker.State[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State;");
				try {
					return (global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker.State));
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State", DoNotGenerateAcw=true)]
		internal partial class StateInvoker : State {

			public StateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (StateInvoker); }
			}

			static IntPtr id_oppositeState;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker.State']/method[@name='oppositeState' and count(parameter)=0]"
			[Register ("oppositeState", "()Ljava/lang/Enum;", "GetOppositeStateHandler")]
			public override unsafe global::Java.Lang.Enum OppositeState ()
			{
				if (id_oppositeState == IntPtr.Zero)
					id_oppositeState = JNIEnv.GetMethodID (class_ref, "oppositeState", "()Ljava/lang/Enum;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_oppositeState), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/AbstractCircuitBreaker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractCircuitBreaker); }
		}

		protected AbstractCircuitBreaker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/constructor[@name='AbstractCircuitBreaker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractCircuitBreaker ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AbstractCircuitBreaker)) {
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

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		static IntPtr id_isClosed;
		public virtual unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClosed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isClosed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isOpen;
#pragma warning disable 0169
		static Delegate GetIsOpenHandler ()
		{
			if (cb_isOpen == null)
				cb_isOpen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsOpen);
			return cb_isOpen;
		}

		static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isOpen;
		public virtual unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "GetIsOpenHandler")]
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOpen", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_addChangeListener_Ljava_beans_PropertyChangeListener_;
#pragma warning disable 0169
		static Delegate GetAddChangeListener_Ljava_beans_PropertyChangeListener_Handler ()
		{
			if (cb_addChangeListener_Ljava_beans_PropertyChangeListener_ == null)
				cb_addChangeListener_Ljava_beans_PropertyChangeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddChangeListener_Ljava_beans_PropertyChangeListener_);
			return cb_addChangeListener_Ljava_beans_PropertyChangeListener_;
		}

		static void n_AddChangeListener_Ljava_beans_PropertyChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Java.Beans.IPropertyChangeListener)global::Java.Lang.Object.GetObject<global::Java.Beans.IPropertyChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddChangeListener (listener);
		}
#pragma warning restore 0169

		static IntPtr id_addChangeListener_Ljava_beans_PropertyChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='addChangeListener' and count(parameter)=1 and parameter[1][@type='java.beans.PropertyChangeListener']]"
		[Register ("addChangeListener", "(Ljava/beans/PropertyChangeListener;)V", "GetAddChangeListener_Ljava_beans_PropertyChangeListener_Handler")]
		public virtual unsafe void AddChangeListener (global::Java.Beans.IPropertyChangeListener listener)
		{
			if (id_addChangeListener_Ljava_beans_PropertyChangeListener_ == IntPtr.Zero)
				id_addChangeListener_Ljava_beans_PropertyChangeListener_ = JNIEnv.GetMethodID (class_ref, "addChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addChangeListener_Ljava_beans_PropertyChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addChangeListener", "(Ljava/beans/PropertyChangeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_changeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_;
#pragma warning disable 0169
		static Delegate GetChangeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_Handler ()
		{
			if (cb_changeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_ == null)
				cb_changeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ChangeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_);
			return cb_changeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_;
		}

		static void n_ChangeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newState)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newState = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker.State> (native_newState, JniHandleOwnership.DoNotTransfer);
			__this.ChangeState (newState);
		}
#pragma warning restore 0169

		static IntPtr id_changeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='changeState' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.concurrent.AbstractCircuitBreaker.State']]"
		[Register ("changeState", "(Lorg/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State;)V", "GetChangeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_Handler")]
		protected virtual unsafe void ChangeState (global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker.State newState)
		{
			if (id_changeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_ == IntPtr.Zero)
				id_changeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_ = JNIEnv.GetMethodID (class_ref, "changeState", "(Lorg/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (newState);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changeState_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeState", "(Lorg/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_checkState;
#pragma warning disable 0169
		static Delegate GetCheckStateHandler ()
		{
			if (cb_checkState == null)
				cb_checkState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CheckState);
			return cb_checkState;
		}

		static bool n_CheckState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckState ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='checkState' and count(parameter)=0]"
		[Register ("checkState", "()Z", "GetCheckStateHandler")]
		public abstract bool CheckState ();

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_incrementAndCheckState_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIncrementAndCheckState_Ljava_lang_Object_Handler ()
		{
			if (cb_incrementAndCheckState_Ljava_lang_Object_ == null)
				cb_incrementAndCheckState_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IncrementAndCheckState_Ljava_lang_Object_);
			return cb_incrementAndCheckState_Ljava_lang_Object_;
		}

		static bool n_IncrementAndCheckState_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IncrementAndCheckState (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='incrementAndCheckState' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("incrementAndCheckState", "(Ljava/lang/Object;)Z", "GetIncrementAndCheckState_Ljava_lang_Object_Handler")]
		public abstract bool IncrementAndCheckState (global::Java.Lang.Object p0);

		static IntPtr id_isOpen_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='isOpen' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.concurrent.AbstractCircuitBreaker.State']]"
		[Register ("isOpen", "(Lorg/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State;)Z", "")]
		protected static unsafe bool InvokeIsOpen (global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker.State state)
		{
			if (id_isOpen_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_ == IntPtr.Zero)
				id_isOpen_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_ = JNIEnv.GetStaticMethodID (class_ref, "isOpen", "(Lorg/apache/commons/lang3/concurrent/AbstractCircuitBreaker$State;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (state);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isOpen_Lorg_apache_commons_lang3_concurrent_AbstractCircuitBreaker_State_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Open);
			return cb_open;
		}

		static void n_Open (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "GetOpenHandler")]
		public virtual unsafe void Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeChangeListener_Ljava_beans_PropertyChangeListener_;
#pragma warning disable 0169
		static Delegate GetRemoveChangeListener_Ljava_beans_PropertyChangeListener_Handler ()
		{
			if (cb_removeChangeListener_Ljava_beans_PropertyChangeListener_ == null)
				cb_removeChangeListener_Ljava_beans_PropertyChangeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveChangeListener_Ljava_beans_PropertyChangeListener_);
			return cb_removeChangeListener_Ljava_beans_PropertyChangeListener_;
		}

		static void n_RemoveChangeListener_Ljava_beans_PropertyChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Java.Beans.IPropertyChangeListener)global::Java.Lang.Object.GetObject<global::Java.Beans.IPropertyChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveChangeListener (listener);
		}
#pragma warning restore 0169

		static IntPtr id_removeChangeListener_Ljava_beans_PropertyChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='removeChangeListener' and count(parameter)=1 and parameter[1][@type='java.beans.PropertyChangeListener']]"
		[Register ("removeChangeListener", "(Ljava/beans/PropertyChangeListener;)V", "GetRemoveChangeListener_Ljava_beans_PropertyChangeListener_Handler")]
		public virtual unsafe void RemoveChangeListener (global::Java.Beans.IPropertyChangeListener listener)
		{
			if (id_removeChangeListener_Ljava_beans_PropertyChangeListener_ == IntPtr.Zero)
				id_removeChangeListener_Ljava_beans_PropertyChangeListener_ = JNIEnv.GetMethodID (class_ref, "removeChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeChangeListener_Ljava_beans_PropertyChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeChangeListener", "(Ljava/beans/PropertyChangeListener;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/AbstractCircuitBreaker", DoNotGenerateAcw=true)]
	internal partial class AbstractCircuitBreakerInvoker : AbstractCircuitBreaker, global::Org.Apache.Commons.Lang3.Concurrent.ICircuitBreaker {

		public AbstractCircuitBreakerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractCircuitBreakerInvoker); }
		}

		static IntPtr id_checkState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='checkState' and count(parameter)=0]"
		[Register ("checkState", "()Z", "GetCheckStateHandler")]
		public override unsafe bool CheckState ()
		{
			if (id_checkState == IntPtr.Zero)
				id_checkState = JNIEnv.GetMethodID (class_ref, "checkState", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkState);
			} finally {
			}
		}

		static IntPtr id_incrementAndCheckState_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AbstractCircuitBreaker']/method[@name='incrementAndCheckState' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("incrementAndCheckState", "(Ljava/lang/Object;)Z", "GetIncrementAndCheckState_Ljava_lang_Object_Handler")]
		public override unsafe bool IncrementAndCheckState (global::Java.Lang.Object p0)
		{
			if (id_incrementAndCheckState_Ljava_lang_Object_ == IntPtr.Zero)
				id_incrementAndCheckState_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "incrementAndCheckState", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_incrementAndCheckState_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
