using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Runtime.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/CFlowStack", DoNotGenerateAcw=true)]
	public partial class CFlowStack : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/runtime/internal/CFlowStack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CFlowStack); }
		}

		protected CFlowStack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/constructor[@name='CFlowStack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CFlowStack ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CFlowStack)) {
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

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValid", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_getThreadStackFactoryClassName;
		public static unsafe string ThreadStackFactoryClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='getThreadStackFactoryClassName' and count(parameter)=0]"
			[Register ("getThreadStackFactoryClassName", "()Ljava/lang/String;", "")]
			get {
				if (id_getThreadStackFactoryClassName == IntPtr.Zero)
					id_getThreadStackFactoryClassName = JNIEnv.GetStaticMethodID (class_ref, "getThreadStackFactoryClassName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getThreadStackFactoryClassName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (index));
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public virtual unsafe global::Java.Lang.Object Get (int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peek;
#pragma warning disable 0169
		static Delegate GetPeekHandler ()
		{
			if (cb_peek == null)
				cb_peek = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Peek);
			return cb_peek;
		}

		static IntPtr n_Peek (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Peek ());
		}
#pragma warning restore 0169

		static IntPtr id_peek;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='peek' and count(parameter)=0]"
		[Register ("peek", "()Ljava/lang/Object;", "GetPeekHandler")]
		public virtual unsafe global::Java.Lang.Object Peek ()
		{
			if (id_peek == IntPtr.Zero)
				id_peek = JNIEnv.GetMethodID (class_ref, "peek", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_peek), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peek", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peekCFlow;
#pragma warning disable 0169
		static Delegate GetPeekCFlowHandler ()
		{
			if (cb_peekCFlow == null)
				cb_peekCFlow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PeekCFlow);
			return cb_peekCFlow;
		}

		static IntPtr n_PeekCFlow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekCFlow ());
		}
#pragma warning restore 0169

		static IntPtr id_peekCFlow;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='peekCFlow' and count(parameter)=0]"
		[Register ("peekCFlow", "()Lorg/aspectj/runtime/CFlow;", "GetPeekCFlowHandler")]
		public virtual unsafe global::Org.Aspectj.Runtime.CFlow PeekCFlow ()
		{
			if (id_peekCFlow == IntPtr.Zero)
				id_peekCFlow = JNIEnv.GetMethodID (class_ref, "peekCFlow", "()Lorg/aspectj/runtime/CFlow;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_peekCFlow), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekCFlow", "()Lorg/aspectj/runtime/CFlow;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peekInstance;
#pragma warning disable 0169
		static Delegate GetPeekInstanceHandler ()
		{
			if (cb_peekInstance == null)
				cb_peekInstance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PeekInstance);
			return cb_peekInstance;
		}

		static IntPtr n_PeekInstance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekInstance ());
		}
#pragma warning restore 0169

		static IntPtr id_peekInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='peekInstance' and count(parameter)=0]"
		[Register ("peekInstance", "()Ljava/lang/Object;", "GetPeekInstanceHandler")]
		public virtual unsafe global::Java.Lang.Object PeekInstance ()
		{
			if (id_peekInstance == IntPtr.Zero)
				id_peekInstance = JNIEnv.GetMethodID (class_ref, "peekInstance", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_peekInstance), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekInstance", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peekTopCFlow;
#pragma warning disable 0169
		static Delegate GetPeekTopCFlowHandler ()
		{
			if (cb_peekTopCFlow == null)
				cb_peekTopCFlow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PeekTopCFlow);
			return cb_peekTopCFlow;
		}

		static IntPtr n_PeekTopCFlow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekTopCFlow ());
		}
#pragma warning restore 0169

		static IntPtr id_peekTopCFlow;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='peekTopCFlow' and count(parameter)=0]"
		[Register ("peekTopCFlow", "()Lorg/aspectj/runtime/CFlow;", "GetPeekTopCFlowHandler")]
		public virtual unsafe global::Org.Aspectj.Runtime.CFlow PeekTopCFlow ()
		{
			if (id_peekTopCFlow == IntPtr.Zero)
				id_peekTopCFlow = JNIEnv.GetMethodID (class_ref, "peekTopCFlow", "()Lorg/aspectj/runtime/CFlow;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_peekTopCFlow), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekTopCFlow", "()Lorg/aspectj/runtime/CFlow;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pop;
#pragma warning disable 0169
		static Delegate GetPopHandler ()
		{
			if (cb_pop == null)
				cb_pop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Pop);
			return cb_pop;
		}

		static void n_Pop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pop ();
		}
#pragma warning restore 0169

		static IntPtr id_pop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='pop' and count(parameter)=0]"
		[Register ("pop", "()V", "GetPopHandler")]
		public virtual unsafe void Pop ()
		{
			if (id_pop == IntPtr.Zero)
				id_pop = JNIEnv.GetMethodID (class_ref, "pop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pop", "()V"));
			} finally {
			}
		}

		static Delegate cb_push_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPush_Ljava_lang_Object_Handler ()
		{
			if (cb_push_Ljava_lang_Object_ == null)
				cb_push_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Push_Ljava_lang_Object_);
			return cb_push_Ljava_lang_Object_;
		}

		static void n_Push_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.Push (obj);
		}
#pragma warning restore 0169

		static IntPtr id_push_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='push' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("push", "(Ljava/lang/Object;)V", "GetPush_Ljava_lang_Object_Handler")]
		public virtual unsafe void Push (global::Java.Lang.Object obj)
		{
			if (id_push_Ljava_lang_Object_ == IntPtr.Zero)
				id_push_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "push", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_push_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "push", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_push_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPush_arrayLjava_lang_Object_Handler ()
		{
			if (cb_push_arrayLjava_lang_Object_ == null)
				cb_push_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Push_arrayLjava_lang_Object_);
			return cb_push_arrayLjava_lang_Object_;
		}

		static void n_Push_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_obj, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Push (obj);
			if (obj != null)
				JNIEnv.CopyArray (obj, native_obj);
		}
#pragma warning restore 0169

		static IntPtr id_push_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='push' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("push", "([Ljava/lang/Object;)V", "GetPush_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Push (global::Java.Lang.Object[] obj)
		{
			if (id_push_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_push_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "push", "([Ljava/lang/Object;)V");
			IntPtr native_obj = JNIEnv.NewArray (obj);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_obj);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_push_arrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "push", "([Ljava/lang/Object;)V"), __args);
			} finally {
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
			}
		}

		static Delegate cb_pushInstance_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPushInstance_Ljava_lang_Object_Handler ()
		{
			if (cb_pushInstance_Ljava_lang_Object_ == null)
				cb_pushInstance_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PushInstance_Ljava_lang_Object_);
			return cb_pushInstance_Ljava_lang_Object_;
		}

		static void n_PushInstance_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.PushInstance (obj);
		}
#pragma warning restore 0169

		static IntPtr id_pushInstance_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='pushInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("pushInstance", "(Ljava/lang/Object;)V", "GetPushInstance_Ljava_lang_Object_Handler")]
		public virtual unsafe void PushInstance (global::Java.Lang.Object obj)
		{
			if (id_pushInstance_Ljava_lang_Object_ == IntPtr.Zero)
				id_pushInstance_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "pushInstance", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pushInstance_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pushInstance", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

	}
}
