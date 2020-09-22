using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Lang {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang']/class[@name='SoftException']"
	[global::Android.Runtime.Register ("org/aspectj/lang/SoftException", DoNotGenerateAcw=true)]
	public partial class SoftException : global::Java.Lang.RuntimeException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/lang/SoftException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SoftException); }
		}

		protected SoftException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.lang']/class[@name='SoftException']/constructor[@name='SoftException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe SoftException (global::Java.Lang.Throwable inner)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (inner);
				if (((object) this).GetType () != typeof (SoftException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static Delegate cb_getWrappedThrowable;
#pragma warning disable 0169
		static Delegate GetGetWrappedThrowableHandler ()
		{
			if (cb_getWrappedThrowable == null)
				cb_getWrappedThrowable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWrappedThrowable);
			return cb_getWrappedThrowable;
		}

		static IntPtr n_GetWrappedThrowable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.SoftException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WrappedThrowable);
		}
#pragma warning restore 0169

		static IntPtr id_getWrappedThrowable;
		public virtual unsafe global::Java.Lang.Throwable WrappedThrowable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='SoftException']/method[@name='getWrappedThrowable' and count(parameter)=0]"
			[Register ("getWrappedThrowable", "()Ljava/lang/Throwable;", "GetGetWrappedThrowableHandler")]
			get {
				if (id_getWrappedThrowable == IntPtr.Zero)
					id_getWrappedThrowable = JNIEnv.GetMethodID (class_ref, "getWrappedThrowable", "()Ljava/lang/Throwable;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getWrappedThrowable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWrappedThrowable", "()Ljava/lang/Throwable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
