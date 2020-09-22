using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Runtime.Internal.Cflowstack {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackFactoryImpl11']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/cflowstack/ThreadStackFactoryImpl11", DoNotGenerateAcw=true)]
	public partial class ThreadStackFactoryImpl11 : global::Java.Lang.Object, global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStackFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/runtime/internal/cflowstack/ThreadStackFactoryImpl11", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreadStackFactoryImpl11); }
		}

		protected ThreadStackFactoryImpl11 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackFactoryImpl11']/constructor[@name='ThreadStackFactoryImpl11' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadStackFactoryImpl11 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ThreadStackFactoryImpl11)) {
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

		static Delegate cb_getNewThreadCounter;
#pragma warning disable 0169
		static Delegate GetGetNewThreadCounterHandler ()
		{
			if (cb_getNewThreadCounter == null)
				cb_getNewThreadCounter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewThreadCounter);
			return cb_getNewThreadCounter;
		}

		static IntPtr n_GetNewThreadCounter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadStackFactoryImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewThreadCounter);
		}
#pragma warning restore 0169

		static IntPtr id_getNewThreadCounter;
		public virtual unsafe global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter NewThreadCounter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackFactoryImpl11']/method[@name='getNewThreadCounter' and count(parameter)=0]"
			[Register ("getNewThreadCounter", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadCounter;", "GetGetNewThreadCounterHandler")]
			get {
				if (id_getNewThreadCounter == IntPtr.Zero)
					id_getNewThreadCounter = JNIEnv.GetMethodID (class_ref, "getNewThreadCounter", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadCounter;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNewThreadCounter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewThreadCounter", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadCounter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNewThreadStack;
#pragma warning disable 0169
		static Delegate GetGetNewThreadStackHandler ()
		{
			if (cb_getNewThreadStack == null)
				cb_getNewThreadStack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewThreadStack);
			return cb_getNewThreadStack;
		}

		static IntPtr n_GetNewThreadStack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadStackFactoryImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewThreadStack);
		}
#pragma warning restore 0169

		static IntPtr id_getNewThreadStack;
		public virtual unsafe global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack NewThreadStack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackFactoryImpl11']/method[@name='getNewThreadStack' and count(parameter)=0]"
			[Register ("getNewThreadStack", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadStack;", "GetGetNewThreadStackHandler")]
			get {
				if (id_getNewThreadStack == IntPtr.Zero)
					id_getNewThreadStack = JNIEnv.GetMethodID (class_ref, "getNewThreadStack", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadStack;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNewThreadStack), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewThreadStack", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadStack;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
