using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Runtime {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/CFlow", DoNotGenerateAcw=true)]
	public partial class CFlow : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/runtime/CFlow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CFlow); }
		}

		protected CFlow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']/constructor[@name='CFlow' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CFlow ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CFlow)) {
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

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']/constructor[@name='CFlow' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe CFlow (global::Java.Lang.Object _aspect)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (_aspect);
				if (((object) this).GetType () != typeof (CFlow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static Delegate cb_getAspect;
#pragma warning disable 0169
		static Delegate GetGetAspectHandler ()
		{
			if (cb_getAspect == null)
				cb_getAspect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAspect);
			return cb_getAspect;
		}

		static IntPtr n_GetAspect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Aspect);
		}
#pragma warning restore 0169

		static Delegate cb_setAspect_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetAspect_Ljava_lang_Object_Handler ()
		{
			if (cb_setAspect_Ljava_lang_Object_ == null)
				cb_setAspect_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAspect_Ljava_lang_Object_);
			return cb_setAspect_Ljava_lang_Object_;
		}

		static void n_SetAspect_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__aspect)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var _aspect = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__aspect, JniHandleOwnership.DoNotTransfer);
			__this.Aspect = _aspect;
		}
#pragma warning restore 0169

		static IntPtr id_getAspect;
		static IntPtr id_setAspect_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object Aspect {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']/method[@name='getAspect' and count(parameter)=0]"
			[Register ("getAspect", "()Ljava/lang/Object;", "GetGetAspectHandler")]
			get {
				if (id_getAspect == IntPtr.Zero)
					id_getAspect = JNIEnv.GetMethodID (class_ref, "getAspect", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAspect), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAspect", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']/method[@name='setAspect' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setAspect", "(Ljava/lang/Object;)V", "GetSetAspect_Ljava_lang_Object_Handler")]
			set {
				if (id_setAspect_Ljava_lang_Object_ == IntPtr.Zero)
					id_setAspect_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setAspect", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAspect_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAspect", "(Ljava/lang/Object;)V"), __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (index));
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
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

	}
}
