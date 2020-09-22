using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Runtime.Internal.Cflowstack {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/cflowstack/ThreadCounterImpl11", DoNotGenerateAcw=true)]
	public partial class ThreadCounterImpl11 : global::Java.Lang.Object, global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/runtime/internal/cflowstack/ThreadCounterImpl11", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreadCounterImpl11); }
		}

		protected ThreadCounterImpl11 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']/constructor[@name='ThreadCounterImpl11' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadCounterImpl11 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ThreadCounterImpl11)) {
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

		static Delegate cb_isNotZero;
#pragma warning disable 0169
		static Delegate GetIsNotZeroHandler ()
		{
			if (cb_isNotZero == null)
				cb_isNotZero = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNotZero);
			return cb_isNotZero;
		}

		static bool n_IsNotZero (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadCounterImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNotZero;
		}
#pragma warning restore 0169

		static IntPtr id_isNotZero;
		public virtual unsafe bool IsNotZero {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']/method[@name='isNotZero' and count(parameter)=0]"
			[Register ("isNotZero", "()Z", "GetIsNotZeroHandler")]
			get {
				if (id_isNotZero == IntPtr.Zero)
					id_isNotZero = JNIEnv.GetMethodID (class_ref, "isNotZero", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNotZero);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNotZero", "()Z"));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadCounterImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dec ();
		}
#pragma warning restore 0169

		static IntPtr id_dec;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']/method[@name='dec' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadCounterImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Inc ();
		}
#pragma warning restore 0169

		static IntPtr id_inc;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']/method[@name='inc' and count(parameter)=0]"
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

		static Delegate cb_removeThreadCounter;
#pragma warning disable 0169
		static Delegate GetRemoveThreadCounterHandler ()
		{
			if (cb_removeThreadCounter == null)
				cb_removeThreadCounter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveThreadCounter);
			return cb_removeThreadCounter;
		}

		static void n_RemoveThreadCounter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadCounterImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveThreadCounter ();
		}
#pragma warning restore 0169

		static IntPtr id_removeThreadCounter;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']/method[@name='removeThreadCounter' and count(parameter)=0]"
		[Register ("removeThreadCounter", "()V", "GetRemoveThreadCounterHandler")]
		public virtual unsafe void RemoveThreadCounter ()
		{
			if (id_removeThreadCounter == IntPtr.Zero)
				id_removeThreadCounter = JNIEnv.GetMethodID (class_ref, "removeThreadCounter", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeThreadCounter);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeThreadCounter", "()V"));
			} finally {
			}
		}

	}
}
