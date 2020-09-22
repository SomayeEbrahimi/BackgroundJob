using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Runtime.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/AroundClosure", DoNotGenerateAcw=true)]
	public abstract partial class AroundClosure : global::Java.Lang.Object {


		static IntPtr bitflags_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/field[@name='bitflags']"
		[Register ("bitflags")]
		protected int Bitflags {
			get {
				if (bitflags_jfieldId == IntPtr.Zero)
					bitflags_jfieldId = JNIEnv.GetFieldID (class_ref, "bitflags", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, bitflags_jfieldId);
			}
			set {
				if (bitflags_jfieldId == IntPtr.Zero)
					bitflags_jfieldId = JNIEnv.GetFieldID (class_ref, "bitflags", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bitflags_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr preInitializationState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/field[@name='preInitializationState']"
		[Register ("preInitializationState")]
		protected IList<Java.Lang.Object> PreInitializationState {
			get {
				if (preInitializationState_jfieldId == IntPtr.Zero)
					preInitializationState_jfieldId = JNIEnv.GetFieldID (class_ref, "preInitializationState", "[Ljava/lang/Object;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Object>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, preInitializationState_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (preInitializationState_jfieldId == IntPtr.Zero)
					preInitializationState_jfieldId = JNIEnv.GetFieldID (class_ref, "preInitializationState", "[Ljava/lang/Object;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Lang.Object>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, preInitializationState_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr state_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/field[@name='state']"
		[Register ("state")]
		protected IList<Java.Lang.Object> State {
			get {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "[Ljava/lang/Object;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Object>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, state_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "[Ljava/lang/Object;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Lang.Object>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, state_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/runtime/internal/AroundClosure", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AroundClosure); }
		}

		protected AroundClosure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/constructor[@name='AroundClosure' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AroundClosure ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AroundClosure)) {
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

		static IntPtr id_ctor_arrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/constructor[@name='AroundClosure' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		public unsafe AroundClosure (global::Java.Lang.Object[] state)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_state = JNIEnv.NewArray (state);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_state);
				if (((object) this).GetType () != typeof (AroundClosure)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_ctor_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLjava_lang_Object_, __args);
			} finally {
				if (state != null) {
					JNIEnv.CopyArray (native_state, state);
					JNIEnv.DeleteLocalRef (native_state);
				}
			}
		}

		static Delegate cb_getFlags;
#pragma warning disable 0169
		static Delegate GetGetFlagsHandler ()
		{
			if (cb_getFlags == null)
				cb_getFlags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFlags);
			return cb_getFlags;
		}

		static int n_GetFlags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flags;
		}
#pragma warning restore 0169

		static IntPtr id_getFlags;
		public virtual unsafe int Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()I", "GetGetFlagsHandler")]
			get {
				if (id_getFlags == IntPtr.Zero)
					id_getFlags = JNIEnv.GetMethodID (class_ref, "getFlags", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFlags);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlags", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPreInitializationState;
#pragma warning disable 0169
		static Delegate GetGetPreInitializationStateHandler ()
		{
			if (cb_getPreInitializationState == null)
				cb_getPreInitializationState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPreInitializationState);
			return cb_getPreInitializationState;
		}

		static IntPtr n_GetPreInitializationState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPreInitializationState ());
		}
#pragma warning restore 0169

		static IntPtr id_getPreInitializationState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='getPreInitializationState' and count(parameter)=0]"
		[Register ("getPreInitializationState", "()[Ljava/lang/Object;", "GetGetPreInitializationStateHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetPreInitializationState ()
		{
			if (id_getPreInitializationState == IntPtr.Zero)
				id_getPreInitializationState = JNIEnv.GetMethodID (class_ref, "getPreInitializationState", "()[Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreInitializationState), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				else
					return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreInitializationState", "()[Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetState ());
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()[Ljava/lang/Object;", "GetGetStateHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetState ()
		{
			if (id_getState == IntPtr.Zero)
				id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()[Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				else
					return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "()[Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_linkClosureAndJoinPoint;
#pragma warning disable 0169
		static Delegate GetLinkClosureAndJoinPointHandler ()
		{
			if (cb_linkClosureAndJoinPoint == null)
				cb_linkClosureAndJoinPoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LinkClosureAndJoinPoint);
			return cb_linkClosureAndJoinPoint;
		}

		static IntPtr n_LinkClosureAndJoinPoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LinkClosureAndJoinPoint ());
		}
#pragma warning restore 0169

		static IntPtr id_linkClosureAndJoinPoint;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='linkClosureAndJoinPoint' and count(parameter)=0]"
		[Register ("linkClosureAndJoinPoint", "()Lorg/aspectj/lang/ProceedingJoinPoint;", "GetLinkClosureAndJoinPointHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.IProceedingJoinPoint LinkClosureAndJoinPoint ()
		{
			if (id_linkClosureAndJoinPoint == IntPtr.Zero)
				id_linkClosureAndJoinPoint = JNIEnv.GetMethodID (class_ref, "linkClosureAndJoinPoint", "()Lorg/aspectj/lang/ProceedingJoinPoint;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_linkClosureAndJoinPoint), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "linkClosureAndJoinPoint", "()Lorg/aspectj/lang/ProceedingJoinPoint;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_linkClosureAndJoinPoint_I;
#pragma warning disable 0169
		static Delegate GetLinkClosureAndJoinPoint_IHandler ()
		{
			if (cb_linkClosureAndJoinPoint_I == null)
				cb_linkClosureAndJoinPoint_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_LinkClosureAndJoinPoint_I);
			return cb_linkClosureAndJoinPoint_I;
		}

		static IntPtr n_LinkClosureAndJoinPoint_I (IntPtr jnienv, IntPtr native__this, int flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LinkClosureAndJoinPoint (flags));
		}
#pragma warning restore 0169

		static IntPtr id_linkClosureAndJoinPoint_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='linkClosureAndJoinPoint' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("linkClosureAndJoinPoint", "(I)Lorg/aspectj/lang/ProceedingJoinPoint;", "GetLinkClosureAndJoinPoint_IHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.IProceedingJoinPoint LinkClosureAndJoinPoint (int flags)
		{
			if (id_linkClosureAndJoinPoint_I == IntPtr.Zero)
				id_linkClosureAndJoinPoint_I = JNIEnv.GetMethodID (class_ref, "linkClosureAndJoinPoint", "(I)Lorg/aspectj/lang/ProceedingJoinPoint;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (flags);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_linkClosureAndJoinPoint_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "linkClosureAndJoinPoint", "(I)Lorg/aspectj/lang/ProceedingJoinPoint;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_run_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRun_arrayLjava_lang_Object_Handler ()
		{
			if (cb_run_arrayLjava_lang_Object_ == null)
				cb_run_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Run_arrayLjava_lang_Object_);
			return cb_run_arrayLjava_lang_Object_;
		}

		static IntPtr n_Run_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Run (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='run' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("run", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetRun_arrayLjava_lang_Object_Handler")]
		public abstract global::Java.Lang.Object Run (global::Java.Lang.Object[] p0);

	}

	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/AroundClosure", DoNotGenerateAcw=true)]
	internal partial class AroundClosureInvoker : AroundClosure {

		public AroundClosureInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AroundClosureInvoker); }
		}

		static IntPtr id_run_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='run' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("run", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetRun_arrayLjava_lang_Object_Handler")]
		public override unsafe global::Java.Lang.Object Run (global::Java.Lang.Object[] p0)
		{
			if (id_run_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_run_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "run", "([Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_run_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

}
