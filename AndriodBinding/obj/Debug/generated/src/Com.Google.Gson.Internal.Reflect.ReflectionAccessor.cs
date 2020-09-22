using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.reflect']/class[@name='ReflectionAccessor']"
	[global::Android.Runtime.Register ("com/google/gson/internal/reflect/ReflectionAccessor", DoNotGenerateAcw=true)]
	public abstract partial class ReflectionAccessor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/reflect/ReflectionAccessor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReflectionAccessor); }
		}

		protected ReflectionAccessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.reflect']/class[@name='ReflectionAccessor']/constructor[@name='ReflectionAccessor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReflectionAccessor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ReflectionAccessor)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Com.Google.Gson.Internal.Reflect.ReflectionAccessor Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.reflect']/class[@name='ReflectionAccessor']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/google/gson/internal/reflect/ReflectionAccessor;", "")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/google/gson/internal/reflect/ReflectionAccessor;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Reflect.ReflectionAccessor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_makeAccessible_Ljava_lang_reflect_AccessibleObject_;
#pragma warning disable 0169
		static Delegate GetMakeAccessible_Ljava_lang_reflect_AccessibleObject_Handler ()
		{
			if (cb_makeAccessible_Ljava_lang_reflect_AccessibleObject_ == null)
				cb_makeAccessible_Ljava_lang_reflect_AccessibleObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_MakeAccessible_Ljava_lang_reflect_AccessibleObject_);
			return cb_makeAccessible_Ljava_lang_reflect_AccessibleObject_;
		}

		static void n_MakeAccessible_Ljava_lang_reflect_AccessibleObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Reflect.ReflectionAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.AccessibleObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MakeAccessible (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.reflect']/class[@name='ReflectionAccessor']/method[@name='makeAccessible' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.AccessibleObject']]"
		[Register ("makeAccessible", "(Ljava/lang/reflect/AccessibleObject;)V", "GetMakeAccessible_Ljava_lang_reflect_AccessibleObject_Handler")]
		public abstract void MakeAccessible (global::Java.Lang.Reflect.AccessibleObject p0);

	}

	[global::Android.Runtime.Register ("com/google/gson/internal/reflect/ReflectionAccessor", DoNotGenerateAcw=true)]
	internal partial class ReflectionAccessorInvoker : ReflectionAccessor {

		public ReflectionAccessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReflectionAccessorInvoker); }
		}

		static IntPtr id_makeAccessible_Ljava_lang_reflect_AccessibleObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.reflect']/class[@name='ReflectionAccessor']/method[@name='makeAccessible' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.AccessibleObject']]"
		[Register ("makeAccessible", "(Ljava/lang/reflect/AccessibleObject;)V", "GetMakeAccessible_Ljava_lang_reflect_AccessibleObject_Handler")]
		public override unsafe void MakeAccessible (global::Java.Lang.Reflect.AccessibleObject p0)
		{
			if (id_makeAccessible_Ljava_lang_reflect_AccessibleObject_ == IntPtr.Zero)
				id_makeAccessible_Ljava_lang_reflect_AccessibleObject_ = JNIEnv.GetMethodID (class_ref, "makeAccessible", "(Ljava/lang/reflect/AccessibleObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_makeAccessible_Ljava_lang_reflect_AccessibleObject_, __args);
			} finally {
			}
		}

	}

}
