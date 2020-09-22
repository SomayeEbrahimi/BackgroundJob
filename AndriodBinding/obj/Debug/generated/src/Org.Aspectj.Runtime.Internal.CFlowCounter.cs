using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Runtime.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/CFlowCounter", DoNotGenerateAcw=true)]
	public partial class CFlowCounter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/runtime/internal/CFlowCounter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CFlowCounter); }
		}

		protected CFlowCounter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']/constructor[@name='CFlowCounter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CFlowCounter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CFlowCounter)) {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowCounter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']/method[@name='isValid' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']/method[@name='getThreadStackFactoryClassName' and count(parameter)=0]"
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

		static Delegate cb_dec;
#pragma warning disable 0169
		static Delegate GetDecHandler ()
		{
			if (cb_dec == null)
				cb_dec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dec);
			return cb_dec;
		}

		static void n_Dec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowCounter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dec ();
		}
#pragma warning restore 0169

		static IntPtr id_dec;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']/method[@name='dec' and count(parameter)=0]"
		[Register ("dec", "()V", "GetDecHandler")]
		public virtual unsafe void Dec ()
		{
			if (id_dec == IntPtr.Zero)
				id_dec = JNIEnv.GetMethodID (class_ref, "dec", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dec);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dec", "()V"));
			} finally {
			}
		}

		static Delegate cb_inc;
#pragma warning disable 0169
		static Delegate GetIncHandler ()
		{
			if (cb_inc == null)
				cb_inc = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Inc);
			return cb_inc;
		}

		static void n_Inc (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowCounter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Inc ();
		}
#pragma warning restore 0169

		static IntPtr id_inc;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']/method[@name='inc' and count(parameter)=0]"
		[Register ("inc", "()V", "GetIncHandler")]
		public virtual unsafe void Inc ()
		{
			if (id_inc == IntPtr.Zero)
				id_inc = JNIEnv.GetMethodID (class_ref, "inc", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inc);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "inc", "()V"));
			} finally {
			}
		}

	}
}
